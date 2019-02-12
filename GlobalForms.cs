using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект
{
    class GlobalForms
    {
        public static Admin AdminForm()
        {
            Admin AdminForm = new Admin();
            AdminForm.ShowDialog();
            return AdminForm;
        }

        public static Auth AuthForm()
        {
            Auth AuthForm = new Auth();
            AuthForm.ShowDialog();
            return AuthForm;
        }    
        
        public static Student StudentForm()
        {
            Student StudentForm = new Student();
            StudentForm.ShowDialog();
            return StudentForm;
        }  

        public static Register RegisterForm()
        {
            Register RegisterForm = new Register();
            RegisterForm.ShowDialog();
            return RegisterForm;
        }

        public static Staff StaffForm()
        {
            Staff StaffForm = new Staff();
            StaffForm.ShowDialog();
            return StaffForm;
        }

        public static Debug DebugForm()
        {
            Debug DebugForm = new Debug();
            DebugForm.ShowDialog();
            return DebugForm;
        }

        public static ErrorBox ErrorBoxForm()
        {
            ErrorBox ErrorBoxForm = new ErrorBox();
            ErrorBoxForm.ShowDialog();
            return ErrorBoxForm;
        }

        public static Checking CheckForm()
        {
            Checking CheckForm = new Checking();
            CheckForm.ShowDialog();
            return CheckForm;
        }
    }
}
