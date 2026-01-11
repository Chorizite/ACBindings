namespace ACBindings.Internal;

public unsafe struct BaseProperty : System.IDisposable
{
    // Members
    public ACBindings.Internal.BasePropertyDesc* m_pcPropertyDesc;
    public ACBindings.Internal.BasePropertyValue* m_pcPropertyValue;

    // Generated Constructor
    public BaseProperty() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a BaseProperty instance by setting its descriptor and value pointers to null.
    /// <code>Offset: 0x004175F0
    /// void __thiscall BaseProperty::BaseProperty(BaseProperty*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, void>)0x004175F0)(ref this);

    /// <summary>Releases references held by the property, decrementing reference counts and invoking cleanup when count reaches zero.
    /// <code>Offset: 0x004234D0
    /// void __thiscall BaseProperty::~BaseProperty(BaseProperty*)</code>
    /// </summary>
    /// <param name="this">The BaseProperty instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, void>)0x004234D0)(ref this);

    /// <summary>Retrieves an enumeration value stored in the property and writes it into the supplied buffer.
    /// <code>Offset: 0x00429940
    /// bool __thiscall BaseProperty::InqEnum(BaseProperty*,unsigned int*)</code>
    /// </summary>
    /// <param name="value">Pointer to a variable that receives the enumeration value when the query succeeds.</param>
    /// <returns>True if the property contains a valid value and the underlying implementation returns success; otherwise false.</returns>
    public byte InqEnum(uint* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, uint*, byte>)0x00429940)(ref this, value);

    /// <summary>Determines whether the BaseProperty instance contains only client-side data.
    /// <code>Offset: 0x00429960
    /// bool __thiscall BaseProperty::IsClientOnlyData(BaseProperty*)</code>
    /// </summary>
    /// <returns>True when m_pcPropertyDesc exists and its datFileType equals zero; otherwise false.</returns>
    public byte IsClientOnlyData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, byte>)0x00429960)(ref this);

    /// <summary>Determines whether the property is marked as server‑only data by checking its description's file type.
    /// <code>Offset: 0x00429980
    /// bool __thiscall BaseProperty::IsServerOnlyData(BaseProperty*)</code>
    /// </summary>
    /// <returns>True if the property's description exists and its datFileType equals 1; otherwise, false.</returns>
    public byte IsServerOnlyData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, byte>)0x00429980)(ref this);

    /// <summary>Checks whether the property’s descriptor flags it as tool‑only.
    /// <code>Offset: 0x004299A0
    /// bool __thiscall BaseProperty::IsToolOnly(BaseProperty*)</code>
    /// </summary>
    /// <returns>True when a valid descriptor exists and its m_bToolOnly flag is set; otherwise false.</returns>
    public byte IsToolOnly() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, byte>)0x004299A0)(ref this);

    /// <summary>Determines whether this property is equal to another by comparing their names and underlying values.
    /// <code>Offset: 0x004299B0
    /// bool __thiscall BaseProperty::Compare(BaseProperty*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="p">The property to compare against.</param>
    /// <returns>True if both the property name and value are equivalent; otherwise, false.</returns>
    public byte Compare(ACBindings.Internal.BaseProperty* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.BaseProperty*, byte>)0x004299B0)(ref this, p);

    /// <summary>Retrieves the identifier for the property’s name associated with this BaseProperty instance.
    /// <code>Offset: 0x00429A00
    /// unsigned int __thiscall BaseProperty::GetPropertyName(BaseProperty*)</code>
    /// </summary>
    /// <returns>The property name ID if a descriptor exists; otherwise zero.</returns>
    public uint GetPropertyName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, uint>)0x00429A00)(ref this);

    /// <summary>Retrieves the property’s group identifier from its descriptor; returns 0 when no descriptor is present.
    /// <code>Offset: 0x00429A10
    /// unsigned int __thiscall BaseProperty::GetGroupName(BaseProperty*)</code>
    /// </summary>
    /// <returns>The group identifier for the property, or 0 if the property lacks a descriptor.</returns>
    public uint GetGroupName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, uint>)0x00429A10)(ref this);

    /// <summary>Retrieves the property name string associated with this BaseProperty instance and stores it in the supplied output pointer.
    /// <code>Offset: 0x00429A20
    /// char __thiscall BaseProperty::InqPropertyName(void*,volatile LONG**)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the property name identifier (or NULL if none is available).</param>
    /// <returns>A status code: non‑zero on success, zero if no descriptor or name exists.</returns>
    public sbyte InqPropertyName(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, int**, sbyte>)0x00429A20)(ref this, a2);

    /// <summary>Ensures the property's internal value is unique before modification by decrementing the reference count of a shared value and creating a new instance when necessary.
    /// <code>Offset: 0x00429B10
    /// void __thiscall BaseProperty::CheckCopyOnWrite(BaseProperty*)</code>
    /// </summary>
    public void CheckCopyOnWrite() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, void>)0x00429B10)(ref this);

    /// <summary>Assigns a floating‑point value to this property, updating its internal representation when available.
    /// <code>Offset: 0x00429B80
    /// bool __thiscall BaseProperty::SetFloat(BaseProperty*,const float)</code>
    /// </summary>
    /// <param name="value">The new float value to set for the property.</param>
    /// <returns>True if the property had an associated value object and was successfully updated; otherwise false.</returns>
    public byte SetFloat(float value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, float, byte>)0x00429B80)(ref this, value);

    /// <summary>Assigns an enumerated value to a property, handling reference counting and delegating the operation to the underlying property value object.
    /// <code>Offset: 0x00429BC0
    /// bool __thiscall BaseProperty::SetEnum(BaseProperty*,const unsigned int)</code>
    /// </summary>
    /// <param name="value">The new enum value to set for this property.</param>
    /// <returns>True if the value was successfully applied; false when no associated property value exists.</returns>
    public byte SetEnum(uint value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, uint, byte>)0x00429BC0)(ref this, value);

    /// <summary>Assigns the supplied string information to the property’s underlying value by delegating to its value object.
    /// <code>Offset: 0x00429C00
    /// bool __thiscall BaseProperty::SetStringInfo(BaseProperty*,const StringInfo*)</code>
    /// </summary>
    /// <param name="value">StringInfo containing token, ID, table reference and literal data to set on the property.</param>
    /// <returns>True if the operation succeeds; otherwise false when the property has no value or the underlying call fails.</returns>
    public byte SetStringInfo(ACBindings.Internal.StringInfo* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.StringInfo*, byte>)0x00429C00)(ref this, value);

    /// <summary>Collects all sub‑data identifiers referenced by this property and its child properties into the supplied array.
    /// <code>Offset: 0x00429CE0
    /// void __thiscall BaseProperty::GetSubDataIDs(BaseProperty*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive the collected data identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00429CE0)(ref this, id_array);

    /// <summary>Converts the property represented by this object into a sub‑node under the supplied file node, storing its name and value.
    /// <code>Offset: 0x00429EA0
    /// bool __thiscall BaseProperty::ToFileNode(BaseProperty*,PFileNode*)</code>
    /// </summary>
    /// <param name="node">The parent file node to which the property will be added as a new sub‑node.</param>
    /// <returns>True if the conversion succeeded; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.PFileNode*, byte>)0x00429EA0)(ref this, node);

    /// <summary>Parses the given file node and sets the property’s value accordingly.
    /// <code>Offset: 0x00429F40
    /// bool __thiscall BaseProperty::ValueFromFileNode(BaseProperty*,const PFileNode*)</code>
    /// </summary>
    /// <param name="node">The file node containing the property data.</param>
    /// <returns>True if the value was successfully read; otherwise, false.</returns>
    public byte ValueFromFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.PFileNode*, byte>)0x00429F40)(ref this, node);

    /// <summary>Replaces the property’s current value with its default by releasing any existing reference and assigning a new value from the descriptor or, if none, an initial type‑specific value.
    /// <code>Offset: 0x0042A1C0
    /// bool __thiscall BaseProperty::InitToDefaultValue(BaseProperty*)</code>
    /// </summary>
    /// <returns>True when a non‑null default value was assigned; otherwise false (including when no descriptor exists).</returns>
    public byte InitToDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, byte>)0x0042A1C0)(ref this);

    /// <summary>Assigns a new property descriptor to the BaseProperty, releasing any existing descriptor and value references, increments reference counts appropriately, and initializes the property to its default value.
    /// <code>Offset: 0x0042A280
    /// bool __thiscall BaseProperty::SetPropertyDesc(BaseProperty*,BasePropertyDesc*)</code>
    /// </summary>
    /// <param name="i_pcDesc">Pointer to the new BasePropertyDesc; may be null to clear the current description.</param>
    /// <returns>Always true (1).</returns>
    public byte SetPropertyDesc(ACBindings.Internal.BasePropertyDesc* i_pcDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.BasePropertyDesc*, byte>)0x0042A280)(ref this, i_pcDesc);

    /// <summary>Assigns a new property descriptor based on an identifier. If the identifier is zero, the existing descriptor is cleared.
    /// <code>Offset: 0x0042A2D0
    /// bool __thiscall BaseProperty::SetPropertyName(BaseProperty*,const unsigned int)</code>
    /// </summary>
    /// <param name="i_eName">Identifier of the desired property; zero indicates removal.</param>
    /// <returns>True when a valid descriptor was obtained and set; otherwise false.</returns>
    public byte SetPropertyName(uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, uint, byte>)0x0042A2D0)(ref this, i_eName);

    /// <summary>Serializes a base property’s name and value to an archive, handling both writing and reading modes based on the archive flags. The method updates internal references, manages reference counting for the property value, and raises errors if required data is missing.
    /// <code>Offset: 0x0042A330
    /// void __thiscall BaseProperty::Serialize(BaseProperty*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization; its flags determine whether to write or read data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.Archive*, void>)0x0042A330)(ref this, io_archive);

    /// <summary>Parses a PFileNode and initializes the BaseProperty instance with the node’s name and value, reporting errors for invalid names or initialization failures.
    /// <code>Offset: 0x0042A420
    /// bool __thiscall BaseProperty::FromFileNode(BaseProperty*,const PFileNode*)</code>
    /// </summary>
    /// <param name="node">The file node containing property data to load.</param>
    /// <returns>True if the property was successfully initialized; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BaseProperty, ACBindings.Internal.PFileNode*, byte>)0x0042A420)(ref this, node);
}

