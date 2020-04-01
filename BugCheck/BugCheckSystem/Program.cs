using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = new Product("name", "type", "desc");

            product.Create(product);
            product.Update("newType", "newDesc");
            
            var employee = new Employee("first", "sur", "position");
            var pAcc = new PersonalAccount("nick", employee);
            var bug = new Bug("ttile", "desc", "Active", 3, product, pAcc);

            var ops = new BugOps();
            ops.Insert(bug);

            var b = BugOps.Read(8);
            Console.WriteLine(b.Title + " " + b.Status);
        }
    }
}
