namespace ACBindings.Internal;

public unsafe struct StringInfo_StringInfoData
{
    // Base Classes
    public ACBindings.Internal.StringInfoData BaseClass_StringInfoData; // ACBindings.Internal.StringInfoData

    // Child Types
    public unsafe struct StringInfo_StringInfoData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfo_StringInfoData*, void> StringInfo_StringInfoData_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfo_StringInfoData*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfo_StringInfoData*, byte, byte> IsValid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfo_StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public ACBindings.Internal.StringInfo m_cVal;

    // Generated Constructor
    public StringInfo_StringInfoData(uint i_eVarID) {
        _ConstructorInternal(i_eVarID);
    }

    // Methods

    /// <summary>Initializes a StringInfo_StringInfoData instance, assigning the specified variable ID and setting its type to 1.
    /// <code>Offset: 0x0042EA40
    /// void __thiscall StringInfo_StringInfoData::StringInfo_StringInfoData(StringInfo_StringInfoData*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eVarID">Identifier for the variable represented by this string info data.</param>
    public void _ConstructorInternal(uint i_eVarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo_StringInfoData, uint, void>)0x0042EA40)(ref this, i_eVarID);

    /// <summary>Collects all sub‑data identifiers from the internal string value and stores them in the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x0042EAE0
    /// void __thiscall StringInfo_StringInfoData::GetSubDataIDs(StringInfo_StringInfoData*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the collected data IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo_StringInfoData, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0042EAE0)(ref this, id_array);

    /// <summary>Checks whether the string information stored in this instance is valid, optionally recursively validating any child objects.
    /// <code>Offset: 0x0042EAF0
    /// bool __thiscall StringInfo_StringInfoData::IsValid(StringInfo_StringInfoData*,bool)</code>
    /// </summary>
    /// <param name="i_bValidateChildren">If true, perform validation on child elements; otherwise only validate the top‑level data.</param>
    /// <returns>True if the string and its validated children are well‑formed; otherwise false.</returns>
    public byte IsValid(byte i_bValidateChildren) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo_StringInfoData, byte, byte>)0x0042EAF0)(ref this, i_bValidateChildren);

    /// <summary>Serializes the string information data to the specified archive by delegating serialization of its base class and contained string value.
    /// <code>Offset: 0x0042F150
    /// void __thiscall StringInfo_StringInfoData::Serialize(StringInfo_StringInfoData*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive used for reading or writing the serialized data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo_StringInfoData, ACBindings.Internal.Archive*, void>)0x0042F150)(ref this, io_rcArchive);

    /// <summary>Retrieves sub‑private identifiers for this StringInfo instance by delegating to its base StringInfo implementation.
    /// <code>Offset: 0x0042F170
    /// int* __thiscall StringInfo_StringInfoData::GetSubPrivateIDs(unsigned int*,QualifiedDataIDArray*,int)</code>
    /// </summary>
    /// <param name="a2">Collection of qualified data IDs that will be populated with the retrieved sub‑private identifiers.</param>
    /// <param name="a3">Integer flag or count influencing which identifiers are collected.</param>
    /// <returns>Pointer to an array of integer sub‑private IDs, or null if no identifiers were found.</returns>
    public int* GetSubPrivateIDs(ACBindings.Internal.QualifiedDataIDArray* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo_StringInfoData, ACBindings.Internal.QualifiedDataIDArray*, int, int*>)0x0042F170)(ref this, a2, a3);

    /// <summary>Produces a wide‑string representation of the StringInfo_StringInfoData instance, handling reference counting and logging an error if rendering fails.
    /// <code>Offset: 0x0042F920
    /// volatile LONG** __thiscall StringInfo_StringInfoData::ToString(_DWORD*,volatile LONG**)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the newly created string buffer; the function increments its reference count before returning it.</param>
    /// <returns>The same pointer passed in via <paramref name="a2"/>, pointing to the rendered wide‑string.</returns>
    public int** ToString(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfo_StringInfoData, int**, int**>)0x0042F920)(ref this, a2);
}

