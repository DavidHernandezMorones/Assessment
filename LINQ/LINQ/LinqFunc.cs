using System;
using System.Linq;

namespace LINQ
{
    public class LinqFunc
    {
        public static string[] sortdesc(string[] names)
        {
            string[] sortdesc =
                (from name in names
                    orderby name descending
                    select name
                ).ToArray();
            return sortdesc;
        }

        public static bool find(string[] names, string m)
        {
            string[] found =
                (from name in names
                    where name == m
                    select name
                ).ToArray();
            return found.Length > 0;
        }
        
        public static string[] getJuanes(string[] names)
        {
            string[] str =
                (from name in names
                    where name.StartsWith("Juan")
                    select name
                ).ToArray();
            return str;
        }
        
        public static string[] concat(string[] names)
        {
            return (from name in names
                    select "hola " + name
                ).ToArray();
        }

        static void print(string[] str)
        {
            foreach (string s in str)
            {
                Console.Out.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            string[] names =
            {
                "Juan", "Pablo", "Pedro", "Pepe", "Ana", "Esteban", "Daniel", "Mariano", "Carolina", "Silvia",
                "Roberto", "Juanito", "Juana"
            };
            
            print(sortdesc(names));
            
            Console.Out.WriteLine(find(names, "Juan"));
            
            print(getJuanes(names));
            
            print(concat(names));
 
        }
    }
}