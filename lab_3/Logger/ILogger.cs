using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
   public interface ILogger: IDisposable
    {
        void Log(params String[] messages);
       
    }
}
