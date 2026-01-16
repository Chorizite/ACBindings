namespace ACBindings.Internal;


/// <summary>Encapsulates a double value with formatting options such as precision, grouping, and numeric base, enabling conversion to a formatted string and persistence through serialization.</summary>
public unsafe struct Formatted_Double_StringInfoData
{
    // Base Classes
    public ACBindings.Internal.Double_StringInfoData BaseClass_Double_StringInfoData; // ACBindings.Internal.Double_StringInfoData
    public ACBindings.Internal.Formatted_StringInfoData BaseClass_Formatted_StringInfoData; // ACBindings.Internal.Formatted_StringInfoData

    // Child Types
    public unsafe struct Formatted_Double_StringInfoData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_Double_StringInfoData*, void> Formatted_Double_StringInfoData_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_Double_StringInfoData*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_Double_StringInfoData*, byte, byte> IsValid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Formatted_Double_StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Methods

    /// <summary>Serializes the double‑string information data, including formatting flags and numeric precision, to or from an archive.
    /// <code>Offset: 0x0042F2A0
    /// void __thiscall Formatted_Double_StringInfoData::Serialize(Formatted_Double_StringInfoData*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive used for reading or writing the object's state; the operation performed depends on the archive’s mode flag.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Formatted_Double_StringInfoData, ACBindings.Internal.Archive*, void>)0x0042F2A0)(ref this, io_rcArchive);

    /// <summary>Formats the double value stored in this instance into a string using the object's precision, grouping, and base options.
    /// <code>Offset: 0x0042FA90
    /// int* __thiscall Formatted_Double_StringInfoData::ToString(int,int*)</code>
    /// </summary>
    /// <param name="a2">Buffer into which the formatted string will be written.</param>
    /// <returns>The same buffer pointer that was passed in, now containing the formatted string.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Formatted_Double_StringInfoData, int*, int*>)0x0042FA90)(ref this, a2);
}

