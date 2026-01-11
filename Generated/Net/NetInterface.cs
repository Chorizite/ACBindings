namespace ACBindings.Internal;

public unsafe struct NetInterface
{
    // Statics
    public static ACBindings.Internal.NetInterface* netInterface_ = (ACBindings.Internal.NetInterface*)0x00846F74;

    // Generated Constructor
    public NetInterface() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005497A0
    /// void __thiscall NetInterface::NetInterface(NetInterface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInterface, void>)0x005497A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005497B0
    /// unsigned __int64 __thiscall NetInterface::GetNonEphemeralID(NetInterface*)</code>
    /// </summary>
    public ulong GetNonEphemeralID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInterface, ulong>)0x005497B0)(ref this);
}

