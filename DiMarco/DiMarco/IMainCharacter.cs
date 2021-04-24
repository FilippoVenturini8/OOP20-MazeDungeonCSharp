using System;
using System.Collections.Generic;
using System.Text;
using DiMarco;

namespace DiMarco
{
    /// <summary>
    /// this interface contains method to handle the character
    /// </summary>
    public interface IMainCharacter
    {
        /// <summary>
        /// Max life of the main character
        /// </summary>
        double MaxLife { get; }

        /// <summary>
        /// current life of main character
        /// </summary>
        double Life { get; set; }

        /// <summary>
        /// current money of main character
        /// </summary>
        int Money { get; set; }

        /// <summary>
        /// set the shoot oe
        /// </summary>
        bool Shoot { get; set; }
        
        /// <summary>
        /// method for increase character's bullet damage
        /// </summary>
        /// <param name="damage"></param>
        void IncreaseDamage(int damage);

        /// <summary>
        /// method for increase character's bullet speede
        /// </summary>
        /// <param name="speed"></param>
        void IncreaseSpeed(int speed);

        /// <summary>
        /// take damage when character is hit
        /// </summary>
        /// <param name="damage"></param>
        void TakesDamage(int damage);

        /// <summary>
        /// set the shoot to true
        /// </summary>
        /// <param name="shoot"></param>
        /// <param name="vectorDirection"></param>
        void SetShoot(bool shoot, VectorDirection vectorDirection);

        /// <summary>
        /// pick up final artifact
        /// </summary>
        void PickedUpFinalArtifact();

        /// <summary>
        /// verify if the character is dead
        /// </summary>
        /// <returns></returns>
        bool IsDead();

        /// <summary>
        /// verify if the character is win
        /// </summary>
        /// <returns></returns>
        bool IsWin();

    }
}

