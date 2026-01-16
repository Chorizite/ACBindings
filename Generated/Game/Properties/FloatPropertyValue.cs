namespace ACBindings.Internal;


/// <summary>Stores a single floating-point property value and supplies methods for copying, comparing, serializing to file nodes, and formatting as text.</summary>
public unsafe struct FloatPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public float m_value;

    // Methods

    /// <summary>Assigns the float property from the supplied base property value, updating the instance’s internal value.
    /// <code>Offset: 0x00424250
    /// bool __thiscall FloatPropertyValue::SetValue(FloatPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="this">The FloatPropertyValue object whose value is to be set.</param>
    /// <param name="value">A BasePropertyValue containing a float representation used for assignment.</param>
    /// <returns>True if the value was successfully extracted and assigned; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424250)(ref this, value);

    /// <summary>Compares the stored float value with that of a supplied property value and reports whether this value is less.
    /// <code>Offset: 0x00424270
    /// bool __thiscall FloatPropertyValue::InqLessThan(FloatPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="this">The FloatPropertyValue instance whose value is compared.</param>
    /// <param name="i_pcRHS">A BasePropertyValue representing the right‑hand side value to compare against.</param>
    /// <param name="o_rbLessThan">Output flag set to true if this object's value is less than the RHS value; otherwise false.</param>
    /// <returns>True if the comparison was performed (the RHS was a compatible float property); otherwise false, indicating an invalid or unsupported comparison target.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00424270)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Compares this FloatPropertyValue with another BasePropertyValue, returning true if this value is greater after confirming type compatibility.
    /// <code>Offset: 0x00424380
    /// bool __thiscall FloatPropertyValue::operator&gt;(FloatPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The BasePropertyValue to compare against.</param>
    /// <returns>True when this FloatPropertyValue exceeds the RHS property value; otherwise false.</returns>
//     public byte operator>(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424380)(ref this, i_rcRhs);

    /// <summary>Determines if this float property value is less than another base property value by first verifying type compatibility through a virtual check and then comparing the underlying floating-point values.
    /// <code>Offset: 0x00424400
    /// bool __thiscall FloatPropertyValue::operator&lt;(FloatPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The other property value to compare against, expected to expose a comparable float representation.</param>
    /// <returns>True when the current value is strictly smaller; otherwise false.</returns>
//     public byte operator__(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424400)(ref this, i_rcRhs);

    /// <summary>Creates a new BasePropertyValue instance that replicates the floating‑point value stored in this FloatPropertyValue.
    /// <code>Offset: 0x00424500
    /// BasePropertyValue* __thiscall FloatPropertyValue::Copy(FloatPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the freshly allocated BasePropertyValue carrying the same numeric value, or nullptr when memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00424500)(ref this);

    /// <summary>Compares the FloatPropertyValue’s numeric value with another BasePropertyValue that must represent a non‑zero float and be of a compatible type, returning true when the values differ by no more than 0.0002.
    /// <code>Offset: 0x00424570
    /// bool __thiscall FloatPropertyValue::Compare(FloatPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The BasePropertyValue to compare against; it is interpreted as a floating-point property whose value must be non‑zero and whose type is verified via a virtual method call.</param>
    /// <returns>True if p is of compatible type, its numeric value differs from this->m_value by at most 0.0002; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424570)(ref this, p);

    /// <summary>Writes the float property value into a file node by creating a child node and setting its name to the numeric value.
    /// <code>Offset: 0x00425C20
    /// bool __thiscall FloatPropertyValue::ToFileNode(FloatPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Metadata for the property; not directly used in this operation.</param>
    /// <param name="node">File node where the property should be stored. Must not be null.</param>
    /// <returns>True if the float value was successfully written into the node; otherwise, false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425C20)(ref this, desc, node);

    /// <summary>Parses a floating‑point value from the supplied file node and stores it in m_value.
    /// <code>Offset: 0x00426C80
    /// bool __thiscall FloatPropertyValue::FromFileNode(FloatPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">The property descriptor; currently unused by this method.</param>
    /// <param name="node">File node that should contain the float value to read.</param>
    /// <returns>true if a leaf node was found and parsed successfully; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00426C80)(ref this, desc, node);

    /// <summary>Converts the float value stored in this FloatPropertyValue into a formatted string and stores it at the location referenced by a3.
    /// <code>Offset: 0x004276A0
    /// char __thiscall FloatPropertyValue::GetValueAsString(float*,int,char**,char)</code>
    /// </summary>
    /// <param name="a2">Unused; present for compatibility with other property implementations.</param>
    /// <param name="a3">Pointer to a character buffer that receives the formatted number.</param>
    /// <param name="a4">Non‑zero selects fixed‑point formatting ("%.3f"); zero uses general formatting ("%.3g").</param>
    /// <returns>Always 1, indicating successful conversion.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FloatPropertyValue, int, sbyte**, sbyte, sbyte>)0x004276A0)(ref this, a2, a3, a4);
}

