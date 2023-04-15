using MetroFramework.Forms;
using Newtonsoft.Json;
using Simple.DotNMap;
using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPScanner
{
    public partial class Form1 : MetroForm
    {
        public bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            console.AppendText($"Loaded!{Environment.NewLine}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/HEXPLOIT-UI/IPScanner");
        }

        public void RunPortScan(string ip, string ports)
        {
            new Thread(async () =>
            {
                if (ip != null)
                {
                    if (ports != null)
                    {
                        try
                        {
                            string[] _ports = ports.Trim().Split(',');
                            ProgressBar.Maximum = _ports.Length;
                            IPAddress ipAddress;
                            if (!IPAddress.TryParse(ip, out ipAddress))
                            {
                                console.AppendText($"Invalid IP address{Environment.NewLine}");
                                return;
                            }
                            console.AppendText($"Run target ports scan for: {ip}{Environment.NewLine}");
                            foreach (string s in _ports)
                            {
                                int port = int.Parse(s);
                                using (TcpClient scan = new TcpClient())
                                {
                                    Task<bool> t = Task.Run(() => scan.ConnectAsync(ipAddress, port).Wait(500));
                                    await t;
                                    if (!t.Result)
                                    {
                                        if (ShowClosedPorts.Checked)
                                        {
                                            console.AppendText($"Port {port} is closed{Environment.NewLine}");
                                        }
                                    } else
                                    {
                                        console.AppendText($"Port {port} is open{Environment.NewLine}");
                                    }
                                }
                                ProgressBar.Value++;
                            }
                            console.AppendText($"Scan end{Environment.NewLine}");
                        }
                        catch (NotFiniteNumberException)
                        {
                            console.AppendText($"ip address or port is wrong{Environment.NewLine}");
                            return;
                        }
                    } else
                    {
                        console.AppendText($"Enter ports{Environment.NewLine}");
                    }
                } else
                {
                    console.AppendText($"Enter ip address{Environment.NewLine}");
                }
            }).Start();
        }

        public void RunFullScan(string ip)
        {
            new Thread(() =>
            {
                StringBuilder sb = new StringBuilder();
                IPAddress ipAddress;
                if (!IPAddress.TryParse(ip, out ipAddress))
                {
                    console.AppendText($"Invalid ip address{Environment.NewLine}");
                    return;
                }
                string apiUrl = $"http://ip-api.com/json/{ipAddress}?lang=en";
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        string json = client.DownloadString(apiUrl);
                        dynamic data = JsonConvert.DeserializeObject(json);
                        if (data.status == "success")
                        {
                            sb.AppendLine("-------------");
                            sb.AppendLine($"Information about ip {ip}:");
                            sb.AppendLine($"Country: {data.country}");
                            sb.AppendLine($"City: {data.city}");
                            sb.AppendLine($"Zip code: {data.zip}");
                            sb.AppendLine($"ISP/Organization: {data.isp}");
                            sb.AppendLine("-------------");
                            console.AppendText(sb.ToString());
                        }
                        else
                        {
                            console.AppendText($"Error: {data.message}{Environment.NewLine}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error locating IP address: {0}", ex.Message);
                }
            }).Start();
        }

        public void RunPortRangeScan(string ip, string portRange)
        {
            new Thread(async () =>
            {
                if (ip != null)
                {
                    if (portRange != null)
                    {
                        if (TimeoutBox != null)
                        {
                            try
                            {
                                int startPort = int.Parse(portRange.Split('-')[0]);
                                int endPort = int.Parse(portRange.Split('-')[1]);
                                ProgressBar.Maximum = endPort;
                                int timeout = int.Parse(TimeoutBox.Text);
                                IPAddress ipAddress;
                                if (!IPAddress.TryParse(ip, out ipAddress))
                                {
                                    console.AppendText($"Invalid IP address{Environment.NewLine}");
                                    return;
                                }
                                console.AppendText($"Run Port Range scan for: {ip}{Environment.NewLine}");
                                for (int port = startPort; port <= endPort; port++)
                                {
                                    using (TcpClient scan = new TcpClient())
                                    {
                                        Task<bool> t = Task.Run(() => scan.ConnectAsync(ipAddress, port).Wait(timeout));
                                        await t;
                                        if (!t.Result)
                                        {
                                            if (ShowClosedPorts.Checked)
                                            {
                                                console.AppendText($"Port {port} is closed{Environment.NewLine}");
                                            }
                                        }
                                        else
                                        {
                                            console.AppendText($"Port {port} is open{Environment.NewLine}");
                                        }
                                    }
                                    ProgressBar.Value++;
                                }
                            }
                            catch (NotFiniteNumberException)
                            {
                                console.AppendText($"ip address or port is wrong{Environment.NewLine}");
                                return;
                            }
                        } 
                        else
                        {
                            console.AppendText($"Enter timeout value{Environment.NewLine}");
                        }
                    }
                    else
                    {
                        console.AppendText($"Enter port range{Environment.NewLine}");
                    }
                }
                else
                {
                    console.AppendText($"Enter ip address{Environment.NewLine}");
                }
            }).Start();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            if (GetFullInfo.Checked)
            {
                RunFullScan(IPBox.Text);
            }
            if (PortRangeScanCheck.Checked)
            {
                RunPortRangeScan(IPBox.Text, PortRangeBox.Text);
            } else
            {
                RunPortScan(IPBox.Text, TargetPortBox.Text);
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(!PortRangeScanCheck.Checked)
            {
                TimeoutBox.Visible = false;
                TimeoutLabel.Visible = false;
                PortRangeBox.Visible = false;
                PortRangeLabel.Visible = false;
            } else
            {
                TimeoutBox.Visible = true;
                TimeoutLabel.Visible =true;
                PortRangeBox.Visible = true;
                PortRangeLabel.Visible = true;
            }
        }
    }
}
