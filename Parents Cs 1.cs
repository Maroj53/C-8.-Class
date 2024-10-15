
using System.Security.Cryptography.X509Certificates;

namespace Parenting
{



    class Human
    {
        public string name;
        public int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;



        }
        public virtual void Hello()
        {
            Console.WriteLine("Hello my name is", this.name, "and my age is", this.age);
            


        }




    }

    class Student : Human
    {
        public string Grade;

        
        public Student(string Grade)  :base("Ema",13)
        {
            this.Grade = Grade;

            






        }
        public virtual void grade()
        {
            Console.WriteLine("Btw my grade is ");
            Console.Write(this.Grade);
            Console.Write(" but nobody cares about that.");



        }
        
    }
        class Program
        {
            static void Main()
            {
                Student Anna = new Student("A++");
                Anna.Hello();
                Anna.grade();
            }
        }
}

