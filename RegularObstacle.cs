using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2DPlatformer
{
    internal class RegularObstacle : Obstacle
    {
        public override void EmittModifier()
        {
            throw new NotImplementedException();
        }
        public override void DeleteObstacle() { }

        public RegularObstacle(int height, int width, bool isGrounded)
        {
            Height = height; 
            Width = width;
            IsGrounded = isGrounded;
        }
    }
}
