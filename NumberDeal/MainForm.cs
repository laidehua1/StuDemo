using NumberDeal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ThreadTest;

namespace NumberDeal
{
    public partial class MainForm : Form
    {
        #region 属性
        private int _Count = -1;
        private int Count
        {
            get
            {
                if (_Count == -1)
                {
                    DateTime curtime = DateTime.Now;
                    string Date = curtime.ToShortDateString();
                    string sql = string.Format("select Max(count) from tblNum where Date = '{0}'", Date);
                    object obj = DbHelper.ExcuteScalarSQLObj(sql, null);
                    bool Res = false;
                    if (obj != null)
                        Res = int.TryParse(obj.ToString(), out _Count);
                    if (!Res)
                        _Count = 1;
                    else
                        _Count++;
                }
                return _Count;
            }
        }

        private DataTable _table;
        private DataTable table
        {
            get
            {
                if (_table == null)
                {
                    string SelSql = string.Format("Select * from tblNum Where 1=0");
                    _table = DbHelper.GetTable(SelSql);
                    if (_table.Columns.Count < 5)
                    {
                        _table = new DataTable();
                        DataColumn Col = new DataColumn("RowNo", typeof(int));
                        _table.Columns.Add(Col);
                        _table.PrimaryKey = new DataColumn[] { Col };
                        Col = new DataColumn("Num", typeof(int));
                        _table.Columns.Add(Col);
                        Col = new DataColumn("DateTime", typeof(DateTime));
                        _table.Columns.Add(Col);
                        Col = new DataColumn("Date", typeof(string));
                        _table.Columns.Add(Col);
                        Col = new DataColumn("Time", typeof(string));
                        _table.Columns.Add(Col);
                    }

                }
                return _table;
            }
        }
        private int _CurRowNo = 1;
        private int 序号自增
        {
            get
            {
                return _CurRowNo++;
            }
        }

        private TaskForm _TaskForm;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Tick += Timer_Refresh_Tick;

            this.textBox_num.KeyPress += TextBox_num_KeyPress;

            this.dataGridView_Data.DataSource = table;
            this.textBox_num.Focus();

            this.tabControl.SelectedTab = this.tabPage_Chart;

            //this.chart1.Series.Add("series2");
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            //this.chart1.Series[0].Points.DataBind(_table.AsEnumerable(), "Time", "Num", string.Empty);
        }

        private void TextBox_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)//回车键
            {
                DataRow newRow = table.NewRow();
                int RowCd = 序号自增;
                newRow["RowNo"] = RowCd;
                int num;
                bool res = int.TryParse(this.textBox_num.Text, out num);
                if (!res)
                    return;
                newRow["Num"] = num;
                newRow["Count"] = Count;
                DateTime curtime = DateTime.Now;
                newRow["DateTime"] = curtime;
                newRow["Date"] = curtime.ToShortDateString();
                newRow["Time"] = curtime.ToLongTimeString();
                table.Rows.Add(newRow);

                this.textBox_num.Text = string.Empty;
                this.textBox_num.Focus();

                this.chart1.Series[0].Points.AddXY(RowCd, num);
            }
        }

        private void Timer_Refresh_Tick(object sender, EventArgs e)
        {
            this.label_DateTime.Text = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            this.label_DateTime.Location = new Point(this.panel_Top.Width - this.label_DateTime.Width - 2, this.label_DateTime.Location.Y);

            //string SelSql = string.Format("Select * from tblNum where Date = '2019/4/10 '");
            //DataTable res = DbHelper.GetTable(SelSql);
            //SelSql = string.Format("Select * from tblNum where Date = '2019/4/11 '");
            //DataTable res2 = DbHelper.GetTable(SelSql);
            //this.chart1.Series[0].ChartType = SeriesChartType.Line;
            //this.chart1.Series[1].ChartType = SeriesChartType.Line;
            //this.chart1.Series[0].Points.Clear();
            //this.chart1.Series[1].Points.Clear();
            //int n = 1;
            //foreach (DataRow row in res.Rows)
            //{
            //    int Num = (int)row["Num"];
            //    DateTime date = (DateTime)row["DateTime"];
            //    string d = date.ToString("MM-dd hh:mm:ss");
            //    this.chart1.Series[0].Points.AddXY(n, Num);
            //    n++;
            //}
            //n = 1;
            //foreach (DataRow row in res2.Rows)
            //{
            //    int Num = (int)row["Num"];
            //    DateTime date = (DateTime)row["DateTime"];
            //    string d = date.ToString("MM-dd hh:mm:ss");
            //    this.chart1.Series[1].Points.AddXY(n, Num);
            //    n++;
            //}
        }

        private void 主窗体关闭(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button_Fin_Click(object sender, EventArgs e)
        {
            DbHelper.BulkToDB(_table, "tblNum");
            _table.Clear();
            this.chart1.Series[0].Points.Clear();
            _Count = -1;
        }

        private void 多线程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadTestMainForm Form = new ThreadTestMainForm();
            Form.FormClosed += Form_FormClosed;
            this.Hide();
            Form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            if (_TaskForm != null)
                _TaskForm.Close();
            //this.TopMost = true;
        }

        private void 桌面任务栏窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_TaskForm != null) { _TaskForm.Show(); }
            else
            {
                _TaskForm = new TaskForm();
                _TaskForm.FormClosed += Form_FormClosed;
                _TaskForm.Show();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (_TaskForm == null)
            {
                _TaskForm = new TaskForm();
                _TaskForm.FormClosed += Form_FormClosed;
                _TaskForm.Show();
            }
        }
    }
}
