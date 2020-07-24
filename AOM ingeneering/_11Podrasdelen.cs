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
    public partial class _11Podrasdelen : Form
    {
        public _11Podrasdelen()
        {
            InitializeComponent();
        }

        private void _11Podrasdelen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.movedbDataSet.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.рабместо". При необходимости она может быть перемещена или удалена.
            this.рабместоTableAdapter.Fill(this.movedbDataSet.рабместо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.movedbDataSet.подразделение);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            podrUpdate();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            pabMUpdate();

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            sotrUpdate();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridError.Msg();
        }
        private void podrUpdate() {
            try
            {
            подразделениеTableAdapter.Update(movedbDataSet.подразделение);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }
        private void sotrUpdate()
        {
            try
            {
            сотрудникTableAdapter.Update(movedbDataSet.сотрудник);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }
        private void pabMUpdate() {
            try
            {
            рабместоTableAdapter.Update(movedbDataSet.рабместо);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
