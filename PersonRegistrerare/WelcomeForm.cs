using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonRegistrerare
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        // Om användaren klickar på PersReg så startas ett nytt fönster som öppnas
        private void buttonPersReg_Click(object sender, EventArgs e)
        {
            new PersonRegistrerare().Show();
        }
        // Vid avbryt stängs programmet ned
        private void buttonAvbryt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
