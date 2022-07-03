using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace University
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void LoadData()
        {
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //SqlDataReader sqlReader = null;
            String quary = "Select * from[University131]  ORDER BY Prise";

            SqlCommand command = new SqlCommand(quary, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[9]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }
            reader.Close();
            sqlConnection.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked && textBox20.Text != " ")// Пошук за університетом
            {
                dataGridView1.Rows.Clear();

                String quary = "Select * FROM University131 WHERE University LIKE N'%" + textBox20.Text + "%'";
                sqlConnection.Open();

                //SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand(quary, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[9]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }
                reader.Close();
                sqlConnection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else if (checkBox1.Checked && textBox1.Text != " ")// Пошук за спеціальністю
            {
                dataGridView1.Rows.Clear();

                String quary = "Select * FROM University131 WHERE Specialties LIKE N'%" + textBox1.Text + "%'";
                sqlConnection.Open();

                //SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand(quary, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[9]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }
                reader.Close();
                sqlConnection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else if (checkBox2.Checked && textBox2.Text != " ")// Форма навчання
            {
                dataGridView1.Rows.Clear();

                String quary = "Select * FROM University131 WHERE Form_studies LIKE N'%" + textBox2.Text + "%'";
                sqlConnection.Open();

                // SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand(quary, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[9]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }
                reader.Close();
                sqlConnection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else if (checkBox3.Checked && textBox3.Text != "  ")//Область
            {
                dataGridView1.Rows.Clear();

                String quary = "Select * FROM University131 WHERE Region LIKE N'%" + textBox3.Text + "%'";
                sqlConnection.Open();

                // SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand(quary, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[9]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }
                reader.Close();
                sqlConnection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }
            else // Вся таблиця
            {
                dataGridView1.Rows.Clear();

                String quary = "Select * FROM University131";
                sqlConnection.Open();

                //   SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand(quary, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[9]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }
                reader.Close();
                sqlConnection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

            }

        }
        //Вторая таблица
        private void button1_Click(object sender, EventArgs e)
        {
            // Начало блоку пошуку та створення Регіону
            textBox9.Clear();


            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //SqlDataReader sqlReader = null;
            String quary = "Select id_region from[Region] WHERE region LIKE N'" + textBox4.Text + "'";

            SqlCommand command = new SqlCommand(quary, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {


                textBox9.Text = reader["Id_region"].ToString();
                sqlConnection.Close();
            }

            if ((textBox9.Text == "") && (textBox4.Text != ""))//Створення нових записів в таблиці Областей
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                //SqlDataReader sqlReader1 = null;
                String quary1 = "INSERT INTO [Region] (region)  VALUES ( N'" + textBox4.Text + "')";

                SqlCommand command1 = new SqlCommand(quary1, sqlConnection);
                SqlDataReader reader1 = command1.ExecuteReader();
                sqlConnection.Close();

                // Кінець блоку пошуку та створення регіону              
            }
            {
                //Початок блоку пошуку та створення міст
                textBox10.Clear();

                String connectionString1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
                sqlConnection = new SqlConnection(connectionString1);
                sqlConnection.Open();

                // SqlDataReader sqlReader2 = null;
                String quary2 = "Select id_sity from[Sity] WHERE sity LIKE N'" + textBox5.Text + "'";

                SqlCommand command2 = new SqlCommand(quary2, sqlConnection);
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read())
                {

                    textBox10.Text = reader2["Id_sity"].ToString();
                    sqlConnection.Close();
                }

                if ((textBox10.Text == "") && (textBox5.Text != ""))//Створення нових записів в таблиці Міст
                {
                    sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();

                    //   SqlDataReader sqlReader3 = null;
                    String quary3 = "INSERT INTO [Sity] (sity)  VALUES ( N'" + textBox5.Text + "')";

                    SqlCommand command3 = new SqlCommand(quary3, sqlConnection);
                    SqlDataReader reader3 = command3.ExecuteReader();
                    sqlConnection.Close();

                    // Кінець блоку пошуку та створення Міста  
                }
                {
                    // Початок блоку пошуку та створення університета
                    textBox11.Clear();

                    String connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
                    sqlConnection = new SqlConnection(connectionString2);
                    sqlConnection.Open();

                    //   SqlDataReader sqlReader4 = null;
                    String quary4 = "Select id_university from[University] WHERE university LIKE N'" + textBox6.Text + "'";

                    SqlCommand command4 = new SqlCommand(quary4, sqlConnection);
                    SqlDataReader reader4 = command4.ExecuteReader();
                    if (reader4.Read())
                    {

                        textBox11.Text = reader4["Id_university"].ToString();
                        sqlConnection.Close();
                    }
                }

                if ((textBox11.Text == "") && (textBox6.Text != ""))//Створення нових записів в таблиці Університет
                {
                    sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();

                    //    SqlDataReader sqlReader5 = null;
                    String quary5 = "INSERT INTO [University] (university,address)  VALUES((N'" + textBox6.Text + "'),( N'" + textBox7.Text + "'))";

                    SqlCommand command5 = new SqlCommand(quary5, sqlConnection);
                    SqlDataReader reader5 = command5.ExecuteReader();
                    sqlConnection.Close();

                    // Кінець блоку пошуку та створення Університету з адресою  
                }
                {
                    // Початок блоку пошуку та створення Форми навчання
                    textBox13.Clear();

                    String connectionString3 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
                    sqlConnection = new SqlConnection(connectionString3);
                    sqlConnection.Open();

                    //    SqlDataReader sqlReader6 = null;
                    String quary6 = "Select id_form_studies from[Form_studies] WHERE form_studies LIKE N'" + textBox8.Text + "'";

                    SqlCommand command6 = new SqlCommand(quary6, sqlConnection);
                    SqlDataReader reader6 = command6.ExecuteReader();
                    if (reader6.Read())
                    {

                        textBox13.Text = reader6["Id_form_studies"].ToString();
                        sqlConnection.Close();
                    }

                    if ((textBox13.Text == "") && (textBox8.Text != ""))//Створення нових записів в таблиці Форми навчання
                    {
                        sqlConnection = new SqlConnection(connectionString);
                        sqlConnection.Open();

                        //   SqlDataReader sqlReader7 = null;
                        String quary7 = "INSERT INTO [Form_studies] (form_studies)  VALUES(N'" + textBox8.Text + "')";

                        SqlCommand command7 = new SqlCommand(quary7, sqlConnection);
                        SqlDataReader reader7 = command7.ExecuteReader();
                        sqlConnection.Close();

                        // Кінець блоку пошуку та створення форми навчання 
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //// Початок блоку створення таблиці спеціальність
        {
            if ((textBox9.Text != "") && (textBox10.Text != "") && (textBox11.Text != "") && (textBox13.Text != "") && (textBox17.Text != "") && (textBox16.Text != "") && (textBox15.Text != ""))
            {
                string str = textBox16.Text;
                string str1 = textBox15.Text;
                try
                {
                    int p = Convert.ToInt32(str);
                    int c =Convert.ToInt32(str1);
                    int r = Convert.ToInt32(textBox9.Text);//Id_региона
                    int sity = Convert.ToInt32(textBox10.Text);//Id_міста
                    int u = Convert.ToInt32(textBox11.Text);//Id_університету
                    int fs = Convert.ToInt32(textBox13.Text);//id_форма навчання

                    String connectionString3 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
                    sqlConnection = new SqlConnection(connectionString3);
                    sqlConnection.Open();
                    // SqlDataReader sqlReader8 = null;
                    string quary8 = "INSERT INTO [Specialties] (specialties,Id_region,id_sity,id_form_studies,id_university,prise,competition)VALUES((N'" + textBox17.Text + "'),(@r),(@sity),(@fs),(@u),(@p),(@c))";
                    SqlCommand command8 = new SqlCommand(quary8, sqlConnection);
                    command8.Parameters.Add("@p", p);
                    command8.Parameters.Add("@c", c);
                    command8.Parameters.Add("@r", r);
                    command8.Parameters.Add("@sity ", sity);
                    command8.Parameters.Add("@u", u);
                    command8.Parameters.Add("@fs ", fs);
                    textBox16.Clear(); textBox15.Clear(); textBox9.Clear(); textBox10.Clear(); textBox11.Clear(); textBox13.Clear(); textBox17.Clear(); textBox4.Clear(); textBox5.Clear(); textBox7.Clear(); textBox8.Clear(); textBox6.Clear();
                    SqlDataReader reader8 = command8.ExecuteReader();
                    sqlConnection.Close();

                    MessageBox.Show("Спеціальність створюється");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("не число в полі ціна та конкурс");
                }
                {
                   // int p = Convert.ToInt32(textBox16.Text);//Ціна в рік
                    //int c = Convert.ToInt32(textBox15.Text);//Конкурс людей на місце
                   
                 }
               

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox9.Text != "") && (textBox10.Text != "") && (textBox11.Text != "") && (textBox13.Text != "") && (textBox17.Text != "") && (textBox16.Text != "") && (textBox15.Text != "") && (textBox18.Text != ""))
            {
                try
                {
                    int p = Convert.ToInt32(textBox16.Text);//Ціна в рік
                    int c = Convert.ToInt32(textBox15.Text);//Конкурс людей на місце
                    int r = Convert.ToInt32(textBox9.Text);//Id_региона
                    int sity = Convert.ToInt32(textBox10.Text);//Id_міста
                    int u = Convert.ToInt32(textBox11.Text);//Id_університету
                    int fs = Convert.ToInt32(textBox13.Text);//id_форма навчання
                    int sp = Convert.ToInt32(textBox18.Text);//id_спеціальність
                    String connectionString4 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
                    sqlConnection = new SqlConnection(connectionString4);
                    sqlConnection.Open();
                    //  SqlDataReader sqlReader9 = null;
                    String quary9 = "UPDATE [specialties] SET [specialties]=@spe,[Id_region]=@r,[id_sity]=@sity,[id_form_studies]=@fs,[id_university]=@u,[prise]=@p,[competition]=@c WHERE [id_specialties]=@sp";
                    SqlCommand command9 = new SqlCommand(quary9, sqlConnection);
                    command9.Parameters.Add("@spe", textBox17.Text);
                    command9.Parameters.Add("@p", p);
                    command9.Parameters.Add("@c", c);
                    command9.Parameters.Add("@r", r);
                    command9.Parameters.Add("@sity ", sity);
                    command9.Parameters.Add("@u", u);
                    command9.Parameters.Add("@fs ", fs);
                    command9.Parameters.Add("@sp", sp);
                    SqlDataReader reader9 = command9.ExecuteReader();
                    sqlConnection.Close();
                    textBox16.Clear(); textBox15.Clear(); textBox9.Clear(); textBox10.Clear(); textBox11.Clear(); textBox13.Clear(); textBox17.Clear(); textBox4.Clear(); textBox5.Clear(); textBox7.Clear(); textBox8.Clear(); textBox6.Clear();
                    MessageBox.Show("Дані змінені");
                }
                catch
                {
                 MessageBox.Show("не число в полі ціна та конкурс");

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox18.Text != "")
            {//Видалення
                int sp = Convert.ToInt32(textBox18.Text);//id_спеціальність
                String connectionString4 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Институт\5семестр\Базы данных+групповая динамика\Бази даних\Курсовий проект\University\UniversityP.mdf; Integrated Security=True";
                sqlConnection = new SqlConnection(connectionString4);
                sqlConnection.Open();
                //  SqlDataReader sqlReader10 = null;
                String quary10 = "DELETE FROM [Specialties] WHERE [id_specialties]=@sp";
                SqlCommand command10 = new SqlCommand(quary10, sqlConnection);
                command10.Parameters.Add("@sp ", sp);
                SqlDataReader reader10 = command10.ExecuteReader();
                textBox18.Clear();
                 sqlConnection.Close();
            }

        }//Кінець блоку видалення.
        //Блок друку
        Bitmap bmp;

        //CurrentChangedEventManager Page++;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printDocument2.DefaultPageSettings.Landscape = true;
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        

       
    }
}
    
 



       