namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x006BA9F0
    /// unsigned int __thiscall RpcServer::UnRegisterInterface(RpcServer*)</code>
    /// </summary>
    public uint UnRegisterInterface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RpcServer, uint>)0x006BA9F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BAA50
    /// void __thiscall RpcServer::~RpcServer(RpcServer*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RpcServer, void>)0x006BAA50)(ref this);
}

