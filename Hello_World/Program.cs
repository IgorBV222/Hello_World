using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hello_World
{
    internal class Program
    {
        static void PrintName(string _name, string _order = "")
        {
            Console.WriteLine("Hello, \n");
            if (_order == "-")
            {
                for (int i = _name.Length - 1; i >= 0; i--)
                {
                    Console.Write(_name[i] + "\n");
                }
            }
            else
            {
                for (int i = 0; i < _name.Length; i++)
                {
                    Console.Write(_name[i] + "\n");
                }
            }  
                
            Console.WriteLine("!");
        }

        static void Main(string[] args)
        {
            string name = "";
            string order;
            try
            {
                name = args[0];
                order = args[1];
            }
            catch
            {
                Console.WriteLine("Как Вас зовут?");
                name = Console.ReadLine();
            }
            finally
            {
                PrintName(name);
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