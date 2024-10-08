﻿using Battleship.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Battleship.Model.Tests
{
    [TestClass]
    public class SquareEliminatorTests
    {
        [TestMethod]
        public void FOrSquares4x3To4x6Returns18SquaresIncludingSurroundingSquares()
        {
            var eliminator = new SquareEliminator();
            var shipSquares = new List<Square> { new Square(4, 3), new Square(4, 4), new Square(4, 5), new Square(4, 6) };

            Assert.AreEqual(18, eliminator.ToEliminate(shipSquares, 10, 10).Count());
        }

        [TestMethod]
        public void FOrSquares3x9To4x9Returns8SquaresIncludingSurroundingSquares()
        {
            var eliminator = new SquareEliminator();
            var shipSquares = new List<Square> { new Square(3, 9), new Square(4, 9) };

            var toEliminate = eliminator.ToEliminate(shipSquares, 10, 10).Count();
            Assert.AreEqual(8, toEliminate);

            //TODO: Check if boundary coordinates are included
        }
    }
}