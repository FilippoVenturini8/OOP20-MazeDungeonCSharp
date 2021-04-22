using System;
using System.Collections.Generic;
using System.Text;

namespace DiMarco
{
    public class MainCharacter : AbstractDynamicObject, IMainCharacter
    {
        private static readonly double MAX_LIFE = 100;
        private static readonly int INITIAL_MONEY = 0;
        private static readonly int INITIAL_BONUS_SPEED = 0;
        private static readonly int INITIAL_BULLET_DELAY = 400;
        private static readonly DateTime firstDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        //private readonly BulletFactory bulletFactory;
        private long lastShootTime;
        private Vector2D shootDirection;
        private bool win;


        public MainCharacter(Point2D position)
        {
            this.Life = MAX_LIFE;
            this.BonusDamage = 0;
            this.BonusSpeed = INITIAL_BONUS_SPEED;
            this.Money = INITIAL_MONEY;
            this.lastShootTime = this.GetTimeMillis();
            this.Shoot = false;
            this.win = false;
        }


        public double MaxLife 
        { 
            get { return this.MaxLife; } 
        }

        public double Life { get; set; }

        public int Money { get; set; }

        public bool Shoot { get; set; }

        public int BonusSpeed { get; private set; }

        public int BonusDamage { get; private set; }

        public override void Update(double elapsed)
        {

        }

        public void IncreaseDamage(int damage)
        {
            this.BonusDamage += damage;
        }

        public void IncreaseSpeed(int speed)
        {
            this.BonusSpeed += speed;
        }

        public bool IsDead()
        {
            return this.Life <= 0;
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
                this.Shoot = shoot;
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
            this.Life -= damage;
        }
    }
}
