using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<Product> product1 = new List<Product>();
            List<Product> product2 = new List<Product>();
            MobilePhone mobile1 = new MobilePhone(1,"Iphone 5",1.3,"Abc");
            MobilePhone mobile2 = new MobilePhone(2,"Iphone 6",2.3,"Abc");
            MobilePhone mobile3 = new MobilePhone(3,"Iphone 7",3.3,"Abc");
            Book book1 = new Book(1, "Sach c#", 8.0, "Sack");
            Book book2 = new Book(2, "Sach c++", 9.0, "Sack");
            Book book3 = new Book(2, "Sach c--", 10.0, "Sack");
            product1.Add(mobile1);
            product1.Add(mobile2);
            product1.Add(mobile3);
            product2.Add(book1);
            product2.Add(book2);
            product2.Add(book3);

            
        }
    }
}
