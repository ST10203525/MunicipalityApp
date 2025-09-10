using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MunicipalityApp.Models;

namespace MunicipalityApp.Data
{
    public static class IssueRepository
    {
        private static readonly string dataFile = "issues.json";
        public static List<Issue> Issues { get; private set; } = new List<Issue>();

        static IssueRepository()
        {
            LoadIssues();
        }

        public static void AddIssue(Issue issue)
        {
            Issues.Add(issue);
            SaveIssues();
        }

        private static void SaveIssues()
        {
            string json = JsonSerializer.Serialize(Issues, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataFile, json);
        }

        private static void LoadIssues()
        {
            if (File.Exists(dataFile))
            {
                string json = File.ReadAllText(dataFile);
                Issues = JsonSerializer.Deserialize<List<Issue>>(json);
            }
        }
    }
}
