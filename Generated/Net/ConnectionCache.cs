namespace ACBindings.Internal;


/// <summary>Represents a lightweight container for an internal unsigned long cache value used within the system.</summary>
public unsafe struct ConnectionCache
{
    // Child Types

    /// <summary>Serves as a marker for connections pending closure in ConnectionCache, indicating that cleanup actions should be performed.</summary>
    public unsafe struct CloseConnection
    {
        // Methods
    }

    /// <summary>
    /// Holds the host name, port, and pointer to an established network connection, enabling quick lookup and reuse of connections within the cache.
    /// </summary>
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

