using MetroFramework.Forms;
using Nmap.NET;
using Nmap.NET.Container;
using System;
using System.Linq;
using System.Threading;

namespace IPScanner
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            console.AppendText("test1");
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
            new Thread(() =>
            {
                if (ip != null)
                {
                    if (ports != null)
                    {
                        try
                        {
                            int _ports = int.Parse(ports);
                            var target = new Target(ip.Trim());
                            console.AppendText($"Initializing scan of {target}");
                            ScanResult result = new Scanner(target, System.Diagnostics.ProcessWindowStyle.Hidden).PortScan();
                            console.AppendText($"Detected {result.Total} host(s), {result.Up} up and {result.Down} down.");
                            foreach (Host i in result.Hosts)
                            {
                                console.AppendText($"Host: {i.Address}");
                                foreach (Port j in i.Ports)
                                {
                                    console.AppendText($"\tport {j.PortNumber}");
                                    if (!string.IsNullOrEmpty(j.Service.Name))
                                    {
                                        console.AppendText($" is running {j.Service.Name}");
                                    }

                                    if (j.Filtered)
                                    {
                                        console.AppendText($" is filtered");
                                    }

                                    console.AppendText($"");
                                }

                                if (i.OsMatches.Any())
                                {
                                    console.AppendText($"and is probably running {i.OsMatches.First().Name}");
                                }
                            }
                        }
                        catch (NotFiniteNumberException)
                        {

                        }
                    }
                }
            }).Start();
        }

        public void RunFullScan(string ip, string ports)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(fullScan.Checked)
            {
                RunFullScan(IPBox.Text, PortBox.Text);
            }
            else
            {
                RunPortScan(IPBox.Text, PortBox.Text);
            }
        }
    }
}
