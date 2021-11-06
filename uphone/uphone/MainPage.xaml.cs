using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace uphone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            CallPage callPage = new CallPage();
            callPage.Title = "call";

            OptionPage optionPage = new OptionPage();
            optionPage.Title = "option";

            Children.Add(callPage);
            Children.Add(optionPage);
            //InitializeComponent();
        }

        protected override bool OnBackButtonPressed() => true;
    }
}
