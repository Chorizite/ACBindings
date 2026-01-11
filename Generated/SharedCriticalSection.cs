namespace ACBindings.Internal;

public unsafe struct SharedCriticalSection : System.IDisposable
{
    // Child Types
    public unsafe struct SharedCriticalSection_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedCriticalSection*, void> SharedCriticalSection_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SharedCriticalSection*, void> EnterCriticalSection; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal._RTL_CRITICAL_SECTION myCritSection_;
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

    /// <summary>
    /// <code>Offset: 0x0065E8B0
    /// void __thiscall SharedCriticalSection::SharedCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E8B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065E8D0
    /// void __thiscall SharedCriticalSection::~SharedCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E8D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065E8F0
    /// void __thiscall SharedCriticalSection::EnterCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void EnterCriticalSection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E8F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065E910
    /// void __thiscall SharedCriticalSection::LeaveCriticalSection(SharedCriticalSection*)</code>
    /// </summary>
    public void LeaveCriticalSection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SharedCriticalSection, void>)0x0065E910)(ref this);
}

