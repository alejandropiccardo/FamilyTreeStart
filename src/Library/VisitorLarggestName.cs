using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
public class VisitorLargestName:Visitor
{
    public VisitorLargestName()
    {
        this.LarggestName="";
    }
    public override string Content()
    {
        return LarggestName.ToString();
    }
    
    public string LarggestName{get;set;}
    public override void Visit(Person person)
    {
        if (person.Name.Length>LarggestName.Length)
        {
            LarggestName= person.Name;
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
