using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    public class Bug
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        
        public string Status { get; set; }

        public int Priority { get; set; }

        public Product Product { get; set; }

        public PersonalAccount AddedBy { get; set; }

        public PersonalAccount AssignedTo { get; set; }
        
        public Bug() { }

        public Bug(string title, string desc, string status, int priority, Product p, PersonalAccount a)
        {
            Title = title;
            Description = desc;
            Status = status;
            Priority = priority;
            Product = p;
            AddedBy = a;
        }

        public Bug(int id, string title, string desc, string status, int priority)
        {
            Id = id;
            Title = title;
            Description = desc;
            Status = status;
            Priority = priority;
        }

        /*
        public Bug(int id, string title, string desc, string status, string priority, int prodId, int addBy)
        {
            Id = id;
            Title = title;
            Description = desc;
            Status = status;
            Priority = priority;
            ProductId = prodId;
            AddedBy = addBy;
        }

        public Bug(int id, string title, string desc, string status, string priority, int prodId, int addBy, int assTo)
        {
            Id = id;
            Title = title;
            Description = desc;
            Status = status;
            Priority = priority;
            ProductId = prodId;
            AddedBy = addBy;
            AssignedTo = assTo;
        }*/
    }
}
