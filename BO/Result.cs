using System;

namespace BO
{
    public class Result<T>
    {
        public bool ResultOperation { get; set; } = true;
        public T ResultObject { get; set; }
        public string ErrorMessage { get; set; }
        public Exception Exception { get; set; }
    }
}
