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
        public Bullet(Vector2 startPosition) : base("spr_bullet")
        {
            position = startPosition;
            origin = Center;
            velocity.Y = -200;
        }
    }
}
