using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCourse
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public string Diag { get; set; }
        public int RoomN { get; set; }

        public Patient(string name, string surname, DateTime birth, string diag, int roomN)
        {
            Name = name; Surname = surname; Birth = birth; Diag = diag; RoomN = roomN;
        }

        public Patient()
        { }
    }
}
