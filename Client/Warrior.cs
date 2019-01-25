﻿using SFML.Graphics;
using SFML.System;
using System;

namespace Struggle
{
    class Warrior : Unit
    { 
        public Warrior(Vector2f crd, uint m) : base(crd, m)
        {
            titleString = "Warrior";
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
