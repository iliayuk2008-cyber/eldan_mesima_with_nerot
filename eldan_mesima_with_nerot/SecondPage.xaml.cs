namespace eldan_mesima_with_nerot
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage(string name, int age)
        {
            InitializeComponent();

            int candleCount = age + 10;

            ResultLabel.Text =
                $"Your name is {name}, in 10 years you will be {candleCount} years old";

            for (int i = 0; i < candleCount; i++)
            {
                Image candle = new Image
                {
                    Source = "candle.png",
                    WidthRequest = 40,
                    HeightRequest = 70,
                    Margin = 5,
                    Aspect = Aspect.AspectFit
                };

                CandlesLayout.Children.Add(candle);
            }
        }
    }
}