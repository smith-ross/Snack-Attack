using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snack_Attack
{
    public class Player
    {
        public PictureBox Entity;
        int movementDir = 0;
        int speed = 10;
        int score = 0;
        public Player(PictureBox playerEntity)
        {
            this.Entity = playerEntity;
            game.GetScoreObject().Text = $"SCORE : {this.score}";
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void ChangeMovement(int newDir)
        {
            movementDir += newDir; //Change direction of movement, makes it fluid if the player holds A & D and lets go of one.
        }

        public int GetScore() { return this.score; }
        public void IncreaseScore(int amount) { 
            this.score += amount;
            GravityObject.SetDefaultSpeed(GravityObject.defaultSpeed + ((int)game.playerObject.GetScore() / 10)); //Scale the default speed of the incoming objects by how much score the player has
            game.GetScoreObject().Text = $"SCORE : {this.score}";
        }

        public void OnTick()
        {
            //Move the player
            this.Entity.Location = new Point(
                Math.Min( // Math.Clamp doesn't actually exist for whatever reason, so we need to use a dodgy workaround of Math.Min and Math.Max
                    Math.Max(this.Entity.Location.X + (speed * movementDir), game.Boundaries[0].X),
                    game.Boundaries[1].X
                ), // Prevents player from moving out of the window boundaries.
                this.Entity.Location.Y
            );
        }
    }
}
