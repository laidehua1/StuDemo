﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NumberDeal
{
    public partial class TaskForm : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]

        private IntPtr hShell;
        private IntPtr hBar;
        private IntPtr hMin;

        private Rectangle rcShell;
        private Rectangle rcBar;
        private Rectangle rcMin;

        private int fixY = 0;

        public TaskForm()
        {
            InitializeComponent();
            showTask();
        }

        private void showTask()
        {
            hShell = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);
            GetWindowRect(hShell, ref rcShell);
            GetWindowRect(hBar, ref rcBar);
            GetWindowRect(hMin, ref rcMin);
            MoveWindow(hMin, 0, 0, rcBar.Width - this.Width, rcBar.Height, true);
            GetWindowRect(hMin, ref rcMin);
            SetParent(this.Handle, hBar);
            Rectangle ScreenArea = System.Windows.Forms.Screen.GetBounds(this);
            MoveWindow(this.Handle, rcBar.Width -this.Width - rcBar.X, 0, this.Width, this.Height, true);
            Rectangle rcFrom = new Rectangle();
            GetWindowRect(this.Handle, ref rcFrom);
        }


        private void TaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MoveWindow(hMin, 0, 0, rcMin.Right - rcMin.Left, rcMin.Bottom - rcMin.Top, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showTask();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}