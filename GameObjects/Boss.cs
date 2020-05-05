using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKong.GameObjects
{
    class Boss : SpriteGameObject
    {

        protected Vector2 startPosition = new Vector2(25, 50);
        Player player;
        public Boss(Player player) : base("boss_spr")
        {
            this.player = player;
            position = startPosition;
            velocity.X = 250;
           
        }

        public override void Update(GameTime gameTime)
        {

            if(position.X > DonkeyKong.Screen.X-75)
            {
                velocity.X *= -1;
            }
            if(position.X < 0)
            {
                velocity.X *= -1;
            }
            //if (position.X > player.Position.X)
            //{
            //    velocity.X = -100;
            //}
            //else if (position.X < player.Position.X)
            //{
            //    velocity.X = 100;
            //}

            base.Update(gameTime);
        }

    }
}
