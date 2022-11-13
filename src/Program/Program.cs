using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1=new Person("a",1);
            Person p2=new Person("b",2);
            Person p3=new Person("c",3);
            Person p4=new Person("d",4);
            Person p5=new Person("e",100);
            Person p6=new Person("f",1);
            Person p7=new Person("gal",10);
            Person p8=new Person("h",7);
            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n5.AddChildren(n8);
            // n1(n2(n4+n5(n8)) + n3(n6+n7))        estructura

            VisitorTotalAge vTotalAge = new VisitorTotalAge();
            vTotalAge.Visit(n1);
            Console.WriteLine(vTotalAge.Content()); //no recorre el nodo padre p1. ya que va directo a los child
            VisitorLargestName vLargestName = new VisitorLargestName();
            vLargestName.Visit(n1);
            Console.WriteLine(vLargestName.Content());
            VisitorFirstBorn vFB = new VisitorFirstBorn();
            vFB.Visit(n1);
            Console.WriteLine(vFB.Content());

        }
    }
}
