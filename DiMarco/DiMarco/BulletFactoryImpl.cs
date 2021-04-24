using System;
using System.Collections.Generic;
using System.Text;

namespace DiMarco
{
    public class BulletFactoryImpl:IBulletFactory
    {
        private const int CHARACTER_BULLET_SPEED = 400;
        private const int SKELETON_BULLET_SPEED = 200;
        private const int SOUL_BULLET_SPEED = 200;
        private const int SPROUT_BULLET_SPEED = 300;
        private const int BOSS_BULLET_SPEED = 300;
        private const int CHARACTER_BULLET_DAMAGE = 10;
        private const int SKELETON_BULLET_DAMAGE = 15;
        private const int SOUL_BULLET_DAMAGE = 10;
        private const int SPROUT_BULLET_DAMAGE = 20;
        private const int BOSS_BULLET_DAMAGE = 30;

        public IBullet CreateMainCharacterBullet(Point2D initialPosition, Vector2D direction, int bonusDamage, int bonusBulletSpeed)
        {
            return new BulletImpl(initialPosition, direction, bonusDamage + CHARACTER_BULLET_DAMAGE, CHARACTER_BULLET_SPEED + bonusBulletSpeed);
        }
    
        public IBullet CreateSkeletonBullet(Point2D initialPosition, Vector2D direction)
        {
            return new BulletImpl(initialPosition, direction, SKELETON_BULLET_DAMAGE, SKELETON_BULLET_SPEED);
        }
    
        public IBullet CreateSoulBullet(Point2D initialPosition, Vector2D direction)
        {
            return new BulletImpl(initialPosition, direction, SOUL_BULLET_DAMAGE, SOUL_BULLET_SPEED);
        }
     
        public IBullet CreateSproutBullet(Point2D initialPosition, Vector2D direction)
        {
            return new BulletImpl(initialPosition, direction, SPROUT_BULLET_DAMAGE, SPROUT_BULLET_SPEED);
        }
       
        public IBullet CreateBossBullet(Point2D initialPosition, Vector2D direction)
        {
            return new BulletImpl(initialPosition, direction, BOSS_BULLET_DAMAGE, BOSS_BULLET_SPEED);
        }
    }
}
