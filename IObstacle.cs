using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DPlatformer
{
    internal interface IObstacle
    {
        public int Height { get; }
        public int Width { get; }
        public bool IsGrounded { get;  }
        public string? Modifier { get; set; } 

        public virtual void EmittModifier()
        {
            throw new NotImplementedException();
        }
        public abstract void DeleteObstacle();
    }
}
