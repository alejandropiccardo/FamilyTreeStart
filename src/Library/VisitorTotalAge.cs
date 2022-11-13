using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
public class VisitorTotalAge:Visitor
{
    public override string Content()
    {
        return TotalAge.ToString();
    }
    
    public int TotalAge{get;set;}
    public override void Visit(Person person)
    {
        TotalAge+=person.Age;
    }
    public override void Visit(Node node)
    {
        foreach (Node Child in node.Children)
        {
            Child.Accept(this);
            this.Visit(Child.Person);
        }
    }
}
}
