namespace ThreadTest
{
    partial class ThreadInfoPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox_Refresh = new System.Windows.Forms.PictureBox();
            this.Btn_Join = new System.Windows.Forms.Button();
            this.Btn_Priority = new System.Windows.Forms.Button();
            this.Btn_Act = new System.Windows.Forms.Button();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.label_Priority = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ThreadState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_IsAlive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBox_Refresh);
            this.groupBox.Controls.Add(this.Btn_Join);
            this.groupBox.Controls.Add(this.Btn_Priority);
            this.groupBox.Controls.Add(this.Btn_Act);
            this.groupBox.Controls.Add(this.textBox_msg);
            this.groupBox.Controls.Add(this.label_Priority);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label_ThreadState);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label_IsAlive);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(248, 167);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // pictureBox_Refresh
            // 
            this.pictureBox_Refresh.BackgroundImage = global::TreadTest.Properties.Resources.Refresh;
            this.pictureBox_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Refresh.Location = new System.Drawing.Point(200, 97);
            this.pictureBox_Refresh.Name = "pictureBox_Refresh";
            this.pictureBox_Refresh.Size = new System.Drawing.Size(33, 31);
            this.pictureBox_Refresh.TabIndex = 10;
            this.pictureBox_Refresh.TabStop = false;
            this.pictureBox_Refresh.Click += new System.EventHandler(this.pictureBox_Refresh_Click);
            // 
            // Btn_Join
            // 
            this.Btn_Join.Location = new System.Drawing.Point(160, 68);
            this.Btn_Join.Name = "Btn_Join";
            this.Btn_Join.Size = new System.Drawing.Size(82, 23);
            this.Btn_Join.TabIndex = 9;
            this.Btn_Join.Text = "Join";
            this.Btn_Join.UseVisualStyleBackColor = true;
            this.Btn_Join.Click += new System.EventHandler(this.Btn_Join_Click);
            // 
            // Btn_Priority
            // 
            this.Btn_Priority.Location = new System.Drawing.Point(160, 39);
            this.Btn_Priority.Name = "Btn_Priority";
            this.Btn_Priority.Size = new System.Drawing.Size(82, 23);
            this.Btn_Priority.TabIndex = 8;
            this.Btn_Priority.Text = "切换优先级";
            this.Btn_Priority.UseVisualStyleBackColor = true;
            this.Btn_Priority.Click += new System.EventHandler(this.Btn_Priority_Click);
            // 
            // Btn_Act
            // 
            this.Btn_Act.Location = new System.Drawing.Point(160, 9);
            this.Btn_Act.Name = "Btn_Act";
            this.Btn_Act.Size = new System.Drawing.Size(82, 23);
            this.Btn_Act.TabIndex = 7;
            this.Btn_Act.Text = "切换状态";
            this.Btn_Act.UseVisualStyleBackColor = true;
            this.Btn_Act.Click += new System.EventHandler(this.Btn_Act_Click);
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(9, 95);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(160, 59);
            this.textBox_msg.TabIndex = 6;
            // 
            // label_Priority
            // 
            this.label_Priority.AutoSize = true;
            this.label_Priority.Location = new System.Drawing.Point(66, 44);
            this.label_Priority.Name = "label_Priority";
            this.label_Priority.Size = new System.Drawing.Size(41, 12);
            this.label_Priority.TabIndex = 5;
            this.label_Priority.Text = "优先级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "优先级";
            // 
            // label_ThreadState
            // 
            this.label_ThreadState.AutoSize = true;
            this.label_ThreadState.Location = new System.Drawing.Point(66, 69);
            this.label_ThreadState.Name = "label_ThreadState";
            this.label_ThreadState.Size = new System.Drawing.Size(53, 12);
            this.label_ThreadState.TabIndex = 3;
            this.label_ThreadState.Text = "线程状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "线程状态";
            // 
            // label_IsAlive
            // 
            this.label_IsAlive.AutoSize = true;
            this.label_IsAlive.Location = new System.Drawing.Point(66, 21);
            this.label_IsAlive.Name = "label_IsAlive";
            this.label_IsAlive.Size = new System.Drawing.Size(53, 12);
            this.label_IsAlive.TabIndex = 1;
            this.label_IsAlive.Text = "执行状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "执行状态";
            // 
            // ThreadInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "ThreadInfoPanel";
            this.Size = new System.Drawing.Size(248, 167);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Label label_Priority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ThreadState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_IsAlive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Priority;
        private System.Windows.Forms.Button Btn_Act;
        private System.Windows.Forms.Button Btn_Join;
        private System.Windows.Forms.PictureBox pictureBox_Refresh;
    }
}
