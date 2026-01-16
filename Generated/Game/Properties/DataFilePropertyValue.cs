namespace ACBindings.Internal;


/// <summary>Encapsulates a file identifier for use in the property framework, holding a BasePropertyValue base instance and an IDClass of 32‑bit data IDs.</summary>
/// <remarks>Contains a BasePropertyValue member rather than inheriting from it. Provides equality comparison, value assignment, timestamp querying (unsupported), and string representation with optional relative path formatting based on context flags.</remarks>
public unsafe struct DataFilePropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_value;

    // Methods

    /// <summary>Retrieves the data ID stored in this property value and writes it into the supplied unsigned integer pointer.
    /// <code>Offset: 0x00423510
    /// bool __thiscall DataFilePropertyValue::InqDataID(StringTokenPropertyValue*,unsigned int*)</code>
    /// </summary>
    /// <param name="value">Pointer to an unsigned int that will receive the data ID.</param>
    /// <returns>True on success; the current implementation always returns true.</returns>
    public byte InqDataID(uint* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataFilePropertyValue, uint*, byte>)0x00423510)(ref this, value);

    /// <summary>Copies the underlying data identifier from the specified BasePropertyValue into this DataFilePropertyValue instance, returning true on success.
    /// <code>Offset: 0x00424050
    /// bool __thiscall DataFilePropertyValue::SetValue(DataFilePropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">Source property value containing the ID to set.</param>
    /// <returns>True if the operation succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataFilePropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424050)(ref this, value);

    /// <summary>Compares this property value to another base property value for equality by verifying type compatibility and matching data identifiers.
    /// <code>Offset: 0x004240C0
    /// bool __thiscall DataFilePropertyValue::Compare(DataFilePropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The base property value to compare against.</param>
    /// <returns>True if the two values represent the same data identifier; otherwise, false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataFilePropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004240C0)(ref this, p);

    /// <summary>Converts the property’s file identifier into a string written to ArgList. If an identifier exists and the context flag at offset 12 equals 10, formats it as a relative path; otherwise returns zero while leaving the hex representation unchanged, and writes “&lt;file unset&gt;” when no identifier is set. The function returns nonzero on success or zero if the flag condition fails.
    /// <code>Offset: 0x0042B3A0
    /// char __thiscall DataFilePropertyValue::GetValueAsString(_DWORD*,int,PStringBase&lt;char&gt;,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a context structure that contains a flag at offset 12 used for conditional path conversion.</param>
    /// <param name="ArgList">String buffer where the formatted result is stored.</param>
    /// <param name="a4">Unused in this implementation.</param>
    /// <returns>Nonzero if the string was successfully produced; zero when the context flag differs from 10 while a value exists.</returns>
    public sbyte GetValueAsString(int a2, ACBindings.Internal.PStringBase__sbyte ArgList, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DataFilePropertyValue, int, ACBindings.Internal.PStringBase__sbyte, int, sbyte>)0x0042B3A0)(ref this, a2, ArgList, a4);
}

