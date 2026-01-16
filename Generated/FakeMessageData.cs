namespace ACBindings.Internal;


/// <summary>Holds a message type identifier used during serialization, with virtual function table support for polymorphic handling.</summary>
public unsafe struct FakeMessageData
{
    // Child Types

    /// <summary>Provides a virtual table for FakeMessageData, exposing a Serialize method to persist message state.</summary>
    public unsafe struct FakeMessageData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FakeMessageData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_et;

    // Methods

    /// <summary>Serializes the message type identifier to or from an Archive, handling both write and read operations while ensuring proper alignment.
    /// <code>Offset: 0x004F8310
    /// void __thiscall FakeMessageData::Serialize(FakeMessageData*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization; its flags determine whether the operation writes the current value of m_et into the archive or reads a new value into it.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FakeMessageData, ACBindings.Internal.Archive*, void>)0x004F8310)(ref this, io_archive);
}

