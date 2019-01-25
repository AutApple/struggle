﻿using SFML.Graphics;
using SFML.System;

namespace Struggle
{
    class Builder : Unit
    {
        public Builder(Vector2f crd, uint m) : base(crd, m)
        {
            titleString = "Builder";
        }

        public override void Draw(RenderWindow app)
        {
            base.Draw(app);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
