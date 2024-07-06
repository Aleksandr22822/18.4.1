using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._4._1
{
    internal class User
    {
        ICommand _command;

        public void SerCommand(ICommand command)
        { 
        _command = command; 
        }
       public void Run () 
        {
            _command.Run();
        }    

        void Download () 
        { 
        
        }    
    }
}
