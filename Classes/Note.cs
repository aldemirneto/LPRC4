using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteHub
{
    public class Note
    {
        public Int32 ID;
        public string Date { get; set; }
        public int Topic { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Note() { }

        public Note(int id, string date, int topic, string name, string description)
        {

            this.ID = id;
            this.Date = date;
            this.Topic = topic;
            this.Name = name;
            this.Description = description;

        }

    }
}