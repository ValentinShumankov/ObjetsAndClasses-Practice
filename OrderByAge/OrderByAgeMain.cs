using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class OrderByAgeMain
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            string[] personInfo = Console.ReadLine().Split(" ").ToArray();
            while (personInfo[0] != "End")
            {
                var personInfo1 = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
                person.Add(personInfo1);
                personInfo = Console.ReadLine().Split(" ").ToArray();
            }

            person = person.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, person));
        }
        class Person

        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string personName, string IDinfo, int personAge)
            {
                this.Name = personName;
                this.ID = IDinfo;
                this.Age = personAge;
            }


            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
    }
}
