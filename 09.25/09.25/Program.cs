using 09.25;

using var db = new ProductContext();
Console.WriteLine("Mit csináljunk? 1-Új diák, 2-Új tantárgy, 3-Új Eredmény");
var id = Int32.Parse(Console.ReadLine());
while (true)
{