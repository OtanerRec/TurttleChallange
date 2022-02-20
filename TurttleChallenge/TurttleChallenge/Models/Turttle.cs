using System;
using System.Drawing;

using TurttleChallenge.Models.Enums;

namespace TurttleChallenge.Models
{
    public sealed class Turttle : Part
    {
        public Turttle(
            Point position, 
            Direction direction) 
            : base(position)
        {
            this.Direction = direction;
        }

        public Direction Direction { get; private set; }

        public void DoMovement(Actions action)
        {
            if (action == Actions.R)
            {
                switch (this.Direction)
                {
                    case Direction.North:
                        Direction = Direction.East;
                        break;
                    case Direction.East:
                        Direction = Direction.South;
                        break;
                    case Direction.South:
                        Direction = Direction.West;
                        break;
                    case Direction.West:
                        Direction = Direction.North;
                        break;
                    default:
                        Console.WriteLine("Invalid direction");
                        break;
                }
            }
            else if (action == Actions.M)
            {
                switch (this.Direction)
                {
                    case Direction.North:
                        this.Position = new Point(this.Position.X, this.Position.Y - 1);
                        return;
                    case Direction.East:
                        this.Position = new Point(this.Position.X + 1, this.Position.Y);
                        return;
                    case Direction.South:
                        this.Position = new Point(this.Position.X, this.Position.Y + 1);
                        return;
                    case Direction.West:
                        this.Position = new Point(this.Position.X - 1, this.Position.Y);
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
