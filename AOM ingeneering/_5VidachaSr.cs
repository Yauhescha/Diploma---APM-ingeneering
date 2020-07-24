using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOM_ingeneering
{
    public partial class _5VidachaSr : Form
    {
        int sakl = 0;
        public static int update = 0;
        public _5VidachaSr()
        {
            InitializeComponent();
        }

        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void _5VidachaSr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ответственный". При необходимости она может быть перемещена или удалена.
            this.ответственныйTableAdapter.Fill(this.movedbDataSet.ответственный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сиз". При необходимости она может быть перемещена или удалена.
            this.сизTableAdapter.Fill(this.movedbDataSet.сиз);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.выдачасиз". При необходимости она может быть перемещена или удалена.
            this.выдачасизTableAdapter.Fill(this.movedbDataSet.выдачасиз);
            refrechItem();
        }

        //add sokl
        private void button7_Click(object sender, EventArgs e)
        {
            sakl = dataGridView1.CurrentRow.Index;
        }
        //go to sakl
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0 && sakl <= dataGridView1.RowCount - 1)
                    dataGridView1.CurrentCell = dataGridView1[0, sakl];
            }
            catch (Exception ex) { }
        }
        //free sakl
        private void button9_Click(object sender, EventArgs e)
        {
            sakl = 0;
        }

        //pring
        private void button5_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, this.Text);
            _ClsPrint.PrintForm();
        }
        //exit
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
        //otchet
        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _5VidachaSrReport().Show();
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            //refrechItem();
        }
        private void refrechItem() {
           
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {               
                    try
                    {
                        int index1 = сизBindingSource.Find("ID", dataGridView1[1, i].Value.ToString());
                        dataGridView1[8, i].Value = ((DataRowView)(сизBindingSource[index1]))[1];
                    } catch (Exception ex) { Console.WriteLine("нет элемента сиз "); }
                    try
                    {
                        int index2 = ответственныйBindingSource.Find("ID", dataGridView1[2, i].Value.ToString());
                        dataGridView1[6, i].Value = ((DataRowView)(ответственныйBindingSource[index2]))[1];
                    } catch (Exception ex) { Console.WriteLine("нет элемента ответственный" ); }
                    try
                    {
                        int index3 = сотрудникBindingSource.Find("ТабN", dataGridView1[0, i].Value.ToString());
                        dataGridView1[7, i].Value = ((DataRowView)(сотрудникBindingSource[index3]))[1];
                    } catch (Exception ex) { Console.WriteLine("нет элемента сотрудник" ); }
            }

        }
        //find
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                //string str1 = "ИнструктажID";
                string str = "SELECT `Дата`, `СотрудникID`, `СИЗ_ID`, `Количество`, `ВыдалID`, `ид` FROM `выдачасиз` WHERE `СотрудникID`> 0 ";
                if (checkBox1.Checked) str += " AND `СИЗ_ID` = " + comboBox1.SelectedValue;
                if (checkBox2.Checked) str += " AND `ВыдалID` = " + comboBox2.SelectedValue;
                if (checkBox3.Checked) str += " AND `СотрудникID` = " + comboBox3.SelectedValue;

                str += " AND `Дата` between '" + dateTimePicker1.Value.Date.AddDays(-1).ToString("yyyy-MM-dd") 
                    + "' AND '"+ dateTimePicker2.Value.Date.AddDays(1).ToString("yyyy-MM-dd") + "'";

                MySqlConnection con = выдачасизTableAdapter.Connection;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(str, con);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                refrechItem();
            }
            catch (Exception ex) { }
        
    }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            this.выдачасизTableAdapter.Fill(this.movedbDataSet.выдачасиз);
            new VidachaSrCRUD(this.выдачасизTableAdapter, this.выдачасизBindingSource, this.movedbDataSet, null).Show();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int index = -1;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    try
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString() &&
                            dataGridView2.Rows[i].Cells[1].Value.ToString() == dataGridView1.CurrentRow.Cells[1].Value.ToString() &&
                            dataGridView2.Rows[i].Cells[2].Value.ToString() == dataGridView1.CurrentRow.Cells[2].Value.ToString() &&
                            dataGridView2.Rows[i].Cells[3].Value.ToString() == dataGridView1.CurrentRow.Cells[3].Value.ToString() &&
                            dataGridView2.Rows[i].Cells[4].Value.ToString() == dataGridView1.CurrentRow.Cells[4].Value.ToString() &&
                            dataGridView2.Rows[i].Cells[5].Value.ToString() == dataGridView1.CurrentRow.Cells[5].Value.ToString()                            )
                        {
                            index = i;
                            break;
                        }
                    }
                    catch (Exception ex) { }
                        
                }
                string a = dataGridView1.CurrentRow.Cells.ToString();
                if (index != -1)
                    new VidachaSrCRUD(this.выдачасизTableAdapter, this.выдачасизBindingSource, this.movedbDataSet, dataGridView2.Rows[index]).Show();
            }
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {

            if (DataGridError.isRemove())
                if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                {
                    выдачасизBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    выдачасизTableAdapter.Update(movedbDataSet.выдачасиз);
                }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (update != 0) {
                выдачасизTableAdapter.Update(movedbDataSet.выдачасиз);
                //this.выдачасизTableAdapter.Fill(this.movedbDataSet.выдачасиз);
                update = 0;
                refrechItem();
            }
        }

        private void _5VidachaSr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
