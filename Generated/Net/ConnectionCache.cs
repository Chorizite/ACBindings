namespace ACBindings.Internal;

public unsafe struct ConnectionCache
{
    // Child Types
    public unsafe struct CloseConnection
    {
        // Methods
    }
    public unsafe struct Entry
    {
        // Members
        public ushort* hostName;
        public uint hostPort;
        public System.IntPtr hostConnection;

        // Methods
    }

    // Members
    public uint m_cache;

    // Methods
}

