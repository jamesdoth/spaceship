using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    internal class Ship
    {
        public Vector2 position = new Vector2(100, 100);
        public int speed = 240;

        public void shipUpdate(GameTime gameTime)
        {
            KeyboardState kstate = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Right))
            {
                position.X += speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Left))
            {
                position.X -= speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Up))
            {
                position.Y -= speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Down))
            {
                position.Y += speed * dt;
            }
        }
    }
}