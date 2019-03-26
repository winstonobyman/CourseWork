using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCourse
{
    [Serializable]
    public class Department
    {
        public string Head { get; set; }
        public string Name { get; set; }
        public int MaxRoom { get; set; }
        public string Phone { get; set; }
        public List<Patient> List { get; set; }

        public int Count { get
            {
                if (List == null)
                    return 0;
                else return List.Count;
            }
        }

        public Department(string head, string name, int maxRoom, string phone, List<Patient> list)
        {
            Head = head; Name = name; MaxRoom = maxRoom; Phone = phone; List = list;
        }

        public Department()
        { }
    }
}
