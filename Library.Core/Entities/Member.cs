using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Member : BaseEntity, IReadable
    {
        public string? Fullname { get; set; }
        public string? Address { get; set; }
        public void Read()
        {
            Console.Write("Fullname: ");
            Fullname = Console.ReadLine();
            Console.Write("Address: ");
            Address = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Member : {Id} {Fullname} {Address} {CreationTime}";
        }
    }
}
