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
    public partial class Questions2 : Form
    {
        public Questions2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Fim Score = new Fim();
            Score.Show();
            this.Hide();
        }
    }
}
