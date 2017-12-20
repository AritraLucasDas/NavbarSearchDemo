using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavbarSearchDemo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavbarSearchDemo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this,false);
		    BindingContext = new SearchPageViewModel();
		}
	}
}