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
        protected Vector2 startPosition = new Vector2(50, 500);
        public Player() : base("DK_player")
        {
            // Mouse.SetPosition(235, 500);
            position = startPosition;
            origin = Center;
        }

        public override void HandleInput(InputHelper inputHelper)
        {

            if (inputHelper.IsKeyDown(Keys.Right))
            {
                this.position.X += 3;
            }

            if (inputHelper.IsKeyDown(Keys.Left))
            {
                this.position.X += -3;
            }

            if (inputHelper.KeyPressed(Keys.Up))
            {
                this.position.Y += -5;
            }

            base.HandleInput(inputHelper);
        }
    }
}
