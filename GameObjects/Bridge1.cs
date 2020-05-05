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

        public static bool Collision = true;
        public Bridge(Vector2 startPosition, String Assetname,bool collision) : base(Assetname)
        {
            Collision = collision;
            position = startPosition;

        }

    }
}
