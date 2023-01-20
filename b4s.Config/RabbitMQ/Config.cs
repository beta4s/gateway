using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4s.Config.RabbitMQ
{
    public static class Config
    {
        public static string UserName 
        {
            get { return "lauracare"; }
        }

        public static string Password 
        { 
            get { return "QM4Z$u#k46uFHs"; } 
        }

        public static int Port
        {
            get { return 5671; }
        }

        public static string HostName
        {
            get { return "b-d9c2f300-d90b-476f-9451-6c5d1d118650.mq.us-east-1.amazonaws.com"; } 
        }
    }
}
