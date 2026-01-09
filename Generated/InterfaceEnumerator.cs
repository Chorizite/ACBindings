namespace ACBindings;

// InterfaceEnumerator
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
    // void __thiscall InterfaceEnumerator::InterfaceEnumerator(InterfaceEnumerator*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceEnumerator, void>)0x005AC5F0)(ref this);
    // void __thiscall InterfaceEnumerator::~InterfaceEnumerator(InterfaceEnumerator*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceEnumerator, void>)0x005AC690)(ref this);
}

