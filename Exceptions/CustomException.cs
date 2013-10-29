using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CustomException:Exception
    {
        public string ErrorCode = "Error en formato tiene que escribir un int\n";
        public CustomException()
        {
            Console.WriteLine(ErrorCode);
        }
    }
}
