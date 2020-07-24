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
    public partial class _8SIZ : Form
    {
        public _8SIZ()
        {
            InitializeComponent();
        }

        private void _8SIZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сиз". При необходимости она может быть перемещена или удалена.
            this.сизTableAdapter.Fill(this.movedbDataSet.сиз);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            сизTableAdapter.Update(movedbDataSet.сиз);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridError.Msg();
        }
    }
}
