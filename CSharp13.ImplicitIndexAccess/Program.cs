
var dataBuffer = new Buffer<int>(10);
dataBuffer[^1] = 1;

var buffer = new Buffer<int>(10)
{
    [^1] = 1,
    [^2] = 2,
    [^3] = 3,
    [^4] = 4,
    [^5] = 5,
    [^6] = 6,
    [^7] = 7,
    [^8] = 8,
    [^9] = 9,
    [^10] = 10
};


Console.ReadKey();


public class Buffer<T>
{
    private T[] buffer;

    public Buffer(int size)
    {
        buffer = new T[size];
    }

    public T this[Index index]
    {
        get => buffer[index];
        set => buffer[index] = value;
    }

    public void Print()
    {
        for (int i = 0; i < buffer.Length; i++)
        {
            Console.WriteLine($"[{i}] = {buffer[i]}");
        }
    }
}