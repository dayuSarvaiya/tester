using System;
using System.Globalization;

class Program
{
   /* static void Mymethod(string fname="jeel")//default parameter
    {
        Console.WriteLine(fname);

    }
    static void Main(string[] args )
    {
        // Console.WriteLine();
        Mymethod();
        Mymethod("bhaveshbhai");

    }*/


   //return  value
  /* static int val(int x)
    {
        return 2+x;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(val(5));
    }*/


  //named argument 
  //key:value 
 /* static void Mymethod(string book1, string book2)
    {
        Console.WriteLine("firse book name is:" + book1);
    }
    static void Main(string[] args)
    {
        Mymethod(book1: "c#", book2: "java");
    }*/

    //method overloading:same method name diffrent parameter
    /*static int Mymethod(int a,int b)
    {
        return a + b;
    }
    static double Mymethod(double a,double b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Mymethod(5, 10));
        Console.WriteLine(Mymethod(2.0,3.5));
    }*/


    //class members
    //Variables and fuction

    /*class Person
    {
        public string name="jeel";
        public int age = 22;
        public void personData()
        {
            Console.WriteLine("Person name is:" + name + "person age is:" + age);
        }

    }
    static void Main(string[] args)
    {
        Person p = new Person();
        Console.WriteLine(p.name);
        Console.WriteLine(p.age);
        p.personData();

    }*/


    //parameter constructor/simple constructor class have a default constructor

   class Person
    {
        public string name;
        public int age;
        public Person(/*string personmname, int age*/)
        {
            name = "jeel";
            age = 22;
           // name = personmname;
        }
    }
   static void Main(string[] args)
    {
       Person p = new Person(/*"jeel",22*/);
       Console.WriteLine(p.name);
       Console.WriteLine(p.age);
    }

}


