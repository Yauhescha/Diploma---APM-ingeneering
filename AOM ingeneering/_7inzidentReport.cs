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
    public partial class _7inzidentReport : Form
    {
        public _7inzidentReport()
        {
            InitializeComponent();
        }

        private void _7inzidentReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.инцидент". При необходимости она может быть перемещена или удалена.
            this.инцидентTableAdapter.Fill(this.movedbDataSet.инцидент);

            this.reportViewer1.RefreshReport();
        }
    }
}
