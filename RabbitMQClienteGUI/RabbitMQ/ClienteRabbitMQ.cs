using RabbitMQ.Client;
using System.Text;

namespace RabbitMQClienteGUI.RabbitMQ
{
    public class ClienteRabbitMQ : ClienteRabbitMQBase {

        public ClienteRabbitMQ() : base() {}

        public string Call(string mensaje) {
            byte[] messageBytes = 
                Encoding.UTF8.GetBytes(mensaje);

            channelModel.BasicPublish(
                body: messageBytes,
                exchange: "",
                routingKey: "ColaDesembolsoBIM",
                basicProperties: null /*basicPropierties*/);

            channelModel.BasicConsume(
                autoAck: false,
                consumer: consumer,
                queue: replyQueueName);

            return respQueue.Take();
        }

        public void Close() {
            connection.Close();
        }
    }
}
