namespace ACBindings;

// CMostlyConsecutiveIntSet
public unsafe struct CMostlyConsecutiveIntSet : System.IDisposable
{
    // Child Types
    // CMostlyConsecutiveIntSet_vtbl
    public unsafe struct CMostlyConsecutiveIntSet_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.SmartArray__int m_Ints;
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
    // void __thiscall CMostlyConsecutiveIntSet::~CMostlyConsecutiveIntSet(CMostlyConsecutiveIntSet*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMostlyConsecutiveIntSet, void>)0x004F8C10)(ref this);
    // void __thiscall CMostlyConsecutiveIntSet::Sort(CMostlyConsecutiveIntSet*)
    public void Sort() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMostlyConsecutiveIntSet, void>)0x00670F20)(ref this);
    // void __thiscall CMostlyConsecutiveIntSet::CMostlyConsecutiveIntSet(CMostlyConsecutiveIntSet*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMostlyConsecutiveIntSet, void>)0x00670FC0)(ref this);
    // void __thiscall CMostlyConsecutiveIntSet::Serialize(CMostlyConsecutiveIntSet*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMostlyConsecutiveIntSet, ACBindings.Archive*, void>)0x00671040)(ref this, io_archive);
    // bool __thiscall CMostlyConsecutiveIntSet::Add(CMostlyConsecutiveIntSet*,int)
    public byte Add(int NewInt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMostlyConsecutiveIntSet, int, byte>)0x00671280)(ref this, NewInt);
}

