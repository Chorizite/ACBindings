namespace ACBindings;

// SharedCriticalSection
public unsafe struct SharedCriticalSection : System.IDisposable
{
    // Child Types
    // SharedCriticalSection_vtbl
    public unsafe struct SharedCriticalSection_vtbl
    {
        // Members
        public System.IntPtr SharedCriticalSection_dtor_0; // function pointer
        public System.IntPtr EnterCriticalSection; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings._RTL_CRITICAL_SECTION myCritSection_;
    public uint lockHolder_;
    public int lockCount_;

    // Generated Constructor
    public SharedCriticalSection() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall SharedCriticalSection::SharedCriticalSection(SharedCriticalSection*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedCriticalSection, void>)0x0065E8B0)(ref this);
    // void __thiscall SharedCriticalSection::~SharedCriticalSection(SharedCriticalSection*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedCriticalSection, void>)0x0065E8D0)(ref this);
    // void __thiscall SharedCriticalSection::EnterCriticalSection(SharedCriticalSection*)
    public void EnterCriticalSection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedCriticalSection, void>)0x0065E8F0)(ref this);
    // void __thiscall SharedCriticalSection::LeaveCriticalSection(SharedCriticalSection*)
    public void LeaveCriticalSection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SharedCriticalSection, void>)0x0065E910)(ref this);
}

