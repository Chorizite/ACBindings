namespace ACBindings.Internal;


/// <summary>Stores a unique instance identifier, providing mechanisms for copying, comparison, parsing from file nodes, assignment, serialization, and string formatting as hexadecimal.</summary>
public unsafe struct InstanceIDPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public uint m_value;

    // Methods

    /// <summary>Assigns the property value from a BasePropertyValue into this InstanceIDPropertyValue, delegating through the base's virtual interface.
    /// <code>Offset: 0x004245C0
    /// bool __thiscall InstanceIDPropertyValue::SetValue(InstanceIDPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source BasePropertyValue providing the data to assign.</param>
    /// <returns>True if the assignment succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceIDPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004245C0)(ref this, value);

    /// <summary>Compares this InstanceIDPropertyValue against a supplied BasePropertyValue, validating the property and matching its stored value to the pointer address.
    /// <code>Offset: 0x004245E0
    /// bool __thiscall InstanceIDPropertyValue::Compare(InstanceIDPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The BasePropertyValue instance to compare.</param>
    /// <returns>True when p is non‑null, passes its internal comparison check, and this object's m_value equals the numeric address of p; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceIDPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004245E0)(ref this, p);

    /// <summary>Creates a duplicate of the current InstanceIDPropertyValue as a BasePropertyValue object, initializing reference counting and virtual function table.
    /// <code>Offset: 0x00424620
    /// BasePropertyValue* __thiscall InstanceIDPropertyValue::Copy(InstanceIDPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated BasePropertyValue instance or nullptr if allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceIDPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00424620)(ref this);

    /// <summary>
    /// Creates a new child node of the supplied file node and assigns it the instance’s unsigned integer value as a hexadecimal name.
    /// 
    /// <code>Offset: 0x00425CD0
    /// bool __thiscall InstanceIDPropertyValue::ToFileNode(InstanceIDPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Description of the property; not used by this method.</param>
    /// <param name="node">File node to which the new child will be added. Must support sub‑node creation.</param>
    /// <returns>True if the child node was successfully created and named; otherwise, false when the supplied node is null or cannot create a child.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceIDPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425CD0)(ref this, desc, node);

    /// <summary>Parses an instance identifier from the supplied file node and stores it in the property value.
    /// <code>Offset: 0x00426D70
    /// bool __thiscall InstanceIDPropertyValue::FromFileNode(InstanceIDPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Metadata describing the property, such as its type and constraints.</param>
    /// <param name="node">XML or configuration node that may contain the instance ID to be read.</param>
    /// <returns>True if an instance ID was successfully retrieved from a leaf node; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceIDPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00426D70)(ref this, desc, node);

    /// <summary>Formats the instance's identifier as an eight‑digit hexadecimal string and stores it in the supplied buffer.
    /// <code>Offset: 0x004276F0
    /// char __thiscall InstanceIDPropertyValue::GetValueAsString(_DWORD*,int,char**,int)</code>
    /// </summary>
    /// <param name="a2">Ignored – placeholder for a property index or similar value.</param>
    /// <param name="a3">Pointer to a character array that will receive the formatted string.</param>
    /// <param name="a4">Ignored – may represent the maximum length of the output buffer.</param>
    /// <returns>Non‑zero if formatting succeeded; zero otherwise.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InstanceIDPropertyValue, int, sbyte**, int, sbyte>)0x004276F0)(ref this, a2, a3, a4);
}

