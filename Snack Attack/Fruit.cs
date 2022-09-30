using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

public enum FruitType //Data type to store each type of fruit
{
    ORANGE,
    BANANA,
    BROCCOLI,
    CHERRY,
    APPLE
}


namespace Snack_Attack
{
    class Fruit : GravityObject // Class Fruit which inherits the methods and fields of the GravityObject superclass
    {

        static Dictionary<FruitType, Bitmap> FruitImages = new Dictionary<FruitType, Bitmap>() { //Dictionary storing the images of each fruit based on their enum value
            { FruitType.ORANGE, Properties.Resources.Orange },
            { FruitType.BANANA, Properties.Resources.Banana },
            { FruitType.BROCCOLI, Properties.Resources.Broccoli },
            { FruitType.CHERRY, Properties.Resources.Cherry },
            { FruitType.APPLE, Properties.Resources.Apple },
        };

        static Random rnd = new Random();

        public Fruit(PictureBox Entity = null, FruitType Type = FruitType.APPLE)
        {
            SetEntity(Entity); //Sets the GravityObject to use the Fruit PictureBox
            this.Type = Type;
            this.FoodType = Food.FRUIT;
        }

        public void Spawn()
        {
            Point spawnPosition = new Point(
                rnd.Next(
                       game.Boundaries[0].X, game.Boundaries[1].X + 1
                ),
                game.Boundaries[0].Y
            ); //Determines a position to spawn the fruit


            GetEntity().Image = FruitImages[this.Type];
            GetEntity().Location = spawnPosition;
        }
    }
}
