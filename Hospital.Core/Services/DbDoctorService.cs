using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Core.Contracts;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Microsoft.Data.SqlClient;

namespace Hospital.Core.Services
{
    public class DbDoctorService : IDoctorService
    {
        private readonly string _connectionString;
        private readonly string _tableName;

        public DbDoctorService(string connString)
        {
            _connectionString = connString;
            _tableName = ResolveTableName("dbo.dbDoctors", "dbo.dbDoctor", "dbo.Doctor", "dbo.Doctors");
        }

        public List<Doctor> GetAll()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {_tableName}", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            ExperienceYears = reader.GetInt32(reader.GetOrdinal("ExperienceYears")),
                            Specialty = Enum.TryParse<DoctorSpecialtyEnum>(reader["Specialty"].ToString(), ignoreCase: true, out var specialtyParsed)
                                ? specialtyParsed
                                : DoctorSpecialtyEnum.General
                        };
                        doctors.Add(doctor);
                    }
                }
            }

            return doctors;
        }

        public Doctor GetById(string id)
        {
            Doctor doctor = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {_tableName} WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        doctor = new Doctor
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            ExperienceYears = reader.GetInt32(reader.GetOrdinal("ExperienceYears")),
                            Specialty = Enum.TryParse<DoctorSpecialtyEnum>(reader["Specialty"].ToString(), ignoreCase: true, out var specialtyParsed)
                                ? specialtyParsed
                                : DoctorSpecialtyEnum.General
                        };
                    }
                }
            }

            return doctor;
        }

        public void Add(Doctor doctor)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Generate shorter ID like D001, D002, etc.
                string newId = GenerateDoctorId(conn);
                doctor.Id = newId;

                SqlCommand cmd = new SqlCommand(
                    $"INSERT INTO {_tableName} (Id, FirstName, LastName, Phone, Email, ExperienceYears, Specialty) " +
                    "VALUES (@id, @firstName, @lastName, @phone, @email, @experienceYears, @specialty)", conn);

                cmd.Parameters.AddWithValue("@id", doctor.Id);
                cmd.Parameters.AddWithValue("@firstName", doctor.FirstName ?? "");
                cmd.Parameters.AddWithValue("@lastName", doctor.LastName ?? "");
                cmd.Parameters.AddWithValue("@phone", doctor.Phone ?? "");
                cmd.Parameters.AddWithValue("@email", doctor.Email ?? "");
                cmd.Parameters.AddWithValue("@experienceYears", doctor.ExperienceYears);
                cmd.Parameters.AddWithValue("@specialty", doctor.Specialty.ToString());

                cmd.ExecuteNonQuery();
            }
        }

        private string GenerateDoctorId(SqlConnection conn)
        {
            // Get the maximum doctor ID and increment it
            SqlCommand cmd = new SqlCommand($"SELECT MAX(CAST(SUBSTRING(Id, 2, LEN(Id)) AS INT)) FROM {_tableName} WHERE Id LIKE 'D%'", conn);
            var result = cmd.ExecuteScalar();
            int nextNumber = (result == DBNull.Value || result == null) ? 1 : Convert.ToInt32(result) + 1;
            return $"D{nextNumber:D3}"; // Format as D001, D002, etc.
        }

        public void Update(Doctor doctor)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    $"UPDATE {_tableName} SET FirstName = @firstName, LastName = @lastName, " +
                    "Phone = @phone, Email = @email, ExperienceYears = @experienceYears, Specialty = @specialty WHERE Id = @id", conn);

                cmd.Parameters.AddWithValue("@id", doctor.Id);
                cmd.Parameters.AddWithValue("@firstName", doctor.FirstName ?? "");
                cmd.Parameters.AddWithValue("@lastName", doctor.LastName ?? "");
                cmd.Parameters.AddWithValue("@phone", doctor.Phone ?? "");
                cmd.Parameters.AddWithValue("@email", doctor.Email ?? "");
                cmd.Parameters.AddWithValue("@experienceYears", doctor.ExperienceYears);
                cmd.Parameters.AddWithValue("@specialty", doctor.Specialty.ToString());

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM {_tableName} WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Doctor> GetBySpecialty(DoctorSpecialtyEnum specialty)
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {_tableName} WHERE Specialty = @specialty", conn);
                cmd.Parameters.AddWithValue("@specialty", specialty.ToString());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            ExperienceYears = reader.GetInt32(reader.GetOrdinal("ExperienceYears")),
                            Specialty = Enum.TryParse<DoctorSpecialtyEnum>(reader["Specialty"].ToString(), ignoreCase: true, out var specialtyParsed)
                                ? specialtyParsed
                                : DoctorSpecialtyEnum.General
                        };
                        doctors.Add(doctor);
                    }
                }
            }

            return doctors;
        }

        public List<Doctor> Search(string text, DoctorSpecialtyEnum? specialty = null)
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM {_tableName} WHERE (FirstName LIKE @search OR LastName LIKE @search OR Email LIKE @search)";

                if (specialty.HasValue)
                {
                    query += " AND Specialty = @specialty";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + text + "%");

                if (specialty.HasValue)
                {
                    cmd.Parameters.AddWithValue("@specialty", specialty.Value.ToString());
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString(),
                            ExperienceYears = reader.GetInt32(reader.GetOrdinal("ExperienceYears")),
                            Specialty = Enum.TryParse<DoctorSpecialtyEnum>(reader["Specialty"].ToString(), ignoreCase: true, out var specialtyParsed)
                                ? specialtyParsed
                                : DoctorSpecialtyEnum.General
                        };
                        doctors.Add(doctor);
                    }
                }
            }

            return doctors;
        }

        private string ResolveTableName(params string[] candidates)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            foreach (string candidate in candidates)
            {
                using SqlCommand cmd = new SqlCommand("SELECT OBJECT_ID(@tableName, 'U')", conn);
                cmd.Parameters.AddWithValue("@tableName", candidate);
                if (cmd.ExecuteScalar() is not DBNull)
                {
                    return candidate;
                }
            }

            throw new InvalidOperationException($"None of the expected doctor tables exist: {string.Join(", ", candidates)}");
        }

        // Async implementations
        public async Task<List<Doctor>> GetAllAsync()
        {
            return await Task.Run(() => GetAll());
        }

        public async Task<Doctor> GetByIdAsync(string id)
        {
            return await Task.Run(() => GetById(id));
        }

        public async Task AddAsync(Doctor doctor)
        {
            await Task.Run(() => Add(doctor));
        }

        public async Task UpdateAsync(Doctor doctor)
        {
            await Task.Run(() => Update(doctor));
        }

        public async Task DeleteAsync(string id)
        {
            await Task.Run(() => Delete(id));
        }

        public async Task<List<Doctor>> GetBySpecialtyAsync(DoctorSpecialtyEnum specialty)
        {
            return await Task.Run(() => GetBySpecialty(specialty));
        }

        public async Task<List<Doctor>> SearchAsync(string text, DoctorSpecialtyEnum? specialty = null)
        {
            return await Task.Run(() => Search(text, specialty));
        }
    }
}
