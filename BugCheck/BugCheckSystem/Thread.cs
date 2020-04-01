using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    public class Thread
    {
        public int Id { get; set; }
        
        public string Message { get; set; }
        
        public Thread() { }

        public Thread(string m)
        {
            Message = m;
        }
    }
}
