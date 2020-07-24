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
    public partial class _10ProgrammInstruc : Form
    {
        public _10ProgrammInstruc()
        {
            InitializeComponent();
        }

        private void _10ProgrammInstruc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.movedbDataSet.документ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.инструктаж". При необходимости она может быть перемещена или удалена.
            this.инструктажTableAdapter.Fill(this.movedbDataSet.инструктаж);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try{
            инструктажTableAdapter.Update(movedbDataSet.инструктаж);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. ВОзможно вы пытаетесь удалить используемый объект"); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
            документTableAdapter.Update(movedbDataSet.документ);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. ВОзможно вы пытаетесь удалить используемый объект"); }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridError.Msg();
        }

        private void _10ProgrammInstruc_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, "Инструктаж");
            _ClsPrint.PrintForm();
            _ClsPrint = new ClsPrint(dataGridView2, "Документ");
            _ClsPrint.PrintForm();
        }
    }
}
