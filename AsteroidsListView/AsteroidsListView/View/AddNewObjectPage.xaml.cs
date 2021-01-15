using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AsteroidsListView.Models;
using Xamarin.Essentials;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace AsteroidsListView.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class AddNewObject : ContentPage
    {
        ObservableCollection<SpaceObject> oCollection;

        public AddNewObject()
        {
            InitializeComponent();
        }

        public AddNewObject(SpaceObject m, ObservableCollection<SpaceObject> collection)
        {
            InitializeComponent();
            PageViewModel pvm = new PageViewModel(m);
            BindingContext = pvm;
            oCollection = collection;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            oCollection.Add((BindingContext as PageViewModel).ToSpaceObject());
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }

    public partial class PageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PageViewModel(SpaceObject o)
        {
            Name = o.Name;
            Type = o.Type;
            Age = (int)o.Age;
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        string _Type;
        public string Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Type"));
            }
        }

        int _Age;
        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public SpaceObject ToSpaceObject()
        {
            SpaceObject o = new SpaceObject
            {
                Name = this.Name,
                Type = this.Type,
                Age = this.Age
            };

            return o;
        }
    }

    
}