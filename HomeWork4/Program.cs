internal class Program
{
    private static void Main(string[] args)
    {
        int picture;
        int pictureInRow;
        int numberOfFullRows;
        int remainPicture;

        Console.Write("Введите количество картинок: ");
        picture = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество картинок в столбце: ");
        pictureInRow = Convert.ToInt32(Console.ReadLine());

        numberOfFullRows = picture / pictureInRow;
        remainPicture = picture % pictureInRow;

        Console.WriteLine($"Можно будет вывести {numberOfFullRows} рядов и сверх меры будет {remainPicture} картинок");
    }
}