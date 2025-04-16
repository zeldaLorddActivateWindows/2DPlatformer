using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DPlatformer
{
    internal class Field
    {
        public string? Name { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Field(string? name, int height, int width)
        {
            Name = name;
            Height = height;
            Width = width;
        }
    }
}
