namespace Ministry_of_Health.RabitMQ
{
    public interface IRabitMQProducer
    {
        public void SendCitizens<T>(T message);

    }
}
