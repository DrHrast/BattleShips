﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Battleship.Model.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void ConstructorCreatesSquareWithRowAndColumnProvided()
        {
            int row = 4;
            int col = 8;
            var square = new Square(row, col);

            Assert.AreEqual(row, square.Row);
            Assert.AreEqual(col, square.Column);
        }
    }
}