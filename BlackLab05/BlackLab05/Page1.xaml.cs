using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlackLab05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout();

            Label label = new Label();

            label.Text = "Black";
            label.BackgroundColor= Color.Blue;


            
            stackLayout.Children.Add(label);

            for(int i = 0;i < 5; i++)
            {
                Button button = new Button();
                button.Text = "Eduardo";
                button.BackgroundColor = Color.Green;
                stackLayout.Children.Add(button);
            }


            this.Content= stackLayout;
        }
    }
}