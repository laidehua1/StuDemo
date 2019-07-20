namespace ThreadTest
{
    partial class ThreadTestMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Func = new System.Windows.Forms.Panel();
            this.button_AddThread = new System.Windows.Forms.Button();
            this.label_x1 = new System.Windows.Forms.Label();
            this.label_x0 = new System.Windows.Forms.Label();
            this.label_x2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Show = new System.Windows.Forms.Panel();
            this.button_Item = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Start = new System.Windows.Forms.Button();
            this.panel_Func.SuspendLayout();
            this.panel_Show.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Func
            // 
            this.panel_Func.Controls.Add(this.button_Start);
            this.panel_Func.Controls.Add(this.button_AddThread);
            this.panel_Func.Controls.Add(this.label_x1);
            this.panel_Func.Controls.Add(this.label_x0);
            this.panel_Func.Controls.Add(this.label_x2);
            this.panel_Func.Controls.Add(this.label4);
            this.panel_Func.Controls.Add(this.label3);
            this.panel_Func.Controls.Add(this.label2);
            this.panel_Func.Controls.Add(this.label1);
            this.panel_Func.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Func.Location = new System.Drawing.Point(0, 398);
            this.panel_Func.Name = "panel_Func";
            this.panel_Func.Size = new System.Drawing.Size(841, 164);
            this.panel_Func.TabIndex = 0;
            // 
            // button_AddThread
            // 
            this.button_AddThread.Location = new System.Drawing.Point(15, 104);
            this.button_AddThread.Name = "button_AddThread";
            this.button_AddThread.Size = new System.Drawing.Size(75, 23);
            this.button_AddThread.TabIndex = 7;
            this.button_AddThread.Text = "创建线程";
            this.button_AddThread.UseVisualStyleBackColor = true;
            this.button_AddThread.Click += new System.EventHandler(this.button_AddThread_Click);
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Location = new System.Drawing.Point(83, 67);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(11, 12);
            this.label_x1.TabIndex = 6;
            this.label_x1.Text = "0";
            // 
            // label_x0
            // 
            this.label_x0.AutoSize = true;
            this.label_x0.Location = new System.Drawing.Point(83, 46);
            this.label_x0.Name = "label_x0";
            this.label_x0.Size = new System.Drawing.Size(11, 12);
            this.label_x0.TabIndex = 5;
            this.label_x0.Text = "0";
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Location = new System.Drawing.Point(83, 28);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(11, 12);
            this.label_x2.TabIndex = 4;
            this.label_x2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "右:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "下:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "上:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X轴次数";
            // 
            // panel_Show
            // 
            this.panel_Show.Controls.Add(this.button_Item);
            this.panel_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Show.Location = new System.Drawing.Point(0, 0);
            this.panel_Show.Name = "panel_Show";
            this.panel_Show.Size = new System.Drawing.Size(841, 398);
            this.panel_Show.TabIndex = 1;
            // 
            // button_Item
            // 
            this.button_Item.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Item.Location = new System.Drawing.Point(76, 53);
            this.button_Item.Name = "button_Item";
            this.button_Item.Size = new System.Drawing.Size(33, 33);
            this.button_Item.TabIndex = 0;
            this.button_Item.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(14, 133);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 8;
            this.button_Start.Text = "开始";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // ThreadTestMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 562);
            this.Controls.Add(this.panel_Show);
            this.Controls.Add(this.panel_Func);
            this.Name = "ThreadTestMainForm";
            this.Text = "TreadTestMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThreadTestMainForm_FormClosed);
            this.panel_Func.ResumeLayout(false);
            this.panel_Func.PerformLayout();
            this.panel_Show.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Func;
        private System.Windows.Forms.Panel panel_Show;
        private System.Windows.Forms.Button button_Item;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_x1;
        private System.Windows.Forms.Label label_x0;
        private System.Windows.Forms.Label label_x2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddThread;
        private System.Windows.Forms.Button button_Start;
    }
}