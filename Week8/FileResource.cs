namespace Week8;

public class FileResource: Resource, IDisposable
{

    public FileResource(string name) : base(name)
    {
        
    }
    
    public override void Open()
    {
        IsOpen = true;
        throw new NotImplementedException();
    }
    
    
    public override void Close()
    {
        IsOpen = false;
        throw new NotImplementedException();
    }
    
    
    public void Dispose()
    {
        // TODO: call Close() and print diagnostic message
        throw new NotImplementedException();
    }
    

    
}