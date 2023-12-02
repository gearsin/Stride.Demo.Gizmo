using Stride.Engine;

namespace CustomGizmo
{
    class CustomGizmoApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
