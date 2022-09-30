using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

public enum JunkType //Data type to store each type of fruit
{
    CHOCOLATE,
    PIZZA,
    BURGER
}


namespace Snack_Attack
{
    class Junk : GravityObject // Class Junk which inherits the methods and fields of the GravityObject superclass
    {
        public new JunkType Type;
        static Random rnd = new Random();

        static Dictionary<JunkType, Bitmap> JunkImages = new Dictionary<JunkType, Bitmap>() { //Dictionary storing the images of each junk based on their enum value
            { JunkType.CHOCOLATE, Properties.Resources.Chocolate },
            { JunkType.PIZZA, Properties.Resources.Pizza },
            { JunkType.BURGER, Properties.Resources.Burger },
           
        };

        public Junk(PictureBox Entity = null, JunkType Type = JunkType.CHOCOLATE)
        {
            SetEntity(Entity); //Sets the GravityObject to use the Junk PictureBox
            this.Type = Type;
            this.FoodType = Food.JUNK;
        }

        public void Spawn()
        {
            Point spawnPosition = new Point(
                rnd.Next(
                       game.Boundaries[0].X, game.Boundaries[1].X + 1
                ),
                game.Boundaries[0].Y
            ); //Determines a position to spawn the junk


            GetEntity().Image = JunkImages[this.Type];
            GetEntity().Location = spawnPosition;
        }
    }
}
