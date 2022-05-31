using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ClubRegistration
    {
        private string name, president, vicePresident, clubRepresentative, clubDescription;
        private DateTime registrationDate;

        public ClubRegistration(string n, DateTime d, string p, string vp, string r, string cd)
        {
            Name = n;
            RegistrationDate = d;
            President = p;
            VicePresident = vp;
            ClubRepresentative = r;
            ClubDescription = cd;
        }

        public ClubRegistration(string n)
        {
            Name = n;
        }

        public string Name { get => name; set => name = value; }
        public string President { get => president; set => president = value; }
        public string VicePresident { get => vicePresident; set => vicePresident = value; }
        public string ClubRepresentative { get => clubRepresentative; set => clubRepresentative = value; }
        public string ClubDescription { get => clubDescription; set => clubDescription = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }

        public void updateDetails(string p, string vp, string r, string d)
        {
            President = p;
            VicePresident = vp;
            ClubRepresentative = r;
            ClubDescription = d;
        }
    }
}
