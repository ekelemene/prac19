using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books boo = new Books();
            ///делаем ввод с клавиатуры
            Console.Write("название:");
            boo.title = Console.ReadLine();
            Console.Write("автор:");
            boo.autor = Console.ReadLine();
            Console.Write("год:");
            boo.age = int.Parse(Console.ReadLine());
            Console.Write("страницы:");
            boo.pages = int.Parse(Console.ReadLine());
            ///используем метод для вывода 
            boo.Info();
        }
    }
}
