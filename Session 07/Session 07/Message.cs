using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Session_07
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? MessageText { get; set; }  //Message in exercise pronunciation (property name can not be the same name as class name!)

        public Message() { 
            ID = Guid.NewGuid();
        }

        public Message(string text)
        {
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            MessageText = text;
        }



        //public Message(Guid id, DateTime timeStamp, string messageText)
        //{
        //    ID = id;
        //    TimeStamp = timeStamp;
        //    MessageText = messageText;
        //}
    }
}
