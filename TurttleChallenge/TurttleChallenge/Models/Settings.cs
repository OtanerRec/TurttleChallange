using System.Collections.Generic;
using System.Drawing;

using TurttleChallenge.Models.Enums;

namespace TurttleChallenge.Models
{
    public class Settings
    {
        public Point StartPosition { get; set; }

        public Direction StartDirection { get; set; }

        public Point SizeBoard { get; set; }

        public Point Exit { get; set; }

        public IEnumerable<Point> MinePosition { get; set; }
    }
}