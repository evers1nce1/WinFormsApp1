using System.Text;

namespace WinFormsApp1
{
    class Program
    {
        [STAThread]
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            LoginForm MainForm = new LoginForm();
            Application.Run(MainForm);
        }
    }
}