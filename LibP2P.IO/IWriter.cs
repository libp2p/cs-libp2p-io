namespace LibP2P.IO
{
    public interface IWriter
    {
        int Write(byte[] buffer, int offset, int count);
    }
}