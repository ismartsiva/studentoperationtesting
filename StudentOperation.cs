using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentoperationtesting
{
    public class StudentOperation : Istudent

    {
        public StudentOperation()
        {

        }


        public List<student> GetStudents()
        {
            Idataservices services = new dataservices();

            var res = services.GetStudentdata();

            //List<student> students = new List<student>();
            //students.Add(new student() { rno = 1, name = "AAA" }) ;
            //students.Add(new student() { rno = 2, name = "BBB" }) ;
            //students.Add(new student() { rno = 3, name = "CCC" }) ;
            //students.Add(new student() { rno = 4, name = "DDD" });

            return res ;
        }
    }
}
