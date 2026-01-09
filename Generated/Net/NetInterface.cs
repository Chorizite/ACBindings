namespace ACBindings;

// NetInterface
public unsafe struct NetInterface
{
    // Statics
    public static ACBindings.NetInterface* netInterface_ = (ACBindings.NetInterface*)0x00846F74;

    // Generated Constructor
    public NetInterface() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall NetInterface::NetInterface(NetInterface*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetInterface, void>)0x005497A0)(ref this);
    // unsigned __int64 __thiscall NetInterface::GetNonEphemeralID(NetInterface*)
    public ulong GetNonEphemeralID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NetInterface, ulong>)0x005497B0)(ref this);
}

