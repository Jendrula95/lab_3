using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_3
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;
        public virtual void Log(params string[] messages)
        {
            FileStream stream = new FileStream("plik-1.txt", FileMode.Append);

            writer = new StreamWriter(stream, Encoding.UTF8);

            // stream and writer should be closed and destroyed when not needed, eg.
            //
            //     writer.Close();
            //     stream.Close();
            //     writer.Dispose();
            //     stream.Dispose();
        }

        // when we want to write text into console:
        {
            writer = Console.Out;

            // writer is not created by programmer so we should not close or destroy it
        }

        writer.Write("Text to write here ...");
        writer.Flush();
        }

        public abstract void Dispose();
    }
}


