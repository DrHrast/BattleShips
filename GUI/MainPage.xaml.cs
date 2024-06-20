namespace GUI
{
    public partial class MainPage : ContentPage
    {
        public int rows, columns;
        
        public MainPage()
        {
            InitializeComponent();
            inputRowCol();
            DrawGrid(rows, columns);
        }

        private void DrawGrid(int rows, int columns)
        {
            GridGraphicsView grid = new GridGraphicsView(rows, columns)
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            enemyGrid = new Grid
            {
                Children = 
                {
                    grid               
                }
            }; 
            friendlyGrid = new Grid
            {
                Children =
                {
                    grid
                }
            };
        }

        private void inputRowCol()
        {
            rows = int.Parse(gridRows.Text);
            columns = int.Parse(gridColumns.Text);
        }
    }
}
