using System;
using System.IO;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Admin : Form
    {
        public Admin()
            //Инициализация + БД
        {
            InitializeComponent();
            label1.Text = GlobalVars.globalusergroup + ": " + GlobalVars.GlobalUser;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            toolTip1.SetToolTip(button3, "В данный момент изменение данных только через веб-интерфейс.\nОжидайте обновлений! Кнопка \"Открыть в браузере\"");
            toolTip2.SetToolTip(button2, "В браузере откроется страница для редактирования данных!");
            if (Additions.testconnection())
            {
                radioButton2.Checked = true;
                radioButton2.Enabled = true;
                radioButton1.Checked = false;
                radioButton1.Enabled = false;
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
            //Выход
        {
            try
            {
                Additions.globallog("Пользователь вышел из программы");
                Hide();
                File.Delete(@"runconf.txt");
                GlobalForms.AuthForm();
                this.Close();
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }


        private void Admin_Load(object sender, EventArgs e)
            //Подключение БД
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSetusers.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter1.Fill(this.dekanatDataSetusers.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSetus.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dekanatDataSetus.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSeterr.ErrorLog". При необходимости она может быть перемещена или удалена.
            this.errorLogTableAdapter.Fill(this.dekanatDataSeterr.ErrorLog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSetlog.Log". При необходимости она может быть перемещена или удалена.
            this.logTableAdapter.Fill(this.dekanatDataSetlog.Log);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.logTableAdapter.FillBy(this.dekanatDataSetlog.Log);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
            //Открытие БД в браузере
        {
            Additions.globallog("Администратор открыл БД в браузере");
            DialogResult dialogResult = MessageBox.Show("Открыть ссылку в браузере по умолчанию?", "Внимание, внешняя ссылка!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://192.168.0.34/phpmyadmin/#PMAURL-1:db_structure.php?db=dekanat&table=&server=1&target=&token=70bcc62bd16edc4ad83d55f1cfb2de3a");
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        public void button4_Click(object sender, EventArgs e)
            //Обновление формы(перезагрузка)
        {
            Hide();
            GlobalForms.AdminForm();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
            //Очистка логов
        {
            Additions.tableclear("Log");
            Hide();
            GlobalForms.AdminForm();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
            //Очистка ошибок
        {
            Additions.tableclear("ErrorLog");
            Hide();
            GlobalForms.AdminForm();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Additions.DBIntegrityGen();
        }
    }
}
