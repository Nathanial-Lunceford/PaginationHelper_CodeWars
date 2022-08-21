// See https://aka.ms/new-console-template for more information

using PaginationHelper_CodeWars;
internal class Program
{
    static void Main(string[] args)
    {
        PagnationHelper pag = new PagnationHelper(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);


        Console.WriteLine($"Pagecount is - {pag.PageCount}");
        Console.WriteLine($"ItemCount is - {pag.ItemCount}");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");
    }
}