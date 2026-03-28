using Week8;
class Program
{
    public static void Main()
    {
        var file = new FileResource("reposts.txt");
        var network = new NetworkResource("api.compant.local");

        var manager = new ResourceManager<Resource>();
        
        manager.Add(file);
        manager.Add(network);
        
        manager.OpenAll();
        using (file)
        {
            Console.WriteLine($"Using file {file.IsOpen}");
        }
        
        manager.CloseAll();
        Console.WriteLine("Done");
    }
    
}