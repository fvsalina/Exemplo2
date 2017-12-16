using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Exemplo2
{
	public partial class App : Application
	{
        private static PessoaItemDatabase dataBase;
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Exemplo2.MainPage());
		}

        internal static PessoaItemDatabase DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new PessoaItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("PessoaSQLite.db3"));
                }
                return dataBase;
            }
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
