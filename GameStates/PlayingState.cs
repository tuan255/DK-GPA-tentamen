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
    class PlayingState : GameObjectList
    {
        Player thePlayer;
        Boss boss;
        GameObjectList bridge, bullets;

        TextGameObject DonkeyKongDickScore;
        public PlayingState()
        {
            this.Add(new SpriteGameObject("background_sprite"));

            thePlayer = new Player();
            this.Add(thePlayer);

            boss = new Boss(thePlayer);
            this.Add(boss);

            bullets = new GameObjectList();
            this.Add(bullets);
            bullets.Add(new Bullet(new Vector2(100, -100)));
            bullets.Add(new Bullet(new Vector2(100, -50)));
            bullets.Add(new Bullet(new Vector2(100, -10)));



            bridge = new GameObjectList();
            this.Add(bridge);
            
            bridge.Add(new Bridge(new Vector2(0,575),"longbridge_spr",true));
            bridge.Add(new Bridge(new Vector2(0, 125), "longbridge_spr",false));

            for (int iShortBridgeX = 0; iShortBridgeX < 2; iShortBridgeX++)
            {               
                for (int iShortBridgeY = 0; iShortBridgeY < 2; iShortBridgeY++)
                {
                    bridge.Add(new Bridge(new Vector2(750/3+(iShortBridgeX*350), 275+(iShortBridgeY*125)),"bridge_spr",true));
                }
            }

            DonkeyKongDickScore = new TextGameObject("gamefont2");
            DonkeyKongDickScore.Text = "Score: "+ DonkeyKong.self.score;
            DonkeyKongDickScore.Position = new Vector2(0, 0);
            this.Add(DonkeyKongDickScore);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            
            base.HandleInput(inputHelper);
        }

        public override void Update(GameTime gameTime)
        {
            bool gameOver = false;
            DonkeyKongDickScore.Text = "Score: " + DonkeyKong.self.score;
            Random rnd = new Random();
            foreach (Bullet bullet in bullets.Children)

            {

                if (!bullet.isOnScreen)
                {
                    bullet.isOnScreen = true;
                    bullet.Position = boss.Position + new Vector2((float)rnd.Next(-125,200),0);
                    bullet.Velocity = new Vector2(0, 500);
                }
                if (thePlayer.CollidesWith(bullet))
                {
                    gameOver = true;

                }
                if (gameOver)
                {
                    DonkeyKong.GameStateManager.SwitchTo("Endscreen");
                    thePlayer.Position = new Vector2(50, 502);
                    bullet.Position = boss.Position + new Vector2((float)rnd.Next(-125, 200), 0);
                    gameOver = false;
                }
            }

            base.Update(gameTime);

            Console.WriteLine("Collision");
            foreach (Bridge aBridge in bridge.Children)
            {
                if (aBridge.CollidesWith(thePlayer))
                {
                    thePlayer.gravity = 0;
                    thePlayer.inAir = false;
                    //thePlayer.Position = Vector2.Zero;
                    Console.WriteLine("Collision");
                    break;
                }
                else thePlayer.gravity = 100;
     
            }
     
            
        }
    }
}
