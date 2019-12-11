using System;
using System.Collections.Generic;

namespace GradeBook.BusinessLogic
{

    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    public class InMemoryBook : Book
    {

        public override event GradeAddedDelegate GradeAdded; 
        List<double> grades;
                  
        public const string CATEGORY = "Science";


        public InMemoryBook(string name) : base(name) // Access the base class constr.
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

        public override void AddGrade(double grade)
        {
            // Per requirements the grade must be higher than 0 and lower than 100
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
               throw new ArgumentException ($"Invalid {nameof(Name)}");
            }
        }

       

        public override Statistics GetStatistics()
        {

            var result = new Statistics();            
            
            for(var i = 0; i < grades.Count; i++)
            {                
                result.Add(grades[i]);
            }            

            return result;

        }
    }
}