using System.Drawing;

namespace TurttleChallenge.Models
{
    public class Part
    {
        public Part(Point position)
        {
            this.Position = position;
        }

        public Point Position { get; protected set; }
    }
}
