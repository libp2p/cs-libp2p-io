namespace LibP2P.IO
{
    public interface IReader
    {
        int Read(byte[] buffer, int offset, int count);
    }
}