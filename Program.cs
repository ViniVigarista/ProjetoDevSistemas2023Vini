using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Globalization;

namespace ProjetoDevSistemas2023Vini;

   
    internal static class Program
    {
    internal static readonly char currencySymbol;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
        static void Main()
        {

            string? auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);

            
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new telaInicial());

        }
    }
