using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeeeee
{
    public class test
    {
        public int idStudent { get; set; }
        public List<StudentGrade> StudentGrades { get; set; }
    }
    public class StudentGrade
    {
        public string className { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }

    }

    public class DbResult
    {
        public int studentID { get; set; }
        public string className { get; set; }

        public int startTime { get; set; }
        public int endTime { get; set; }

    }
    public void Calcular()
    {

    }
}
