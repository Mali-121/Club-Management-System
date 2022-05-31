using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Activity
    {
        private string name, description, achievement;
        private DateTime entryDate;

        public Activity(string n, string d, string a, DateTime ed)
        {
            Name = n;
            Description = d;
            Achievement = a;
            EntryDate = ed;
        }

        public Activity(string n, string d, DateTime ed)
        {
            Name = n;
            Description = d;
            EntryDate = ed;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Achievement { get => achievement; set => achievement = value; }
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
    }
}
