namespace HomeWorkLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"17/4 = {quotient} остаток {remainder}");
        }
    }
}
