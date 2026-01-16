namespace ACBindings.Internal;


/// <summary>Encapsulates an RPC server instance, tracking protocols, interface registration state, and binding resources to manage remote procedure call services.</summary>
public unsafe struct RpcServer : System.IDisposable
{
    // Statics
    public static ACBindings.Internal._SECURITY_DESCRIPTOR* sm_sid = (ACBindings.Internal._SECURITY_DESCRIPTOR*)0x009065C0;

    // Members
    public uint m_dwProtocols;
    public System.IntPtr m_hRpcInterface;
    public sbyte* m_pszServiceName;
    public int m_fInterfaceAdded;
    public int m_fEpRegistered;
    public int m_fServerStarted;
    public System.IntPtr m_pBindingVector;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Unregisters the RPC interface associated with this server, releasing endpoint registrations and binding vector resources.
    /// <code>Offset: 0x006BA9F0
    /// unsigned int __thiscall RpcServer::UnRegisterInterface(RpcServer*)</code>
    /// </summary>
    /// <returns>An unsigned integer status code from the final unregistration operation; zero indicates success.</returns>
    public uint UnRegisterInterface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RpcServer, uint>)0x006BA9F0)(ref this);

    /// <summary>Shuts down an RPC server if it is currently listening, unregisters its interface, resets internal state—including protocol flags and security identifiers—and frees the allocated service name string.
    /// <code>Offset: 0x006BAA50
    /// void __thiscall RpcServer::~RpcServer(RpcServer*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RpcServer, void>)0x006BAA50)(ref this);
}

