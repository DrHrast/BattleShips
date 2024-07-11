using Battleship.Model;

namespace Battleship.GUI.Models
{
    public class GameModel
    {
        private readonly Model.FleetGrid gameGrid;
        private readonly int rowsNumber;
        private readonly int columnsNumber;
        private readonly int dificulty;

        public GameModel(int rows, int columns, int dificulty = 0)
        {
            rowsNumber = rows;
            columnsNumber = columns;
            this.gameGrid = new Model.FleetGrid(rowsNumber, columnsNumber);
            this.dificulty = dificulty;
        }
    }
}
