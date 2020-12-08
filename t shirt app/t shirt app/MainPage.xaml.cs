using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t_shirt_app;
using Xamarin.Forms;
using SQLite;
using System.IO;

namespace t_shirt_app
{
    public partial class MainPage : ContentPage
    {
       public  OrderingApp customer;
        userdatabase thando = new userdatabase();


        public MainPage()
        {
            InitializeComponent();
        }

        private void savebutton_Clicked(object sender, EventArgs e)
        {
            customer = new OrderingApp();

            customer.DateofTransaction = DateTime.Now;
            customer.Name = NameEntry.Text;
            customer.Gender = genderName.Text;
            customer.TshirtSize = size.Text;
            customer.TshirtColor = colorName.Text;
            customer.ShipppingAddress = addressname.Text;
            
            thando.addorder(NameEntry.Text, genderName.Text, size.Text, colorName.Text, addressname.Text);
                
            var page = new Page1(customer);

            Navigation.PushAsync(page);

        }
         

        }
        
       
}
           




            



            










