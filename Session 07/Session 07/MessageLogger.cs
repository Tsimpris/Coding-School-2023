using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class MessageLogger
    {      
        public Message[] Messages { get; set; }

        public MessageLogger() 
        {
            Messages = new Message[1000];
        }

        public void ReadAll() {
            
        }
        public void Clear() { }

        //i'll come back later
        //public string Write(Message) { }
    }
}
