namespace FibreSharp;

public interface IPacketTransport
{
    Task<int> ReceivePacketAsync(byte[] buffer, int offset, int count);
    Task SendPacketAsync(byte[] buffer, int offset, int count);
}