using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public Person(string Name, int Age)
        {
            this.Name=Name;
            this.Age=Age;
        }
        public string Name{get;set;}
        public int Age{get;set;}
        public void Accept(Visitor visitor)
       {
            visitor.Visit(this);
       }
    }
}
