namespace Adventure
{
    internal class Program
    {
        private const int mapWidth = 100;
        private const int mapHeight = mapWidth / 2;

        private const ConsoleColor BorderColor = ConsoleColor.White;

        static void Main()
        {
            Console.SetWindowSize(mapWidth, mapHeight);
            Console.SetBufferSize(mapWidth, mapHeight);
            Console.CursorVisible = false;

            drawBorder();

            Console.ReadKey();
        }

        static void drawBorder()
        {
            //верхний и нижний края
            for (int i = 0; i < mapWidth; i++)
            {
                new Pixel(i, 0, BorderColor).Draw();
                new Pixel(i, mapHeight - 1, BorderColor).Draw();
            }
            //левый и правый края
            for (int i = 0; i < mapHeight; i++)
            {
                new Pixel(0, i, BorderColor).Draw();
                new Pixel(mapWidth - 1, i, BorderColor).Draw();
            }
        }
    }
}