using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public interface ICustomMessage
    {
        int MessageNumber { get; set; }
        String Message { get; set; }
    }
}
