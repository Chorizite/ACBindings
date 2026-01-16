namespace ACBindings.Internal;


/// <summary>Represents a 64‑bit unsigned integer value within the string information system, extending StringInfoData to provide serialization and conversion to text.</summary>
public unsafe struct ULInt_StringInfoData
{
    // Base Classes
    public ACBindings.Internal.StringInfoData BaseClass_StringInfoData; // ACBindings.Internal.StringInfoData

    // Child Types
    public unsafe struct ULInt_StringInfoData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ULInt_StringInfoData*, void> ULInt_StringInfoData_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ULInt_StringInfoData*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ULInt_StringInfoData*, byte, byte> IsValid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ULInt_StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public ulong m_iVal;

    // Methods

    /// <summary>Serializes or deserializes the 64‑bit integer member of ULInt_StringInfoData to or from an Archive, ensuring proper alignment and handling read/write based on archive flags.
    /// <code>Offset: 0x0042F200
    /// void __thiscall ULInt_StringInfoData::Serialize(ULInt_StringInfoData*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The Archive used for reading or writing the data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ULInt_StringInfoData, ACBindings.Internal.Archive*, void>)0x0042F200)(ref this, io_rcArchive);

    /// <summary>Converts the unsigned 64‑bit value stored in this ULInt_StringInfoData instance into its decimal string representation and writes it into the supplied buffer.
    /// <code>Offset: 0x0042FA30
    /// int* __thiscall ULInt_StringInfoData::ToString(unsigned __int64*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer that receives the formatted number as a null‑terminated string.</param>
    /// <returns>The same pointer passed in as a2, now pointing to the resulting string.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ULInt_StringInfoData, int*, int*>)0x0042FA30)(ref this, a2);
}

