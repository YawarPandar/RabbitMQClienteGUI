namespace RabbitMQClienteGUI.RabbitMQ
{
    partial class ServicioCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSolicitudJSON = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtRespuestaJSON = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtSolicitudJSON
            // 
            this.txtSolicitudJSON.Location = new System.Drawing.Point(12, 50);
            this.txtSolicitudJSON.Multiline = true;
            this.txtSolicitudJSON.Name = "txtSolicitudJSON";
            this.txtSolicitudJSON.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSolicitudJSON.Size = new System.Drawing.Size(478, 157);
            this.txtSolicitudJSON.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitud JSON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Respuesta JSON";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(218, 435);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtRespuestaJSON
            // 
            this.txtRespuestaJSON.Location = new System.Drawing.Point(12, 258);
            this.txtRespuestaJSON.Name = "txtRespuestaJSON";
            this.txtRespuestaJSON.Size = new System.Drawing.Size(478, 161);
            this.txtRespuestaJSON.TabIndex = 5;
            this.txtRespuestaJSON.Text = "";
            // 
            // ServicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 470);
            this.Controls.Add(this.txtRespuestaJSON);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSolicitudJSON);
            this.MaximizeBox = false;
            this.Name = "ServicioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServicioCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSolicitudJSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.RichTextBox txtRespuestaJSON;
    }
}