using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteHub
{
    internal class Topic
    {
        private Int32 IDTopic;
        public string DescTopic { get; set; }

        public Topic(Int32 id, string desctopic)
        {
            this.IDTopic = id;
            this.DescTopic = desctopic;
        }

    }
}