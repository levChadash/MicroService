using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Ministry_of_Health
{
    public  class RabbitMQClass
    {

        public  List<string> Messages { get; set; } = new List<string>();
        public RabbitMQClass()
        {

        }
        
        public  void initilize()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost"
            };
            //Create the RabbitMQ connection using connection factory details as i mentioned above
            var connection = factory.CreateConnection();
            //Here we create channel with session and model
            using
            var channel = connection.CreateModel();
            //declare the queue after mentioning name and a few property related to that
            channel.QueueDeclare("MinistryOfInterior", exclusive: false);
            //Set Event object which listen message from chanel which is sent by producer
            var consumer = new EventingBasicConsumer(channel);
            //List<string> message = new List<string>();
            consumer.Received += (model, eventArgs) =>
            {
                var body = eventArgs.Body.ToArray();
               var message=(Encoding.UTF8.GetString(body));
                //setMesseges(message);


                Console.WriteLine($"Product message received: {message}");

            };
            //read the message
            channel.BasicConsume(queue: "MinistryOfInterior", autoAck: true, consumer: consumer);
            Console.ReadKey();
            // return message;
        }
        public void setMesseges(string m)
        {
            this.Messages.Add(m);
        } 

    }
}
