using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Курсовой_проект
{
    public partial class Auth : Form
    {
        public Auth()
            //Запуск
        {
            InitializeComponent();
            if (Additions.testconnection())
                //Проверка БД
            {
                radioButton2.Checked = true;
                radioButton2.Enabled = true;
                radioButton1.Checked = false;
                radioButton1.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = false;
            }
            if(Directory.Exists(@"Documents") && Directory.Exists(@"Documents\Signed") && Directory.Exists(@"Documents\Unsigned"))
            {
                //Проверка директорий
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Продолжить работу, создав необходимые директории?", "Внимание, необнаружены директории!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(@"Documents");
                        Directory.CreateDirectory(@"Documents\Signed");
                        Directory.CreateDirectory(@"Documents\Unsigned");
                    }
                    catch(Exception error)
                    {
                        Additions.ErrorLogs(error);
                    }
                }
                else
                {
                    MessageBox.Show("Программа будет закрыта!");
                    Close();
                }
            }
            GlobalVars.intchecked = false;
        }


        [DllImport("advapi32.dll")]
        public static extern bool LogonUser(string name, string domain, string pass, int logType, int logpv, ref IntPtr pht);

        
        private void Textbox2_Changed(Object sender, EventArgs e)
            //debug form
        {
            try
            {
                string login = textBox1.Text, pass = textBox2.Text;
                if (login == "admin" && pass == "1234")
                {
                    Hide();
                    GlobalForms.DebugForm().ShowDialog();
                    this.Close();
                }
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }



        private void button2_Click(object sender, EventArgs e)
            //Выход
        {
            try
            {
                File.Delete(@"runconf.txt");
                Application.Exit();
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }

        public static string loginbd, hexbd;
        public static int triesdb = 0;
        private void button1_Click(object sender, EventArgs e)
        // Авторизация
        {
            try
            {
                IntPtr th = IntPtr.Zero;
                string loging = textBox1.Text, passg = textBox2.Text, hexedg = Additions.GetSHA256(textBox3.Text);
                bool log = LogonUser(loging, "workspace", passg, 2, 0, ref th);
                string sql = "SELECT * FROM  `Users` WHERE  `User` LIKE  '" + loging +
                    "' AND  `Pass` LIKE  '" + passg +
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
                try
                {
                    if (loging == loginbd && hexedg == hexbd && log == true)
                    {
                        GlobalVars.GlobalUser = loging;
                        try
                        {
                            MessageBox.Show("Авторизация удалась!\nДобро пожаловать, " + loging);
                            Additions.globallog("Пользователь авторизован");
                            string timenow = DateTime.Now.ToString();
                            string sql2 = ("UPDATE  `dekanat`.`Users` SET  `LastLogin` =  '" + timenow + "' WHERE  `Users`.`User` ='" + GlobalVars.GlobalUser + "';");
                            MySqlConnection conn2 = new MySqlConnection(GlobalVars.dbconnect());
                            MySqlCommand sqlcom2 = new MySqlCommand(sql2, conn2);
                            conn2.Open();
                            sqlcom2.ExecuteNonQuery();
                            conn2.Close();
                            this.Hide();
                            Additions.usersgroup(loginbd, hexbd);
                            Close();
                        }
                        catch (MySqlException)
                        {
                            result.Close();
                            connection.Close();
                            MessageBox.Show("Неверно заданы параметры вашей учетной записи\nОбратитесь к администратору!");
                            Additions.globallog("Неуспешная попытка авторизации пользователя!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Авторизация неуспешна!\nНе найден пользователь с такой парой логин/пароль.");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        Additions.globallog("Неуспешная попытка авторизации пользователя!");
                    }
                }
				catch (MySqlException error)
				{
					result.Close();
					connection.Close();
					Additions.ErrorLogs(error);
                    MessageBox.Show("Потеряна связь с базой данных.\nПриносим извинения за временные неудобства.");
                }
                catch (Exception error)
                {
                    Additions.ErrorLogs(error);
                }
            }
            catch (MySqlException)
            {
                Additions.globallog("Неверный секртеный пароль");
                MessageBox.Show("Неверный секретный пароль!!!");
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
            //Проверка БД по таймеру
        {
            if (Additions.testconnection())
            {
                radioButton2.Checked = true;
                radioButton2.Enabled = true;
                radioButton1.Checked = false;
                radioButton1.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
            //Регистрация
        {
            try
            {
                GlobalVars.GlobalUser = "Non_Registered";
                Hide();
                Register RegisterForm = new Register();
                RegisterForm.ShowDialog();
                this.Close();
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }
    }
}

