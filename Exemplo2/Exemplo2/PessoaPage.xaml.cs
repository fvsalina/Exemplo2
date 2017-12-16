using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplo2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PessoaPage : ContentPage
	{
		public PessoaPage ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var pessoa = (Pessoa)BindingContext;
            await App.DataBase.SaveItemAsync(pessoa);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var pessoa = (Pessoa)BindingContext;
            await App.DataBase.DeleteItemAsync(pessoa);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

   
    }
}