// Ignore Spelling: Vsite Oom

using System.Data.Common;

namespace Battleship.Model
{

    public enum Direction
    {
        Upwards,
        Rightwards,
        Downwards,
        Leftwards
    }

    public class ShotsGrid : Grid
    {

        public ShotsGrid(int rows, int columns) : base(rows, columns)
        {

        }

        protected override bool IsSquareAvailable(int row, int column)
        {
            return squares[row, column]?.SquareState == SquareState.Intact;
        }

        //public Square GetSquare(int row, int column)
        //{
        //    return squares[row, column]!;
        //}

        public void ChangeSquareState(int row, int column, SquareState newState)
        {
            squares[row, column]!.ChangeState(newState);
        }

        //DID_IT: Implement ShotsGridTests for method GetSquaresInDirection
        public IEnumerable<Square> GetSquaresInDirection(int row, int col, Direction upwards)
        {
			var result = new List<Square>();

			int deltaRow = 0;
			int deltaColumn = 0;
			int limit = 0;
			switch (upwards)
			{
				case Direction.Upwards:
					--row;
					deltaRow = -1;
					limit = -1;
					break;
				case Direction.Rightwards:
					++col;
					deltaColumn = +1;
					limit = Columns;
					break;
				case Direction.Downwards:
					++row;
					deltaRow = +1;
					limit = Rows;
					break;
				case Direction.Leftwards:
					--col;
					deltaColumn = -1;
					limit = -1;
					break;
			}
			for (int r = row, c = col; r != limit && c != limit && IsSquareAvailable(r, c); r += deltaRow, c += deltaColumn)
			{
				result.Add(squares[r, c]!);
			}
			return result;
		}

    }
}
