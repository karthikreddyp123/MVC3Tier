using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    //This class is used to store Custom Messages
    public class CustomMessage:ICustomMessage
    {
        public int MessageNumber { get; set; }
        public String Message { get; set; }
    }
}
