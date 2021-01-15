using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsteroidsListView.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsteroidsListView.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            CreateObjects pModel = new CreateObjects();
            BindingContext = pModel;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Page p = new AddNewObject(((((ListView)sender).SelectedItem) as SpaceObject), (BindingContext as CreateObjects).AllObjects);
            NavigationPage np = new NavigationPage(p);
            await Application.Current.MainPage.Navigation.PushAsync(np);

            if ((sender as ListView) != null)
                (sender as ListView).SelectedItem = null;
        }

    }
}