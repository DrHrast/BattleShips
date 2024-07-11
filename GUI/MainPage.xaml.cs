using Battleship.GUI;
using GUI.Views;

namespace GUI
{
    public partial class MainPage : ContentPage
    {
        private int rows = 10;
        private int columns = 10;
        private List<int> ints = new() {7, 8, 9, 10, 11, 12};

        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            rowPicker.ItemsSource = ints;
            columnPicker.ItemsSource = ints;
            rowPicker.SelectedIndex = 3;
            columnPicker.SelectedIndex = 3;
        }

        private async void startButton_Clicked(object sender, EventArgs e)
        {
            int rows = ints[rowPicker.SelectedIndex];
            int columns = ints[columnPicker.SelectedIndex];
            await Navigation.PushAsync(new GamePage(rows, columns));
        }
    }
}