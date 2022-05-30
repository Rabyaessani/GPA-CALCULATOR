using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GpaCalculator:GradePointCal
    {
        public double points = 0;
        private double CrdHrs;
        public double Hrs = 0;

        public void setCrdHrs(double hrs)
        {
            CrdHrs = hrs;
        }
        public double getCrdHrs()
        {
            return CrdHrs;
        }
        public void cal()
        {
            double point = CrdHrs * GradePoint();
            points = point + points;
            Hrs = CrdHrs + Hrs;
        }
        public double Gpa()
        {
            double gpa = points / Hrs;
            return gpa;
        }

    }
}
