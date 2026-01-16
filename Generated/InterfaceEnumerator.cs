namespace ACBindings.Internal;


/// <summary>
/// Holds a list of IPv4 addresses for the local machine, populated during construction by resolving the host name.
/// </summary>
public unsafe struct InterfaceEnumerator : System.IDisposable
{
    // Members
    public fixed byte gap0[4];
    public int numInterfaces_;
    public System.IntPtr interfaces_;

    // Generated Constructor
    public InterfaceEnumerator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes an InterfaceEnumerator by resolving the local host name and storing all IPv4 addresses associated with the machine.
    /// <code>Offset: 0x005AC5F0
    /// void __thiscall InterfaceEnumerator::InterfaceEnumerator(InterfaceEnumerator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceEnumerator, void>)0x005AC5F0)(ref this);

    /// <summary>Destroys an InterfaceEnumerator instance, freeing its internal interface array and invoking any necessary base‑class cleanup.
    /// <code>Offset: 0x005AC690
    /// void __thiscall InterfaceEnumerator::~InterfaceEnumerator(InterfaceEnumerator*)</code>
    /// </summary>
    /// <param name="this">Pointer to the enumerator object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceEnumerator, void>)0x005AC690)(ref this);
}

