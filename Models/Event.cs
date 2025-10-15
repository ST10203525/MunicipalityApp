using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Models
{
    public class Event
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Event(int id, string title, string category, DateTime date, string description = "")
        {
            Id = id;
            Title = title;
            Category = category;
            Date = date.Date;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Date:yyyy-MM-dd} | {Category} | {Title}";
        }
    }
}