using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsQuizSENAC
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultados PP = new Resultados();
            PP.Show();
            this.Hide();
        }
    }
}
