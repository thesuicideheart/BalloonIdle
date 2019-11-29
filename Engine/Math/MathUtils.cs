using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Math
{
    public class MathUtils
    {
        public static float Lerp(float first, float second, float by)
        {
            return first + (second - first) * by;
        }
    }
}
