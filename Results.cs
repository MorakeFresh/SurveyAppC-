using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SurveyTest
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            Survey survey = new Survey(this);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //Calling MainWindow
            Form1 main = new Form1();
            main.Show();
            //Hiding Results window
            this.Hide();
        }

        private void btn_Results_Click(object sender, EventArgs e)
        {
            //Calculating total number of surveys and displaying in textbox 
            int count_rows = dataGridView1.Rows.Count;
            txtBox_Total.Text = dataGridView1.Rows.Count.ToString();

            //Calculating average age and displaying in textbox 
            int ageSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ageSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            double ageAvg = ageSum / count_rows;
            txtBox_AgeAvg.Text = ageAvg.ToString();

            //Calculating maximum age and displaying in textbox 
            txtBox_AgeMax.Text = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[4].FormattedValue)).Max().ToString();

            //Calculating minimum and displaying in textbox 
            txtBox_AgeMin.Text = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[4].FormattedValue)).Min().ToString();

            //Calculating percentage of people who like pizza and displaying in textbox 
            int pizzaSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                pizzaSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            double pizzaPercent = (pizzaSum / count_rows) * 100;
            txtBox_Pizza.Text = pizzaPercent.ToString() + " %";

            //Calculating percentage of people who like pasta and displaying in textbox 
            int pastaSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                pastaSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            double pastaPercent = (pastaSum / count_rows) * 100;
            txtBox_Pasta.Text = pastaPercent.ToString() + " %";

            //Calculating percentage of people who like pap and wors and displaying in textbox 
            int papnWorsSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                papnWorsSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            double papnWorsPercent = (papnWorsSum / count_rows) * 100;
            txtBox_PapnWors.Text = papnWorsPercent.ToString() + " %";

            //Calculating percentage of people who like chicken stir fry and displaying in textbox 
            int chickenSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                chickenSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            double chickenPercent = (chickenSum / count_rows) * 100;
            txtBox_Chicken.Text = chickenPercent.ToString() + " %";

            //Calculating percentage of people who like beef stir and displaying in textbox 
            int beefSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                beefSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
            }
            double beefPercent = (beefSum / count_rows) * 100;
            txtBox_Beef.Text = beefPercent.ToString() + " %";

            //Calculating percentage of people who like other food and displaying in textbox 
            int otherSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                otherSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value);
            }
            double otherPercent = (otherSum / count_rows) * 100;
            txtBox_Other.Text = otherPercent.ToString() + " %";


            //Calculating average rating of people who like to eat out and displaying in textbox 
            int eatSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                eatSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value);
            }
            double eatAvg = eatSum / count_rows;
            txtBox_EatOut.Text = eatAvg.ToString();

            //Calculating average rating of people who like to watch movies and displaying in textbox 
            int movieSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                movieSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[12].Value);
            }
            double movieAvg = movieSum / count_rows;
            txtBox_Movies.Text = movieAvg.ToString();

            //Calculating average rating of people who like to watch tv and displaying in textbox 
            int tvSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tvSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value);
            }
            double tvAvg = tvSum / count_rows;
            txtBox_TV.Text = tvAvg.ToString();

            //Calculating average rating of people who like to listen to the radio and displaying in textbox 
            int radioSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                radioSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[14].Value);
            }
            double radioAvg = (radioSum / count_rows);
            txtBox_Radio.Text = radioAvg.ToString();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'surveyDatabase1DataSet.SurveyData_tbl' table. You can move, or remove it, as needed.
            this.surveyData_tblTableAdapter.Fill(this.surveyDatabase1DataSet.SurveyData_tbl);

        }
    }
}
