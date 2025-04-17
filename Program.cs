

using Raylib_cs;
namespace _2DPlatformer

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field("Platformer", 500, 1000);
            Raylib.InitWindow(field.Width, field.Height, field.Name);
            Raylib.SetTargetFPS(60); 

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black); 
                
                if (field.obstacles.Count < 10)
                {
                    if (Random.Shared.Next(0, 3) == 0) field.obstacles.Add(new FieryObstacle(100, 100, false));
                    else field.obstacles.Add(new RegularObstacle(100, 100, false));
                }

                foreach (var obstacle in field.obstacles)
                {
                    
                    Color color = new Color();
                    switch (obstacle.Modifier)
                    {
                        case null: color = Color.White; break;
                        case "Fiery": color = Color.Red; break;
                    }

                    Raylib.DrawRectangle(
                        Random.Shared.Next(0, Raylib.GetScreenWidth()),
                        Random.Shared.Next(0, Raylib.GetScreenHeight()),
                        obstacle.Width, obstacle.Height, color);
                }
                Raylib.EndDrawing(); 
            }
            Raylib.CloseWindow(); 
        }
    }
}
