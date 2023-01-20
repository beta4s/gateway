using RabbitMQ.Client;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace b4s.RabbitMQ
{

    public class Helper
    {

        private static IConnection? producerConnection;
        private static IConnection? consumerConnection;
        private static IModel producerChanel;
        private static IModel consumerChanel;


        public Helper()
        {
            Console.WriteLine("X");
        }

        private IConnection GetProducerConnection()
        {

            if (producerConnection == null)
                producerConnection = CreateConnectionFactory();

            return producerConnection;
        }

        private IConnection GetConsumerConnection()
        {

            if (consumerConnection == null)
                consumerConnection = CreateConnectionFactory();

            return consumerConnection;
        }

        private IConnection CreateConnectionFactory()
        {

            var factory = new ConnectionFactory()
            {
                UserName = Config.RabbitMQ.Config.UserName,
                Password = Config.RabbitMQ.Config.Password,
                Port = Config.RabbitMQ.Config.Port,
                HostName = Config.RabbitMQ.Config.HostName,
                Ssl = {
                    Enabled= true,
                    ServerName = Config.RabbitMQ.Config.HostName
                }
            };

            return factory.CreateConnection();

        }

        public IModel GetProducerChanel()
        {

            if (producerChanel == null ||
                producerChanel.IsClosed)
                producerChanel = GetProducerConnection().CreateModel();

            return producerChanel;
        }

        public IModel GetConsumerChanel()
        {

            if (consumerChanel == null ||
                consumerChanel.IsClosed)
                consumerChanel = GetConsumerConnection().CreateModel();

            return consumerChanel;
        }

        public void Publish(string queue, byte[] message)
        {
            GetProducerChanel().BasicPublish(exchange: "", routingKey: queue, body: message);
        }

    }

}