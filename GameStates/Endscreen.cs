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
    class Endscreen : GameObjectList
    {

        TextGameObject DonkeyKongBigDick;
        public Endscreen()
        {

            this.Add(new SpriteGameObject("endscreen_spr"));
            DonkeyKongBigDick = new TextGameObject("gamefont");
            DonkeyKongBigDick.Text = "you ded bro \n(SPACE to restart) \nScore: "+ DonkeyKong.self.score;
            DonkeyKongBigDick.Position = new Vector2(175, 200);
            this.Add(DonkeyKongBigDick);

        }

        public override void HandleInput(InputHelper inputHelper)
        {

            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                //DonkeyKong.self.Exit();
                DonkeyKong.GameStateManager.SwitchTo("PlayingState");
                DonkeyKong.self.score = 0;

                
            }


        }

        public override void Update(GameTime gameTime)
        {
            DonkeyKongBigDick.Text = "you ded bro \n(SPACE to restart) \nScore: " + DonkeyKong.self.score;
        }
    }
}
