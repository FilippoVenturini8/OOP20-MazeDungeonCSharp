using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo
{
    public class ItemBuilder : IItem
    {
        private readonly Items name;
        private int cost;
        private readonly int damage;
        private readonly int speed;
        private readonly int bulletSpeed;
        private readonly double health;

        private ItemBuilder(Items name, int cost, int damage, int speed, int bulletSpeed, double health)
        {
            this.name = name;
            this.Cost = cost;
            this.damage = damage;
            this.speed = speed;
            this.bulletSpeed = bulletSpeed;
            this.health = health;
        }

        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public Items Name
        {
            get { return this.name; }
           
        }

        public double Health
        {
            get { return this.health; }
        }

        public int Speed
        {
           get { return this.speed; }
        }

        public int BulletSpeed
        {
            get { return this.bulletSpeed; }
        }

        public int Damage
        {
            get { return this.damage; }
        }

        public class Builder
        {

            private readonly Items name;
            private readonly int cost;
            private int speed;
            private int damage;
            private int bulletSpeed;
            private double health;

            /// <summary>
            /// set the required parameters of the Items.
            /// While the remaining values with a default value.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="cost"></param>
            public Builder(Items name, int cost)
            {
                this.name = name;
                this.cost = cost;
                this.damage = 0;
                this.speed = 0;
                this.bulletSpeed = 0;
                this.health = 0;
            }

            /// <summary>
            /// @param health 
            /// </summary>
            /// <param name="health">value that increase the health</param>
            /// <returns>this, for create Item</returns>
            public Builder addHelath(double health)
            {
                this.health = health;
                return this;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="damage">value that increase the damage</param>
            /// <returns>this, for create Item</returns>
            public Builder addDamage(int damage)
            {
                this.damage = damage;
                return this;
            }
            
            /// <summary>
            /// </summary>
            /// <param name="speed">value that increase the Speed</param>
            /// <returns>this, for create Item</returns>
            public Builder addSpeed(int speed)
            {
                this.speed = speed;
                return this;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="bulletSpeed">value that increase the Bullet Speed</param>
            /// <returns>this, for create Item</returns>
            public Builder addBulletSpeed(int bulletSpeed)
            {
                this.bulletSpeed = bulletSpeed;
                return this;
            }

            /// <summary>
            ///  Complete and create Item.
            /// </summary>
            /// <returns>Item</returns>
            public IItem build()
            {
                return new ItemBuilder(this.name, this.cost, this.damage, this.speed, this.bulletSpeed, this.health);
            }
        }
    }
}
