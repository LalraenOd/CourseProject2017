using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Checking : Form
    {
        public Checking()
        {
            InitializeComponent();
            textBox1.Text = GlobalVars.GlobalUser;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loginbd, hexbd, hexedg = Additions.GetSHA256(textBox2.Text);
                string sql = "SELECT * FROM  `Users` WHERE  `User` LIKE  '" + GlobalVars.GlobalUser +
                     "' AND  `Passhex` LIKE  '" + hexedg +
                     "' LIMIT 0, 1;";
                MySqlConnection connection = new MySqlConnection(GlobalVars.dbconnect());
                MySqlCommand sqlcom = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader result = sqlcom.ExecuteReader();
                result.Read();
                loginbd = result["User"] + "";
                hexbd = result["Passhex"] + "";
                result.Close();
                connection.Close();
                if (loginbd == GlobalVars.GlobalUser && hexbd == hexedg)
                {
                    GlobalVars.secondauth = true;
                    Close();
                }
            }
            catch (MySqlException)
            {
                Additions.globallog("Неверный секртеный пароль");
                MessageBox.Show("Неверный секретный пароль!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVars.secondauth = false;
            Close();
        }

        
    }
}
