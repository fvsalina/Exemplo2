using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exemplo2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.DataBase.GetItemsAsync();
        }

        public async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            if (e.SelectedItem != null)
            {
                 await Navigation.PushAsync(new PessoaPage
                 {
                     BindingContext = e.SelectedItem as Pessoa
                 });
            }
        }
        async void button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PessoaPage
            {
                BindingContext = new Pessoa()
            });
        }
    }
}

