using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace _2DPlatformer
{
    internal class FieryObstacle : Obstacle
    {
        public override string? Modifier { get => "Fiery"; }

        public override void EmittModifier()
        {
            throw new NotImplementedException();
        }
        public override void DeleteObstacle() { }

        public FieryObstacle(float height, float width, bool isGrounded)
        {
            Height = height;
            Width = width;
            IsGrounded = isGrounded;
            Children.Add(this);
        }
    }
}
