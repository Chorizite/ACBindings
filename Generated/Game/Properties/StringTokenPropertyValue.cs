namespace ACBindings.Internal;

public unsafe struct StringTokenPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public uint m_value;
    public ACBindings.Internal.PStringBase__sbyte m_tokenName;

    // Methods

    /// <summary>Sets the string token property value from a base property value and reports success.
    /// <code>Offset: 0x00426690
    /// bool __thiscall StringTokenPropertyValue::SetValue(StringTokenPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value used to update the token.</param>
    /// <returns>True if the value was applied successfully; otherwise, false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTokenPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00426690)(ref this, value);

    /// <summary>Compares this StringTokenPropertyValue against another BasePropertyValue, ensuring the argument is non‑null, satisfies a base class comparison via a virtual method, and that the instance's unsigned integer equals the pointer address of the argument.
    /// <code>Offset: 0x004266B0
    /// bool __thiscall StringTokenPropertyValue::Compare(StringTokenPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The BasePropertyValue to compare with; must not be null for a successful comparison.</param>
    /// <returns>True when p is non‑null, passes the base class comparison logic, and this->m_value matches the address of p; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTokenPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004266B0)(ref this, p);

    /// <summary>
    /// Copies the current StringTokenPropertyValue into a newly allocated BasePropertyValue, duplicating its integer value and token string.
    /// 
    /// <code>Offset: 0x00426730
    /// BasePropertyValue* __thiscall StringTokenPropertyValue::Copy(StringTokenPropertyValue*)</code>
    /// </summary>
    /// <returns>
    /// A pointer to the new BasePropertyValue instance with an initialized reference count of one, or null if memory allocation fails.
    /// </returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTokenPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00426730)(ref this);

    /// <summary>Parses a file node to extract a string token, stores the token in <c>m_tokenName</c>, computes its hash into <c>m_value</c>, and returns success status.
    /// <code>Offset: 0x00426770
    /// bool __thiscall StringTokenPropertyValue::FromFileNode(StringTokenPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Description of the property; not used by this implementation but provided for consistency with the interface.</param>
    /// <param name="node">File node containing the token to read. The function looks up the leaf node and retrieves its name.</param>
    /// <returns>True if a valid token was extracted and hashed; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTokenPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00426770)(ref this, desc, node);

    /// <summary>Writes the token name of this property value as a sub‑node within the supplied file node. Returns true if the sub‑node was successfully created.
    /// <code>Offset: 0x004270C0
    /// bool __thiscall StringTokenPropertyValue::ToFileNode(StringTokenPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="this">The StringTokenPropertyValue instance whose token is to be written.</param>
    /// <param name="desc">Property descriptor; not used in this implementation.</param>
    /// <param name="node">Target file node that will receive the new sub‑node.</param>
    /// <returns>True if a sub‑node was created; otherwise, false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTokenPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x004270C0)(ref this, desc, node);

    /// <summary>Converts the property’s numeric value into an eight‑digit hexadecimal string and optionally appends its token name when not suppressed.
    /// <code>Offset: 0x00427F50
    /// char __thiscall StringTokenPropertyValue::GetValueAsString(_DWORD*,int,char**,char)</code>
    /// </summary>
    /// <param name="this">Pointer to the StringTokenPropertyValue instance whose value is formatted.</param>
    /// <param name="a2">Reserved; currently unused.</param>
    /// <param name="a3">Address of a buffer that receives the resulting string representation.</param>
    /// <param name="a4">If zero, appends the token name; if non‑zero, suppresses the addition.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTokenPropertyValue, int, sbyte**, sbyte, sbyte>)0x00427F50)(ref this, a2, a3, a4);
}

