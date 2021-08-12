using HotelManagement.Business;
using HotelManagement.DAO;
using HotelManagement.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using HotelManagement.View;
namespace HotelManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frLogin1());
        }
        
    }
}
