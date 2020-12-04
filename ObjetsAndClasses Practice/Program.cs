using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace ObjetsAndClasses_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person petar = new Person("Ivan","Ivanov",23,"lkahsd@abv.bg");
            Person sanyq = new Person("Sanyq","Ivanova",20,"snayq2019@abv.bg");
            Console.WriteLine(petar);
            Console.WriteLine(sanyq);
        }
    }


    
}
