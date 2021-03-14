using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMaqueta.View
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            this.Title ="Select Option";
            StackLayout stack = new StackLayout();
            Button btn = new Button();
            btn.Text = "Add Compañia";
            btn.Clicked += Button_Clicked;
            stack.Children.Add(btn);
            
            Button btn1 = new Button();
            btn1.Text = "Get";
            btn1.Clicked += Button1_Clicked;
            stack.Children.Add(btn1);

            Button btn2 = new Button();
            btn2.Text = "Edit";
            btn2.Clicked += Button2_Clicked;
            stack.Children.Add(btn2);

            Button btn3 = new Button();
            btn3.Text = "Delete";
            btn3.Clicked += Button3_Clicked;
            stack.Children.Add(btn3);

            Button btn4 = new Button();
            btn4.Text = "SelectorDesple";
            btn4.Clicked += Button4_Clicked;
            stack.Children.Add(btn4);

            Content = stack;
        }
        private async void Button4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UsoCombobox());
        }


        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllCompanias());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCompany());
        }
        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditCompanyPage());
        }
        private async void Button3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteCompany());
        }
    }
}