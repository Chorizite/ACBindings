namespace ACBindings;

// RpcServer
public unsafe struct RpcServer : System.IDisposable
{
    // Statics
    public static ACBindings._SECURITY_DESCRIPTOR* sm_sid = (ACBindings._SECURITY_DESCRIPTOR*)0x009065C0;

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
    // unsigned int __thiscall RpcServer::UnRegisterInterface(RpcServer*)
    public uint UnRegisterInterface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RpcServer, uint>)0x006BA9F0)(ref this);
    // void __thiscall RpcServer::~RpcServer(RpcServer*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RpcServer, void>)0x006BAA50)(ref this);
}

