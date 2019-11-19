using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public int Count;
        public double High;
        public double Low;
        public double Sum;
        
        public void Add (double number)

        {
            Sum+=number;
            Count++;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
            Average = Sum / Count;
        }


        public Statistics()
        {
            Sum = 0; 
            Average = 0;
            Count = 0;
            Low = double.MaxValue;
            High = double.MinValue;
        }
        public char Letter ()
        {
            switch(Average)

            {   
                case var d when d>=90.0:
                    return 'A';
                case var d when d>=80.0:
                    return 'B';
                    ;
                case var d when d>=70.0:
                    return 'C';
                    
                case var d when d>=60.0:
                    return 'D';
                    
                default:
                    return 'F';
                
            }
        }
        
    }
}