using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentQuery
{
    class Students
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public string city { get; set; }
        public bool isActive { get; set; }

    }

    class MinimalStudents
    {
        public string name { get; set; }
        public int score { get; set; }
    }
}
