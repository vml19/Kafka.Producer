namespace Kafka.Producer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var producer = new Producer();
            producer.PublishMessage();
        }
    }
}