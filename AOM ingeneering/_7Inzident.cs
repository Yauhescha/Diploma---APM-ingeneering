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
    public partial class _7Inzident : Form
    {
        int sakl = 0;
        public static int update = 0;
        public _7Inzident()
        {
            InitializeComponent();
        }

        private void _7Inzident_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.видинцидента". При необходимости она может быть перемещена или удалена.
            this.видинцидентаTableAdapter.Fill(this.movedbDataSet.видинцидента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.инцидент". При необходимости она может быть перемещена или удалена.
            this.инцидентTableAdapter.Fill(this.movedbDataSet.инцидент);
            fixTable();
        }


        //find
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox4.Checked && checkBox5.Checked)
                    this.инцидентTableAdapter.FillByAll(this.movedbDataSet.инцидент, dateTimePicker1.Value, dateTimePicker2.Value, (int)comboBox2.SelectedValue, (int)comboBox3.SelectedValue);
                else if (checkBox4.Checked)
                    this.инцидентTableAdapter.FillByIntzident(this.movedbDataSet.инцидент, dateTimePicker1.Value, dateTimePicker2.Value, (int)comboBox2.SelectedValue);
                else if (checkBox5.Checked)
                    this.инцидентTableAdapter.FillBySotrudn(this.movedbDataSet.инцидент, dateTimePicker1.Value, dateTimePicker2.Value, (int)comboBox3.SelectedValue);
                else
                    this.инцидентTableAdapter.FillByDate(this.movedbDataSet.инцидент, dateTimePicker1.Value, dateTimePicker2.Value);
            }
            catch (Exception ex) { }
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _7inzidentReport().Show();
        }
        //print
        private void button5_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, "Инструктаж");
            _ClsPrint.PrintForm();
        }

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
            if (dataGridView1.RowCount > 0 && sakl <= dataGridView1.RowCount - 1)
                dataGridView1.CurrentCell = dataGridView1[2, sakl];
        }
        //free sakl
        private void button9_Click(object sender, EventArgs e)
        {
            sakl = 0;
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            new InzidentCRUD(this.инцидентTableAdapter, this.инцидентBindingSource, this.movedbDataSet, null).Show();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                new InzidentCRUD(this.инцидентTableAdapter, this.инцидентBindingSource, this.movedbDataSet, dataGridView1.CurrentRow).Show();
        }
        //remove
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridError.isRemove())
                    if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                    {
                        инцидентBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                        инцидентTableAdapter.Update(movedbDataSet.инцидент);
                    }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void _7Inzident_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        private void fixTable() {
            for (int i = 0; i < dataGridView1.RowCount; i++) {
                try
                {
                    int index1 = видинцидентаBindingSource.Find("ID", dataGridView1[1, i].Value.ToString());
                    dataGridView1[2, i].Value = ((DataRowView)(видинцидентаBindingSource[index1]))[1];
                } catch (Exception ex) { Console.WriteLine("нет элемента вида инцидента "); }
                try
                {
                    int index2 = сотрудникBindingSource.Find("ТабN", dataGridView1[5, i].Value.ToString());
                    dataGridView1[6, i].Value = ((DataRowView)(сотрудникBindingSource[index2]))[1];
                }
                catch (Exception ex) { Console.WriteLine("нет элемента вида инцидента "); }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (update != 0) { movedbDataSet.AcceptChanges(); инцидентTableAdapter.Update(movedbDataSet.инцидент); update = 0; movedbDataSet.AcceptChanges(); };
                fixTable();
            
        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            fixTable();
        }
    }
}
