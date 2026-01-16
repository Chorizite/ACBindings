namespace ACBindings.Internal;


/// <summary>Encapsulates a double value with an associated display precision, enabling formatted text representation and binary persistence within the string information subsystem.</summary>
public unsafe struct Double_StringInfoData
{
    // Base Classes
    public ACBindings.Internal.StringInfoData BaseClass_StringInfoData; // ACBindings.Internal.StringInfoData

    // Child Types
    public unsafe struct Double_StringInfoData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Double_StringInfoData*, void> Double_StringInfoData_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Double_StringInfoData*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Double_StringInfoData*, byte, byte> IsValid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Double_StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public double m_fVal;
    public ushort m_iPrecision;

    // Methods

    /// <summary>Serializes a Double_StringInfoData object to or from an Archive, storing its double value and precision with proper alignment.
    /// <code>Offset: 0x0042F180
    /// void __thiscall Double_StringInfoData::Serialize(Double_StringInfoData*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive used for serialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Double_StringInfoData, ACBindings.Internal.Archive*, void>)0x0042F180)(ref this, io_rcArchive);

    /// <summary>Converts the object's double value into a formatted string using its precision setting and writes it into the supplied buffer.
    /// <code>Offset: 0x0042F9D0
    /// int* __thiscall Double_StringInfoData::ToString(int,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer array that receives the resulting null‑terminated string representation of the double value.</param>
    /// <returns>Returns the same pointer passed in, now pointing to the formatted string.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Double_StringInfoData, int*, int*>)0x0042F9D0)(ref this, a2);
}

