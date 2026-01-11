namespace ACBindings.Internal;

public unsafe struct CMostlyConsecutiveIntSet : System.IDisposable
{
    // Child Types
    public unsafe struct CMostlyConsecutiveIntSet_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CMostlyConsecutiveIntSet*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.SmartArray__int m_Ints;
    public byte m_bSorted;

    // Generated Constructor
    public CMostlyConsecutiveIntSet() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8C10
    /// void __thiscall CMostlyConsecutiveIntSet::~CMostlyConsecutiveIntSet(CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, void>)0x004F8C10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00670F20
    /// void __thiscall CMostlyConsecutiveIntSet::Sort(CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public void Sort() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, void>)0x00670F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00670FC0
    /// void __thiscall CMostlyConsecutiveIntSet::CMostlyConsecutiveIntSet(CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, void>)0x00670FC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00671040
    /// void __thiscall CMostlyConsecutiveIntSet::Serialize(CMostlyConsecutiveIntSet*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, ACBindings.Internal.Archive*, void>)0x00671040)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00671280
    /// bool __thiscall CMostlyConsecutiveIntSet::Add(CMostlyConsecutiveIntSet*,int)</code>
    /// </summary>
    public byte Add(int NewInt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMostlyConsecutiveIntSet, int, byte>)0x00671280)(ref this, NewInt);
}

