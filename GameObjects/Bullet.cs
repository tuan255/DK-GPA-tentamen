using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKong.GameObjects
{

    class Bullet : SpriteGameObject
    {
        public bool isOnScreen = false;
        public Bullet(Vector2 startPosition) : base("bullet_spr")
        {
            position = startPosition;
            origin = Center;
        }

        public override void Update(GameTime gameTime)
        {

            if (position.Y > GameEnvironment.Screen.Y)
            {
                velocity.Y = 0;
                position.X = -1000;
                isOnScreen = false;
                DonkeyKong.self.score++;
            }

            base.Update(gameTime);
        }
    }
}
