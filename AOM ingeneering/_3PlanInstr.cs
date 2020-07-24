using AOM_ingeneering.movedbDataSetTableAdapters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOM_ingeneering
{
    public partial class _3PlanInstr : Form
    {
       public static int update = 0;
        int sakl = 0;
        public _3PlanInstr()
        {
            InitializeComponent();
        }

        private void _3PlanInstr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.инструктаж". При необходимости она может быть перемещена или удалена.
            this.инструктажTableAdapter.Fill(this.movedbDataSet.инструктаж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.мероприятие". При необходимости она может быть перемещена или удалена.
            this.планинструктажейTableAdapter.Fill(this.movedbDataSet.планинструктажей);

        }

        private void нормативныеДокументыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            this.планинструктажейTableAdapter.Fill(this.movedbDataSet.планинструктажей);
            new PlanInstrCRUD(планинструктажейTableAdapter, планинструктажейBindingSource, movedbDataSet, null).Show();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int index = -1;
                for (int i = 0; i < dataGridView2.RowCount; i++) {
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString() &&
                        dataGridView2.Rows[i].Cells[1].Value.ToString() == dataGridView1.CurrentRow.Cells[1].Value.ToString() &&
                        dataGridView2.Rows[i].Cells[2].Value.ToString() == dataGridView1.CurrentRow.Cells[2].Value.ToString() &&
                        dataGridView2.Rows[i].Cells[3].Value.ToString() == dataGridView1.CurrentRow.Cells[3].Value.ToString() &&
                        dataGridView2.Rows[i].Cells[4].Value.ToString() == dataGridView1.CurrentRow.Cells[4].Value.ToString() &&
                        dataGridView2.Rows[i].Cells[5].Value.ToString() == dataGridView1.CurrentRow.Cells[5].Value.ToString())
                            index = i;
                }
                string a= dataGridView1.CurrentRow.Cells.ToString();
                //int index = dataGridView2.Rows.IndexOf(dataGridView1.CurrentRow);
                if (index!=-1)
                new PlanInstrCRUD(планинструктажейTableAdapter, планинструктажейBindingSource, movedbDataSet,dataGridView2.Rows[index]).Show();
            }
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (DataGridError.isRemove())
                if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                {
                    планинструктажейBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    планинструктажейTableAdapter.Update(movedbDataSet.планинструктажей);
                }
        }

        private void шрифтСтолбцовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].DefaultCellStyle.Font = fd.Font;
        }

        private void шрифтЗаголовковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = fd.Font;
        }

        private void фонСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            int x = dataGridView1.CurrentCellAddress.X;
            dataGridView1.Columns[x].DefaultCellStyle.BackColor = cd.Color;
        }

        private void фонЗаголовкаСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            int x = dataGridView1.CurrentCellAddress.X;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[x].HeaderCell.Style.BackColor = cd.Color;
        }

        private void шрифтСтолбцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            int x = dataGridView1.CurrentCellAddress.X;
            dataGridView1.Columns[x].DefaultCellStyle.Font = fd.Font;
        }

        private void _3PlanInstr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        //add sakl
        private void button7_Click(object sender, EventArgs e)
        {
            sakl = dataGridView1.CurrentRow.Index;
        }
        //go to sakl
        private void button8_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount>0 && sakl<= dataGridView1.RowCount-1)
            dataGridView1.CurrentCell = dataGridView1[0, sakl];
        }
        //free sakl
        private void button9_Click(object sender, EventArgs e)
        {
            sakl = 0;
        }
        //print
        private void button5_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, this.Text);
            _ClsPrint.PrintForm();
        }
        //close
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //otshet
        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _3PlanInstrReport().Show();
        }
        //filter
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
               
                //string str1 = "ИнструктажID";
                string str = "SELECT `ИнструктажID`, `СотрудникID`, `ДатаС`, `ДатаПо`, `ОтветственныйID`, `Пройдено` FROM `планинструктажей` WHERE `ИнструктажID` > 0 ";
                if (checkBox1.Checked) str += " AND `ДатаС` >= '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "'";
                if (checkBox2.Checked) str += " AND `ДатаПо` <= '" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "'";
                if (checkBox3.Checked) str += " AND `Пройдено` = " + comboBox1.Text;
                if (checkBox4.Checked) str += " AND `ИнструктажID` = " + comboBox2.SelectedValue;
                if (checkBox5.Checked) str += " AND `СотрудникID` = " + comboBox3.SelectedValue;

                MySqlConnection con = планинструктажейTableAdapter.Connection;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(str, con);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex) { }
            }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (update!=0) this.планинструктажейTableAdapter.Fill(this.movedbDataSet.планинструктажей);
        }
    }
}
