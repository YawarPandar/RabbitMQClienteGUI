using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace RabbitMQClienteGUI.RabbitMQ
{
    public partial class ServicioCliente : Form
    {
        public ServicioCliente() {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            ClienteRabbitMQ clienteRabbitMQ = new ClienteRabbitMQ();

            string response = JsonConvert.SerializeObject(
                clienteRabbitMQ.Call(txtSolicitudJSON.Text), Formatting.Indented);

            stopWatch.Stop();

            TimeSpan timeSpan = stopWatch.Elapsed;
            
            string elapsedTime = string.Format(
                "Tiempo transcurrido: {0:00}:{1:00}:{2:00}.{3:000}",
                    timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

            txtRespuestaJSON.Text =
                new StringBuilder(response)
                    .Append(Environment.NewLine)
                    .Append(Environment.NewLine)
                    .Append(elapsedTime).ToString();

            clienteRabbitMQ.Close();
        }
    }
}
