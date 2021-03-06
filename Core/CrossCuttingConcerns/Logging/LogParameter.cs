using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogParameter
    {
        //instance :  product
        public string Name { get; set; }

        //id , name falan
        public object Value { get; set; }

        //Product
        public string Type { get; set; }
    }
}
