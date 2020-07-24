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
    public partial class _3PlanInstrReport : Form
    {
        public _3PlanInstrReport()
        {
            InitializeComponent();
        }

        private void _3PlanInstrReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.планинструктажей". При необходимости она может быть перемещена или удалена.
            this.планинструктажейTableAdapter.Fill(this.movedbDataSet.планинструктажей);

            this.reportViewer1.RefreshReport();
        }
    }
}
