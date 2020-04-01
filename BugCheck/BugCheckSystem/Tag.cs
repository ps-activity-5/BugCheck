using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Bug> Bug { get; set; }

        public Tag() { }
        
        public Tag(string name)
        {
            Name = name;
        }
    }
}
