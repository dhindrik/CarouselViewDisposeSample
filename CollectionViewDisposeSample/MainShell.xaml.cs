using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CollectionViewDisposeSample
{
    public partial class MainShell
    {
        public MainShell()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            GoToAsync("//photos?id=1");
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            GoToAsync("//photos?id=2");
        }
    }
}
