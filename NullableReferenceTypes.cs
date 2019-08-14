using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;
using System.Xml.Schema;

namespace CSharp8.Nullable
{

#nullable enable
    class NullableReferenceTypes
    {

        public static void Test()
        {
            Person person = new Person("John", "Smith") { MiddleName = "Peter" };

            Console.WriteLine(person.FullName);

            Calculate(null);
        }

        public static int Calculate(string? text)
        {
            return text.Length;
        }

       
    }

    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            MiddleName = null;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                //return (MiddleName != null)
                //    ? $"{FirstName} {MiddleName[0]}. {LastName}"
                //    : $"{FirstName} {LastName}";

                // switch expressions
                return (FirstName, MiddleName, LastName)
                    switch
                    {
                        (string f, string m, string l) => $"{f} {m[0]}.{l}",
                        (string f, null, string l) => $"{f} {l}",
                    };


                //if (MiddleName != null)
                //    return $"{FirstName} {MiddleName[0]}. {LastName}";
                //else
                //    return $"{FirstName} {LastName}";
            }
        }

       
    }
}
