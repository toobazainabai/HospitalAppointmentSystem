using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Hospital.Core.Contracts;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Microsoft.Data.SqlClient;

namespace Hospital.Core.Services
{
    public class DbAppointmentService : IAppointmentService
    {
        private readonly string _connectionString;

        public DbAppointmentService(string connString)
        {
            _connectionString = connString;
        }

        public List<Appointment> GetAll()
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.dbAppointment", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            PatientId = reader["PatientId"].ToString(),
                            DoctorId = reader["DoctorId"].ToString(),
                            AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("AppointmentDateTime")),
                            Status = Enum.TryParse<AppointmentStatusEnum>(reader["Status"].ToString(), ignoreCase: true, out var statusParsed)
                                ? statusParsed
                                : AppointmentStatusEnum.Scheduled,
                            Notes = reader["Notes"].ToString()
                        };
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        public Appointment GetById(string id)
        {
            Appointment appointment = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.dbAppointment WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        appointment = new Appointment
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            PatientId = reader["PatientId"].ToString(),
                            DoctorId = reader["DoctorId"].ToString(),
                            AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("AppointmentDateTime")),
                            Status = Enum.TryParse<AppointmentStatusEnum>(reader["Status"].ToString(), ignoreCase: true, out var statusParsed)
                                ? statusParsed
                                : AppointmentStatusEnum.Scheduled,
                            Notes = reader["Notes"].ToString()
                        };
                    }
                }
            }

            return appointment;
        }

        public void Add(Appointment appointment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.dbAppointment (Id, PatientId, DoctorId, AppointmentDateTime, Status, Notes) " +
                    "VALUES (@id, @patientId, @doctorId, @appointmentDateTime, @status, @notes)", conn);

                cmd.Parameters.AddWithValue("@id", appointment.Id);
                cmd.Parameters.AddWithValue("@patientId", appointment.PatientId ?? "");
                cmd.Parameters.AddWithValue("@doctorId", appointment.DoctorId ?? "");
                cmd.Parameters.AddWithValue("@appointmentDateTime", appointment.AppointmentDateTime);
                cmd.Parameters.AddWithValue("@status", appointment.Status.ToString());
                cmd.Parameters.AddWithValue("@notes", appointment.Notes ?? "");

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Appointment appointment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE dbo.dbAppointment SET PatientId = @patientId, DoctorId = @doctorId, " +
                    "AppointmentDateTime = @appointmentDateTime, Status = @status, Notes = @notes WHERE Id = @id", conn);

                cmd.Parameters.AddWithValue("@id", appointment.Id);
                cmd.Parameters.AddWithValue("@patientId", appointment.PatientId ?? "");
                cmd.Parameters.AddWithValue("@doctorId", appointment.DoctorId ?? "");
                cmd.Parameters.AddWithValue("@appointmentDateTime", appointment.AppointmentDateTime);
                cmd.Parameters.AddWithValue("@status", appointment.Status.ToString());
                cmd.Parameters.AddWithValue("@notes", appointment.Notes ?? "");

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.dbAppointment WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Appointment> GetByPatientId(string patientId)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.dbAppointment WHERE PatientId = @patientId", conn);
                cmd.Parameters.AddWithValue("@patientId", patientId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            PatientId = reader["PatientId"].ToString(),
                            DoctorId = reader["DoctorId"].ToString(),
                            AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("AppointmentDateTime")),
                            Status = Enum.TryParse<AppointmentStatusEnum>(reader["Status"].ToString(), ignoreCase: true, out var statusParsed)
                                ? statusParsed
                                : AppointmentStatusEnum.Scheduled,
                            Notes = reader["Notes"].ToString()
                        };
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        public List<Appointment> GetByDoctorId(string doctorId)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.dbAppointment WHERE DoctorId = @doctorId", conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            PatientId = reader["PatientId"].ToString(),
                            DoctorId = reader["DoctorId"].ToString(),
                            AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("AppointmentDateTime")),
                            Status = Enum.TryParse<AppointmentStatusEnum>(reader["Status"].ToString(), ignoreCase: true, out var statusParsed)
                                ? statusParsed
                                : AppointmentStatusEnum.Scheduled,
                            Notes = reader["Notes"].ToString()
                        };
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        public List<Appointment> GetByStatus(AppointmentStatusEnum status)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.dbAppointment WHERE Status = @status", conn);
                cmd.Parameters.AddWithValue("@status", status.ToString());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            PatientId = reader["PatientId"].ToString(),
                            DoctorId = reader["DoctorId"].ToString(),
                            AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("AppointmentDateTime")),
                            Status = Enum.TryParse<AppointmentStatusEnum>(reader["Status"].ToString(), ignoreCase: true, out var statusParsed)
                                ? statusParsed
                                : AppointmentStatusEnum.Scheduled,
                            Notes = reader["Notes"].ToString()
                        };
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        public List<Appointment> Search(string text, AppointmentStatusEnum? status, DateTime? date)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT a.* FROM dbo.dbAppointment a " +
                               "JOIN dbo.dbPatient p ON a.PatientId = p.Id " +
                               "WHERE (p.FirstName LIKE @search OR p.LastName LIKE @search OR a.Notes LIKE @search)";

                if (status.HasValue)
                {
                    query += " AND a.Status = @status";
                }

                if (date.HasValue)
                {
                    query += " AND CAST(a.AppointmentDateTime AS DATE) = @date";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + text + "%");

                if (status.HasValue)
                {
                    cmd.Parameters.AddWithValue("@status", status.Value.ToString());
                }

                if (date.HasValue)
                {
                    cmd.Parameters.AddWithValue("@date", date.Value.Date);
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            PatientId = reader["PatientId"].ToString(),
                            DoctorId = reader["DoctorId"].ToString(),
                            AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("AppointmentDateTime")),
                            Status = Enum.TryParse<AppointmentStatusEnum>(reader["Status"].ToString(), ignoreCase: true, out var statusParsed)
                                ? statusParsed
                                : AppointmentStatusEnum.Scheduled,
                            Notes = reader["Notes"].ToString()
                        };
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        public List<Appointment> GetRecent(int count)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP (@count) * FROM dbo.dbAppointment ORDER BY AppointmentDateTime DESC", conn);
                cmd.Parameters.AddWithValue("@count", count);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment
                        {
                            Id = reader.GetString(reader.GetOrdinal("Id")),
                            PatientId = reader["PatientId"].ToString(),
                            DoctorId = reader["DoctorId"].ToString(),
                            AppointmentDateTime = reader.GetDateTime(reader.GetOrdinal("AppointmentDateTime")),
                            Status = Enum.TryParse<AppointmentStatusEnum>(reader["Status"].ToString(), ignoreCase: true, out var statusParsed)
                                ? statusParsed
                                : AppointmentStatusEnum.Scheduled,
                            Notes = reader["Notes"].ToString()
                        };
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        public string GetNextAppointmentId()
        {
            var existingIds = GetAll().Select(a => a.Id).ToList();
            return AppointmentIdGenerator.GenerateNextId(existingIds);
        }

        public bool IsDoctorAvailable(string doctorId, DateTime appointmentDateTime, string excludeAppointmentId = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM dbo.dbAppointment " +
                               "WHERE DoctorId = @doctorId " +
                               "AND Status != 'Cancelled' " +
                               "AND AppointmentDateTime = @appointmentDateTime";

                if (!string.IsNullOrEmpty(excludeAppointmentId))
                {
                    query += " AND Id != @excludeId";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);

                if (!string.IsNullOrEmpty(excludeAppointmentId))
                {
                    cmd.Parameters.AddWithValue("@excludeId", excludeAppointmentId);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }
    }
}
