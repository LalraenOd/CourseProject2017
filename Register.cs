using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Курсовой_проект
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            toolTip1.SetToolTip(checkBox1, "Функция временно недоступна!");
            button1.Enabled = false;
            comboBox1.Items.Add("Administrators");
            comboBox1.Items.Add("Students");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Head");
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

        
        public void button1_Click(object sender, EventArgs e)
            //Регистрация
        {
            try
            {
                string existslog, login = textBox1.Text, pass1 = textBox2.Text, pass2 = textBox3.Text;
                string pass1hex = Additions.GetSHA256(textBox2.Text), pass2hex = Additions.GetSHA256(textBox3.Text), 
                        spass1hex = Additions.GetSHA256(textBox4.Text), spass2hex = Additions.GetSHA256(textBox5.Text);
                string email = textBox6.Text, surname = textBox7.Text, name = textBox8.Text, group = textBox9.Text;
                /*string sql = "SELECT * FROM  `Users` WHERE  `User` LIKE  '" + login +
                    "' LIMIT 0, 1;";
                MySqlConnection connection = new MySqlConnection(GlobalVars.dbconnect());
                MySqlCommand sqlcom = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader result = sqlcom.ExecuteReader();
                result.Read();
                existslog = result["User"] + "";
                result.Close();
                connection.Close();*/
                if (login.Length == 0 || pass1.Length == 0 || pass2.Length ==0 || spass1hex.Length == 0 || spass2hex.Length == 0 || email.Length == 0 || 
                    surname.Length == 0 || name.Length == 0 || group.Length == 0)
                {
                    try
                    {
                        MessageBox.Show("Не все необходимые поля заполнены!");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                    }
                    catch(Exception error)
                    {
                        Additions.ErrorLogs(error);
                    }
                }
                else /*if (login == existslog)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }

                else */if (pass1 != pass2 || spass1hex != spass2hex)
                {
                    try
                    {
                        MessageBox.Show("Пароль и подтверждение не совпадает!");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                   }
                    catch(Exception error)
                    {
                        Additions.ErrorLogs(error);
                    }
                }
                else if(pass1hex == spass1hex)
                    {
                    try
                    {
                        MessageBox.Show("Пароли для аутентификации и внутренней идентификации не могут совпадать!!!");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                    }
                    catch(Exception error)
                    {
                        Additions.ErrorLogs(error);
                    }
                    }
                else if(pass1.Length >= 4 || textBox4.TextLength >= 6)
                {
                    try
                    {
                        GlobalVars.GlobalUser = login;
                        MessageBox.Show("Заявка на регистрацию принята\nОжидайте ответа от администратора!");
                        string currenttime = DateTime.Now.ToString();
                        Additions.sqlquery("INSERT INTO `dekanat`.`Users` (`ID`, `User`, `Pass`, `Passhex`, `Email`, `Surname`, `Student_name`, `Student_group`, `UsersGroup`, `LastLogin`, `Registration`, `WinAcc`)" +
                            " VALUES (NULL, '" + login +
                            "', '" + pass1 +
                            "', '" + spass1hex +
                            "', '" + email +
                            "', '" + surname +
                            "', '" + name +
                            "', '" + group +
                            "', '" + comboBox1.Text +
                            "', '" + currenttime +
                            "', '" + currenttime + 
                            "', 'New');");
                        Additions.globallog("Запрос на регистрацию.");
                        if (checkBox1.Checked)
                        {
                            //тут надо отправить письмо
                        }
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        checkBox2.Checked = false;
                        checkBox2.Enabled = true;
                        button1.Enabled = false;
                        comboBox1.SelectedIndex = -1;
                        checkBox1.Checked = false;

                    }
                    catch (Exception error)
                    {
                        Additions.ErrorLogs(error);
                    }
                }
                else
                {
                    MessageBox.Show("Пароль недостаточной длины!!!");
                }
            }
            catch(Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }

        public void button2_Click(object sender, EventArgs e)
            //Очистка
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                checkBox2.Checked = false;
                checkBox2.Enabled = true;
                button1.Enabled = false;
            }
            catch(Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
            //Выход
        {
            try
            {
                Hide();
                GlobalForms.AuthForm().ShowDialog();
                this.Close();
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
            //Таймер на БД
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
    }
}
