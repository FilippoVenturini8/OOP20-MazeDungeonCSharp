using System;
using System.Collections.Generic;
using System.Text;
using DiMarco;

namespace DiMarco
{
    /// <summary>
    /// An interface to model bullet factory
    /// </summary>
    public interface IBulletFactory
    { 
        /// <summary>
        /// create a character bullet.
        /// </summary>
        /// <param name="initialPosition"></param>
        /// <param name="direction"></param>
        /// <param name="bonusDamage"></param>
        /// <param name="bonusBulletSpeed"></param>
        /// <returns></returns>
        IBullet CreateMainCharacterBullet(Point2D initialPosition, Vector2D direction, int bonusDamage, int bonusBulletSpeed);
        
        /// <summary>
        /// create a skeletonBullet.
        /// </summary>
        /// <param name="initialPosition"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        IBullet CreateSkeletonBullet(Point2D initialPosition, Vector2D direction);

        /// <summary>
        /// create soul bullet.
        /// </summary>
        /// <param name="initialPosition"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        IBullet CreateSoulBullet(Point2D initialPosition, Vector2D direction);
      
        /// <summary>
        /// create sprout bullet
        /// </summary>
        /// <param name="initialPosition"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        IBullet CreateSproutBullet(Point2D initialPosition, Vector2D direction);

        /// <summary>
        /// create boss bullet.
        /// </summary>
        /// <param name="initialPosition"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        IBullet CreateBossBullet(Point2D initialPosition, Vector2D direction);
    }
}
