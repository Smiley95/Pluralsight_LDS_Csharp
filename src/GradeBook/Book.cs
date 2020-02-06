using System;
using System.Collections.Generic; 
namespace GradeBook
{
    public class Book
    {
        // don't use implicit typing with fields : var keyword  
        List<double> grades;//this is a field= attribute 
        public string Name;
        public Book(string name){
            this.Name= name;
            grades = new List<double>();
        }
        public Statistics getStatistics(){
            Statistics result = new Statistics();
            result.average = 0.0;
            result.low = double.MaxValue;
            result.high = double.MinValue;
            foreach(var grade in grades){
                result.average+= grade;
                result.low = Math.Min(grade,result.low);
                result.high = Math.Max(grade,result.high);
            }
            result.average/=grades.Count; 
            return result;
        }
        public void addGrade(double x){
            //always add validation input in every method
            grades.Add(x);
        }
        
    }
}