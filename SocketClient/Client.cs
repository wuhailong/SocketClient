using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using ToolFunction;

namespace SocketClient
{
    public partial class Client : Form
    {
        string target = "";
        string users = "";
        string user = "";
        Socket cc = null;
        Thread clientThread = null;
        public Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        /// <summary>
        /// 向服务器发送消息
        /// </summary>
        /// <param name="p_strMessage"></param>
        public void SendMessage(string p_strMessage)
        {
            byte[] bs = Encoding.UTF8.GetBytes(p_strMessage);//把字符串编码为字节
            cc.Send(bs, bs.Length, 0); //发送信息
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                user = txt_name.Text;
                int port = int.Parse(txt_port.Text);
                string host = txt_ip.Text;
                //创建终结点EndPoint
                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);   //把ip和端口转化为IPEndPoint的实例
                //创建Socket并连接到服务器
                cc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);   //  创建Socket
                cc.Connect(ipe); //连接到服务器
                clientThread = new Thread(new ThreadStart(ReceiveData));
                clientThread.Start();
                //向服务器发送本机用户名，以便服务器注册客户端
                SendMessage("@" + txt_name.Text);
            }
            catch (ArgumentException ex)
            {
                CommonFunction.WriteLog(ex, ex.Message);
            }
            catch (SocketException exp)
            {
                CommonFunction.WriteLog(exp, exp.Message);
                if (10061 == exp.ErrorCode)
                {
                    rch_back.Text = "服务器未开启！";
                }
            }
        }

        /// <summary>
        /// 解析字符串，假如是发给自己的消息则格式化消息格式
        /// </summary>
        /// <param name="p_strMessage">消息字符串</param>
        /// <returns></returns>
        public void FiltMessage(string p_strMessage)
        {
            if (p_strMessage.Contains("@") && p_strMessage.Contains(":"))
            {
                string _strTemp = "";
                string[] u = p_strMessage.Split('@');
                string[] s = u[1].Split(':');
                string sender = u[0];
                string veceiver = s[0];
                string message = s[1];
                if (txt_name.Text == veceiver || "ALL" == veceiver)
                {
                    _strTemp = sender + ":" + message;
                    SetText(_strTemp);
                }
            }
        }

        public void Send()
        {
            if ("" == txt_target.Text)
            {
                MessageBox.Show("未选择对话人物");
                return;
            }
            //向服务器发送信息
            string sendStr = txt_name.Text + "@" + target + ":" + txt_message.Text;
            SendMessage(sendStr);
            rch_back.Text += "\n" + sendStr;
            txt_message.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Send();
        }

        public delegate void SetTextHandler(string text);
        private void SetText(string text)
        {
            if (rch_back.InvokeRequired == true)
            {
                SetTextHandler set = new SetTextHandler(SetText);//委托的方法参数应和SetText一致 
                rch_back.Invoke(set, new object[] { text }); //此方法第二参数用于传入方法,代替形参text 
            }
            else
            {
                rch_back.Text += "\n" + text;
            }
        }

        /// <summary>
        /// 刷新客户端列表
        /// </summary>
        public void RefreshClient(string mess)
        {
            if (mess.StartsWith("@"))
            {
                //MessageBox.Show(mess);
                DataTable _dtSocket = new DataTable();
                _dtSocket.Columns.Add("Client");
                mess = mess.Remove(0, 1);
                string[] userarray = mess.Split(';');
                foreach (string item in userarray)
                {
                    _dtSocket.Rows.Add(item);
                }
                SetDataSource(_dtSocket);
            }

        }

        public delegate void SetDataSourceHandler(DataTable p_dtSource);
        private void SetDataSource(DataTable p_dtSource)
        {
            if (dgv_client.InvokeRequired == true)
            {
                SetDataSourceHandler set = new SetDataSourceHandler(SetDataSource);//委托的方法参数应和SetText一致 
                dgv_client.Invoke(set, new object[] { p_dtSource }); //此方法第二参数用于传入方法,代替形参text 
            }
            else
            {
                dgv_client.DataSource = p_dtSource;
            }

        }


        public void ReceiveData()
        {
            try
            {
                while (true)
                {
                    //接受从服务器返回的信息
                    string recvStr = "";
                    byte[] recvBytes = new byte[1024];
                    int bytes;
                    bytes = cc.Receive(recvBytes, recvBytes.Length, 0);    //从服务器端接受返回信息
                    recvStr =  Encoding.UTF8.GetString(recvBytes, 0, bytes);
                    RefreshClient(recvStr);
                    FiltMessage(recvStr);
                }
            }
            catch (Exception exp)
            {
                CommonFunction.WriteLog(exp,exp.Message);
                if (cc != null)
                {
                    cc.Close();
                }
                if (clientThread != null)
                {
                    clientThread.Abort();
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SendMessage(">" + txt_name.Text);
                //cc.Disconnect(true);
                //cc.Shutdown(SocketShutdown.Both);
                //cc.Close();
            }
            catch (Exception exp)
            {
                CommonFunction.WriteLog(exp, exp.Message);
            }
        }

        private void dgv_friend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                target = dgv_client[e.ColumnIndex, e.RowIndex].Value.ToString();
                txt_target.Text = target;
            }
            catch (Exception exp)
            {
                CommonFunction.WriteLog(exp, exp.Message);
            }
           
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cc!=null)
            {
                cc.Close();
            }
            if (clientThread!=null)
            {
                clientThread.Abort();
            }
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 27)
            //{
            //    Send();
            //}
        }

        private void txt_message_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyChar == '\r')
            {
                Send();
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            ofd_file.ShowDialog();
            txt_filepath.Text = ofd_file.FileName;
            cc.SendFile(ofd_file.FileName);
        }
    }
}
