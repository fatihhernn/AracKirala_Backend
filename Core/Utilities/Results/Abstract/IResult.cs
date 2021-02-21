using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Abstract
{
    public interface IResult
    {
        string Message { get; }
        bool Success { get; }

    }
}
