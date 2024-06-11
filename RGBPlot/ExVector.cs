using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RGBPlot {
    public static class ExVector {
        public static Vector2 ToVector(this Point point) {
            return new Vector2(point.X, point.Y);
        }

        public static Point ToPoint(this Vector2 vec) {
            return new Point((int)vec.X, (int)vec.Y);
        }
    }
}
