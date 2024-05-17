using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.SignalR.Client;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace chatapp
{
    public partial class Form1 : Form
    {
        HubConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new HubConnectionBuilder().WithUrl(new Uri("https://localhost:44307/chat")).WithAutomaticReconnect().Build();
            con.StartAsync();
            //con.On<messagedata>("newMessage", (mess) => listBox_messages.Items.Add(mess.name + ":" + mess.message));
            con.On<messagedata>("newMessage", (mess) => listBox_messages.Invoke(new Action(() => listBox_messages.Items.Add(mess.name + ":" + mess.message))));

            con.On<string, string>("newmember", (n, g) => listBox_messages.Invoke(new Action(() => listBox_messages.Items.Add(n + "Joined" + g))));

        }
        //string conid1 = con.ConnectionId;
        private void btn_send_Click(object sender, EventArgs e)
        {
            messagedata mes = new messagedata()
            {
                name = text_Name.Text,
                message = text_Message.Text,
            };
            con.InvokeAsync("sendmessage", mes);
        }


        private void btn_join_Click(object sender, EventArgs e)
        {
            //string groubname, name;

            // con.InvokeAsync("newmember",)
            string groupname = text_Group.Text;
            string name = text_Name.Text;
            con.InvokeAsync("joingroup", groupname, name);
            listBox_messages.Items.Add(name + " joined " + groupname);
        }

        private void btn_group_Click(object sender, EventArgs e)
        {
            string name = text_Name.Text;
            string message = text_Message.Text;
            string groub = text_Group.Text;

            con.InvokeAsync("sendToGroub", groub, name, message);
            listBox_messages.Items.Add(name + " Sent to "+groub);
        }
    }
}
