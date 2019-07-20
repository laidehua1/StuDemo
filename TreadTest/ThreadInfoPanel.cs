using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TreadTest;

namespace ThreadTest
{
    public partial class ThreadInfoPanel : UserControl
    {
        public delegate void TreadDelegate(object i);
        public delegate void ButtonClick(object Sender, EventArgs e);
        public TreadDelegate mainThread;
        public ButtonClick Btn_ActClick;
        public ButtonClick Btn_PriorityClick;
        public ButtonClick Btn_JoinClick;
        public ButtonClick Refresh_Click;
        public GroupBox GroupBox
        {
            get
            {
                return this.groupBox;
            }
        }

        public string Msg
        {
            get
            {
                return this.textBox_msg.Text;
            }
            set
            {
                this.textBox_msg.Text = value;
            }
        }

        public direction DirTy;

        public ThreadInfoPanel()
        {
            InitializeComponent();
        }

        public void SetThreadInfo()
        {
            this.label_IsAlive.Text = Thread.CurrentThread.IsAlive.ToString();
            if (Thread.CurrentThread.IsAlive)
                this.label_Priority.Text = Thread.CurrentThread.Priority.ToString();
            else
                this.label_Priority.Text = string.Empty;
            this.label_ThreadState.Text = Thread.CurrentThread.ThreadState.ToString();
        }

        public void SetThreadInfo(Thread thread)
        {
            this.label_IsAlive.Text = thread.IsAlive.ToString();
            if (thread.IsAlive)
                this.label_Priority.Text = thread.Priority.ToString();
            else
                this.label_Priority.Text = string.Empty;
            this.label_ThreadState.Text = thread.ThreadState.ToString();
        }

        public int num = 0;
        public void ThreadFunc()
        {
            while (true)
            {
                if (mainThread != null)
                {
                    string Date = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
                    mainThread(Date);
                    //Msg = Date;
                    num++;
                }
                Thread.Sleep(CommAttribute.CommInterval);
                if (num > 10000)
                    break;
            }
        }

        private void Btn_Act_Click(object sender, EventArgs e)
        {

            if(Btn_ActClick != null)
            {
                Btn_ActClick(this, e);
            }
        }

        private void Btn_Priority_Click(object sender, EventArgs e)
        {
            if (Btn_PriorityClick != null)
            {
                Btn_PriorityClick(this, e);
            }
        }

        private void Btn_Join_Click(object sender, EventArgs e)
        {
            if (Btn_JoinClick != null)
            {
                Btn_JoinClick(this, e);
            }
        }

        private void pictureBox_Refresh_Click(object sender, EventArgs e)
        {
            if (Refresh_Click != null)
            {
                Refresh_Click(this, e);
            }
        }
    }

    public enum direction
    {
        down = 0,
        right = 1,
        up = 2,
        left = 3,
    }
}
