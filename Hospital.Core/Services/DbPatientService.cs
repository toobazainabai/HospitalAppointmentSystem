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
    public class DbPatientService : IPatientService
    {
        private readonly string _connectionString;
        private readonly string _tableName;

        public DbPatientService(string connString)
        {
            _connectionString = connString;
            _tableName = ResolveTableName("dbo.Patients", "dbo.dbPatient", "dbo.dbPateint", "dbo.dbPatietn", "dbo.dbPatients");
        }

        public List<Patient> GetAll()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {_tableName}", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                            Gender = Enum.TryParse<GenderEnum>(reader["Gender"].ToString(), ignoreCase: true, out var genderParsed)
                                ? genderParsed
                                : GenderEnum.Unknown,
                            BloodGroup = GetSafeString(reader, "BloodGroup", "Unknown"),
                            Email = GetSafeString(reader, "Email", ""),
                            AddressLine1 = GetSafeString(reader, "AddressLine1", ""),
                            City = GetSafeString(reader, "City", ""),
                            EmergencyName = GetSafeString(reader, "EmergencyName", ""),
                            EmergencyPhone = GetSafeString(reader, "EmergencyPhone", ""),
                            MedicalHistory = GetSafeString(reader, "MedicalHistory", "")
                        };
                        patients.Add(patient);
                    }
                }
            }

            return patients;
        }

        public Patient GetById(string id)
        {
            Patient patient = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {_tableName} WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patient = new Patient
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                            Gender = Enum.TryParse<GenderEnum>(reader["Gender"].ToString(), ignoreCase: true, out var genderParsed)
                                ? genderParsed
                                : GenderEnum.Unknown,
                            BloodGroup = GetSafeString(reader, "BloodGroup", "Unknown"),
                            Email = GetSafeString(reader, "Email", ""),
                            AddressLine1 = GetSafeString(reader, "AddressLine1", ""),
                            City = GetSafeString(reader, "City", ""),
                            EmergencyName = GetSafeString(reader, "EmergencyName", ""),
                            EmergencyPhone = GetSafeString(reader, "EmergencyPhone", ""),
                            MedicalHistory = GetSafeString(reader, "MedicalHistory", "")
                        };
                    }
                }
            }

            return patient;
        }

        public void Add(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Generate shorter ID like P001, P002, etc.
                string newId = GeneratePatientId(conn);
                patient.Id = newId;

                SqlCommand cmd = new SqlCommand(
                    $"INSERT INTO {_tableName} (Id, FirstName, LastName, Phone, DateOfBirth, Gender, BloodGroup, Email, AddressLine1, City, EmergencyName, EmergencyPhone, MedicalHistory) " +
                    "VALUES (@id, @firstName, @lastName, @phone, @dateOfBirth, @gender, @bloodGroup, @email, @addressLine1, @city, @emergencyName, @emergencyPhone, @medicalHistory)", conn);

                cmd.Parameters.AddWithValue("@id", patient.Id);
                cmd.Parameters.AddWithValue("@firstName", patient.FirstName ?? "");
                cmd.Parameters.AddWithValue("@lastName", patient.LastName ?? "");
                cmd.Parameters.AddWithValue("@phone", patient.Phone ?? "");
                cmd.Parameters.AddWithValue("@dateOfBirth", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@gender", patient.Gender.ToString());
                cmd.Parameters.AddWithValue("@bloodGroup", patient.BloodGroup ?? "Unknown");
                cmd.Parameters.AddWithValue("@email", patient.Email ?? "");
                cmd.Parameters.AddWithValue("@addressLine1", patient.AddressLine1 ?? "");
                cmd.Parameters.AddWithValue("@city", patient.City ?? "");
                cmd.Parameters.AddWithValue("@emergencyName", patient.EmergencyName ?? "");
                cmd.Parameters.AddWithValue("@emergencyPhone", patient.EmergencyPhone ?? "");
                cmd.Parameters.AddWithValue("@medicalHistory", patient.MedicalHistory ?? "");

                cmd.ExecuteNonQuery();
            }
        }

        private string GeneratePatientId(SqlConnection conn)
        {
            // Get the maximum patient ID and increment it
            SqlCommand cmd = new SqlCommand($"SELECT MAX(CAST(SUBSTRING(Id, 2, LEN(Id)) AS INT)) FROM {_tableName} WHERE Id LIKE 'P%'", conn);
            var result = cmd.ExecuteScalar();
            int nextNumber = (result == DBNull.Value || result == null) ? 1 : Convert.ToInt32(result) + 1;
            return $"P{nextNumber:D3}"; // Format as P001, P002, etc.
        }

        public void Update(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    $"UPDATE {_tableName} SET FirstName = @firstName, LastName = @lastName, " +
                    "Phone = @phone, DateOfBirth = @dateOfBirth, Gender = @gender, BloodGroup = @bloodGroup, " +
                    "Email = @email, AddressLine1 = @addressLine1, City = @city, EmergencyName = @emergencyName, " +
                    "EmergencyPhone = @emergencyPhone, MedicalHistory = @medicalHistory WHERE Id = @id", conn);

                cmd.Parameters.AddWithValue("@id", patient.Id);
                cmd.Parameters.AddWithValue("@firstName", patient.FirstName ?? "");
                cmd.Parameters.AddWithValue("@lastName", patient.LastName ?? "");
                cmd.Parameters.AddWithValue("@phone", patient.Phone ?? "");
                cmd.Parameters.AddWithValue("@dateOfBirth", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@gender", patient.Gender.ToString());
                cmd.Parameters.AddWithValue("@bloodGroup", patient.BloodGroup ?? "Unknown");
                cmd.Parameters.AddWithValue("@email", patient.Email ?? "");
                cmd.Parameters.AddWithValue("@addressLine1", patient.AddressLine1 ?? "");
                cmd.Parameters.AddWithValue("@city", patient.City ?? "");
                cmd.Parameters.AddWithValue("@emergencyName", patient.EmergencyName ?? "");
                cmd.Parameters.AddWithValue("@emergencyPhone", patient.EmergencyPhone ?? "");
                cmd.Parameters.AddWithValue("@medicalHistory", patient.MedicalHistory ?? "");

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

        public List<Patient> Search(string searchText)
        {
            List<Patient> patients = new List<Patient>();

            // 1. Extra spaces ko shuru aur aakhir se khatam karein
            searchText = searchText?.Trim();

            // Agar search box khali hai to khali list wapas bhej dein ya GetAll() call karein
            if (string.IsNullOrEmpty(searchText))
            {
                return GetAll();
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // 2. Query ko strictly FirstName, LastName, aur Phone tak mehdood rakhein
                string query = $"SELECT * FROM {_tableName} WHERE FirstName LIKE @search OR LastName LIKE @search OR Phone LIKE @search";

                SqlCommand cmd = new SqlCommand(query, conn);

                // 3. Dono taraf % lagane se agar koi 'Fatima' dhoonde ga to 'Fatima Ali' mil jayegi
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                            Gender = Enum.TryParse<GenderEnum>(reader["Gender"].ToString(), ignoreCase: true, out var genderParsed)
                                ? genderParsed
                                : GenderEnum.Unknown,
                            BloodGroup = GetSafeString(reader, "BloodGroup", "Unknown"),
                            Email = GetSafeString(reader, "Email", ""),
                            AddressLine1 = GetSafeString(reader, "AddressLine1", ""),
                            City = GetSafeString(reader, "City", ""),
                            EmergencyName = GetSafeString(reader, "EmergencyName", ""),
                            EmergencyPhone = GetSafeString(reader, "EmergencyPhone", ""),
                            MedicalHistory = GetSafeString(reader, "MedicalHistory", "")
                        };
                        patients.Add(patient);
                    }
                }
            }

            return patients;
        }

        private string GetSafeString(SqlDataReader reader, string columnName, string defaultValue)
        {
            try
            {
                var value = reader[columnName];
                return value == DBNull.Value ? defaultValue : value.ToString() ?? defaultValue;
            }
            catch
            {
                // Column doesn't exist in database yet
                return defaultValue;
            }
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

            throw new InvalidOperationException($"None of the expected patient tables exist: {string.Join(", ", candidates)}");
        }

        // Async implementations
        public async Task<List<Patient>> GetAllAsync()
        {
            return await Task.Run(() => GetAll());
        }

        public async Task<Patient> GetByIdAsync(string id)
        {
            return await Task.Run(() => GetById(id));
        }

        public async Task AddAsync(Patient patient)
        {
            await Task.Run(() => Add(patient));
        }

        public async Task UpdateAsync(Patient patient)
        {
            await Task.Run(() => Update(patient));
        }

        public async Task DeleteAsync(string id)
        {
            await Task.Run(() => Delete(id));
        }

        public async Task<List<Patient>> SearchAsync(string text)
        {
            return await Task.Run(() => Search(text));
        }
    }
}
