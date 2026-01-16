namespace ACBindings.Internal;


/// <summary>Represents a tri‑state property value with states TRUE, FALSE, or UNDEF used for configuration settings and serialization.</summary>
public unsafe struct TriStatePropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.TriState m_value;

    // Methods

    /// <summary>Sets the tri‑state value of this property to the specified unsigned integer and reports success.
    /// <code>Offset: 0x00423520
    /// bool __thiscall TriStatePropertyValue::SetTriState(StringTokenPropertyValue*,const unsigned int)</code>
    /// </summary>
    /// <param name="value">The new tri‑state value to assign.</param>
    /// <returns>True, indicating that the operation succeeded.</returns>
    public byte SetTriState(uint value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, uint, byte>)0x00423520)(ref this, value);

    /// <summary>Assigns a new TriState value to the property from the supplied BasePropertyValue instance.
    /// <code>Offset: 0x004251A0
    /// bool __thiscall TriStatePropertyValue::SetValue(TriStatePropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value providing the new TriState data.</param>
    /// <returns>True if the assignment succeeded; otherwise, false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004251A0)(ref this, value);

    /// <summary>Compares this TriStatePropertyValue with another BasePropertyValue by verifying that the other property is non‑null, passes a virtual compatibility test, and that its internal tri‑state equals the numeric address of the other property cast to an unsigned integer.
    /// <code>Offset: 0x004251C0
    /// bool __thiscall TriStatePropertyValue::Compare(TriStatePropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">Pointer to the BasePropertyValue to compare against.</param>
    /// <returns>True if p is non‑null, satisfies the virtual comparison check, and this->m_value matches the pointer address of p; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004251C0)(ref this, p);

    /// <summary>
    /// Determines whether this TriStatePropertyValue is less than another property value, storing the result in an output boolean.
    /// 
    /// <code>Offset: 0x00425200
    /// bool __thiscall TriStatePropertyValue::InqLessThan(TriStatePropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The right-hand side property to compare against.</param>
    /// <param name="o_rbLessThan">Receives true if this value is less than i_pcRHS; false otherwise.</param>
    /// <returns>True when the comparison succeeds; false if the RHS does not support a less‑than query.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00425200)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Allocates a new BasePropertyValue instance, initializing its reference count and virtual function table pointers based on this TriStatePropertyValue.
    /// <code>Offset: 0x00425240
    /// BasePropertyValue* __thiscall TriStatePropertyValue::Copy(TriStatePropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated BasePropertyValue object, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00425240)(ref this);

    /// <summary>Converts the tri‑state property value into its textual representation and writes it to an output buffer.
    /// <code>Offset: 0x004267E0
    /// char __thiscall TriStatePropertyValue::GetValueAsString(_DWORD*,int,LONG*,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the TriStatePropertyValue instance whose value is converted.</param>
    /// <param name="a2">Reserved parameter; ignored by this implementation.</param>
    /// <param name="a3">Output buffer where the resulting string ("TRUE", "FALSE" or "UNDEF") is stored.</param>
    /// <param name="a4">Reserved parameter; ignored by this implementation.</param>
    /// <returns>Non‑zero if the conversion succeeded; zero indicates failure.</returns>
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, int, int*, int, sbyte>)0x004267E0)(ref this, a2, a3, a4);

    /// <summary>Serializes the TriState property value to or from the provided Archive, updating the internal state when loading.
    /// <code>Offset: 0x00427120
    /// void __thiscall TriStatePropertyValue::Serialize(TriStatePropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; its flags determine whether data is written or read.</param>
    /// <param name="i_eName">Identifier for the serialized field; not utilized in this implementation.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00427120)(ref this, io_archive, i_eName);

    /// <summary>Converts a tri‑state property value into a corresponding file node and attaches it as a child of the supplied node.
    /// <code>Offset: 0x00427160
    /// bool __thiscall TriStatePropertyValue::ToFileNode(TriStatePropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">The property descriptor providing metadata for the value (unused in this implementation).</param>
    /// <param name="node">The file node to which the tri‑state representation will be added.</param>
    /// <returns>True if the sub‑node was created successfully; otherwise, false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00427160)(ref this, desc, node);

    /// <summary>
    /// Parses a file node containing the tri‑state keyword (true, false, undef) and sets the TriStatePropertyValue accordingly.
    /// 
    /// <code>Offset: 0x00427FA0
    /// bool __thiscall TriStatePropertyValue::FromFileNode(TriStatePropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor of the property; passed for consistency but not used in this parsing routine.</param>
    /// <param name="node">The PFileNode from which to read the keyword string. Must be a leaf node containing one of the recognized keywords.</param>
    /// <returns>True if the node was parsed successfully and m_value set; otherwise false, reporting an error for missing or invalid leaf nodes.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TriStatePropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00427FA0)(ref this, desc, node);
}

