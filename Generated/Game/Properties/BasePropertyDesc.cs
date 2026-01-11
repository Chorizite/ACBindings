namespace ACBindings.Internal;

public unsafe struct BasePropertyDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct BasePropertyDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BasePropertyDesc*, void> BasePropertyDesc_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint m_propertyName;
    public uint m_propertyType;
    public uint m_propertyGroup;
    public uint m_propertyProvider;
    public uint m_data;
    public uint m_ePatchFlags;
    public ACBindings.Internal.BasePropertyValue* m_defaultValue;
    public ACBindings.Internal.BasePropertyValue* m_minValue;
    public ACBindings.Internal.BasePropertyValue* m_maxValue;
    public ACBindings.Internal.AvailablePropertySet m_availableProperties;
    public ACBindings.Internal.PropertyInheritanceType.Type m_inheritanceType;
    public ACBindings.Internal.PropertyDatFileType.Type m_datFileType;
    public ACBindings.Internal.PropertyPropagationType.Type m_propagationType;
    public ACBindings.Internal.PropertyCachingType.Type m_cachingType;
    public byte m_bRequired;
    public byte m_bReadOnly;
    public byte m_bPropagateToChildren;
    public byte m_bNoCheckpoint;
    public byte m_bAbsoluteTimeStamp;
    public byte m_bGroupable;
    public byte m_bAllAvailable;
    public byte m_bDoNotReplay;
    public byte m_bRecorded;
    public byte m_bToolOnly;
    public uint m_nMinElements;
    public uint m_nMaxElements;
    public ACBindings.Internal.PStringBase__sbyte m_strHelp;
    public float m_fPredictionTimeout;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the patch flags associated with a property when its type is 10.
    /// <code>Offset: 0x00429920
    /// bool __thiscall BasePropertyDesc::InqPatchFlags(BasePropertyDesc*,unsigned int*)</code>
    /// </summary>
    /// <param name="o_ePatchFlags">Pointer to receive the retrieved patch flag value; only set if the call succeeds.</param>
    /// <returns>True if the property type matches 10 and the flags were copied; otherwise false.</returns>
    public byte InqPatchFlags(uint* o_ePatchFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyDesc, uint*, byte>)0x00429920)(ref this, o_ePatchFlags);

    /// <summary>Obtains the data identifier for properties whose type matches predefined categories.
    /// <code>Offset: 0x00429A70
    /// char __thiscall BasePropertyDesc::InqDataID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Receives the data identifier when available.</param>
    /// <returns>True (1) if a data identifier was retrieved; otherwise false (0).</returns>
    public sbyte InqDataID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyDesc, int*, sbyte>)0x00429A70)(ref this, a2);

    /// <summary>Obtains the textual identifier for a property based on its type, storing the result through the supplied integer pointer. Handles enum types (9) and name types (20).
    /// <code>Offset: 0x0042A500
    /// char __thiscall BasePropertyDesc::InqPropertyEnum(_DWORD*,int,int*)</code>
    /// </summary>
    /// <param name="a2">The enumeration value or ID to look up.</param>
    /// <param name="a3">Pointer that receives the resulting string key or index.</param>
    /// <returns>Nonzero if a mapping was found; zero otherwise.</returns>
    public sbyte InqPropertyEnum(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyDesc, int, int*, sbyte>)0x0042A500)(ref this, a2, a3);

    /// <summary>Adds the property's data identifier to the supplied <c>QualifiedDataIDArray</c> when its type indicates a sub‑data reference (property types 9, 15, 16 or 20).
    /// <code>Offset: 0x0042A580
    /// void __thiscall BasePropertyDesc::GetSubDataIDs(BasePropertyDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the qualifying data ID.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0042A580)(ref this, id_array);

    /// <summary>Serializes the property description to or from the given archive, handling all metadata fields such as name, type, group, provider, data flags, default/minimum/maximum values, timeouts, inheritance and propagation settings, and boolean attributes.
    /// <code>Offset: 0x0042A600
    /// void __thiscall BasePropertyDesc::Serialize(BasePropertyDesc*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization. When writing, it outputs the current state of the property description; when reading, it populates the object's fields from the archive based on its mode and flags.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyDesc, ACBindings.Internal.Archive*, void>)0x0042A600)(ref this, io_archive);

    /// <summary>Populates the available property set by iterating over all master properties associated with this descriptor and adding them to the internal collection.
    /// <code>Offset: 0x0042AA20
    /// void __cdecl BasePropertyDesc::InitializeAllAvailablePropertySet()</code>
    /// </summary>
    public static void InitializeAllAvailablePropertySet() => ((delegate* unmanaged[Cdecl]<void>)0x0042AA20)();

    /// <summary>Releases all owned resources of a BasePropertyDesc instance, including default, min, and max property values, the help string buffer, and the available properties hash table. Decrements reference counts and deletes objects when their count reaches zero.
    /// <code>Offset: 0x0042ACE0
    /// void __thiscall BasePropertyDesc::~BasePropertyDesc(BasePropertyDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasePropertyDesc, void>)0x0042ACE0)(ref this);
}

