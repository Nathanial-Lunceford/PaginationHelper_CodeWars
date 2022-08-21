// See https://aka.ms/new-console-template for more information

using PaginationHelper_CodeWars;
internal class Program
{
    static void Main(string[] args)
    {
        PagnationHelper pag = new PagnationHelper(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, 4);


        Console.WriteLine($"Pagecount is - {pag.PageCount}");
        Console.WriteLine($"ItemCount is - {pag.ItemCount}");
        
        Console.WriteLine(pag.PageItemCount(0));
        Console.WriteLine(pag.PageItemCount(1));
        Console.WriteLine(pag.PageItemCount(2));

        Console.WriteLine(pag.PageIndex(5));
        Console.WriteLine(pag.PageIndex(2));
        Console.WriteLine(pag.PageIndex(20));
        Console.WriteLine(pag.PageIndex(24));
    }
}