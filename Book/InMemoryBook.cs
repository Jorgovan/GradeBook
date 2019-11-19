using System;
using System.Collections.Generic;

namespace GradeBook
{    
    public class InMemoryBook : NamedOBject
        {
            public InMemoryBook(string name) : base(name)
            {
                grades = new List<double>();
                this.Name = name;
            }

            

            public void AddGrade(double grade)
            {
                if(grade <= 100 && grade >=0) {
                    grades.Add(grade);
                    if(GradeAdded!=null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new ArgumentException($"Invalid {nameof(grade)}");
                }
            }

            public Statistics GetStatistics()
            {
                var result = new Statistics();
                
                foreach (double number in grades)
                {
                    result.Add(number);

                }

                return result;
                
                
            }
            public event GradeAddedDelegate GradeAdded;

            List<double> grades;

        }
}