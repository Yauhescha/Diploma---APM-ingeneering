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
    public partial class _4Sotrud : Form
    {
        int sakl = 0;
        public _4Sotrud()
        {
            InitializeComponent();
        }

        private void _4Sotrud_Load(object sender, EventArgs e)
        {
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);

        }
        //add sokl
        private void button7_Click(object sender, EventArgs e)
        {
            sakl = dataGridView1.CurrentRow.Index;
        }
        //go to sakl
        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0 && sakl <= dataGridView1.RowCount - 1)
                dataGridView1.CurrentCell = dataGridView1[0, sakl];
        }
        //free sakl
        private void button9_Click(object sender, EventArgs e)
        {
            sakl = 0;
        }
        //find
        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            try
            {
                if (radioButton3.Checked) this.сотрудникTableAdapter.FillBydateborn(this.movedbDataSet.сотрудник, dateTimePicker1.Value.AddDays(-1), dateTimePicker1.Value.AddDays(1));
                else if (radioButton4.Checked) this.сотрудникTableAdapter.FillBydatepriem(this.movedbDataSet.сотрудник, dateTimePicker1.Value.AddDays(-1), dateTimePicker1.Value.AddDays(1));
                else if (radioButton6.Checked) this.сотрудникTableAdapter.FillBydateDrop(this.movedbDataSet.сотрудник, dateTimePicker1.Value.AddDays(-1), dateTimePicker1.Value.AddDays(1));

                else if (textBox1.Text.Length > 0)
                {
                    if (radioButton1.Checked) this.сотрудникTableAdapter.FillBytab(this.movedbDataSet.сотрудник, int.Parse(textBox1.Text));
                    if (radioButton2.Checked) this.сотрудникTableAdapter.FillByfio(this.movedbDataSet.сотрудник, $"%{textBox1.Text}%");
                    if (radioButton5.Checked) this.сотрудникTableAdapter.FillByobras(this.movedbDataSet.сотрудник, $"%{textBox1.Text}%");
                    }
                else this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            }
            catch (Exception ex) { MessageBox.Show("Неверный формат данных"); }
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
        //add
        private void button1_Click(object sender, EventArgs e)
        {
                new SotrudCRUD(this.сотрудникTableAdapter, this.сотрудникBindingSource,movedbDataSet, null).Show();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                new SotrudCRUD(this.сотрудникTableAdapter, this.сотрудникBindingSource,movedbDataSet, dataGridView1.CurrentRow).Show();
        }
        //remove
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridError.isRemove())
                    if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                    {
                        сотрудникBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                        сотрудникTableAdapter.Update(movedbDataSet.сотрудник);
                    }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

    }
}
