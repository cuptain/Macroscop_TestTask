using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace ServerMacroscop
{
    public partial class ServerForm : Form
    {

        private Regex rgxIP = new Regex(@"(\d{1,3}[\.]){3}\d{1,3}");
        private Regex rgxPort = new Regex(@"\d{1,5}");
        private Regex rgxN = new Regex(@"\b[1-9]{1}\d?\b");
        private TcpListener server;
        private TcpClient clientSocket;
        private bool working = false;
        public static Thread Work;
        public static int N;
        CancellationTokenSource cts;

        public ServerForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            tbLog.Text += "\nСервер запускается...";
            IPAddress ip = IPAddress.Parse(tbIP.Text);
            server = new TcpListener(ip, Convert.ToInt32(tbPort.Text));
            server.Start(Convert.ToInt32(tbN.Text));
            N = Convert.ToInt32(tbN.Text);
            working = true;
            tbLog.Text += "\nСервер запустился";
            btn_Switch();
            using (cts = new CancellationTokenSource())
                await Calculate(cts.Token);
        }

        Task Calculate(CancellationToken ct) //Task для вычисления
        {
            return Task.Run(() => ServerWorking(ct), ct);
        }

        private void ServerWorking(CancellationToken ct) //Зрительная память
        {
            int counter = 0;
            while (working)
            {
                try
                {
                    if (ct.IsCancellationRequested)
                        return;
                    counter += 1;
                    clientSocket = server.AcceptTcpClient();
                    tbLog.Invoke(new Action(() => tbLog.Text += "\nКлиент №:" + Convert.ToString(counter) + " подключился"));
                    handleClient client = new handleClient();
                    client.startClient(clientSocket);
                }
                catch (Exception)
                {
                    working = false;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            working = false;
            if (cts != null)
                cts.Cancel();
            //Thread.Sleep(2000);
            //Work.Abort();
            server.Stop();
            tbLog.Text += "\nСервер отключен";
            btn_Switch();
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

        private void tbN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbIP.Text == "")
                if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                    e.Handled = true;
                else
                if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                    e.Handled = true;
        }

        private void Button_Enable()
        {
            if (rgxIP.IsMatch(tbIP.Text) && rgxPort.IsMatch(tbPort.Text) && rgxN.IsMatch(tbN.Text))
                btnStart.Enabled = true;
            else
                btnStart.Enabled = false;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            Button_Enable();
        }

        private void btn_Switch()
        {
            if (btnStart.Enabled)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        #endregion

        public class handleClient
        {
            TcpClient clientSocket;
            public void startClient(TcpClient inClientSocket)
            {
                this.clientSocket = inClientSocket;
                Thread ctThread = new Thread(doWork);
                ctThread.Start();
            }
            public async void doWork()
            {
                int requestCount = 0;
                string dataFromClient = null;
                Byte[] sendBytes = null;
                string serverResponse = null;
                //string rCount = null;
                while (true)
                {
                    try
                    {
                        requestCount = requestCount + 1;
                        NetworkStream networkStream = clientSocket.GetStream();
                        if (networkStream == null)
                            break;
                        //if (requestCount >= N)
                        //{
                        //    serverResponse = "Запрос пока не может быть обработан, количество запросов превышено";
                        //    sendBytes = Encoding.UTF8.GetBytes(serverResponse);
                        //    networkStream.Write(sendBytes, 0, sendBytes.Length);
                        //    networkStream.Flush();
                        //    await Task.Delay(1000);
                        //    break;
                        //}
                        byte[] bytesFrom = new byte[(int)clientSocket.ReceiveBufferSize];
                        networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                        dataFromClient = Encoding.UTF8.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf('\0'));
                        //rCount = Convert.ToString(requestCount);
                        if (Palindrom(dataFromClient))
                            serverResponse = "Строка является палиндромом";
                        else
                            serverResponse = "Строка не является палиндромом";
                        sendBytes = Encoding.UTF8.GetBytes(serverResponse);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        networkStream.Flush();
                        await Task.Delay(2000);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("В работе сервера произошла ошибка: " + ex.Message, @"Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }

            private bool Palindrom(string input)
            {
                bool otvet = false;
                string symbols = "`~ !@\"#№$;%:^?&*()-–_=+{}[]\\|/<>,.«»";
                input = input.ToLower();
                foreach (char c in symbols)
                    input = input.Replace(c.ToString(), "");
                input = input.Replace("ё", "е");
                int i = 0, j = input.Length, kol = 0;
                while (i <= input.Length / 2)
                {
                    if (input[i] == input[j - 1])
                        kol++;
                    i++;
                    j--;
                    if (i == j)
                        break;
                }
                if (kol == (input.Length / 2 + input.Length % 2))
                    otvet = true;
                return otvet;
            }
        }
    }

}
