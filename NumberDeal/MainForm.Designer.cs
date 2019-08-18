namespace NumberDeal
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.label_DateTime = new System.Windows.Forms.Label();
            this.groupBox_ = new System.Windows.Forms.GroupBox();
            this.button_Fin = new System.Windows.Forms.Button();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Edit = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多线程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Table = new System.Windows.Forms.TabPage();
            this.tabPage_Chart = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.桌面任务栏窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_.SuspendLayout();
            this.panel_Edit.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_Table.SuspendLayout();
            this.tabPage_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DateTime
            // 
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Location = new System.Drawing.Point(726, 9);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(41, 12);
            this.label_DateTime.TabIndex = 0;
            this.label_DateTime.Text = "label1";
            // 
            // groupBox_
            // 
            this.groupBox_.Controls.Add(this.button_Fin);
            this.groupBox_.Controls.Add(this.textBox_num);
            this.groupBox_.Controls.Add(this.label1);
            this.groupBox_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_.Location = new System.Drawing.Point(0, 0);
            this.groupBox_.Name = "groupBox_";
            this.groupBox_.Size = new System.Drawing.Size(779, 215);
            this.groupBox_.TabIndex = 1;
            this.groupBox_.TabStop = false;
            this.groupBox_.Text = "groupBox1";
            // 
            // button_Fin
            // 
            this.button_Fin.Location = new System.Drawing.Point(48, 63);
            this.button_Fin.Name = "button_Fin";
            this.button_Fin.Size = new System.Drawing.Size(75, 23);
            this.button_Fin.TabIndex = 3;
            this.button_Fin.Text = "保存数据";
            this.button_Fin.UseVisualStyleBackColor = true;
            this.button_Fin.Click += new System.EventHandler(this.button_Fin_Click);
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(48, 17);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(178, 21);
            this.textBox_num.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数量";
            // 
            // panel_Edit
            // 
            this.panel_Edit.Controls.Add(this.groupBox_);
            this.panel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Edit.Location = new System.Drawing.Point(0, 31);
            this.panel_Edit.Name = "panel_Edit";
            this.panel_Edit.Size = new System.Drawing.Size(779, 215);
            this.panel_Edit.TabIndex = 2;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label_DateTime);
            this.panel_Top.Controls.Add(this.menuStrip1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(779, 31);
            this.panel_Top.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.多线程ToolStripMenuItem,
            this.桌面任务栏窗体ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 多线程ToolStripMenuItem
            // 
            this.多线程ToolStripMenuItem.Name = "多线程ToolStripMenuItem";
            this.多线程ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.多线程ToolStripMenuItem.Text = "多线程";
            this.多线程ToolStripMenuItem.Click += new System.EventHandler(this.多线程ToolStripMenuItem_Click);
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.AllowUserToAddRows = false;
            this.dataGridView_Data.AllowUserToOrderColumns = true;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Data.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.RowTemplate.Height = 23;
            this.dataGridView_Data.Size = new System.Drawing.Size(765, 234);
            this.dataGridView_Data.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Table);
            this.tabControl.Controls.Add(this.tabPage_Chart);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 246);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(779, 266);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage_Table
            // 
            this.tabPage_Table.Controls.Add(this.dataGridView_Data);
            this.tabPage_Table.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Table.Name = "tabPage_Table";
            this.tabPage_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Table.Size = new System.Drawing.Size(771, 240);
            this.tabPage_Table.TabIndex = 0;
            this.tabPage_Table.Text = "表格";
            this.tabPage_Table.UseVisualStyleBackColor = true;
            // 
            // tabPage_Chart
            // 
            this.tabPage_Chart.Controls.Add(this.chart1);
            this.tabPage_Chart.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Chart.Name = "tabPage_Chart";
            this.tabPage_Chart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Chart.Size = new System.Drawing.Size(771, 240);
            this.tabPage_Chart.TabIndex = 1;
            this.tabPage_Chart.Text = "图表";
            this.tabPage_Chart.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea_main";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea_main";
            series3.Legend = "Legend1";
            series3.Name = "Series_main";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(765, 234);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // 桌面任务栏窗体ToolStripMenuItem
            // 
            this.桌面任务栏窗体ToolStripMenuItem.Name = "桌面任务栏窗体ToolStripMenuItem";
            this.桌面任务栏窗体ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.桌面任务栏窗体ToolStripMenuItem.Text = "桌面任务栏窗体";
            this.桌面任务栏窗体ToolStripMenuItem.Click += new System.EventHandler(this.桌面任务栏窗体ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 512);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel_Edit);
            this.Controls.Add(this.panel_Top);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.主窗体关闭);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox_.ResumeLayout(false);
            this.groupBox_.PerformLayout();
            this.panel_Edit.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_Table.ResumeLayout(false);
            this.tabPage_Chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_Refresh;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.GroupBox groupBox_;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Edit;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.DataGridView dataGridView_Data;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Table;
        private System.Windows.Forms.TabPage tabPage_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_Fin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多线程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桌面任务栏窗体ToolStripMenuItem;
    }
}

