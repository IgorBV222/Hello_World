using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            try
            {
                name = args[0];                
            }
            catch
            {
                Console.WriteLine("Как Вас зовут?");
                name = Console.ReadLine();
            }
            finally
            {
                //Console.WriteLine("Hello, {0}! ", name);
                Console.WriteLine("Hello, \n");
                for (int i = 0; i < name.Length; i++)
                {
                    Console.Write(name[i] + "\n");
                }
                Console.WriteLine("!");
            }
            Console.ReadKey();


            /*Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
             Console.WriteLine("Hello, " + name + "!"); // вывод вариант 1
             Console.WriteLine("Hello, {0}! ", name); // вывод вариант 2
             Console.WriteLine($"Hello, {name} !"); // вывод вариант 3
            Console.WriteLine("Hello, {0}! ", args[0]);*/

        }
    }
}