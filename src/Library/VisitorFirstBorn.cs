using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
public class VisitorFirstBorn:Visitor
{
    public override string Content()
    {
        return FirstBorn.Name;
    }
    
    public Person FirstBorn{get;set;}
    public override void Visit(Person person)
    {
        if (FirstBorn==null)
        {
            FirstBorn=person;
        }
        else 
        {
            if (person.Age>FirstBorn.Age)
            {
                FirstBorn=person;
            }
            
        }
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
