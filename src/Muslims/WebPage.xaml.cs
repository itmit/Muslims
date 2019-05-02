using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
    public partial class WebPage : ContentPage
    {
        public string WebviewSource { get; set; }
        public WebPage()
        {
            InitializeComponent();

        }
        public WebPage(string s)
        {
            InitializeComponent();
            WebviewSource = s;
            Title = "Web-страница";
            BindingContext = this;
        }
    }
}
