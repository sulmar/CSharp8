using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    static class SwitchExpressions
    {
        public static void Test()
        {
           

          

        }

        // Switch expressions
        static string Get(int i)
        {
            switch (i)
            {
                case 1: return "jeden";
                case 2: return "dwa";
                case 3: return "trzy";
                default: throw new ArgumentOutOfRangeException(nameof(i), i, message: null);
            }
        }

        // C# 8.0
        static string Get2(int i)
        {
            return i switch
            {
                1 => "jeden",
                2 => "dwa",
                3 => "trzy",
                _ => throw new ArgumentOutOfRangeException(nameof(i), i, message: null)
            };
        }

        static string Get(PersonType personType)
        {
            switch (personType)
            {
                case PersonType.Adult: return "Dorosły";
                case PersonType.Child: return "Dziecko";
                case PersonType.Teenage: return "Nastolatek";
                default: throw new ArgumentOutOfRangeException(nameof(personType), personType, message: null);
            }
        }



        // C# 8.0
        static string Get2(PersonType personType)
        {
            return personType switch
            {
                PersonType.Adult => "Dorosły",
                PersonType.Child => "Dziecko",
                PersonType.Teenage => "Nastolatek",
                _ => throw new ArgumentOutOfRangeException(nameof(personType), personType, message: null)

            };
        }

        // Zastosowanie when
        static string Get(PersonType personType, bool isWoman)
        {
            switch (personType)
            {
                case PersonType.Adult when isWoman: return "Dorosły";
                case PersonType.Adult when !isWoman: return "Dziecko";
                case PersonType.Child: return "Dziecko";
                case PersonType.Teenage: return "Nastolatek";
                default: throw new ArgumentOutOfRangeException(nameof(personType), personType, message: null);
            }
        }

        // C# 8.0
        static string Get2(PersonType personType, bool isWoman)
        {
            return personType switch
            {
                PersonType.Adult when isWoman => "Dorosły",
                PersonType.Adult when !isWoman => "Dziecko",
                PersonType.Child => "Dziecko",
                PersonType.Teenage => "Nastolatek",
                _ => throw new ArgumentOutOfRangeException(nameof(personType), personType, message: null)

            };
        }


        static string Get3(PersonType personType)
        {
            return personType switch
            {
                PersonType.Adult => "Dorosły",
                PersonType.Child => "Dziecko",
                PersonType.Teenage => "Nastolatek",
                _ => throw new ArgumentOutOfRangeException(nameof(personType), personType, message: null)

            };
        }

        // Property patterns
        static string Get3(Person person)
        {
            return person switch
            {
                { PersonType: PersonType.Adult } => "Dorosły",
                { PersonType: PersonType.Child } => "Dziecko",
                { FirstName: "Marcin" } => "Administrator",
            };
        }

        static int Calculate(string operation, int a, int b)
        {
            var result = operation switch
            {
                "+" => a + b,
                "-" => a - b,
                "/" => a / b,
                _ => throw new NotSupportedException()
            };

            return result;
        }

        static void TuplePatternsTest()
        {
            Person p = new Person("Marcin", "Sulecki");

            p = new Person(null, null);

            Console.WriteLine(Get(p));

            Rectangle rectangle = new Rectangle { Width = 100, Height = 50 };
            double area = CalculateArea(rectangle);
        }

        // Tuple Patterns
        static string Get(Person p)
        {
            return (p.FirstName, p.MiddleName, p.LastName)
            switch
            {
                (string f, string m, string l) => $"{f} {m[0]} {l}",
                (string f, null, string l) => $"{f} {l}",
                (null, null, null) => "Someone",
            };
        }

        static double CalculateArea(Figure figure)
        {
            double area = figure switch
            {
                Line _ => 0,
                Rectangle r => r.Width * r.Height,
                Circle c => Math.PI * c.Radius * c.Radius,
                _ => throw new NotSupportedException()
            };

            return area;
        }


    }


    #region Models

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            MiddleName = null;
            LastName = lastName;
        }

        public Person(string firstName, string middleName, string lastName) : this(firstName, middleName)
        {
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public PersonType PersonType { get; set; }


    }

    public enum PersonType
    {
        Child,
        Teenage,
        Adult

    }

    public abstract class Figure
    {

    }

    public class Line : Figure
    {

    }

    public class Rectangle : Figure
    {
        public float Width { get; set; }

        public float Height { get; set; }
    }

    public class Circle : Figure
    {
        public float Radius { get; set; }
    }

    #endregion
}
