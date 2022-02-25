using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelftCreateIOC.Test
{
    public class MainApp
    {
        public  Task RunAppAsync()
        {
            Console.WriteLine("Done");
            return Task.CompletedTask;  
        }
    }
}
