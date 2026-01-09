namespace ACBindings;

// FakeMessageData
public unsafe struct FakeMessageData
{
    // Child Types
    // FakeMessageData_vtbl
    public unsafe struct FakeMessageData_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_et;

    // Methods
    // void __thiscall FakeMessageData::Serialize(FakeMessageData*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FakeMessageData, ACBindings.Archive*, void>)0x004F8310)(ref this, io_archive);
}

