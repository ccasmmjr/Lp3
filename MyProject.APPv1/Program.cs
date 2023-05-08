using Microsoft.IdentityModel.Tokens;
using Myprojec.MODEL;
using MyProject.BLL;
using System.Collections;

namespace MyProject.APPv1
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            String status1 = "execucao";
            String status2 = "finalizado";
            String status3 = "cancelado";
            List<Status> list = new List<Status>();
            list=StatusRepository.getAll();
            if (list.IsNullOrEmpty()){
                Status stas1 = new Status(status1);
                Status stas2 = new Status(status2);
                Status stas3 = new Status(status3);
                StatusRepository.Add(stas1);
                StatusRepository.Add(stas2);
                StatusRepository.Add(stas3);
            }
            ApplicationConfiguration.Initialize();

            Application.Run(new Form1());

        }
    }
}