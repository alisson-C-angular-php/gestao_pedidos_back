using Azure.Messaging.ServiceBus;

namespace gestaopedidos.Service
{
    public class AzureServiceBusSender
    {
        private readonly string _connectionString;
        private readonly string _queueName;

        public AzureServiceBusSender(IConfiguration configuration)
        {
            _connectionString = configuration["AzureServiceBus:ConnectionString"];
            _queueName = configuration["AzureServiceBus:QueueName"];
        }

        public async Task SendMessageAsync(string messageBody)
        {
            await using var client = new ServiceBusClient(_connectionString);
            ServiceBusSender sender = client.CreateSender(_queueName);

            ServiceBusMessage message = new ServiceBusMessage(messageBody);
            await sender.SendMessageAsync(message);
        }
    }

}
