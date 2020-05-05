using DonkeyKong.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKong.GameStates
{
    class StartScreen : GameObjectList
    {

        TextGameObject DonkeyKongBigDick;
        public StartScreen()
        {

            this.Add(new SpriteGameObject("startscreen_spr"));
            DonkeyKongBigDick = new TextGameObject("gamefont");
            DonkeyKongBigDick.Text = "Press SPACE to play \n Reach the top!";
            DonkeyKongBigDick.Position = new Vector2(140, 265);
            this.Add(DonkeyKongBigDick);

        }

        public override void HandleInput(InputHelper inputHelper)
        {

            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                DonkeyKong.GameStateManager.SwitchTo("PlayingState");
            }

        }
    }
}
