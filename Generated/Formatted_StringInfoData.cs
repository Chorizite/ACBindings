namespace ACBindings;

// Formatted_StringInfoData
public unsafe struct Formatted_StringInfoData
{
    // Child Types
    // Formatted_StringInfoData_vtbl
    public unsafe struct Formatted_StringInfoData_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte m_bGrouping;
    public ushort m_iBase;

    // Methods
    // void __thiscall Formatted_StringInfoData::Serialize(Formatted_StringInfoData*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Formatted_StringInfoData, ACBindings.Archive*, void>)0x0042F250)(ref this, io_rcArchive);
}

