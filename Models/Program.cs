using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using StudentManagementSystemApp.View;
using System.Data;

namespace StudentManagementSystemApp.Models
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=deneme1;Uid=root;Pwd=123456");
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            DataTable dt;
        }
    }
}