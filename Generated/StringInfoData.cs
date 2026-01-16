namespace ACBindings.Internal;


/// <summary>Base structure for string metadata, holding a type identifier and variable ID used in serialization and comparison logic.</summary>
/// <remarks>Serves as the foundation for derived classes that handle specific string formats such as simple strings, doubles, formatted integers, and other variants.</remarks>
public unsafe struct StringInfoData
{
    // Child Types
    public unsafe struct StringInfoData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfoData*, void> StringInfoData_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfoData*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfoData*, byte, byte> IsValid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ushort m_eType;
    public uint m_eVarID;

    // Methods

    /// <summary>Create a new instance of a StringInfoData-derived object corresponding to the specified type identifier.
    /// <code>Offset: 0x0042ED90
    /// StringInfoData* __cdecl StringInfoData::Create(unsigned __int16)</code>
    /// </summary>
    /// <param name="i_eType">The numeric identifier indicating which concrete string info subtype to instantiate.</param>
    /// <returns>A pointer to the allocated object, or nullptr if allocation fails or an unsupported type is requested.</returns>
    public static ACBindings.Internal.StringInfoData* Create(ushort i_eType) => ((delegate* unmanaged[Cdecl]<ushort, ACBindings.Internal.StringInfoData*>)0x0042ED90)(i_eType);

    /// <summary>Compares two StringInfoData instances for equality, delegating to the appropriate subtype comparison based on their m_eType field.
    /// <code>Offset: 0x0042F050
    /// bool __cdecl StringInfoData::Compare(const StringInfoData*,const StringInfoData*)</code>
    /// </summary>
    /// <param name="i_pcLhs">Left‑hand side object to compare.</param>
    /// <param name="i_pcRhs">Right‑hand side object to compare.</param>
    /// <returns>True if both objects are non‑null, share the same type, and the underlying data values are equal; otherwise false.</returns>
    public static byte Compare(ACBindings.Internal.StringInfoData* i_pcLhs, ACBindings.Internal.StringInfoData* i_pcRhs) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.StringInfoData*, ACBindings.Internal.StringInfoData*, byte>)0x0042F050)(i_pcLhs, i_pcRhs);

    /// <summary>Serializes or deserializes the object's type and variable ID to or from the specified Archive.
    /// <code>Offset: 0x0042F0E0
    /// void __thiscall StringInfoData::Serialize(StringInfoData*,Archive*)</code>
    /// </summary>
    /// <param name="rArchive">The archive used for reading or writing the data. When the archive's flags indicate write mode, the current values of m_eType and m_eVarID are written; otherwise they are read into the object.</param>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoData, ACBindings.Internal.Archive*, void>)0x0042F0E0)(ref this, rArchive);

    /// <summary>Creates and returns a deep copy of the given StringInfoData instance. The allocation size depends on m_eType, and the appropriate copy routine is invoked to duplicate the data.
    /// <code>Offset: 0x0042F3A0
    /// StringInfoData* __cdecl StringInfoData::Copy(const StringInfoData*)</code>
    /// </summary>
    /// <param name="i_pcRhs">The source StringInfoData object to be copied. May be null, in which case no copy occurs.</param>
    /// <returns>A pointer to a newly allocated StringInfoData containing an identical copy of i_pcRhs, or nullptr if copying fails or i_pcRhs is null.</returns>
    public static ACBindings.Internal.StringInfoData* Copy(ACBindings.Internal.StringInfoData* i_pcRhs) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.StringInfoData*, ACBindings.Internal.StringInfoData*>)0x0042F3A0)(i_pcRhs);
}

