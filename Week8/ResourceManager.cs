namespace Week8;

public class ResourceManager<T> where T: Resource
{
    private readonly List<T> _resources = new();
    
    public void Add(T resource)
    {
        _resources.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var file in _resources)
        {
            file.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var file in _resources)
        {
            file.Close();
        } 
    }
}