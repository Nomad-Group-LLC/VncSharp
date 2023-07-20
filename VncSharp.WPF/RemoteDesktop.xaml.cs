using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VncSharp.WPF
{
    /// <summary>
    /// Interaction logic for RemoteDesktop.xaml
    /// </summary>
    public partial class RemoteDesktop : UserControl
    {
        public RemoteDesktop()
        {
            InitializeComponent();
        }

        public void Connect(string host, int hostPort)
        {
            if (vnc.IsConnected) vnc.Disconnect();
            vnc.VncPort = hostPort;
            if (string.IsNullOrEmpty(host)) return;
            vnc.Connect(host, false, true);
        }

        public void Disconnect()
        {
            if (vnc.IsConnected) vnc.Disconnect();
        }

    }
}