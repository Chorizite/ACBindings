namespace ACBindings.Internal;


/// <summary>Represents an interface for interacting with the PacketController, exposing a method to retrieve a persistent 64‑bit identifier. Holds a static reference to the current NetInterface instance.</summary>
public unsafe struct NetInterface
{
    // Statics
    public static ACBindings.Internal.NetInterface** netInterface_ = (ACBindings.Internal.NetInterface**)0x00846F74;

    // Generated Constructor
    public NetInterface() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a NetInterface instance and registers it as the active network interface.
    /// <code>Offset: 0x005497A0
    /// void __thiscall NetInterface::NetInterface(NetInterface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInterface, void>)0x005497A0)(ref this);

    /// <summary>Obtains a persistent 64‑bit identifier from the PacketController singleton.
    /// <code>Offset: 0x005497B0
    /// unsigned __int64 __thiscall NetInterface::GetNonEphemeralID(NetInterface*)</code>
    /// </summary>
    /// <returns>The non‑ephemeral ID returned by PacketController::GetNonEphemeralID.</returns>
    public ulong GetNonEphemeralID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetInterface, ulong>)0x005497B0)(ref this);
}

