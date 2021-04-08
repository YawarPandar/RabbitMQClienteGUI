using System;
using System.Collections.Generic;
using System.Configuration;

namespace RabbitMQClienteGUI.RabbitMQ
{
    public static class MQConf {
        public static Dictionary<string, object> QueueDelayArgument() =>
            new Dictionary<string, object>() { { "x-delayed-type", "direct" } };

        public static Dictionary<string, object> QueueDelayHeader() =>
            new Dictionary<string, object>() {
                { "x-delay", Convert.ToInt32(ConfigurationManager.AppSettings["queueDelay"])
            } };
    }
}
