using System;
using System.Collections.Generic;

namespace GradeBook
{   
    public class Book
    {
        List<double> grades;
        //public string Name;
                
        public string Name { get; set; }   // Read Only property   
        public const string CATEGORY = "Science";


        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
            
        }

        public void AddGrade(double grade)
        {
            // Per requirements the grade must be higher than 0 and lower than 100
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
               throw new ArgumentException ($"Invalid {nameof(Name)}");
            }
        }

        public Statistics GetStatistics(){

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            //var avg = 0.0;

            
            for(var i = 0; i < grades.Count; i++)
            {
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
            }

            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;

        }
    }
}