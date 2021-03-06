using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    class LogDetailWithException:LogDetail
    {
        public string ExceptionMessage { get; set; }
    }
}
