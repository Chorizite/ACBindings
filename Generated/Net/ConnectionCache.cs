namespace ACBindings;

// ConnectionCache
public unsafe struct ConnectionCache
{
    // Child Types
    // ConnectionCache::CloseConnection
    public unsafe struct CloseConnection
    {
        // Methods
    }
    // ConnectionCache::Entry
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

