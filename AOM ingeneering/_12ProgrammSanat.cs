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
    public partial class _12ProgrammSanat : Form
    {
        public _12ProgrammSanat()
        {
            InitializeComponent();
        }

        private void _12ProgrammSanat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.темазанятий". При необходимости она может быть перемещена или удалена.
            this.темазанятийTableAdapter.Fill(this.movedbDataSet.темазанятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.разделзанятий". При необходимости она может быть перемещена или удалена.
            this.разделзанятийTableAdapter.Fill(this.movedbDataSet.разделзанятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.прогрзанятий". При необходимости она может быть перемещена или удалена.
            this.прогрзанятийTableAdapter.Fill(this.movedbDataSet.прогрзанятий);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            прогрзанятийTableAdapter.Update(movedbDataSet.прогрзанятий);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            
            try
            {
            разделзанятийTableAdapter.Update(movedbDataSet.разделзанятий);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            try
            {
            темазанятийTableAdapter.Update(movedbDataSet.темазанятий);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridError.Msg();
        }
    }
}
