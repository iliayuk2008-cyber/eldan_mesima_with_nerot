namespace eldan_mesima_with_nerot
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            NameEntry.Text = "";
            AgeEntry.Text = "";
            ResultLabel.Text = "Enter your details";
        }

        private async void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue >= 0.5)
            {
                string name = NameEntry.Text;
                int age;

                if (int.TryParse(AgeEntry.Text, out age))
                {
                    await Navigation.PushAsync(new SecondPage(name, age));
                }
                else
                {
                    ResultLabel.Text = "Please enter a valid age";
                }
            }
        }
    }
}