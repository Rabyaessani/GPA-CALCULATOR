using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GradePointCal
    {
        private double mids;
        public void SetMids(double m)
        {
            mids = m;
        }
        public double GetMids()
        {
            return mids;
        }
        private double Quiz;
        public void setQuiz(double q)
        {
            Quiz = q;
        }
        public double getQuiz()
        {
            return Quiz;
        }
        private double Assignment;
        public void setAssignment(double A)
        {
            Assignment = A;
        }
        public double getAssignment()
        {
            return Assignment;
        }
        private double Final;
        public void setFinal(double f)
        {
            Final = f;
        }
        public double getFinal()
        {
            return Final;
        }
        double sessional;
        double total;
        double Gradepoint;
        string Grade;
        public double SessionalCal()
        {
            sessional = mids + Quiz + Assignment;
            return sessional;
        }
        public double totalCal()
        {
            total = SessionalCal() + Final;
            return total;
        }
        public double GradePoint()
        {
            if (totalCal() >= 85 && totalCal() < 100)
            {
                Gradepoint = 4.00;
                Grade = "A";
              
            }
            else if (totalCal() >= 80 && totalCal() < 85)
            {
                Gradepoint = 3.67;
                Grade = "A-";
                //Console.WriteLine(Grade);
                // return Gradepoint;
            }
            else if (totalCal() >= 75 && totalCal() < 80)
            {
                Gradepoint = 3.33;
                Grade = "B+";
               // Console.WriteLine(Grade);
                // return Gradepoint;
            }
            else if (totalCal() >= 71 && totalCal() < 75)
            {
                Gradepoint = 3.00;
                Grade = "B";
               // Console.WriteLine(Grade);
                // return Gradepoint;
            }
            else if (totalCal() >= 68 && totalCal() < 71)
            {
                Gradepoint = 2.67;
                Grade = "B-";
               // Console.WriteLine(Grade);
                // return Gradepoint;
            }
            else if (totalCal() >= 64 && totalCal() < 68)
            {
                Gradepoint = 2.33;
                Grade = "C+";
              //  Console.WriteLine(Grade);
                // return Gradepoint;
            }
            else if (totalCal() >= 60 && totalCal() < 64)
            {
                Gradepoint = 2.00;
                Grade = "C";
              //  Console.WriteLine(Grade);
                // return Gradepoint;
            }
            else if (totalCal() >= 57 && totalCal() < 60)
            {
                Gradepoint = 1.67;
                Grade = "C-";
              //  Console.WriteLine(Grade);
                //   return Gradepoint;
            }
            else if (totalCal() >= 53 && totalCal() < 57)
            {
                Gradepoint = 1.33;
                Grade = "D+";
               // Console.WriteLine(Grade);
                //return Gradepoint;
            }
            else if (totalCal() >= 50 && totalCal() < 53)
            {
                Gradepoint = 1.00;
                Grade = "D";
               // Console.WriteLine(Grade);
                // return Gradepoint;
            }
            else if (totalCal() < 50)
            {
                Gradepoint = 0.00;
                Grade = "F";
              //  Console.WriteLine(Grade);
                // return Gradepoint;
            }
            
            return Gradepoint;
        }
        public string Gradee(double Gradepoint)
        {
            return Grade;
        }
    }
}
