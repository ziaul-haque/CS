using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Parent{

        public String Name {get;private set;}
        public Parent(string name){
            Name = name;
        }
        public virtual void GreetingMember(string memberName){
            Console.WriteLine("Hello " + memberName + ", I am " + Name);
        }
        public void GreetingHost(){
            Console.WriteLine("Welcome to the world of Drama, I am " + Name);
        } 
    }
    public class Child : Parent{
        public Child(){
            base("child");
        }
    }
}
