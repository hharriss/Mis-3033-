using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Class1
    {
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }

        public Course()
        {

        }
        public override string ToString()
        {
            string msg = $"{CourseID}, {Subject}-{CourseNumber}, taught by {Instructor}";
            //msg = CourseID + ", " + Subject + "-" + Course Number
            return msg;
        }
    }
}
