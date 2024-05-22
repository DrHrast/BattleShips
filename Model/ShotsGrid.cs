﻿// Ignore Spelling: Vsite Oom

namespace Vsite.Oom.Battleship.Model
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

        //TODO: Implement ShotsGridTests for method GetSquaresInDirection
        public IEnumerable<Square> GetSquaresInDirection(int row, int col, Direction upwards)
        {
            throw new NotImplementedException();
        }

    }
}
