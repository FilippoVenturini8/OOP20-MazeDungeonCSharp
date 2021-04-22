using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiMarco
{
    /// <summary>
    /// An abstract class that implements the DynamicObject as a SimpleObject,
    /// with more features defined in the DynamicObject's interface.
    ///
    /// It also implements the changing of the state of the DynamicObject,
    /// making explicit if it's moving and in what direction.
    /// </summary>
    public abstract class AbstractDynamicObject
    {
        public abstract void Update(double elapsed);
    }
}
