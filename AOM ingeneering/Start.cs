using System;
using System.Windows.Forms;

namespace AOM_ingeneering
{
    public partial class Start : Form
    {
        
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Info().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
