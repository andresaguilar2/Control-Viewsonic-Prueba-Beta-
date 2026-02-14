using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ControlProyectorViewsonic2
{
    public partial class Form1 : Form
    {
        // ================== COMANDOS RS-232 ==================
        // OJO: estos comandos son de ejemplo para ViewSonic LS741HD.
        // Si en tu manual/protocolo RS-232 los bytes son otros,
        // solo reemplaza los arrays por los correctos.

        // Encender / Apagar
        private static readonly byte[] CMD_POWER_ON = { 0x06, 0x14, 0x00, 0x04, 0x00, 0x34, 0x11, 0x00, 0x00, 0x5D };
        private static readonly byte[] CMD_POWER_OFF = { 0x06, 0x14, 0x00, 0x04, 0x00, 0x34, 0x11, 0x01, 0x00, 0x5E };

        // Pantalla negra (Blank / AV Mute)
        private static readonly byte[] CMD_BLANK_ON = { 0x06, 0x14, 0x00, 0x04, 0x00, 0x34, 0x12, 0x09, 0x01, 0x68 };
        private static readonly byte[] CMD_BLANK_OFF = { 0x06, 0x14, 0x00, 0x04, 0x00, 0x34, 0x12, 0x09, 0x00, 0x67 };

        // Congelar / Descongelar
        private static readonly byte[] CMD_FREEZE_ON = { 0x06, 0x14, 0x00, 0x04, 0x00, 0x34, 0x13, 0x00, 0x01, 0x60 };
        private static readonly byte[] CMD_FREEZE_OFF = { 0x06, 0x14, 0x00, 0x04, 0x00, 0x34, 0x13, 0x00, 0x00, 0x5F };

        // Botón "Source" (cambiar entrada)
        private static readonly byte[] CMD_REMOTE_SOURCE = { 0x06, 0x14, 0x00, 0x04, 0x00, 0x34, 0x02, 0x04, 0x04, 0x56 };

        public Form1()
        {
            InitializeComponent();

            // Configuración del puerto serie
            serialPort1.BaudRate = 115200;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Handshake = Handshake.None;

            // CAMBIA ESTO al puerto real (por ejemplo "COM3", "COM4", etc.)
            serialPort1.PortName = "COM1";

            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        // Método genérico para enviar comandos
        private void SendCommand(byte[] command)
        {
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();

                serialPort1.Write(command, 0, command.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar comando: " + ex.Message,
                                "Error RS-232",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // ========= Eventos de botones =========

        private void btnEncender_Click(object sender, EventArgs e)
        {
            SendCommand(CMD_POWER_ON);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SendCommand(CMD_POWER_OFF);
        }

        private void btnPantallaNegraOn_Click(object sender, EventArgs e)
        {
            SendCommand(CMD_BLANK_ON);
        }

        private void btnPantallaNegraOff_Click(object sender, EventArgs e)
        {
            SendCommand(CMD_BLANK_OFF);
        }

        private void btnCongelar_Click(object sender, EventArgs e)
        {
            SendCommand(CMD_FREEZE_ON);
        }

        private void btnDescongelar_Click(object sender, EventArgs e)
        {
            SendCommand(CMD_FREEZE_OFF);
        }

        private void btnComputador_Click(object sender, EventArgs e)
        {
            // Actúa como el botón "Source" del control remoto
            SendCommand(CMD_REMOTE_SOURCE);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEncender_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUniversidad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
