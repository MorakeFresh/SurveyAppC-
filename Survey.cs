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
    public partial class Survey : Form
    {
        Results results;
        public Survey(Results res)
        {
            InitializeComponent();
            this.results = res;
        }

        //Establishing connection string
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Morake\source\repos\SurveyTest\SurveyDatabase1.mdf;Integrated Security=True");

        int pizza;
        int pasta;
        int papnWors;
        int Chicken;
        int Beef;
        int other;

        int eatOut;
        int movies;
        int tv;
        int radio;

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (chkBox_Pizza.Checked == true)
            {
                pizza = 1;
            }
            else
            {
                pizza = 0;
            }

            if (chkBox_Pasta.Checked == true)
            {
                pasta = 1;
            }
            else
            {
                pasta = 0;
            }

            if (chkBox_PapnWors.Checked == true)
            {
                papnWors = 1;
            }
            else
            {
                papnWors = 0;
            }

            if (chkBox_Chicken.Checked == true)
            {
                Chicken = 1;
            }
            else
            {
                Chicken = 0;
            }

            if (chkBox_Beef.Checked == true)
            {
                Beef = 1;
            }
            else
            {
                Beef = 0;
            }

            if (chkBox_Other.Checked == true)
            {
                other = 1;
            }
            else
            {
                other = 0;
            }


            if (rdb_EatOut1.Checked == true)
            {
                eatOut = 1;
            }
            else if (rdb_EatOut2.Checked == true)
            {
                eatOut = 2;
            }
            else if (rdb_EatOut3.Checked == true)
            {
                eatOut = 3;
            }
            else if (rdb_EatOut4.Checked == true)
            {
                eatOut = 4;
            }
            else if (rdb_EatOut5.Checked == true)
            {
                eatOut = 5;
            }


            if (rdb_Movies1.Checked == true)
            {
                movies = 1;
            }
            else if (rdb_Movies2.Checked == true)
            {
                movies = 2;
            }
            else if (rdb_Movies3.Checked == true)
            {
                movies = 3;
            }
            else if (rdb_Movies4.Checked == true)
            {
                movies = 4;
            }
            else if (rdb_Movies5.Checked == true)
            {
                movies = 5;
            }


            if (rdb_TV1.Checked == true)
            {
                tv = 1;
            }
            else if (rdb_TV2.Checked == true)
            {
                tv = 2;
            }
            else if (rdb_TV3.Checked == true)
            {
                tv = 3;
            }
            else if (rdb_TV4.Checked == true)
            {
                tv = 4;
            }
            else if (rdb_TV5.Checked == true)
            {
                tv = 5;
            }


            if (rdb_Radio1.Checked == true)
            {
                radio = 1;
            }
            else if (rdb_Radio2.Checked == true)
            {
                radio = 2;
            }
            else if (rdb_Radio3.Checked == true)
            {
                radio = 3;
            }
            else if (rdb_Radio4.Checked == true)
            {
                radio = 4;
            }
            else if (rdb_Radio5.Checked == true)
            {
                radio = 5;
            }


            try
            {
                //Adding values to datagrid from textboxes
                results.dataGridView1.Rows.Add(txtBox_Surname.Text, txtBox_Names.Text, Convert.ToInt32(txtBox_Contact.Text), dtp_Date.Value, Convert.ToInt32(txtBox_Age.Text), pizza, pasta, papnWors, Chicken, Beef, other, eatOut, movies, tv, radio);


                //Adding values to database using sql command from textboxes
                SqlCommand cmd = new SqlCommand(@"INSERT INTO SurveyData_tbl
           ([Surname]
           ,[First Names]
           ,[Contact]
           ,[Date]
           ,[Age]
           ,[Pizza]
           ,[Pasta]
           ,[Pap and Wors]
           ,[Chicken]
           ,[Beef]
           ,[Other]
           ,[Eat Out]
           ,[Movies]
           ,[TV]
           ,[Radio])
     VALUES  ('" + txtBox_Surname.Text + "', '" + txtBox_Names.Text + "', '" + Convert.ToInt32(txtBox_Contact.Text) + "', '" + dtp_Date.Value + "', '" + Convert.ToInt32(txtBox_Age.Text) + "','" + pizza + "', '" + pasta + "', '" + papnWors + "', '" + Chicken + "', '" + Beef + "', '" + other + "', '" + eatOut + "', '" + movies + "', '" + tv + "', '" + radio + "')", con);
            //Opening connection
            con.Open();
            cmd.ExecuteNonQuery();
            //closing connection
            con.Close();
            //displaying message that survey is complete after successfully loading answers to database
            MessageBox.Show("Survey Completed");

        }
            catch (Exception error)
            {
                //displaying error message
                MessageBox.Show(error.Message);
            }

    //clearing textboxes
    txtBox_Surname.Clear();
            txtBox_Names.Clear();
            txtBox_Contact.Clear();
            dtp_Date.Value = DateTime.Now;
            txtBox_Age.Clear();

            //clearing checkboxes
            chkBox_Pizza.Checked = false;
            chkBox_Pasta.Checked = false;
            chkBox_PapnWors.Checked = false;
            chkBox_Chicken.Checked = false;
            chkBox_Beef.Checked = false;
            chkBox_Other.Checked = false;

            //clearing radio buttons
            rdb_EatOut1.Checked = false;
            rdb_EatOut2.Checked = false;
            rdb_EatOut3.Checked = false;
            rdb_EatOut4.Checked = false;
            rdb_EatOut5.Checked = false;

            //clearing radio buttons
            rdb_Movies1.Checked = false;
            rdb_Movies2.Checked = false;
            rdb_Movies3.Checked = false;
            rdb_Movies4.Checked = false;
            rdb_Movies5.Checked = false;

            //clearing radio buttons
            rdb_TV1.Checked = false;
            rdb_TV2.Checked = false;
            rdb_TV3.Checked = false;
            rdb_TV4.Checked = false;
            rdb_TV5.Checked = false;

            //clearing radio buttons
            rdb_Radio1.Checked = false;
            rdb_Radio2.Checked = false;
            rdb_Radio3.Checked = false;
            rdb_Radio4.Checked = false;
            rdb_Radio5.Checked = false;
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
