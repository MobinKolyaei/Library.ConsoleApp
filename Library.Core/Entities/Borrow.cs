using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Borrow : BaseEntity ,IReadable
    {
        public DateTime BorrowTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }

        public void Read()
        {
            Console.Write("Borrow Time: ");
            BorrowTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Book Id: ");
            BookId = int.Parse(Console.ReadLine());
            Console.Write("Member Id: ");
            MemberId = int.Parse(Console.ReadLine());
        }
    }
}
