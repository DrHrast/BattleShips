namespace GUI.Views
{
    public class DrawGridView
    {
        public DrawGridView(int numberOfRows, int numberOfColumns)
        {
            this.numberOfRows = numberOfRows;
            this.numberOfColumns = numberOfColumns;
        }

        private int numberOfRows;
        private int numberOfColumns;

        public void DrawGrid(Grid targetGrid)
        {
            targetGrid.RowDefinitions.Clear();
            targetGrid.ColumnDefinitions.Clear();
            for (int i = 0; i < numberOfRows; i++)
            {
                targetGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            }
            for (int j = 0; j < numberOfColumns; j++)
            {
                targetGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            }

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfColumns; col++)
                {
                    Button button = new Button
                    {
                        Text = $"",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        BackgroundColor = Colors.LightGray,
                        BorderColor = Colors.Black,
                        BorderWidth = 1,
                        CornerRadius = 0,
                    };

                    button.Clicked += OnCellClicked;

                    targetGrid.Children.Add(button);
                    Grid.SetRow(button, row);
                    Grid.SetColumn(button, col);
                }
            }
        }

        public void OnCellClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackgroundColor = Colors.LightBlue;
                Application.Current.MainPage.DisplayAlert("Cell Clicked", $"Cell clicked", "OK");
                button.Clicked -= OnCellClicked;
            }
        }
    }
}
