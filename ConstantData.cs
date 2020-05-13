using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPListenerApplication
{
    public class ConstantData
    {
        public EncodingObject[] Encodings = new EncodingObject[]
        {
            new EncodingObject{DisplayName="Unicode (UTF-8)",Name="utf-8"},
            new EncodingObject{DisplayName="Unicode (UTF-7)",Name="utf-7"},
            new EncodingObject{DisplayName="US-ASCII",Name="us-ascii"},
            new EncodingObject{DisplayName="utf-32BE",Name="utf-32BE"},
            new EncodingObject{DisplayName="Unicode (UTF-32)",Name="utf-32"},
            new EncodingObject{DisplayName="Unicode (Big endian)",Name="unicodeFFFE"},
            new EncodingObject{DisplayName="Unicode",Name="utf-16"},
        };
    }
}
