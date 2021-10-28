using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Survey_Click(object sender, EventArgs e)
        {
            //Calling Survey window
            Survey sur = new Survey();
            sur.Show();

            //Hiding MainWindow
            this.Hide();
        }

        private void btn_Results_Click(object sender, EventArgs e)
        {
            //Calling Results window
            Results res = new Results();
            res.Show();

            //Hiding MainWindow
            this.Hide();
        }

       
    }
}
