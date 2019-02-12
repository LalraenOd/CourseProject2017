using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace Курсовой_проект
{
    class Additions
    {

        public static void ErrorLogs(Exception error)
        //Вывод ошибок
        {
            try
            {
                MySqlConnection conn3 = new MySqlConnection(GlobalVars.dbconnect());
                string currenttime = DateTime.Now.ToString();
                string sqlglobalerrors = ("INSERT INTO `dekanat`.`ErrorLog` (`ErrorID`, `Time`, `CurrentUser`, `ErrorLog`)" +
                    " VALUES (NULL, '" + currenttime +
                    "', '" + GlobalVars.GlobalUser +
                    "', '" + error + "');");
                MySqlCommand sqlglcom = new MySqlCommand(sqlglobalerrors, conn3);
                conn3.Open();
                sqlglcom.ExecuteNonQuery();
                conn3.Close();
                globallog("Возникла ошибка. Подробности в таблице ErrorLog!!!");
            }
            catch (MySqlException)
            {
                GlobalVars.NotException = error.ToString();
                GlobalForms.ErrorBoxForm().Show();
            }
        }

        public static void globallog(string action)
        //Журналирование
        {
            try
            {
                MySqlConnection conn2 = new MySqlConnection(GlobalVars.dbconnect());
                string currenttime = DateTime.Now.ToString();
                string sqlgloballlog = ("INSERT INTO `dekanat`.`Log` (`ActionID`, `Time`, `CurrentUser`, `Action`)" +
                    " VALUES (NULL, '" + currenttime +
                    "', '" + GlobalVars.GlobalUser +
                    "', '" + action + "');");
                MySqlCommand sqlglcom = new MySqlCommand(sqlgloballlog, conn2);
                conn2.Open();
                sqlglcom.ExecuteNonQuery();
                conn2.Close();
            }
            catch (Exception error)
            {
                ErrorLogs(error);
            }
        }

        public static void tableclear(string table)
        //Очистка таблицы БД
        {
            try
            {
                MySqlConnection conn3 = new MySqlConnection(GlobalVars.dbconnect());
                string sqlclear = ("TRUNCATE TABLE  `" + table + "`");
                MySqlCommand sqlglcom = new MySqlCommand(sqlclear, conn3);
                conn3.Open();
                sqlglcom.ExecuteNonQuery();
                globallog("Администратор очистил таблицу " + table);
                conn3.Close();
            }
            catch (Exception error)
            {
                ErrorLogs(error);
            }
        }

        public static string GetSHA256(string texttohex)
        //Хэш
        {
            byte[] hashValue;
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(System.Text.Encoding.UTF8.GetBytes(texttohex));
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }

        public static void debug(string texttofile)
        //Текст в файл дебага
        {
            using (StreamWriter outputFile = new StreamWriter("Debug.txt", true))
            {
                outputFile.WriteLine("Время события: " + DateTime.Now);
                outputFile.WriteLine(texttofile);
                outputFile.WriteLine();
            }
        }

        public static bool testconnection()
        //Проверка свзяи с БД

        {
            MySqlConnection conn = new MySqlConnection(GlobalVars.dbconnect());
            bool testconnect = false;
            try
            {
                conn.Open();
                testconnect = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                conn.Close();
                testconnect = false;
            }
            catch (Exception error)
            {
                ErrorLogs(error);
            }
            return testconnect;
        }

        public static void sqlquery(string sqltext)
        //Запрос на добавление
        {
            try
            {
                MySqlConnection conn1 = new MySqlConnection(GlobalVars.dbconnect());
                MySqlCommand sqlcom = new MySqlCommand(sqltext, conn1);
                conn1.Open();
                sqlcom.ExecuteNonQuery();
                conn1.Close();
            }
            catch (Exception error)
            {
                ErrorLogs(error);
            }
        }

        public static void usersgroup(string loging, string hexedg)
        //Группа пользователей
        {
            string sqlgroup = "SELECT * FROM  `Users` WHERE  `User` LIKE  '" + loging +
                    "' AND  `Passhex` LIKE  '" + hexedg +
                    "' LIMIT 0, 1;";
            MySqlConnection connection = new MySqlConnection(GlobalVars.dbconnect());
            MySqlCommand sqlcom = new MySqlCommand(sqlgroup, connection);
            connection.Open();
            MySqlDataReader result = sqlcom.ExecuteReader();
            result.Read();
            string group = result["UsersGroup"] + "";
            GlobalVars.globalusergroup = group;
            DBIntegrityCheck();
            System.Threading.Thread.Sleep(300);
            if (GlobalVars.globalusergroup == "Administrators")
            {
                GlobalForms.AdminForm();
            }
            else if (GlobalVars.globalusergroup == "Students" && GlobalVars.intchecked)
            {
                GlobalForms.StudentForm();
            }
            else if (GlobalVars.globalusergroup == "Head" && GlobalVars.intchecked || GlobalVars.globalusergroup == "Staff" && GlobalVars.intchecked)
            {
                GlobalForms.StaffForm();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Обнаруженна непредвиденная ошибка! Программа будет закрыта!");
                globallog("Непредиденная ошибка. Неверная группа пользователя (авторизация)!");
                GlobalForms.AuthForm().Close();
            }

        }

        public static void DBIntegrityGen()
            //Генерация целостности
        {
            try
            {
                File.Delete("DBintegrity.txt");
                string sql = "SELECT * FROM  `Users`";
                MySqlConnection connection = new MySqlConnection(GlobalVars.dbconnect());
                MySqlCommand sqlcom = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader result = sqlcom.ExecuteReader();
                while (result.Read())
                {
                    string loginbd = result["User"] + "";
                    string hexbd = result["Passhex"] + "";
                    using (StreamWriter outputFile = new StreamWriter("DBintegrity.txt", true))
                    {
                        outputFile.WriteLine(loginbd);
                        outputFile.WriteLine(hexbd);
                    }
                }
                connection.Close();
            }
            catch(Exception error)
            {
                ErrorLogs(error);
            }
        }

        public static bool DBIntegrityCheck()
            //Проверка целостности БД
        {
            try
            {
                string sql = "SELECT * FROM  `Users`";
                MySqlConnection connection = new MySqlConnection(GlobalVars.dbconnect());
                MySqlCommand sqlcom = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader result = sqlcom.ExecuteReader();
                while (result.Read())
                {
                    string loginbd = result["User"] + "";
                    string hexbd = result["Passhex"] + "";
                    using (StreamWriter outputFile = new StreamWriter("DBintegrityTEMP.txt", true))
                    {
                        outputFile.WriteLine(loginbd);
                        outputFile.WriteLine(hexbd);
                    }
                }
                connection.Close();
            }
            catch (Exception error)
            {
                ErrorLogs(error);
            }     
            if(FileCompare("DBintegrity.txt", "DBintegrityTEMP.txt"))
            {
                GlobalVars.intchecked = true;
            }
            else
            {
                GlobalVars.intchecked = false;
            }
            File.Delete("DBintegrityTEMP.txt");
            return GlobalVars.intchecked;
        }

        public static bool FileCompare(string file1, string file2)
            //Сравнение файлов
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2)
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((file1byte - file2byte) == 0);
        }
    }
}
