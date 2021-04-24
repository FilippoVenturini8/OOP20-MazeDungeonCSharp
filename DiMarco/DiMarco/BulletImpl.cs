using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DiMarco
{
    public class BulletImpl : IBullet
    {
        public int Damage { get; set; }

        public BulletImpl(Point2D initialPosition, Vector2D direction, int damage, int speed)
        {
            this.Damage = damage;
        }

        
    }
}
