
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Demo.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageMainMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailPageMainMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPageMainMasterViewModel(MenuItemsListView);
            ListView = MenuItemsListView;
        }

        class MasterDetailPageMainMasterViewModel
        {
            public ObservableCollection<MasterDetailPageMainMasterMenuItem> MenuItems { get; set; }

            public ListView MenuItemsListView { get; set; }

            public MasterDetailPageMainMasterViewModel(ListView _MenuItemsListView)
            {
                MenuItemsListView = _MenuItemsListView;
                MenuItems = new ObservableCollection<MasterDetailPageMainMasterMenuItem>(new[]
                {
                    new MasterDetailPageMainMasterMenuItem { Id = 0, Title = "Main Page",  TargetType = typeof(MainPage) },
                    new MasterDetailPageMainMasterMenuItem { Id = 1, Title = "Second page", TargetType = typeof(SecondPage) },
                    new MasterDetailPageMainMasterMenuItem { Id = 2, Title = "ThurdPage", TargetType = typeof(ThirdPage) },
                });

                MenuItemsListView.ItemSelected += MenuItemsListView_ItemSelected;
            }

            private void MenuItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItemIndex != -1)
                {
                    foreach (var item in MenuItems)
                    {
                        if (item.Id == e.SelectedItemIndex)
                        {
                            item.isActive = false;
                        }
                        else
                        {
                            item.isActive = true;
                        }
                    }
                }
            }
        }
    }
}