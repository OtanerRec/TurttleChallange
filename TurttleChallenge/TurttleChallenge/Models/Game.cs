using System;

namespace TurttleChallenge.Models
{
    public class Game
    {
        public Game(Settings settings)
        {
            this.Settings = settings;
            
            this.CreateMineField();
        }

        private Settings Settings { get; set; }

        private MineField MineField { get; set; }

        public void Start(SequenceMoves sequences) 
        {
            foreach (var action in sequences.Actions)
            {
                this.MineField.DoTurtleMovement(action);
            }

            throw new Exception("Game Over! Insufficent movements!");
        }

        private void CreateMineField()
        {
            this.MineField = MineFieldFactory.Create(this.Settings);
        }
    }
}
