using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreadTest;

namespace ThreadTest
{
    public partial class ThreadTestMainForm : Form
    {
        private int x0 = 0;
        private int x1 = 0;
        private int x2 = 0;
        private int x3 = 0;
        /// <summary>单位长度</summary>
        private int pairlength = 5;
        private bool Start = false;
        private int PairWidth = 100;
        private Dictionary<int, ThreadInfoPanel> TPDic = new Dictionary<int, ThreadInfoPanel>();
        private Dictionary<int, Thread> ThreadDic = new Dictionary<int, Thread>();

        public ThreadTestMainForm()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Interval = CommAttribute.CommInterval;
            x0 = x1 = x2 = x3 = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random rand = new Random();
            //int resY = rand.Next(0, 3);
            //int resX = rand.Next(0, 3);
            //if (resX == 2) resX = -1;
            //if (resY == 2) resY = -1;
            //Point Old = this.button_Item.Location;

            //int NewX = Old.X + resX * pairlength;
            //int NewY = Old.Y + resY * pairlength;

            //if (NewX < 0) resX = 1;
            //if (NewX + this.button_Item.Width > this.panel_Show.Width) resX = -1;

            //if (NewY < 0) NewY = 1;
            //if (NewY + this.button_Item.Height > this.panel_Show.Height) NewY = -1;

            //this.button_Item.Location = new Point(Old.X + resX * pairlength, Old.Y + resY * pairlength);

            //switch (resX)
            //{
            //    case 0:
            //        x0++;
            //        this.label_x0.Text = x0.ToString();
            //        break;
            //    case 1:
            //        x1++;
            //        this.label_x1.Text = x1.ToString();
            //        break;
            //    case -1:
            //        x2++;
            //        this.label_x2.Text = x2.ToString();
            //        break;
            //}
            //moveDown();
        }

        public void moveDown()
        {
            if (!Start)
                return;
            Point Old = this.button_Item.Location;
            int resY = 1;
            int resX = 0;
            int NewX = Old.X + resX * pairlength;
            int NewY = Old.Y + resY * pairlength;
            if (NewY > this.panel_Show.Height - this.button_Item.Height)
            {
                NewY = 0;
            }
            this.button_Item.Location = new Point(NewX, NewY);
            x0++;
            this.label_x0.Text = x0.ToString();
        }

        public void moveRight()
        {
            if (!Start)
                return;
            Point Old = this.button_Item.Location;
            int resY = 0;
            int resX = 1;
            int NewX = Old.X + resX * pairlength;
            int NewY = Old.Y + resY * pairlength;
            if (NewX > this.panel_Show.Width - this.button_Item.Width)
            {
                NewX = 0;
            }
            this.button_Item.Location = new Point(NewX, NewY);
            x1++;
            this.label_x1.Text = x1.ToString();
        }

        public void moveUp()
        {
            if (!Start)
                return;
            Point Old = this.button_Item.Location;
            int resY = -1;
            int resX = 0;
            int NewX = Old.X + resX * pairlength;
            int NewY = Old.Y + resY * pairlength;
            if (NewY < 0)
            {
                NewY = this.panel_Show.Height - this.button_Item.Height;
            }
            this.button_Item.Location = new Point(NewX, NewY);
            x2++;
            this.label_x2.Text = x2.ToString();
        }

        private void button_AddThread_Click(object sender, EventArgs e)
        {
            direction Dir = direction.down;
            if (x0 == 0)
            {
            }
            else if (x1 == 0)
            {
                Dir = direction.right;
                x1++;
            }
            else if (x2 == 0)
            {
                Dir = direction.up;
                x2++;
            }
            else if (x3 == 0)
            {
                Dir = direction.left;
                x3++;
            }
            if (Dir == direction.down && x0 > 0)
                return;
            else
                x0++;
            ThreadInfoPanel TPanel = new ThreadInfoPanel();
            TPanel.mainThread = ShowMsg;
            TPanel.Btn_ActClick = Btn_ActClick;
            TPanel.Btn_PriorityClick = Btn_PriorityClick;
            TPanel.Btn_JoinClick = Btn_JoinClick;
            TPanel.Refresh_Click = Refresh_Click;
            Thread thread = new Thread(TPanel.ThreadFunc);
            thread.Name = Dir.ToString();//DateTime.Now.ToLongTimeString();
            TPanel.DirTy = Dir;
            TPanel.Location = new Point(PairWidth, 0);
            PairWidth += TPanel.Width;
            TPanel.GroupBox.Text = thread.Name;
            TPanel.Tag = thread.ManagedThreadId;
            this.panel_Func.Controls.Add(TPanel);
            this.panel_Func.Height = TPanel.Height;
            thread.Start();
            if (!TPDic.ContainsKey(thread.ManagedThreadId))
                TPDic.Add(thread.ManagedThreadId, TPanel);
            if (!ThreadDic.ContainsKey(thread.ManagedThreadId))
                ThreadDic.Add(thread.ManagedThreadId, thread);
        }

        private void Refresh_Click(object Sender, EventArgs e)
        {
            ThreadInfoPanel TPanel = Sender as ThreadInfoPanel;
            int Id = Convert.ToInt32(TPanel.Tag);
            if (ThreadDic.ContainsKey(Id))
            {
                Thread CurThread = ThreadDic[Id];
                TPanel.SetThreadInfo(CurThread);
            }
        }

        private void Btn_JoinClick(object Sender, EventArgs e)
        {
            ThreadInfoPanel TPanel = Sender as ThreadInfoPanel;
            int Id = Convert.ToInt32(TPanel.Tag);
            if (ThreadDic.ContainsKey(Id))
            {
                Thread CurThread = ThreadDic[Id];
                CurThread.Join(3000);
                TPanel.SetThreadInfo(CurThread);
            }
        }

        private void Btn_PriorityClick(object Sender, EventArgs e)
        {
            ThreadInfoPanel TPanel = Sender as ThreadInfoPanel;
            int Id = Convert.ToInt32(TPanel.Tag);
            if (ThreadDic.ContainsKey(Id))
            {
                Thread CurThread = ThreadDic[Id];
                if (CurThread.IsAlive)
                {
                    int CurPriority = (int)CurThread.Priority;
                    if (CurPriority >= 4)
                        CurPriority = 0;
                    else
                        CurPriority++;
                    CurThread.Priority = (ThreadPriority)CurPriority;
                }
                TPanel.SetThreadInfo(CurThread);
            }
        }

        private void Btn_ActClick(object Sender, EventArgs e)
        {
            ThreadInfoPanel TPanel = Sender as ThreadInfoPanel;
            int Id = Convert.ToInt32(TPanel.Tag);
            if (ThreadDic.ContainsKey(Id))
            {
                if (ThreadDic[Id].IsAlive)
                {
                    ThreadDic[Id].Abort();
                    if (TPDic.ContainsKey(ThreadDic[Id].ManagedThreadId))
                        TPDic.Remove(ThreadDic[Id].ManagedThreadId);
                    TPanel.SetThreadInfo(ThreadDic[Id]);
                }
                else
                {
                    Thread thread = new Thread(TPanel.ThreadFunc);
                    thread.Name = DateTime.Now.ToLongTimeString();
                    TPanel.Tag = thread.ManagedThreadId;
                    TPanel.num = 0;
                    TPanel.GroupBox.Text = thread.Name;
                    if (!TPDic.ContainsKey(thread.ManagedThreadId))
                        TPDic.Add(thread.ManagedThreadId, TPanel);
                    else
                        TPDic[thread.ManagedThreadId] = TPanel;
                    if (!ThreadDic.ContainsKey(thread.ManagedThreadId))
                        ThreadDic.Add(thread.ManagedThreadId, thread);
                    else
                        ThreadDic[Id] = thread;
                    thread.Start();
                    TPanel.SetThreadInfo(thread);
                }
            }
            //if(Sender is ThreadInfoPanel)
            //{
            //    ThreadInfoPanel TPanel = Sender as ThreadInfoPanel;
            //    int ManagedThreadId = -1;
            //    foreach (KeyValuePair<int, ThreadInfoPanel> pair in TPDic)
            //    {
            //        if(TPanel == pair.Value)
            //        {
            //            ManagedThreadId = pair.Key;
            //        }
            //    }
            //    foreach(ProcessThread Thread in Process.GetCurrentProcess().Threads)
            //    {
            //        if(Thread.Id== ManagedThreadId)
            //        {
            //            Thread.ThreadState
            //        }
            //    }
            //}
        }

        private void ShowMsg(object msg)
        {
            lock (this)
            {
                if (TPDic.ContainsKey(Thread.CurrentThread.ManagedThreadId))
                {
                    ThreadInfoPanel TPanel = TPDic[Thread.CurrentThread.ManagedThreadId];
                    if (TPanel.InvokeRequired)
                    {
                        //TPanel.SetThreadInfo(Thread.CurrentThread);
                        this.ShowMagFunc = ShowPanelMsg;
                        this.Invoke(this.ShowMagFunc, TPanel, msg);
                        switch (TPanel.DirTy)
                        {
                            case direction.down:
                                {
                                    this.ButtonMove = moveDown;
                                }
                                break;
                            case direction.right:
                                {
                                    this.ButtonMove = moveRight;
                                }
                                break;
                            case direction.up:
                                {
                                    this.ButtonMove = moveUp;
                                }
                                break;
                        }
                        this.Invoke(this.ButtonMove);
                    }
                }
            }
        }

        public delegate void FuncWhithoutParam();
        public delegate void ShowPanelMsgEvent(ThreadInfoPanel sender, object msg);
        public ShowPanelMsgEvent ShowMagFunc;
        public FuncWhithoutParam ButtonMove;
        public void ShowPanelMsg(ThreadInfoPanel sender, object msg)
        {
            sender.Msg = msg.ToString();
            int Id = Convert.ToInt32(sender.Tag);
            if (ThreadDic.ContainsKey(Id))
            {
                sender.SetThreadInfo(ThreadDic[Id]);
            }
            //if (sender.InvokeRequired)
            //    sender.SetThreadInfo();
        }

        private void ThreadTestMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (KeyValuePair<int, Thread> pair in ThreadDic)
            {
                if (pair.Value.IsAlive)
                {
                    pair.Value.Abort();
                    int i = 0;
                    while (pair.Value.ThreadState != System.Threading.ThreadState.Aborted)
                    {
                        Thread.Sleep(100);
                        i++;
                        if (i == 10)
                            break;
                    }
                }
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (Start)
            {
                Start = false;
                x0 = x1 = x2 = x3 = 0;
                (sender as Button).Text = "开始";
            }
            else
            {
                Start = true;
                (sender as Button).Text = "停止";
            }
        }
    }
}
