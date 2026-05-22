using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.Core.Utilities
{
    public static class AppointmentIdGenerator
    {
        private const string PREFIX = "A";
        private const int ID_LENGTH = 3; // For A001, A002, etc.

        /// <summary>
        /// Generates the next appointment ID in format A001, A002, etc.
        /// </summary>
        public static string GenerateNextId(List<string> existingIds)
        {
            if (existingIds == null || existingIds.Count == 0)
            {
                return PREFIX + "001";
            }

            // Extract numeric parts from existing IDs and find the maximum
            int maxNumber = 0;
            foreach (var id in existingIds)
            {
                if (id.StartsWith(PREFIX))
                {
                    string numPart = id.Substring(PREFIX.Length);
                    if (int.TryParse(numPart, out int num))
                    {
                        maxNumber = Math.Max(maxNumber, num);
                    }
                }
            }

            // Generate next ID
            int nextNumber = maxNumber + 1;
            return PREFIX + nextNumber.ToString($"D{ID_LENGTH}");
        }

        /// <summary>
        /// Validates if an ID is in the correct format (A###)
        /// </summary>
        public static bool IsValidAppointmentId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return false;

            if (!id.StartsWith(PREFIX))
                return false;

            string numPart = id.Substring(PREFIX.Length);
            return int.TryParse(numPart, out _);
        }

        /// <summary>
        /// Extracts the numeric part from an appointment ID
        /// </summary>
        public static int? ExtractNumber(string id)
        {
            if (!IsValidAppointmentId(id))
                return null;

            string numPart = id.Substring(PREFIX.Length);
            if (int.TryParse(numPart, out int num))
            {
                return num;
            }

            return null;
        }
    }
}
