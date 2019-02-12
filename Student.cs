using System;
using System.IO;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            label1.Text = GlobalVars.globalusergroup + ": " + GlobalVars.GlobalUser;
            treeView1.Nodes.Clear();
            ScanDir(@"Documents\Signed", treeView1.Nodes);
        }
        public void ScanDir(string path, TreeNodeCollection node)
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


        private void button2_Click(object sender, System.EventArgs e)
            //ВЫход
        {

            File.Delete(@"runconf.txt");
            Additions.globallog("Пользователь вышел из программы");
            Hide();
            GlobalForms.AuthForm();
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
            //Открыть файл
        {
            try
            {
                System.Diagnostics.Process.Start(@"Documents\Signed" + treeView1.SelectedNode.FullPath);
            }
            catch(Exception error)
            {
                Additions.ErrorLogs(error);
            }
        }
    }
}
