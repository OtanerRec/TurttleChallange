using System.Collections.Generic;

using TurttleChallenge.Models;

namespace TurttleChallenge
{
    public static class MineFieldFactory
    {
        public static MineField Create(Settings settings)
        {
            var parts = new List<Part>();

            var turttle = new Turttle(settings.StartPosition, settings.StartDirection);
            parts.Add(turttle);

            var exit = new Exit(settings.Exit);
            parts.Add(exit);

            var mines = new List<Mine>();

            foreach (var minePosition in settings.MinePosition)
            {
                mines.Add(new Mine(minePosition));
            }
            parts.AddRange(mines);

            var mineField = new MineField(settings.SizeBoard, parts);

            return mineField;
        }
    }
}
