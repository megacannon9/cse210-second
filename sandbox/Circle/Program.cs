class Program
{

    static void main()
    {
        int x = 10;

        Circle myCircle = new Circle(10);

        double area = myCircle.GetArea();
        Console.WriteLine(area);
    }
}