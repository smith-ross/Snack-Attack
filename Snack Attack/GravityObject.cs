using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

enum Food {
    JUNK,
    FRUIT
};

namespace Snack_Attack
{
    class GravityObject
    {
        public static int defaultSpeed = 0;
        static float Gravity = 9f;
        public FruitType Type;
        public Food FoodType;

        static List<GravityObject> EntityList = new List<GravityObject>(); //List that will store each object to be affected by gravity.

        
        PictureBox Entity;
        public float Speed = defaultSpeed;
        public GravityObject()
        {
            EntityList.Add(this); //Add new object to the list
        }

        public void SetEntity(PictureBox Entity)
        {
            this.Entity = Entity;
        }

        public PictureBox GetEntity()
        {
            return Entity;
        }

        static public void Clear()
        {
            foreach (GravityObject Object in EntityList) //Loop through each object to be affected by gravity
            {
                PictureBox Entity = Object.GetEntity();
                Entity.Dispose(); //Clear entity
            }
            EntityList = new List<GravityObject>();
            Gravity = 9f;
            defaultSpeed = 0;
        }
        static public void OnTick()
        {

            Rectangle playerHitbox = new Rectangle(game.playerObject.Entity.Location, new Size(game.playerObject.Entity.Size.Width, 1));
            GravityObject[] clonedList = new GravityObject[EntityList.Count];
            EntityList.CopyTo(clonedList);

            foreach(GravityObject Object in clonedList) //Loop through each object to be affected by gravity
            {
                PictureBox Entity = Object.GetEntity();
                if (Entity != null) //If the object has an entity attached, apply gravity to it
                {
                    Object.Speed += (Gravity / 100f); //Gradually increase the speed of the object by GRAVITY
                    Entity.Location = new Point(Entity.Location.X, Entity.Location.Y + (int)Object.Speed); //Set the object position
                    
                    if(Entity.Bounds.IntersectsWith(playerHitbox))
                    {
                        Entity.Dispose();
                        EntityList.Remove(Object);
                        if(Object.FoodType == Food.FRUIT) { 
                            game.playerObject.IncreaseScore(1); //Increase the score by 1 if they catch the fruit
                           
                            switch(Object.Type)
                            {
                                case FruitType.CHERRY:
                                    game.Teeth.AddTooth(); //Add back a tooth if the fruit is a Cherry
                                    break;

                                case FruitType.BROCCOLI:
                                    int sizeChangeX = (int)game.playerObject.Entity.Size.Width / 4;
                                    int sizeChangeY = (int)game.playerObject.Entity.Size.Height / 4;
                                    game.playerObject.Entity.Location = new Point(game.playerObject.Entity.Location.X, game.playerObject.Entity.Location.Y - sizeChangeY); //Move the basket upwards to accomodate for the scaling
                                    game.playerObject.Entity.Size = new Size(game.playerObject.Entity.Size.Width + sizeChangeX, game.playerObject.Entity.Size.Height + sizeChangeY); // Scale up the basket by 25%

                                    Action Func1 = () => {
                                        game.playerObject.Entity.Location = new Point(game.playerObject.Entity.Location.X, game.playerObject.Entity.Location.Y + sizeChangeY);
                                        game.playerObject.Entity.Size = new Size(game.playerObject.Entity.Size.Width - sizeChangeX, game.playerObject.Entity.Size.Height - sizeChangeY);
                                    }; //Function to reduce the size

                                    game.ScheduleTask(game.gameTime + 750, Func1); //Reduce the size after a certain amount of seconds
                                    break;


                                case FruitType.BANANA:
                                    SetGravity(Gravity / 2); //Half the gravity

                                    Action Func2 = () =>
                                    {
                                        SetGravity(Gravity * 2);
                                    }; //Function to double the gravity again

                                    game.ScheduleTask(game.gameTime + 1000, Func2); //Double the gravity back to normal after 10 seconds
                                    break;

                                case FruitType.ORANGE:
                                    game.playerObject.SetSpeed((int)((float)game.playerObject.GetSpeed() * 1.5f)); //Set the speed to 1.5x of the current player's speed

                                    Action Func3 = () => {
                                        game.playerObject.SetSpeed((int)((float)game.playerObject.GetSpeed() / 1.5f));
                                    }; //Function to half the players speed again

                                    game.ScheduleTask(game.gameTime + 1000, Func3); //Half the player's speed after a set amount of time
                                    break;

                                default:
                                    break;
                            }

                        }
                        else { game.Teeth.RemoveTooth(); } //If it's a junk food, remove a tooth

                    }
                    else if (Entity.Bounds.IntersectsWith(game.groundObject.Bounds) && Object.FoodType == Food.FRUIT)
                    {
                        Entity.Dispose();
                        EntityList.Remove(Object);
                        game.Teeth.RemoveTooth(); // If the food is fruit and hits the ground, remove a tooth for missing it.
                    }
                }
            }
        }

        static public void SetDefaultSpeed(int speed)
        {
            defaultSpeed = speed;
        }

        static public void SetGravity(float newGravity)
        {
            Gravity = newGravity;
        }
    }
}
