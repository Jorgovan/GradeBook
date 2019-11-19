using System.Collections.Generic;
using System;
using System.IO;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    
    public abstract class Book : NamedOBject, IBook
    {
        public Book(string name) : base (name)
        {}

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);


        public abstract Statistics GetStatistics();
    }
    
    
}