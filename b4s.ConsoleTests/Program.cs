using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

Console.WriteLine("Hello, World!");

//var config = new b4s.Config.Config();

//await config.GetTennants();

var factory = new ConnectionFactory()
{
    UserName = "lauracare",
    Password = "QM4Z$u#k46uFHs",
    Port = 5671,
    HostName = "b-d9c2f300-d90b-476f-9451-6c5d1d118650.mq.us-east-1.amazonaws.com",
    Ssl = {
                    Enabled= true,
                    ServerName = "b-d9c2f300-d90b-476f-9451-6c5d1d118650.mq.us-east-1.amazonaws.com"
                }
};
//Create the RabbitMQ connection using connection factory details as i mentioned above
var connection = factory.CreateConnection();


//Here we create channel with session and model using
var channel = connection.CreateModel();

//Serialize the message
var json = @$"Teste{DateTime.Now}";
var body = Encoding.UTF8.GetBytes(json);

//put the data on to the product queue
channel.BasicPublish(exchange: "", routingKey: "qConfirmDelivery", body: body);


json = @$"Teste{DateTime.Now}";
body = Encoding.UTF8.GetBytes(json);
channel.BasicPublish(exchange: "", routingKey: "qFromRasa", body: body);



////Here we create channel with session and model using
//var channelA = connection.CreateModel();

//////declare the queue after mentioning name and a few property related to that
////channel.QueueDeclare("qConfirmDelivery", exclusive: false);
//channelA.QueueDeclare("qConfirmDelivery", exclusive: false, durable: true, autoDelete: false);

////Serialize the message
//var json = "Teste";
//var body = Encoding.UTF8.GetBytes(json);

////put the data on to the product queue
//channelA.BasicPublish(exchange: "", routingKey: "qConfirmDelivery", body: body);

////Here we create channel with session and model using
//var channelB = connection.CreateModel();

//////declare the queue after mentioning name and a few property related to that
////channel.QueueDeclare("qConfirmDelivery", exclusive: false);
//channelB.QueueDeclare("qFromRasa", exclusive: false, durable: true, autoDelete: false);

////Serialize the message
//json = "Teste";
//body = Encoding.UTF8.GetBytes(json);

////put the data on to the product queue
//channelB.BasicPublish(exchange: "", routingKey: "qConfirmDelivery", body: body);
