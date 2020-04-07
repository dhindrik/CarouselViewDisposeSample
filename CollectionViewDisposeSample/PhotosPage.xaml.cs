using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewDisposeSample
{
    public partial class PhotosPage
    {
        public PhotosPage()
        {
            InitializeComponent();
        }

        public ObservableCollection<string> Items { get; set; }

        public void LoadData()
        {
            var images = new List<string>();


                images.Add("photo_1.jpg");
                images.Add("photo_2.jpg");
                images.Add("photo_3.jpg");
                images.Add("photo_4.jpg");
                images.Add("photo_5.jpg");


            Items = new ObservableCollection<string>(images);
            Photos.ItemsSource = Items;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            LoadData();
        }

        public int PageId
        {
            get;set;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Shell.Current.GoToAsync("//main");
        }
    }
}
