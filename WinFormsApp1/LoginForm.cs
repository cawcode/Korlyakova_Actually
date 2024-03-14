using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public static LoginForm insertTransactions = null;
        public int driver_id = 0;

        public LoginForm()
        {
            InitializeComponent();
            insertTransactions = this;
        }

        MySqlConnection conn = new MySqlConnection("server=90.156.226.116;port=3306;username=cygvincev;" +
                                            "password=flamingo74@@;database=lionfish;");
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                string queryString = "SELECT * FROM users WHERE user_login = '" + textBoxUsername.Text +
                    "' AND user_psswd = '" + textBoxPassword.Text + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if ((int)reader["role_id"] == 2)
                    {
                        dispForm dpForm = new dispForm();
                        this.Hide();
                        dpForm.Show();
                    }
                    else if ((int)reader["role_id"] == 3)
                    {
                        int user_id = (int)reader["user_id"];
                        reader.Close();
                        queryString = "SELECT * FROM drivers WHERE user_id = '" + user_id + "';";
                        cmd = new MySqlCommand(queryString);
                        cmd.Connection = conn;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            driver_id = (int)reader["driver_id"];
                        }
                        reader.Close();


                        driverForm drForm = new driverForm(driver_id);
                        this.Hide();
                        drForm.Show();
                    }
                    else { MessageBox.Show("Ошибка авторизации."); }
                }
                else { MessageBox.Show("Неверный логин или пароль."); }
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
