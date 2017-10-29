using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Menopaws.Models
{
    public class MenopausalEvent
    {
        [PrimaryKey, AutoIncrement]
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public String Description { get; set; }
        public bool IsTrigger { get; set; }
        public int Intensity { get; set; }

        // Copied from sample data code (TodoItem)
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}
