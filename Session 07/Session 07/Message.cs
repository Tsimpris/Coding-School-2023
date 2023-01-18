using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? MessageText { get; set; }  //Message in exercise pronunciation (property name can not be the same name as class name!)

        public Message() { }
        public Message(Guid id)
        {
            ID = id;
        }

        public Message(Guid id, DateTime timeStamp)
        {
            ID = id;
            TimeStamp = timeStamp;
        }

        public Message(Guid id, DateTime timeStamp, string messageText)
        {
            ID = id;
            TimeStamp = timeStamp;
            MessageText = messageText;
        }
    }
}
