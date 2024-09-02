// Ignore Spelling: Vsite Oom
using System;
using System.ComponentModel.DataAnnotations;

namespace Battleship.Model
{
    public class SurroundingTargetSelector : ITargetSelector
    {
        public SurroundingTargetSelector(ShotsGrid grid, Square firstHit, int shipLength)
        {
            _grid = grid;
            _firstHit = firstHit;
            _shipLength = shipLength;
        }

        //DID_IT: Implement shoting target selector
        public Square Next()
        {
            List<IEnumerable<Square>> _squares = new List<IEnumerable<Square>>();
            //DID_IT: Implement with a loop

			foreach (Direction direction in Enum.GetValues(typeof(Direction)))
			{
				var up = _grid.GetSquaresInDirection(_firstHit.Row, _firstHit.Column, Direction.Upwards);
				if (up.Count() > 0) { _squares.Add(up); }

				var right = _grid.GetSquaresInDirection(_firstHit.Row, _firstHit.Column, Direction.Rightwards);
				if (right.Count() > 0) { _squares.Add(right); }

				var down = _grid.GetSquaresInDirection(_firstHit.Row, _firstHit.Column, Direction.Downwards);
				if (down.Count() > 0) { _squares.Add(down); }

				var left = _grid.GetSquaresInDirection(_firstHit.Row, _firstHit.Column, Direction.Leftwards);
				if (left.Count() > 0) { _squares.Add(left); }

				var inDirection = _grid.GetSquaresInDirection(_firstHit.Row, _firstHit.Column, direction);
				//if (inDirection.Any())
				//{
				//	_squares.Add(inDirection);
				//}
			}

			int index = random.Next(_squares.Count);
			return _squares[index].First();
		}

		//public Square Next()
		//{
		//	List<IEnumerable<Square>> squares = new List<IEnumerable<Square>>();

		//	foreach (Direction direction in Enum.GetValues(typeof(Direction)))
		//	{
		//		var inDirection = grid.GetSquaresInDirection(firstHit.Row, firstHit.Column, direction);
		//		if (inDirection.Any())
		//		{
		//			squares.Add(inDirection);
		//		}
		//	}

		//	int index = random.Next(squares.Count);
		//	return squares[index].First();
		//}

		private readonly ShotsGrid _grid;
        private readonly Square _firstHit;
        private readonly int _shipLength;
		private readonly Random random = new Random();
    }
}
