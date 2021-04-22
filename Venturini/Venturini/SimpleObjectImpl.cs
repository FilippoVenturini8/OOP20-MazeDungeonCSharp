using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    public class SimpleObjectImpl : AbstractSimpleObject
    {
        public SimpleObjectImpl(Point2D position, int id) : base(position, id)
        {
        }
    }
}
