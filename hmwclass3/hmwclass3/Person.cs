using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmwclass3
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public string male;
        public bool IsAlive;

        //ланцюжок
       // public Person() { }
      //  public Person(string name) : this(name, "") { }

        public  Person(string name,string surname,string male,int age) {

            this.name = "Richard";
            this.surname = "Wagner";
            
          // this.male = "yes";
            this.age = 70;

        }
        
        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}\nSurname:{1}\nMale:{2}\nAge:{3}", name, surname,male, age);
        }
        public void Alive()
        {
            IsAlive = true;
        }
       public void AliveOff()
        {
            IsAlive = false;
        }

    }
}
