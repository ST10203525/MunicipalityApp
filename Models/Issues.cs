namespace MunicipalityApp.Models
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
        public DateTime ReportedAt { get; set; }

        public Issue()
        {
            ReportedAt = DateTime.Now; // Automatically set timestamp
        }
    }
}
