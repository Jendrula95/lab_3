using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_3
{
    class FileLogger : WriterLogger
    {
        bool disposed;
       //protected FileStream m_stream;
        String m_fileName;
        public FileLogger(String path)
        {
            m_fileName = path;
           //_stream = new FileStream("plik-1.txt", FileMode.Append);
            

            writer = new StreamWriter(m_fileName,false, Encoding.UTF8);

        }
        ~FileLogger(){
            this.Dispose();
        }

        public override void Dispose()
        {
            Dispose(disposing: true);

              GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.writer.Close();
                    this.writer.Dispose();
                }

                this.disposed = true;
            }
        }

    }
}
