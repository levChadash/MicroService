using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;
namespace Ministry_of_Health.RabitMQ;
public class RabitMQProducer : IRabitMQProducer
{
    public void SendCitizens<T>(T message)
    {
        var factory = new ConnectionFactory
        {
            HostName = "localhost"
        };
        var connection = factory.CreateConnection();
        using
        var channel = connection.CreateModel();
        channel.QueueDeclare("MinistryOfInterior", exclusive: false);
        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);
        channel.BasicPublish(exchange: "", routingKey: "MinistryOfInterior", body: body);
    }
}
