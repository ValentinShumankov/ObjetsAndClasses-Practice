using Humanizer;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ObjetsAndClasses_Practice
{
    public class Person
    {
        /// First add Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string eMail { get; set; }


        ///After add Constructors
        
        public Person(string firstName, string lastName, int age, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eMail = email;

        }
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {

        }
        ///All other Methods
        public override string ToString()
        {
            return $"{firstName} {lastName},Age = {age}, E-Mail = {eMail}";
        }

    }
}
