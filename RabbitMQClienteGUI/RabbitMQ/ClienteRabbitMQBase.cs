using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.Text;

namespace RabbitMQClienteGUI.RabbitMQ
{
    public class ClienteRabbitMQBase {
        protected readonly IModel channelModel;
        protected readonly string replyQueueName = "ColaDesembolsoBIM";
        protected readonly IConnection connection;
        protected readonly EventingBasicConsumer consumer;
        protected readonly IBasicProperties basicPropierties;
        protected readonly BlockingCollection<string> respQueue = new BlockingCollection<string>();

        public ClienteRabbitMQBase() {
            string correlationId =
                Guid.NewGuid().ToString();

            connection =
                new ConnectionFactory() {
                    UserName = ConfigurationManager.AppSettings["rabbitMQUser"],
                    Password = ConfigurationManager.AppSettings["rabbitMQPass"],
                    HostName = ConfigurationManager.AppSettings["rabbitMQHost"]
                }.CreateConnection();

            channelModel = connection.CreateModel();
            consumer = new EventingBasicConsumer(channelModel);
            //replyQueueName = channelModel.QueueDeclare().QueueName;
            channelModel.QueueDeclare(queue: replyQueueName,
                                    durable: true,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);
            //channelModel.ExchangeDeclare(
            //    ConfigurationManager.AppSettings["queueDelayName"],
            //        "x-delayed-message", true, false, MQConf.QueueDelayArgument());

            basicPropierties = channelModel.CreateBasicProperties();
            basicPropierties.Headers = MQConf.QueueDelayHeader();
            basicPropierties.CorrelationId = correlationId;
            //basicPropierties.ReplyTo = replyQueueName;
            basicPropierties.DeliveryMode = 2;

            //channelModel.QueueBind(queue: "ColaDesembolsoBIM",
                //exchange: "queue.delay", routingKey: "ColaDesembolsoBIM");

            //consumer.Received +=
            //    (model, eventArguments) => {
            //        var response =
            //            Encoding.UTF8.GetString(
            //                eventArguments.Body.ToArray());

            //        if (eventArguments.BasicProperties.CorrelationId.Equals(correlationId))
            //            respQueue.Add(response);
            //    };
        }
    }
}
