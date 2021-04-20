using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// This is an infinite Iterator that provides id for all the GameObjects.
    /// </summary>
    class IdIterator
    {
        private int value;

        /// <summary>
        /// Has always a next value.
        /// </summary>
        /// <returns> true </returns>
        public bool HasNext()
        {
            return true;
        }

        /// <summary>
        /// the next value
        /// </summary>
        /// <returns> the next value </returns>
        public int Next()
        {
            return this.value++;
        }
    }
}
