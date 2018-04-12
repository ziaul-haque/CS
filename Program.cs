using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Inheritence!");

            Parent parent = new Parent("Parent");
            parent.GreetingMember("Pankaj");
            parent.GreetingHost();

            Child child = new Child();
            child.GreetingMember("Pankaj");
            child.GreetingHost();

            parent = child;
            parent.GreetingMember("Pankaj");
            parent.GreetingHost();



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
            Console.WriteLine("D D Dance Papa, I am " + Name);
        } 
    }
    public class Child : Parent{
        public Child() : base("child"){
            
        }
        public override void GreetingMember(string memberName){
            Console.WriteLine("Hello " + memberName + ", I am " + Name);
        }

        public void GreetingHost(){
            Console.WriteLine("Child can't dance!!!!, I am " + Name);   
        }
    }
}
