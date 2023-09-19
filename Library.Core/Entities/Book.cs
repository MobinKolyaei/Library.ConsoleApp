using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Book : BaseEntity , IReadable
    {
        public string? Title { get; set; }
        public string? Writer { get; set; }
        public double Price { get; set; }

        public void Read()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Writer: ");
            Writer = Console.ReadLine();
            Console.Write("Price: ");
            Price = double.Parse(Console.ReadLine()??"0");
        }
        public override string ToString()
        {
            return $"Book : {Id} {Title} {Writer} {Price} {CreationTime}";
        }
    }
}
