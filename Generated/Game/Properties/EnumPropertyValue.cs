namespace ACBindings.Internal;


/// <summary>
/// Encapsulates an enumeration value in the property framework, storing it as a 32‑bit unsigned integer. Provides operations for copying, comparison, serialization, file node conversion, and string representation.
/// </summary>
public unsafe struct EnumPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public uint m_value;

    // Methods

    /// <summary>Checks whether the supplied MetaSpell contains a non‑null Spell reference.
    /// <code>Offset: 0x00424150
    /// int __thiscall EnumPropertyValue::HasValidData(MetaSpell*)</code>
    /// </summary>
    /// <param name="metaSpell">The MetaSpell instance to examine.</param>
    /// <returns>Non‑zero if the spell data is valid, zero otherwise.</returns>
    public int HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, int>)0x00424150)(ref this);

    /// <summary>Assigns the integer representation of a BasePropertyValue to the enum property via a virtual conversion function.
    /// <code>Offset: 0x00424160
    /// bool __thiscall EnumPropertyValue::SetValue(EnumPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property containing the value to be assigned.</param>
    /// <returns>True when the value was successfully set; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424160)(ref this, value);

    /// <summary>Compares the current EnumPropertyValue instance with a given BasePropertyValue for equality.
    /// <code>Offset: 0x00424180
    /// bool __thiscall EnumPropertyValue::Compare(EnumPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The BasePropertyValue to compare against.</param>
    /// <returns>True if both values are equal and the comparison succeeds; otherwise, false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424180)(ref this, p);

    /// <summary>Copies the current EnumPropertyValue into a newly allocated BasePropertyValue instance.
    /// <code>Offset: 0x00424220
    /// BasePropertyValue* __thiscall EnumPropertyValue::Copy(EnumPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created BasePropertyValue containing the duplicated enum value; returns nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00424220)(ref this);

    /// <summary>Serializes the enum property's integer value to or from an archive, writing when the archive is in write mode and reading otherwise.
    /// <code>Offset: 0x004266F0
    /// void __thiscall EnumPropertyValue::Serialize(StringTokenPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="this">The enum property instance being serialized.</param>
    /// <param name="io_archive">Archive used for serialization.</param>
    /// <param name="i_eName">Identifier of the property (unused).</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x004266F0)(ref this, io_archive, i_eName);

    /// <summary>Parses an enumeration value from a file node according to the given property descriptor and stores it in this instance.
    /// <code>Offset: 0x0042B600
    /// bool __thiscall EnumPropertyValue::FromFileNode(EnumPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor providing type information and metadata for the property.</param>
    /// <param name="node">File node that contains the enum value to be parsed.</param>
    /// <returns>True if the enum was successfully extracted; otherwise, false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042B600)(ref this, desc, node);

    /// <summary>
    /// Adds a representation of this enum property value under the supplied file node. For zero values an empty string node is created; otherwise the enum name or numeric ID is resolved via the descriptor and written as a child node.
    /// 
    /// <code>Offset: 0x0042B770
    /// bool __thiscall EnumPropertyValue::ToFileNode(EnumPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor containing metadata for the property, used to resolve enum names.</param>
    /// <param name="node">Parent file node where the enum value will be added as a sub‑node.</param>
    /// <returns>True if the value was successfully written; otherwise false (e.g., when the node is null or descriptor lookup fails).</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042B770)(ref this, desc, node);

    /// <summary>Converts the enum property value into its string representation using a provided property descriptor.
    /// <code>Offset: 0x0042B860
    /// char __thiscall EnumPropertyValue::GetValueAsString(int*,_DWORD*,char**,char)</code>
    /// </summary>
    /// <param name="a2">Property descriptor used to translate the numeric value stored in this object.</param>
    /// <param name="a3">Pointer to receive the resulting formatted string; the function allocates and assigns a new string to *a3.</param>
    /// <param name="a4">If non‑zero, formats the result as the enum name only; otherwise includes the hex code in brackets.</param>
    /// <returns>Non‑zero if the value was successfully mapped to an enum name; zero if no mapping exists.</returns>
    public sbyte GetValueAsString(int* a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumPropertyValue, int*, sbyte**, sbyte, sbyte>)0x0042B860)(ref this, a2, a3, a4);
}

