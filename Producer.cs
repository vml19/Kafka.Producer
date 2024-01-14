using Confluent.Kafka;

namespace Kafka.Producer
{
    internal class Producer
    {
        public void PublishMessage()
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };
            using var producer = new ProducerBuilder<Null, string>(config).Build();

            var topic = "test-topic";
            var message = new Message<Null, string> { Value = "Hello, Kafka!" };

            producer.Produce(topic, message, deliveryReport =>
            {
                Console.WriteLine(deliveryReport.Message.Value);
            });
        }
    }
}