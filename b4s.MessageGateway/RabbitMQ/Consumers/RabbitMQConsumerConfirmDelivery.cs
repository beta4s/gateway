using System;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace b4s.MessageGateway.RabbitMQ.Consumers
{
    public class RabbitMQConsumerConfirmDelivery: BackgroundService
    {

        private readonly ILogger<RabbitMQConsumerConfirmDelivery> logger;
        private IConnection connection;
        private IModel channel;
        private readonly int intervaloMensagemWorkerAtivo;
        private readonly IConfiguration configuration;

        public RabbitMQConsumerConfirmDelivery(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            this.configuration = configuration;
            this.logger = loggerFactory.CreateLogger<RabbitMQConsumerConfirmDelivery>();
            InitRabbitMQ();
        }

        private void InitRabbitMQ()
        {

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

            // create connection  
            connection = factory.CreateConnection();

            // create channel  
            //channel = connection.CreateModel();
            //channel.

            //_channel.ExchangeDeclare("demo.exchange", ExchangeType.Topic);
            //_channel.QueueDeclare("demo.queue.log", false, false, false, null);
            //_channel.QueueBind("demo.queue.log", "demo.exchange", "demo.queue.*", null);
            //_channel.BasicQos(0, 1, false);

            //_connection.ConnectionShutdown += RabbitMQ_ConnectionShutdown;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }

    }
}
