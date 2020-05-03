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
        Bridge theBridge;
        GameObjectList bullets, snake, mushrooms;

        public PlayingState()
        {
            this.Add(new SpriteGameObject("background_sprite"));

            thePlayer = new Player();
            this.Add(thePlayer);

            theBridge = new Bridge();
            this.Add(theBridge);

            bullets = new GameObjectList();
            this.Add(bullets);

            //snake = new GameObjectList();
            //this.Add(snake);
            
            //for (int iSnakeSegment = 0; iSnakeSegment < 10; iSnakeSegment++)
            //{
            //    snake.Add(new SnakeSegment(new Vector2(10 + iSnakeSegment * 32, 10)));
            //}

            //mushrooms = new GameObjectList();
            //this.Add(mushrooms);
            //for (int iMushroom = 0; iMushroom < 20; iMushroom++)            
            //    mushrooms.Add(new Mushroom());
            

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Space))
                bullets.Add(new Bullet(thePlayer.Position - new Vector2(0, +20)));
            base.HandleInput(inputHelper);
        }

        public override void Update(GameTime gameTime)
        {
            //foreach (Bullet bullet in bullets.Children)
            //{
            //    foreach (SnakeSegment snakeSegment in snake.Children)
            //        if (bullet.CollidesWith(snakeSegment))
            //        {
            //            bullet.Visible = false;
            //            snakeSegment.Visible = false;
            //            mushrooms.Add(new Mushroom(snakeSegment.Position));
            //        }

            //     foreach (Mushroom mushroom in mushrooms.Children)
            //        if (bullet.CollidesWith(mushroom))
            //        {
            //            bullet.Visible = false;
            //            mushroom.Visible = false;
            //        }

            //}

            //foreach (SnakeSegment snakeSegment in snake.Children)
            //    foreach (Mushroom mushroom in mushrooms.Children)
            //        if (snakeSegment.CollidesWith(mushroom))
            //            snakeSegment.Bounce();
            base.Update(gameTime);
        }
    }
}
