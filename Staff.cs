using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Staff : Form
    {
        public void ScanDir(string path, TreeNodeCollection node)
            //Сканирование директории
        {

            DirectoryInfo directory = new DirectoryInfo(path);

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                TreeNode tn = new TreeNode(dir.Name);
                ScanDir(dir.FullName, tn.Nodes);
                node.Add(tn);
            }

            foreach (FileInfo fi in directory.GetFiles())
            {
                TreeNode tn = new TreeNode(fi.Name);
                node.Add(tn);
            }
        }
        public Staff()
            //Инициализация компонента
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            ScanDir(@"Documents", treeView1.Nodes);
            label1.Text = GlobalVars.globalusergroup + ": " + GlobalVars.GlobalUser;
            if (GlobalVars.globalusergroup == "Staff")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else if (GlobalVars.globalusergroup == "Head")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Обнаруженна непредвиденная ошибка! Программа будет закрыта!");
                Additions.globallog("Непредиденная ошибка. Неверная группа пользователя. Окно STAFF!");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
            //Обновить дерево
        {
            treeView1.Nodes.Clear();
            ScanDir(@"Documents", treeView1.Nodes);
        }

        private void button2_Click(object sender, EventArgs e)
            //Добавление файла
        {
            try
            {
                var OFD = new OpenFileDialog();
                OFD.Filter = "pdf files (*.pdf)|*.pdf";
                OFD.ShowDialog();
                string fileToCopy = OFD.FileName;
                var onlyFileName = Path.GetFileName(OFD.FileName);
                Additions.globallog("Пользователем " + GlobalVars.GlobalUser + " добавлен файл " + onlyFileName);
                string newLocation = @"Documents\Unsigned\" + onlyFileName;
                File.Move(fileToCopy, newLocation);
                MessageBox.Show("Файл успешно добавлен");
                treeView1.Nodes.Clear();
                ScanDir(@"Documents", treeView1.Nodes);
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
            //Выход
        {
            File.Delete(@"runconf.txt");
            Additions.globallog("Пользователь вышел из программы");
            Hide();
            GlobalForms.AuthForm();
            this.Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
            //Открыть файл
        {
            try
            {
                System.Diagnostics.Process.Start(@"Documents\" + treeView1.SelectedNode.FullPath);
            }
            catch (Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
            //Утвердить
        {
            try
            {
                string documentpath = @"Documents\" + treeView1.SelectedNode.FullPath;
                Additions.globallog("Утверждается документ: " + Path.GetFileName(documentpath));
                GlobalForms.CheckForm();
                if (GlobalVars.secondauth == true)
                {
                    if (File.Exists(documentpath))
                    {
                        DirectoryInfo dir = new DirectoryInfo(@"Documents\Signed\");
                        File.Move(documentpath, dir + Path.GetFileName(documentpath));
                        foreach (FileInfo files in dir.GetFiles())
                        Additions.globallog("Утвержден документ: " + Path.GetFileName(documentpath));
                        treeView1.Nodes.Clear();
                        ScanDir(@"Documents", treeView1.Nodes);
                    }
                    else
                    {
                        MessageBox.Show("Файл не обнаружен. Обратитесь к администратру!");
                    }
                }
                else
                {
                    Additions.globallog("Не утвержден документ: " + Path.GetFileName(documentpath));
                    GlobalForms.CheckForm();
                }
            }
            catch(Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }
    }
}