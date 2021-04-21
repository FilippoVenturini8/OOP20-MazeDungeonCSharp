using System;
using System.Collections.Generic;
using System.Text;

namespace DiMarco
{
    class MainCharacter : IMainCharacter
    {
        private static readonly double MAX_LIFE = 100;
        private static readonly int INITIAL_SPEED = 300;
        private static readonly int INITIAL_MONEY = 0;
        private static readonly int INITIAL_BONUS_SPEED = 0;
        private static readonly int INITIAL_BULLET_DELAY = 400;
        private static readonly DateTime firstDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private double life;
        private int bonusDamage;
        private int bonusSpeed;
        private int money;
        //private readonly BulletFactory bulletFactory;
        private long lastShootTime;
        private Vector2D shootDirection;
        private bool shoot;
        private bool win;


        public MainCharacter(Point2D position)
        {
            this.life = MAX_LIFE;
            this.bonusDamage = 0;
            this.bonusSpeed = INITIAL_BONUS_SPEED;
            this.money = INITIAL_MONEY;
            //this.lastShootTime = System.currentTimeMillis();
            //this.bulletFactory = new BulletFactoryImpl();
            this.shoot = false;
            this.win = false;
        }


        public double MaxLife 
        { 
            get { return this.MaxLife; } 
        }

        public double Life 
        { 
            get { return this.life; }  
            set { this.life = value; } 
        }

        public int Money 
        { 
            get { return money; } 
            set { this.money = value; } 
        }

        public void IncreaseBulletSpeed(int bulletSpeed)
        {
            this.bonusSpeed += bulletSpeed;
        }

        public void IncreaseDamage(int damage)
        {
            this.bonusSpeed += damage;
        }

        public void IncreaseSpeed(int speed)
        {
            this.bonusSpeed += speed;
        }

        public bool IsDead()
        {
            return this.life <= 0;
        }

        public bool IsWin()
        {
            return this.win;
        }

        public void PickedUpFinalArtifact()
        {
            this.win = true;
        }

        public void SetShoot(bool shoot, VectorDirection vectorDirection)
        {
            if (this.CanShoot())
            {
                this.shoot = shoot;
            }
        }

        private bool CanShoot()
        {
            long currentTime = this.GetTimeMillis();
            if (currentTime - this.lastShootTime > INITIAL_BULLET_DELAY)
            {
                this.lastShootTime = currentTime;
                return true;
            }
            return false;
        }

        private long GetTimeMillis()
        {
            return (long)(DateTime.UtcNow - firstDate).TotalMilliseconds;
        }

        public void TakesDamage(int damage)
        {
            throw new NotImplementedException();
        }


    }
}
