using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_19
{
    /// <summary>
    /// класс книги
    /// </summary>
    internal class Books : Program
    {
        ///1. поля: название, автор, год выпуска, объем в листах.    
        public string title;
        public string autor;
        public int age;
        public int pages;

        /// <summary>
        /// метод для вывода 
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"название: {title}\nавтор: {autor}\nгод выпуска:{age}\nстраницы: {pages}");
        }




    }
}
