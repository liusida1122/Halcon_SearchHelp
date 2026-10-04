using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEZHOUPUKE.Commands
{
    public class MessageBusContent
    {
        public int ReceiveID;
        public string ReceiveType;
        public object ReceiveOBJ;
        public object ReceiveOBJ2;
        public object ReceiveOBJ3;
    }
    public static class MessageBus
    {
        public static event Action<MessageBusContent> MessageBusEvent;
        public static void Publish(MessageBusContent message)
        {
            MessageBusEvent?.Invoke(message);
        }
    }
}
