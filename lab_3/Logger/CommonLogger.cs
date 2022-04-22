using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    class CommonLogger : ILogger
    {
        ILogger [] mLogger;
    
        public CommonLogger(ILogger [] logger) 
        {
            if (logger == null)
            {
               // throw System.Exception();
            }
            mLogger = logger; 
        }
        public virtual void Log(params String[] messages)
        {
      for (int i = 0; i < mLogger.Length; i++)
            {
                mLogger[i].Log(messages);
            }
        }
         public virtual void Dispose()
        {
            for (int i = 0; i < mLogger.Length; i++)
            {
                mLogger[i].Dispose();
            }
            
        }

    };
}