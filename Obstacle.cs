using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DPlatformer
{
    internal abstract class Obstacle : IObstacle
    {
        public List<Obstacle> Children { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public bool IsGrounded { get; set; }
        public virtual string? Modifier { get; set; }

        public virtual void EmittModifier()
        {
            throw new NotImplementedException();
        }
        public abstract void DeleteObstacle();
    }
}
