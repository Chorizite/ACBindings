namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x005AC5F0
    /// void __thiscall InterfaceEnumerator::InterfaceEnumerator(InterfaceEnumerator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceEnumerator, void>)0x005AC5F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AC690
    /// void __thiscall InterfaceEnumerator::~InterfaceEnumerator(InterfaceEnumerator*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceEnumerator, void>)0x005AC690)(ref this);
}

