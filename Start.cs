using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // tiempo de la barrita de carga
            panel2.Width += 6;
            if(panel2.Width>= 800)
            {
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();

            }
        }
    }
}
