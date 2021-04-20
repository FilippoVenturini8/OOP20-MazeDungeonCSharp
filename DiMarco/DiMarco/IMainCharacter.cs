using System;
using System.Collections.Generic;
using System.Text;
using DiMarco;

namespace DiMarco
{
    public interface IMainCharacter
    {
        /// <summary>
        /// 
        /// </summary>
        double MaxLife { get; }

        /// <summary>
        /// 
        /// </summary>
        double Life { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int Money { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="damage"></param>
        void IncreaseDamage(int damage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="speed"></param>
        void IncreaseSpeed(int speed);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bulletSpeed"></param>
        void IncreaseBulletSpeed(int bulletSpeed);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="damage"></param>
        void TakesDamage(int damage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shoot"></param>
        /// <param name="vectorDirection"></param>
        void SetShoot(bool shoot, VectorDirection vectorDirection);

        /// <summary>
        /// 
        /// </summary>
        void PickedUpFinalArtifact();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsDead();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsWin();

    }
}

