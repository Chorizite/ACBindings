namespace ACBindings.Internal;

public unsafe struct Formatted_LInt_StringInfoData
{
    // Base Classes
    public ACBindings.Internal.LInt_StringInfoData BaseClass_LInt_StringInfoData; // ACBindings.Internal.LInt_StringInfoData
    public ACBindings.Internal.Formatted_StringInfoData BaseClass_Formatted_StringInfoData; // ACBindings.Internal.Formatted_StringInfoData

    // Child Types
    public unsafe struct Formatted_LInt_StringInfoData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_LInt_StringInfoData*, void> Formatted_LInt_StringInfoData_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_LInt_StringInfoData*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_LInt_StringInfoData*, byte, byte> IsValid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_LInt_StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Methods

    /// <summary>Serializes a Formatted_LInt_StringInfoData instance to or from an Archive, handling its integer value, grouping flag, and base value.
    /// <code>Offset: 0x0042F2F0
    /// void __thiscall Formatted_LInt_StringInfoData::Serialize(Formatted_ULInt_StringInfoData*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Formatted_LInt_StringInfoData, ACBindings.Internal.Archive*, void>)0x0042F2F0)(ref this, io_rcArchive);

    /// <summary>Formats the object's 64‑bit integer into a string according to its formatting settings.
    /// <code>Offset: 0x0042FAC0
    /// int* __thiscall Formatted_LInt_StringInfoData::ToString(int,int*)</code>
    /// </summary>
    /// <param name="a2">The buffer that receives the formatted number string.</param>
    /// <returns>The same buffer pointer supplied, containing the formatted representation.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Formatted_LInt_StringInfoData, int*, int*>)0x0042FAC0)(ref this, a2);
}

