using System;
using System.Collections.Generic;
using System.Drawing;

using TurttleChallenge.Models.Enums;

namespace TurttleChallenge.Models
{
    public class MineField
    {
        public MineField(
            Point dimension,
            List<Part> parts)
        {
            this.Dimension = dimension;
            this.Parts = parts;

            this.Board = new Part[dimension.X, dimension.Y];
            this.FillBoard();
        }

        private Turttle Turttle { get; set; }

        public Part[,] Board { get; private set; }

        public List<Part> Parts { get; private set; }

        public Point Dimension { get; private set; }

        public void DoTurtleMovement(Actions action)
        {
            this.Turttle.DoMovement(action);

            this.ValidateTurttlePosition();
        }

        private void ValidateTurttlePosition()
        {
            try
            {
                var turttlePosition = this.Turttle.Position;

                var part = this.Board[turttlePosition.X, turttlePosition.Y];

                switch (part)
                {
                    case null:
                        return;
                    case Mine:
                        throw new Exception("Mine hit!");
                    case Exit:
                        throw new Exception("Success!");
                    default:
                        throw new Exception("Part not implemented!");
                }
            }
            catch (IndexOutOfRangeException )
            {
                throw new Exception("Game Over! Move for out of board!");
            }
        }

        private void FillBoard()
        {
            foreach (var part in this.Parts)
            {
                this.Board[part.Position.X, part.Position.Y] = part;

                if (part is Turttle)
                {
                    this.Turttle = (Turttle)part;
                }
            }
        }
    }
}
