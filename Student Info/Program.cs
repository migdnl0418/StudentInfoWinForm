using Student_Info.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Info
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://studentinfoapi-7lpw.onrender.com/api/students");
                httpClient.Timeout = TimeSpan.FromSeconds(30);

                IStudentDataServices studentDataServices = new StudentAPIService(httpClient);
                Application.Run(new Form1(studentDataServices));
            }
        }
    }
}
