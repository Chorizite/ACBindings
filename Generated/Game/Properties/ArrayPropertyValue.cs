namespace ACBindings.Internal;


/// <summary>Stores a dynamic collection of BaseProperty elements, offering manipulation, comparison, and serialization capabilities within the property framework.</summary>
public unsafe struct ArrayPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.SmartArray___BaseProperty m_value;

    // Methods

    /// <summary>Retrieves the number of elements stored in an ArrayPropertyValue instance.
    /// <code>Offset: 0x004269A0
    /// bool __thiscall ArrayPropertyValue::InqArrayNumElements(ArrayPropertyValue*,unsigned int*)</code>
    /// </summary>
    /// <param name="num">Receives the element count.</param>
    /// <returns>Always returns true to indicate successful retrieval.</returns>
    public byte InqArrayNumElements(uint* num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, uint*, byte>)0x004269A0)(ref this, num);

    /// <summary>Retrieves an element from the internal array at the specified zero‑based index and copies it into the provided BaseProperty instance; returns true on success.
    /// <code>Offset: 0x00426B20
    /// bool __thiscall ArrayPropertyValue::InqArrayElement(ArrayPropertyValue*,const unsigned int,BaseProperty*)</code>
    /// </summary>
    /// <param name="index">Zero‑based position within the array to query.</param>
    /// <param name="value">Pointer to a BaseProperty object that will receive a copy of the element.</param>
    /// <returns>True if the index is valid and the element was copied; otherwise false.</returns>
    public byte InqArrayElement(uint index, ACBindings.Internal.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, uint, ACBindings.Internal.BaseProperty*, byte>)0x00426B20)(ref this, index, value);

    /// <summary>Returns a pointer to the BaseProperty stored at the specified zero‑based index in the array.
    /// <code>Offset: 0x00426B50
    /// const BaseProperty* __thiscall ArrayPropertyValue::GetArrayElement(ArrayPropertyValue*,const unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position of the desired element within the array.</param>
    /// <returns>A constant pointer to the BaseProperty located at the provided index.</returns>
    public ACBindings.Internal.BaseProperty* GetArrayElement(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, uint, ACBindings.Internal.BaseProperty*>)0x00426B50)(ref this, index);

    /// <summary>Assigns the array property from a base property value when the underlying conversion succeeds.
    /// <code>Offset: 0x00427510
    /// bool __thiscall ArrayPropertyValue::SetValue(ArrayPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source base property value to convert and assign.</param>
    /// <returns>True if the assignment succeeded; otherwise, false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00427510)(ref this, value);

    /// <summary>Creates a deep copy of an ArrayPropertyValue instance, allocating memory for the new object and duplicating its internal array.
    /// <code>Offset: 0x00428260
    /// BasePropertyValue* __thiscall ArrayPropertyValue::Copy(ArrayPropertyValue*)</code>
    /// </summary>
    /// <returns>Pointer to the newly created BasePropertyValue representing the copied array; returns null if allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00428260)(ref this);

    /// <summary>Serializes the array of base properties stored in this property value to or from the provided archive.
    /// <code>Offset: 0x004282C0
    /// void __thiscall ArrayPropertyValue::Serialize(ArrayPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">The archive instance that receives or supplies serialized data.</param>
    /// <param name="i_eName">An identifier for the property; currently unused by the serialization logic.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x004282C0)(ref this, io_archive, i_eName);

    /// <summary>Sets or appends an element in the array at the specified index using a BaseProperty instance.
    /// <code>Offset: 0x00428420
    /// bool __thiscall ArrayPropertyValue::SetArrayElement(ArrayPropertyValue*,const unsigned int,const BaseProperty*)</code>
    /// </summary>
    /// <param name="index">Zero‑based position where the property should be inserted. If equal to the current number of elements, the value is appended.</param>
    /// <param name="value">The property data to assign to the element.</param>
    /// <returns>True if the operation succeeded; false if the index exceeds the array size or the append operation fails.</returns>
    public byte SetArrayElement(uint index, ACBindings.Internal.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, uint, ACBindings.Internal.BaseProperty*, byte>)0x00428420)(ref this, index, value);

    /// <summary>Adds the supplied BaseProperty element to the end of this ArrayPropertyValue's internal array.
    /// <code>Offset: 0x00428780
    /// void __thiscall ArrayPropertyValue::PushArrayElement(ArrayPropertyValue*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="i_rcElement">The BaseProperty object to append to the array.</param>
    public void PushArrayElement(ACBindings.Internal.BaseProperty* i_rcElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, ACBindings.Internal.BaseProperty*, void>)0x00428780)(ref this, i_rcElement);

    /// <summary>Serializes an array property value into a file node by invoking BaseProperty::ToFileNode on each contained element.
    /// <code>Offset: 0x0042B900
    /// bool __thiscall ArrayPropertyValue::ToFileNode(ArrayPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor of the property; not used directly in this method.</param>
    /// <param name="node">Target file node to which array elements are added. If null, no conversion occurs.</param>
    /// <returns>True if all elements were successfully serialized or the array is empty; false if any element fails serialization.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042B900)(ref this, desc, node);

    /// <summary>Compares the array stored in this object with another property value for equality.
    /// <code>Offset: 0x0042B9D0
    /// bool __thiscall ArrayPropertyValue::Compare(ArrayPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The base property value to compare against, expected to represent an array.</param>
    /// <returns>True if both arrays have the same length and all corresponding elements are equal; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x0042B9D0)(ref this, p);

    /// <summary>Swaps two elements within the internal array at the specified indices.
    /// <code>Offset: 0x0042BA40
    /// bool __thiscall ArrayPropertyValue::SwapArrayElements(ArrayPropertyValue*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="index1">Zero‑based position of the first element to swap.</param>
    /// <param name="index2">Zero‑based position of the second element to swap.</param>
    /// <returns>True after performing the swap; always succeeds.</returns>
    public byte SwapArrayElements(uint index1, uint index2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, uint, uint, byte>)0x0042BA40)(ref this, index1, index2);

    /// <summary>Converts the array property value into a string representation and writes it into the supplied buffer.
    /// <code>Offset: 0x0042BA60
    /// char __thiscall ArrayPropertyValue::GetValueAsString(_DWORD*,int,char**,char)</code>
    /// </summary>
    /// <param name="a3">Pointer to a buffer where the resulting string is stored.</param>
    /// <param name="a4">If nonzero, writes only the item count; otherwise prefixes with "Array [count items]".</param>
    /// <returns>Always 1 to indicate success.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, int, sbyte**, sbyte, sbyte>)0x0042BA60)(ref this, a2, a3, a4);

    /// <summary>Parses an array property value from a file node, populating the internal array with child properties that are available and not marked as tool‑only according to the supplied descriptor.
    /// <code>Offset: 0x0042BAA0
    /// bool __thiscall ArrayPropertyValue::FromFileNode(ArrayPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Describes the property, including its availability set and flags used for filtering subproperties.</param>
    /// <param name="node">The file node whose subnodes represent individual property entries.</param>
    /// <returns>True if all subnodes were successfully parsed; otherwise false when any parse error or filtering restriction occurs.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArrayPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042BAA0)(ref this, desc, node);
}

