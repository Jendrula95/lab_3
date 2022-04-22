using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    public class SocketLogger : ILogger
    {
        private ConsoleApp.Logger.ClientSocket socketHandler;
       public SocketLogger(string host, int port)
        {
            socketHandler = new ConsoleApp.Logger.ClientSocket(host, port);

        }
         ~SocketLogger()
        {

        }
       public virtual void Log( String[]  message)
        {
            String messaged = "";
            for (int i = 0; i < message.Length; i++)
            {
                messaged += message[i] + " ";
            }
            byte[] buffer = new byte[messaged.Length];
            for (int i = 0; i < messaged.Length; i++)
            {
                buffer[i] = Convert.ToByte(messaged[i]);
            }
            socketHandler.Send(buffer,0, buffer.Length);
               
            
        }
        public virtual void  Dispose()
        {

        }
    }
}
