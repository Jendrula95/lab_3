using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_3
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;
 
        public virtual void Log(String[] messages)
        {
            String outMessage ="";


            for ( int i = 0; i < messages.Length; ++i)
            {
                outMessage += messages[i] + " ";
            }


             writer.WriteLineAsync(outMessage);

        }

        public abstract void Dispose();
    }
}


