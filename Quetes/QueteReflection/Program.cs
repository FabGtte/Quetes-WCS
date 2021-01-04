using System;

using System.Reflection;


namespace ReflectionTest

{

    class Program

    {

        static void Main(string[] args)

        {

            var reflected = new ReflectedClass();

            DisplayAllAttributes(reflected);

        }


        private static void DisplayAllAttributes(object reflected)

        {

            Type objectType = reflected.GetType();


            PropertyInfo[] properties = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            MethodInfo[] methods = objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            ConstructorInfo[] constructors = objectType.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo[] fields = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);


            Console.WriteLine("Properties");

            foreach (var p in properties)

            {

                Console.WriteLine("\t" + p);

            }

            Console.WriteLine("Methods");

            foreach (var m in methods)

            {

                Console.WriteLine("\t" + m);

            }


            Console.WriteLine("Constructors");

            foreach (var c in constructors)

            {

                Console.WriteLine("\t" + c);

            }


            Console.WriteLine("Fields");

            foreach (var f in fields)

            {

                Console.WriteLine("\t" + f);

            }

        }

    }

}
