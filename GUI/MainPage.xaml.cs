using GUI.Views;

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
            DrawGridView gridView = new(rows, columns);

            //DrawGrid(enemyGrid, rows, columns);
            //DrawGrid(friendlyGrid, rows, columns);
            gridView.DrawGrid(enemyGrid);
            gridView.DrawGrid(friendlyGrid);
            applyGridChanges.Clicked += OnApplyGridChangesClicked;
        }

        private void OnApplyGridChangesClicked(object sender, EventArgs e)
        {
            inputRowCol();
            enemyGrid.Children.Clear();
            friendlyGrid.Children.Clear();

            DrawGridView gridView = new(rows, columns);
            gridView.DrawGrid(enemyGrid);
            gridView.DrawGrid(friendlyGrid);
            //DrawGrid(enemyGrid, rows, columns);
            //DrawGrid(friendlyGrid, rows, columns);
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