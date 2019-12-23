using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bug8970
{
    public class ViewModel
    {
        public IList<string> Images =>
            new List<string>()
            {
                "http://lorempixel.com/400/200/",
                "http://lorempixel.com/400/200/",
                "http://lorempixel.com/400/200/",
                "http://lorempixel.com/400/200/"
            };
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}