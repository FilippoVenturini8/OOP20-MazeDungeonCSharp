using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    public class DynamicObjectImpl : AbstractDynamicObject
    {
        public DynamicObjectImpl(int speed, Point2D position, int id) : base(speed, position, id)
        {
        }

        public override void Update(double elapsed)
        {
        }
    }
}
