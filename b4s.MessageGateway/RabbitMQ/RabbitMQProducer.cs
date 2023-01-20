using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Runtime.CompilerServices;
using System.Text;

namespace b4s.MessageGateway.RabbitMQ
{
    public class RabbitMQProducer : IRabbitMQProducer
    {

        private readonly IConfiguration configuration;

        public RabbitMQProducer(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void SendMessage<T>(T message, string queue)
        {

            //Here we specify the Rabbit MQ Server. we use rabbitmq docker image and use it
            var factory = new ConnectionFactory()
            {
                UserName = configuration.GetValue<string>("RabbitMQ:UserName"),
                Password = configuration.GetValue<string>("RabbitMQ:Password"),
                Port = configuration.GetValue<int>("RabbitMQ:Port"),
                HostName = configuration.GetValue<string>("RabbitMQ:HostName"),
                Ssl = {
                    Enabled= true,
                    ServerName = configuration.GetValue<string>("RabbitMQ:HostName")
                }
            };
            //Create the RabbitMQ connection using connection factory details as i mentioned above
            var connection = factory.CreateConnection();

            //Here we create channel with session and model using
            var channel = connection.CreateModel();

            //declare the queue after mentioning name and a few property related to that
            //channel.QueueDeclare("product", exclusive: false);

            //Serialize the message
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);

            //put the data on to the product queue
            channel.BasicPublish(exchange: "", routingKey: queue, body: body);

        }

    }

}
