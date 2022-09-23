using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteHub
{
    internal class Note
    {
        private Int32 ID;
        public string Date { get; set; }
        public int Topic { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

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