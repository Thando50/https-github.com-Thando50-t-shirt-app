using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace t_shirt_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private OrderingApp _customer;

        public List<OrderingApp> Orders { get; set; }


        public Page1(OrderingApp customer)
        {
            InitializeComponent();
            var db = new userdatabase();
            Orders = db.GetItems();

            _customer = customer;

            BindingContext = this;
        }
    }
}