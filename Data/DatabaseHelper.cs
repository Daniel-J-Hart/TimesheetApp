using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using TimesheetApp.Models;
using System.IO;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace TimesheetApp.Data
{
    internal class DatabaseHelper
    {
        private static readonly string DatabasePath = @"C:\Users\danie\source\repos\TimesheetApp\timesheetData.json"; // Update this path as needed - WEF Engineering shared file path

        static DatabaseHelper()
        {
            // Ensure the directory exists
            Directory.CreateDirectory(Path.GetDirectoryName(DatabasePath));
        }

        public static TimesheetData LoadData()
        {
            try
            {
                if (!File.Exists(DatabasePath))
                {
                    // Create initial empty database if file doesn't exist
                    var initialData = new TimesheetData();
                    SaveData(initialData);
                    return initialData;
                }

                string jsonString = File.ReadAllText(DatabasePath);

                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    return new TimesheetData();
                }

                TimesheetData result = JsonConvert.DeserializeObject<TimesheetData>(jsonString);
                return result ?? new TimesheetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new TimesheetData();
            }
        }

        public static void SaveData(TimesheetData data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);

                File.WriteAllText(DatabasePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetDatabasePath()
        {
            return DatabasePath;
        }
    }
}
