namespace ACBindings.Internal;


/// <summary>
/// Represents a boolean property value within the system, providing storage and management of true/false state for configuration or runtime data.
/// </summary>
public unsafe struct BoolPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public byte m_value;

    // Methods

    /// <summary>Retrieves the stored boolean value of the property and writes it to the supplied output parameter.
    /// <code>Offset: 0x00423AF0
    /// bool __thiscall BoolPropertyValue::InqBool(BoolPropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="value">Pointer to a bool where the current value will be written.</param>
    /// <returns>True if the operation succeeded (always true for this implementation).</returns>
    public byte InqBool(byte* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, byte*, byte>)0x00423AF0)(ref this, value);

    /// <summary>Assigns a boolean to the property.
    /// <code>Offset: 0x00423B00
    /// bool __thiscall BoolPropertyValue::SetBool(BoolPropertyValue*,const bool)</code>
    /// </summary>
    /// <param name="value">The new boolean value.</param>
    /// <returns>Always true after setting the value.</returns>
    public byte SetBool(byte value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, byte, byte>)0x00423B00)(ref this, value);

    /// <summary>Stores a boolean value extracted from the specified property into this instance.
    /// <code>Offset: 0x00423B10
    /// bool __thiscall BoolPropertyValue::SetValue(BoolPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property containing the value to be stored.</param>
    /// <returns>True if conversion succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00423B10)(ref this, value);

    /// <summary>Compares this BoolPropertyValue instance against another BasePropertyValue, returning true when both represent the same boolean value.
    /// <code>Offset: 0x00423B30
    /// bool __thiscall BoolPropertyValue::Compare(BoolPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The property value to compare with; must not be null and should be a BoolPropertyValue.</param>
    /// <returns>True if p is non‑null and has the identical bool value as this object; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00423B30)(ref this, p);

    /// <summary>Compares the stored boolean value with that of another property value and reports whether it is less than the other.
    /// <code>Offset: 0x00423B70
    /// bool __thiscall BoolPropertyValue::InqLessThan(BoolPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The property value to compare against.</param>
    /// <param name="o_rbLessThan">Receives true if this object's value is less than i_pcRHS's value; otherwise false.</param>
    /// <returns>True when the comparison was performed successfully; false if the right-hand side could not be interpreted as a boolean property.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00423B70)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Switches the Boolean property value to its opposite.
    /// <code>Offset: 0x00423CA0
    /// void __thiscall BoolPropertyValue::toggle(BoolPropertyValue*)</code>
    /// </summary>
    public void toggle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, void>)0x00423CA0)(ref this);

    /// <summary>Creates a copy of this BoolPropertyValue as a new BasePropertyValue instance, initializing its reference count and storing the boolean value.
    /// <code>Offset: 0x00423CB0
    /// BasePropertyValue* __thiscall BoolPropertyValue::Copy(BoolPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated BasePropertyValue containing the copied boolean; null if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00423CB0)(ref this);

    /// <summary>Serializes the bool value stored in a BoolPropertyValue instance to or from an Archive.
    /// <code>Offset: 0x00423CE0
    /// void __thiscall BoolPropertyValue::Serialize(BoolPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for input or output of the property value.</param>
    /// <param name="i_eName">Identifier for the property; currently unused during serialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00423CE0)(ref this, io_archive, i_eName);

    /// <summary>Writes this boolean property's value into the specified file node, creating a child node and setting its name accordingly.
    /// <code>Offset: 0x00423D00
    /// bool __thiscall BoolPropertyValue::ToFileNode(BoolPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor for the property; currently unused by the implementation.</param>
    /// <param name="node">Parent file node to which the property is serialized.</param>
    /// <returns>True if the property was successfully written into a new sub-node; otherwise, false when the supplied node is null or child creation fails.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00423D00)(ref this, desc, node);

    /// <summary>Extracts a boolean value from a file node and assigns it to this object's m_value.
    /// <code>Offset: 0x00426B90
    /// bool __thiscall BoolPropertyValue::FromFileNode(BoolPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor of the property being set.</param>
    /// <param name="node">File node containing the boolean value.</param>
    /// <returns>True if a leaf was found and parsed; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00426B90)(ref this, desc, node);

    /// <summary>Converts the stored boolean value into its textual representation and stores it in the provided output location.
    /// <code>Offset: 0x00427630
    /// char __thiscall BoolPropertyValue::GetValueAsString(_BYTE*,int,void**,int)</code>
    /// </summary>
    /// <param name="a2">Ignored; reserved for future extensions.</param>
    /// <param name="a3">Output parameter that receives a pointer to the string "True" or "False".</param>
    /// <param name="a4">Ignored; reserved for future extensions.</param>
    /// <returns>Always returns 1, indicating successful conversion.</returns>
    public sbyte GetValueAsString(int a2, void** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoolPropertyValue, int, void**, int, sbyte>)0x00427630)(ref this, a2, a3, a4);
}

