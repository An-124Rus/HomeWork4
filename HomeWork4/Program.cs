internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfPictures;
        int numberOfRows;
        int numberOfFullRows;
        int leftPictures;

        Console.Write("Введите количество картинок: ");
        numberOfPictures = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        numberOfRows = Convert.ToInt32(Console.ReadLine());

        numberOfFullRows = numberOfPictures / numberOfRows;
        leftPictures = numberOfPictures - numberOfFullRows * numberOfRows;

        Console.WriteLine($"Можно будет вывести {numberOfFullRows} рядов и сверх меры будет {leftPictures} картинок");
    }
}