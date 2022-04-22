using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
        }

         public override void Dispose()
        {
           // this.Dispose(disposing: true);

            //GC.SuppressFinalize(this);
        }
    }
}
