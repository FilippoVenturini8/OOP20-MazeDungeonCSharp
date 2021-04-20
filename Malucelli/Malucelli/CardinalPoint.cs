using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// A basic class that implements the concept of cardinal point.
    /// </summary>
    public enum CardinalPoint
    {
        /// <summary>
        /// cardinal point north.
        /// </summary>
        NORTH,

        /// <summary>
        /// cardinal point west.
        /// </summary>
        WEST,

        /// <summary>
        /// cardinal point south.
        /// </summary>
        SOUTH,

        /// <summary>
        /// cardinal point east.
        /// </summary>
        EAST
    }

    /// <summary>
    /// a static class that provide utilities for cardinal points.
    /// </summary>
    public static class CardinalPoints
    {
        private const int SIZE = 4;

        /// <summary>
        /// </summary>
        /// <returns> a random cardinal point </returns>
        public static CardinalPoint GetAny()
        {
            Random rnd = new Random();
            return (CardinalPoint) Enum.GetValues(typeof(CardinalPoint)).GetValue(rnd.Next(SIZE));
        }
    
        /// <summary>
        /// </summary>
        /// <param name="cardinalPoint"> the cardinal point for search the opposite </param>
        /// <returns> the opposite cardinal point of the parameter </returns>
        public static CardinalPoint GetOpposite(CardinalPoint cardinalPoint)
        {
            switch (cardinalPoint)
            {
                case CardinalPoint.NORTH:
                    return CardinalPoint.SOUTH;
                case CardinalPoint.SOUTH:
                    return CardinalPoint.NORTH;
                case CardinalPoint.WEST:
                    return CardinalPoint.EAST;
                default:
                    return CardinalPoint.WEST;
            }
        }
    }
}