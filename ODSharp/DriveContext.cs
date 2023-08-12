using ODSharp.Generated;

namespace ODSharp;

public sealed class DriveContext : IDisposable
{
    private bool _isDisposed = false;
    private readonly C_ _root;
    private readonly IDisposable _deviceLifetime;

    public DriveContext(C_ root, IDisposable deviceLifetime)
    {
        _root = root;
        _deviceLifetime = deviceLifetime;
    }

    public C_ Root
    {
        get
        {
            EnsureNotDisposed();
            return _root;
        }
    }

    private void EnsureNotDisposed()
    {
        if (_isDisposed)
        {
            throw new ObjectDisposedException(nameof(DriveContext));
        }
    }

    public void Dispose()
    {
        if (_isDisposed)
        {
            return;
        }

        _isDisposed = true;
        _deviceLifetime.Dispose();
    }
}