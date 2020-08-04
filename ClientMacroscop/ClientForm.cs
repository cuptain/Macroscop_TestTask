using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Sockets;

namespace ClientMacroscop
{
    public partial class ClientForm : Form
    {
        private Regex rgxIP = new Regex(@"([0-9]{1,3}[\.]){3}[0-9]{1,3}");
        private Regex rgxPort = new Regex(@"[0-9]{1,5}");
        TcpClient client = new TcpClient();
        NetworkStream serverStream;
        private string path;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                btnConnect.Enabled = false;
                client.Connect(tbIP.Text, Convert.ToInt32(tbPort.Text));
                tbLog.Text += "\nКлиент подлкючился к " + tbIP.Text + " с портом " + tbPort.Text;
                Send_Enable();
            }
            catch (Exception ex)
            {
                tbLog.Text += "\nПри подключении к севрверу проищошла следующая ошибка: " + ex.Message;
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                serverStream = client.GetStream();
                string query = File.ReadAllText(file);
                byte[] outStream = Encoding.UTF8.GetBytes(query);
                tbLog.Text += "\nЗапрос на сервер: " + query;
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[1000000];
                serverStream.Read(inStream, 0, (int)client.ReceiveBufferSize);
                string returndata = Encoding.UTF8.GetString(inStream);
                tbLog.Text += "\nОтвет с сервера: " + returndata;
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                path = FBD.SelectedPath;
                tbDirectory.Text = path;
            }
        }

        #region Form design

        private void tbIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbIP.Text == "")
                if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                    e.Handled = true;
                else
                if ((e.KeyChar <= 46 || e.KeyChar >= 59) && e.KeyChar != 8)
                    e.Handled = true;
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbIP.Text == "")
                if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                    e.Handled = true;
                else
                if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                    e.Handled = true;
        }

        private void Connect_Enable()
        {
            if (rgxIP.IsMatch(tbIP.Text) && rgxPort.IsMatch(tbPort.Text))
                btnConnect.Enabled = true;
            else
                btnConnect.Enabled = false;
        }

        private void Send_Enable()
        {
            if (client.Connected)
                btnSend.Enabled = true;
            else
                btnSend.Enabled = false;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            Connect_Enable();
        }

        #endregion
    }
}
