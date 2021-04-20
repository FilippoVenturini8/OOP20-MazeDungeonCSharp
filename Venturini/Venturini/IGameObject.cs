using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    interface IGameObject
    {
        Point2D Position { get; set; }

        int ID { get; set; }
    }
}
