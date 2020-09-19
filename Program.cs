using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihalich_zver
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte a = 0;
            Byte b = 0; 
            Int16 с = 0;
            Int32 d = 0;
            Int64 e = 0;
            string s = "";
            object[] types = { a, b, c, d, e, s };
            foreach (object о in types)
            {
                string type;
                if (o.GetType().IsValueType) type = "Value type";
                else
                    type = "Reference Type";
                Console.WriteLine("{0}: {1}", o.GetType(), type);
            }
        }
    }
}
