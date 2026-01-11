namespace ACBindings.Internal;

public unsafe struct FakeMessageData
{
    // Child Types
    public unsafe struct FakeMessageData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FakeMessageData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_et;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8310
    /// void __thiscall FakeMessageData::Serialize(FakeMessageData*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FakeMessageData, ACBindings.Internal.Archive*, void>)0x004F8310)(ref this, io_archive);
}

