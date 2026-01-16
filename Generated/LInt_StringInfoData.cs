namespace ACBindings.Internal;


/// <summary>Wraps a 64‑bit integer value together with a base StringInfoData object, enabling numeric data to be integrated into the string information system and rendered as text.</summary>
public unsafe struct LInt_StringInfoData
{
    // Base Classes
    public ACBindings.Internal.StringInfoData BaseClass_StringInfoData; // ACBindings.Internal.StringInfoData

    // Child Types
    public unsafe struct LInt_StringInfoData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LInt_StringInfoData*, void> LInt_StringInfoData_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LInt_StringInfoData*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LInt_StringInfoData*, byte, byte> IsValid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LInt_StringInfoData*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public long m_iVal;

    // Methods

    /// <summary>Converts the 64‑bit integer stored in the object into a decimal string and writes it to the supplied buffer.
    /// <code>Offset: 0x0042FA00
    /// int* __thiscall LInt_StringInfoData::ToString(__int64*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an output buffer that will contain the resulting null‑terminated string.</param>
    /// <returns>The same pointer that was passed in, pointing to the formatted string.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LInt_StringInfoData, int*, int*>)0x0042FA00)(ref this, a2);
}

