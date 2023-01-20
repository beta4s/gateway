namespace b4s.MessageGateway.RabbitMQ
{
    public interface IRabbitMQProducer 
    {
        public void SendMessage<T>(T message, string queue);
    }

}
