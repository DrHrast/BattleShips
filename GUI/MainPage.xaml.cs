namespace GUI
{
    public partial class MainPage : ContentPage
    {
        int rows, columns = 5;

        public MainPage()
        {
            InitializeComponent();
            DrawGrid(rows, columns);
        }

        private void DrawGrid(int rows, int columns)
        {
            for (int i = 0; i < int.Max(rows, columns); i++)
            {
                
            }
        }
    }
}
