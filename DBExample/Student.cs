using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GetFullName
        {
            get
            {
                return Surname + " " + Name;
            }
        }
        public int? Id_Group { get; set; }
        public Group Group { get; set; }
        public String GetGroup
        {
            get
            {
                return Group != null ? Group.Description : String.Empty;
            }
        }
        public int? Id_Role { get; set; }
        public Role Role { get; set; }
        public String GetRole
        {
            get
            {
                return Role!=null?Role.Name:String.Empty;
            }
        }

    }
}
