internal class Program
{
    private static void Main(string[] args)
    {
        int pictures;
        int pictureInRow;
        int numberOfFullRows;
        int leftPictures;

        Console.Write("Введите количество картинок: ");
        pictures = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        pictureInRow = Convert.ToInt32(Console.ReadLine());

        numberOfFullRows = pictures / pictureInRow;
        leftPictures = pictures % pictureInRow;

        Console.WriteLine($"Можно будет вывести {numberOfFullRows} рядов и сверх меры будет {leftPictures} картинок");
    }
}