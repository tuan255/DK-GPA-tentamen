using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKong.GameObjects
{
    class Bridge : SpriteGameObject
    {
        protected Vector2 startPosition = new Vector2(50, 550);
        public Bridge() : base("bridge_spr")
        {
            position = startPosition;
            origin = Center;
        }

    }
}
