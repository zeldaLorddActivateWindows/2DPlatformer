using Raylib_cs;
namespace _2DPlatformer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Field field = new Field("Platformer", 250, 500);
            //Raylib.InitWindow(field.Width, field.Height, field.Name);
            Obstacle obstacle = new FieryObstacle(100, 100, false);

        }
    }
}
