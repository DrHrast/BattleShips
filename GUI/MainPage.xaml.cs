using Microsoft.Maui.Controls;
using System;

namespace GUI
{
    public partial class MainPage : ContentPage
    {
        private int rows = 10;
        private int columns = 10;

        public MainPage()
        {
            InitializeComponent();
            inputRowCol();
            DrawGrid(enemyGrid, rows, columns);
            DrawGrid(friendlyGrid, rows, columns);
            applyGridChanges.Clicked += OnApplyGridChangesClicked;
        }

        private void OnApplyGridChangesClicked(object sender, EventArgs e)
        {
            inputRowCol();
            enemyGrid.Children.Clear();
            friendlyGrid.Children.Clear();
            DrawGrid(enemyGrid, rows, columns);
            DrawGrid(friendlyGrid, rows, columns);
        }

        private void DrawGrid(Grid targetGrid, int rows, int columns)
        {
            targetGrid.RowDefinitions.Clear();
            targetGrid.ColumnDefinitions.Clear();
            for (int i = 0; i < rows; i++)
            {
                targetGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            }
            for (int j = 0; j < columns; j++)
            {
                targetGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Button button = new Button
                    {
                        Text = $"{row},{col}",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        BackgroundColor = Colors.LightGray,
                        BorderColor = Colors.Black,
                        BorderWidth = 2
                    };

                    button.Clicked += OnCellClicked;

                    targetGrid.Children.Add(button);
                    Grid.SetRow(button, row);
                    Grid.SetColumn(button, col);
                }
            }
        }

        private void OnCellClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackgroundColor = Colors.LightBlue;
                string board = button.Parent.Id == enemyGrid.Id ? "Enemy grid" : "Friendly Grid";
                DisplayAlert("Cell Clicked", $"Cell {button.Text} clicked in a {board}", "OK");
            }
        }

        private void inputRowCol()
        {
            if (!int.TryParse(gridRows.Text, out rows))
            {
                rows = 10;
            }
            if (!int.TryParse(gridColumns.Text, out columns))
            {
                columns = 10;
            }
        }
    }
}