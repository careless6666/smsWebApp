using System;

namespace BO
{
    public class Result
    {
        public bool ResultOperation { get; set; } = true;
        public string ErrorMessage { get; set; }
        public Exception Exception { get; set; }
    }
}
