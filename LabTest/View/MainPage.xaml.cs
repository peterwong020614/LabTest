namespace LabTest
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            slider1 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 100, // Set the initial value based on the image you provided.
                MinimumTrackColor = Colors.Blue,
                MaximumTrackColor = Colors.Gray,
                ThumbColor = Colors.Pink,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center
            };

            label1 = new Label
            {
                Text = slider1.Value.ToString(), // Set the initial text to the slider's value
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            // Initialize the result label
            label2 = new Label
            {
                Text = "Excellent", // Set the initial text based on the slider's initial value.
                TextColor = Colors.Green, // Initial color based on the value.
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Subscribe to the ValueChanged event of the slider
            slider1.ValueChanged += OnSliderValueChanged;
            var stackLayout = new StackLayout
            {
                
                VerticalOptions = LayoutOptions.Center,
                
            Children = { slider1, label1, label2 }
            };

            Content = stackLayout;
        }
        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = String.Format("{0:F0}", e.NewValue);
           
            if (e.NewValue < 40)
            {
                label2.Text = "Failed";
                label2.TextColor = Colors.Red;
            }
            else if (e.NewValue < 80)
            {
                label2.Text = "Passed";
                label2.TextColor = Colors.Black;
            }
            else
            {
                label2.Text = "Excellent";
                label2.TextColor = Colors.Green;
            }
        }

        

    }
    
}
