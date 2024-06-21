public interface IFlyable
{
    void TakeOff();
    void Land();
}

public interface ISwimmable
{
    int MaxDepth { get; set; }
    void Dive(int meters);
    void Surface(int meters);
}