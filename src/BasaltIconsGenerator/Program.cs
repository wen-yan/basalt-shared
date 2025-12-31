namespace BasaltIconsGenerator;

class Program
{
    static void Main(string[] args)
    {
        Generator.Generate(new RenderContext(Constants.Theme), "../../../../../icons");
    }
}