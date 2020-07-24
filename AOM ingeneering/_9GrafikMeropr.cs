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
    public partial class _9GrafikMeropr : Form
    {
        public static int update = 0;
        int sakl = 0;
        public _9GrafikMeropr()
        {
            InitializeComponent();
        }

        private void _9GrafikMeropr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.мероприятие". При необходимости она может быть перемещена или удалена.
            this.мероприятиеTableAdapter.Fill(this.movedbDataSet.мероприятие);
            this.графикTableAdapter.Fill(this.movedbDataSet.график);
            fixName();
        }

        private void _9GrafikMeropr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

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
                    dataGridView1.CurrentCell = dataGridView1[2, sakl];
            }
            catch (Exception ex) { }
        }
        //free sakl
        private void button9_Click(object sender, EventArgs e)
        {
            sakl = 0;
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, this.Text);
            _ClsPrint.PrintForm();
        }
        //otshet
        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new _9GrafikMeroprReport().Show();
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            new GrafikMeroprCRUD(графикTableAdapter, графикBindingSource, movedbDataSet, null).Show();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                new GrafikMeroprCRUD(графикTableAdapter, графикBindingSource, movedbDataSet, dataGridView1.CurrentRow).Show();
        }
        //remove
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            if (DataGridError.isRemove())
                if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                {
                    графикBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    графикTableAdapter.Update(movedbDataSet.график);
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (update != 0) { update = 0; fixName(); }
        }
        private void fixName() {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    int index1 = мероприятиеBindingSource.Find("ID", dataGridView1[0, i].Value.ToString());
                    dataGridView1[5, i].Value = ((DataRowView)(мероприятиеBindingSource[index1]))[1];
                }
                catch (Exception ex) { Console.WriteLine("нет элемента  "); }
                try
                {
                    int index2 = сотрудникBindingSource.Find("ТабN", dataGridView1[1, i].Value.ToString());
                    dataGridView1[6, i].Value = ((DataRowView)(сотрудникBindingSource[index2]))[1];
                }
                catch (Exception ex) { Console.WriteLine("нет элемента  "); }
            }
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked) dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            if (radioButton9.Checked) dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            if (radioButton8.Checked) dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            if (radioButton7.Checked) dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            if (radioButton6.Checked) dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            fixName();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fixName();
        }
        //find
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (radioButton1.Checked) this.графикTableAdapter.FillByMeropr(movedbDataSet.график, $"%{textBox1.Text}%");
                else if (radioButton2.Checked) this.графикTableAdapter.FillBySotrud(movedbDataSet.график, $"%{textBox1.Text}%");
                else if (radioButton4.Checked) this.графикTableAdapter.FillByOtm(movedbDataSet.график, $"%{textBox1.Text}%");

            }
            else if (radioButton5.Checked) this.графикTableAdapter.FillByDatePlan(movedbDataSet.график, dateTimePicker1.Value.Date.AddDays(-1), dateTimePicker1.Value.Date.AddDays(1));
            else if (radioButton3.Checked) this.графикTableAdapter.FillBy(movedbDataSet.график, dateTimePicker1.Value.Date.AddDays(-1), dateTimePicker1.Value.Date.AddDays(1));
            else this.графикTableAdapter.Fill(movedbDataSet.график);
            fixName();
        }

       
    }
}
