using Xamarin.Forms;
namespace dotnettut
{
    public class MainPage : ContentPage
    {
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;
        public MainPage()
        {
            this.Padding = new Thickness(20, 20, 20, 20);

            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };

            panel.Children.Add(new Label
            {
                Text = "Enter a phoneword:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });
        }
    }
}
