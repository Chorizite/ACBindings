namespace ACBindings.Internal;

public unsafe struct ColorPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.RGBAColor m_value;

    // Methods

    /// <summary>Parses a color value from the supplied file node and stores it in this property.
    /// <code>Offset: 0x00423DF0
    /// bool __thiscall ColorPropertyValue::FromFileNode(ColorPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property description (unused during parsing).</param>
    /// <param name="node">File node containing the color data.</param>
    /// <returns>True if the node was valid and the color was successfully parsed; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00423DF0)(ref this, desc, node);

    /// <summary>Converts the stored RGBA color value into a file node suitable for serialization.
    /// <code>Offset: 0x00423E10
    /// bool __thiscall ColorPropertyValue::ToFileNode(ColorPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor containing metadata about the property (unused in this conversion).</param>
    /// <param name="node">The target file node that receives the serialized color data; must not be null to succeed.</param>
    /// <returns>True if the node was successfully populated with the color value, otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00423E10)(ref this, desc, node);

    /// <summary>Retrieves the current RGBA color stored in the property value.
    /// <code>Offset: 0x00423E30
    /// bool __thiscall ColorPropertyValue::InqColor(ColorPropertyValue*,RGBAColor*)</code>
    /// </summary>
    /// <param name="value">Pointer to an RGBAColor structure that receives the current color.</param>
    /// <returns>True to indicate successful retrieval.</returns>
    public byte InqColor(ACBindings.Internal.RGBAColor* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.RGBAColor*, byte>)0x00423E30)(ref this, value);

    /// <summary>Copies the provided RGBAColor into this ColorPropertyValue instance.
    /// <code>Offset: 0x00423E60
    /// bool __thiscall ColorPropertyValue::SetColor(ColorPropertyValue*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="value">The RGBAColor whose components are assigned to the property value.</param>
    /// <returns>True when the color is successfully set.</returns>
    public byte SetColor(ACBindings.Internal.RGBAColor* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.RGBAColor*, byte>)0x00423E60)(ref this, value);

    /// <summary>Updates the object's color value from a supplied BasePropertyValue.
    /// <code>Offset: 0x00423E90
    /// bool __thiscall ColorPropertyValue::SetValue(ColorPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The property containing the new color data.</param>
    /// <returns>True if the conversion and assignment succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00423E90)(ref this, value);

    /// <summary>Serializes the color value stored in this instance to the supplied archive.
    /// <code>Offset: 0x00423EF0
    /// void __thiscall ColorPropertyValue::Serialize(ColorPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive object to write the serialized data into.</param>
    /// <param name="i_eName">Identifier for the property being serialized (unused in current implementation).</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00423EF0)(ref this, io_archive, i_eName);

    /// <summary>Compares the current ColorPropertyValue to another property value for equality.
    /// <code>Offset: 0x00423F00
    /// bool __thiscall ColorPropertyValue::Compare(ColorPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The base property value to compare against.</param>
    /// <returns>True if p is non‑null, represents an RGBA color, and matches this instance's color; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00423F00)(ref this, p);

    /// <summary>Determines whether this object's RGBA color is numerically less than that of another property value, writing the result to <paramref name="o_rbLessThan"/>.
    /// <code>Offset: 0x00423FB0
    /// bool __thiscall ColorPropertyValue::InqLessThan(ColorPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The right-hand side property value to compare against.</param>
    /// <param name="o_rbLessThan">Receives true if this object's 32‑bit color is less than <paramref name="i_pcRHS"/>'s; otherwise false.</param>
    /// <returns>True if the comparison succeeded (the RHS could be interpreted as an RGBAColor); otherwise false.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00423FB0)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Serializes the RGBAColor stored in this instance into a string of four floating‑point numbers formatted to three decimal places.
    /// <code>Offset: 0x00427660
    /// char __thiscall ColorPropertyValue::GetValueAsString(float*,int,char**,int)</code>
    /// </summary>
    /// <param name="a2">Unused parameter reserved for future extensions.</param>
    /// <param name="a3">Pointer to a character buffer that receives the formatted color value.</param>
    /// <param name="a4">Size of the output buffer (not enforced in this implementation).</param>
    /// <returns>Non‑zero on success; zero indicates failure.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ColorPropertyValue, int, sbyte**, int, sbyte>)0x00427660)(ref this, a2, a3, a4);
}

