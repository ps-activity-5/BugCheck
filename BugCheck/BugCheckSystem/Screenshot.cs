using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    public class Screenshot
    {
        public int Id { get; set; }
        
        public string Path { get; set; }

        public int BugId { get; set; }

        public Screenshot() { }

        public Screenshot(string path)
        {
            Path = path;
        }
    }
}
