namespace ACBindings.Internal;

public unsafe struct Formatted_StringInfoData
{
    // Child Types
    public unsafe struct Formatted_StringInfoData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte m_bGrouping;
    public ushort m_iBase;

    // Methods

    /// <summary>Serializes or deserializes the grouping flag and base index of a Formatted_StringInfoData object to or from an Archive.
    /// <code>Offset: 0x0042F250
    /// void __thiscall Formatted_StringInfoData::Serialize(Formatted_StringInfoData*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The Archive instance used for reading or writing data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Formatted_StringInfoData, ACBindings.Internal.Archive*, void>)0x0042F250)(ref this, io_rcArchive);
}

