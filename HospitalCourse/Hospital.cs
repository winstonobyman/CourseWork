using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCourse
{
    public class Hospital
    {
        public string Name { get; set; }
        public DateTime Foundation { get; set; }
        public string Address { get; set; }
        public string HospHead { get; set; }
        public List<Department> List { get; set; }

        public int Count
        {
            get
            {
                if (List == null)
                    return 0;
                else return List.Count;
            }
        }

        public Hospital(string name, DateTime foundation, string address, 
            string hosphead, List<Department> list)
        {
            Name = name; Foundation = foundation; Address = address;
            HospHead = hosphead; List = list;
        }

        public Hospital()
        { }
    }
}
