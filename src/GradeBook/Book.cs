using System;
using System.Collections.Generic; 
namespace GradeBook
{
    class Book
    {
        // don't use implicit typing with fields : var keyword  
        List<double> grades = new List<double>();//this is a field= attribute 
        public void showStatistics(){
            double result = 0.0;
            double lowDegree = double.MaxValue;
            double highDegree = double.MinValue;
            foreach(var grade in grades){
                lowDegree = Math.Min(grade,lowDegree);
                highDegree = Math.Max(grade,highDegree);
            }
            System.Console.WriteLine($"lowest grade {lowDegree}");
            System.Console.WriteLine($"highest grade {highDegree}");
        }
        public void addGrade(double x){
            //always add validation input in every method
            grades.Add(x);
        }
    }
}