using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKong.GameObjects
{
    class Player : SpriteGameObject
    {
        protected Vector2 startPosition = new Vector2(50, 502);
        public float gravity = 500f;
        public bool hit = false;
        public bool inAir = false;
        public Player() : base("DK_player")
        {

            position = startPosition;
      
        }

        

        public override void Update(GameTime GameTime)
        {
            if (Position.Y < 0)
            {
                DonkeyKong.self.score += 100;
                position.Y = 502;
            }
           
            position.Y += gravity * (float)GameTime.ElapsedGameTime.TotalSeconds;

            base.Update(GameTime);

        }

        public override void HandleInput(InputHelper inputHelper)
        {

            if (inputHelper.IsKeyDown(Keys.Right))
            {
                position.X += 3;
            }

            if (inputHelper.IsKeyDown(Keys.Left))
            {
                position.X += -3;
            }

            if (inputHelper.KeyPressed(Keys.Up) && inAir == false)
            {
                inAir = true;
                position.Y += -104;
               
            }

            base.HandleInput(inputHelper);
        }
    }
}
