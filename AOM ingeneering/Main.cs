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
    public partial class Main : Form
    {
        _1PlanSan _1plansan = new _1PlanSan();
        _2NormDoc _2NormDoc = new _2NormDoc();
        _3PlanInstr _3PlanInstr = new _3PlanInstr();        
        _5VidachaSr _5VidachaSr = new _5VidachaSr();
        _7Inzident _7Inzident = new _7Inzident();
        _9GrafikMeropr _9GrafikMeropr = new _9GrafikMeropr();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.планинструктажей". При необходимости она может быть перемещена или удалена.
            this.планинструктажейTableAdapter.Fill(this.movedbDataSet.планинструктажей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.график". При необходимости она может быть перемещена или удалена.
            this.графикTableAdapter.Fill(this.movedbDataSet.график);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _1plansan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2NormDoc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _3PlanInstr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new _4Sotrud().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _5VidachaSr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new _6Otwetstwen().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _7Inzident.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new _8SIZ().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _9GrafikMeropr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           new _10ProgrammInstruc().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new _11Podrasdelen().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new _12ProgrammSanat().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            graphUpdate();
        }
        private void graphUpdate()
        {
                графикTableAdapter.Update(movedbDataSet.график);
        }
        private void planUpdate()
        {
                планинструктажейTableAdapter.Update(movedbDataSet.планинструктажей);
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            planUpdate();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridError.Msg();
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            graphUpdate();
        }

        private void dataGridView2_Leave(object sender, EventArgs e)
        {
            planUpdate();
        }
    }
}
