namespace ACBindings.Internal;

public unsafe struct DBObjGrabber___EnumMapper
{
    // Members
    public ACBindings.Internal.EnumMapper* m_object;

    // Methods

    /// <summary>Retrieves a database object identified by an integer ID and assigns it to the provided DBObj** handle.
    /// <code>Offset: 0x0041ABA0
    /// DBObj** __thiscall DBObjGrabber&lt;EnumMapper&gt;::DBObjGrabber&lt;EnumMapper&gt;(DBObj**,int)</code>
    /// </summary>
    /// <param name="a2">The integer identifier used to look up the database entry.</param>
    /// <returns>The same DBObj** pointer that was passed in, now pointing to the retrieved object or null if not found.</returns>
    // DBObj** __thiscall DBObjGrabber<EnumMapper>::DBObjGrabber<EnumMapper>(DBObj**,int) (template type method)
}

public unsafe struct DBObjGrabber___EnumIDMap
{
    // Members
    public ACBindings.Internal.EnumIDMap* m_object;

    // Methods

    /// <summary>Initializes a DBObj pointer by retrieving an object identified by the supplied ID.
    /// <code>Offset: 0x0041ABD0
    /// DBObj** __thiscall DBObjGrabber&lt;EnumIDMap&gt;::DBObjGrabber&lt;EnumIDMap&gt;(DBObj**,int)</code>
    /// </summary>
    /// <param name="this">Pointer to a DBObj reference that will receive the retrieved object.</param>
    /// <param name="a2">Identifier used to locate the desired DBObj.</param>
    /// <returns>The same DBObj** passed in, now pointing to the fetched DBObj (or null if not found).</returns>
    // DBObj** __thiscall DBObjGrabber<EnumIDMap>::DBObjGrabber<EnumIDMap>(DBObj**,int) (template type method)
}

public unsafe struct DBObjGrabber___DualEnumIDMap
{
    // Members
    public ACBindings.Internal.DualEnumIDMap* m_object;

    // Methods

    /// <summary>Initializes a DBObj pointer with the database object corresponding to the specified data ID.
    /// <code>Offset: 0x0041AC00
    /// DBObj** __thiscall DBObjGrabber&lt;DualEnumIDMap&gt;::DBObjGrabber&lt;DualEnumIDMap&gt;(DBObj**,int)</code>
    /// </summary>
    /// <param name="outDbObjPtr">Pointer to receive the retrieved DBObj instance; set to null before loading.</param>
    /// <param name="dataId">Identifier used to locate the desired DBObj via QualifiedDataID.</param>
    /// <returns>Returns the original pointer, now pointing to the loaded DBObj.</returns>
    // DBObj** __thiscall DBObjGrabber<DualEnumIDMap>::DBObjGrabber<DualEnumIDMap>(DBObj**,int) (template type method)
}

public unsafe struct DBObjGrabber___MasterProperty
{
    // Members
    public ACBindings.Internal.MasterProperty* m_object;

    // Methods
}

public unsafe struct DBObjGrabber___StringTable
{
    // Members
    public ACBindings.Internal.StringTable* m_object;

    // Methods

    /// <summary>Initialises the grabber by retrieving a DBObj instance based on the supplied identifier and fixed category 37, storing it in the provided pointer.
    /// <code>Offset: 0x0042CAF0
    /// DBObj** __thiscall DBObjGrabber&lt;StringTable&gt;::DBObjGrabber&lt;StringTable&gt;(DBObj**,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the DBObj* that will receive the retrieved object.</param>
    /// <param name="a2">Identifier used to locate the desired DBObj within the database.</param>
    /// <returns>Returns the same pointer passed in after assignment.</returns>
    // DBObj** __thiscall DBObjGrabber<StringTable>::DBObjGrabber<StringTable>(DBObj**,int) (template type method)

    /// <summary>
    /// <code>Offset: 0x0049B890
    /// int __thiscall DBObjGrabber&lt;StringTable&gt;::~DBObjGrabber&lt;StringTable&gt;(int*)</code>
    /// </summary>
    // int __thiscall DBObjGrabber<StringTable>::~DBObjGrabber<StringTable>(int*) (template type method)
}

public unsafe struct DBObjGrabber___LayoutDesc
{
    // Members
    public ACBindings.Internal.LayoutDesc* m_object;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00459A40
    /// bool __thiscall DBObjGrabber&lt;LayoutDesc&gt;::set(DBObj**,int)</code>
    /// </summary>
    // bool __thiscall DBObjGrabber<LayoutDesc>::set(DBObj**,int) (template type method)
}

public unsafe struct DBObjGrabber___SkillTable
{
    // Members
    public ACBindings.Internal.SkillTable* m_object;

    // Methods
}

public unsafe struct DBObjGrabber___CContractTable
{
    // Members
    public ACBindings.Internal.CContractTable* m_object;

    // Methods
}

public unsafe struct DBObjGrabber___DBPropertyCollection
{
    // Members
    public ACBindings.Internal.DBPropertyCollection* m_object;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F0010
    /// bool __thiscall DBObjGrabber&lt;DBPropertyCollection&gt;::set(DBObj***,int)</code>
    /// </summary>
    // bool __thiscall DBObjGrabber<DBPropertyCollection>::set(DBObj***,int) (template type method)
}

public unsafe struct DBObjGrabber___TabooTable
{
    // Members
    public ACBindings.Internal.TabooTable* m_object;

    // Methods
}

public unsafe struct DBObjGrabber___Font
{
    // Members
    public ACBindings.Internal.Font* m_object;

    // Methods
}

public unsafe struct DBObjGrabber___Attribute2ndTable
{
    // Members
    public ACBindings.Internal.Attribute2ndTable* m_object;

    // Methods
}

public unsafe struct DBObjGrabber___ExperienceTable
{
    // Members
    public ACBindings.Internal.ExperienceTable* m_object;

    // Methods
}

public unsafe struct DBObjGrabber___QuestDefDB
{
    // Members
    public ACBindings.Internal.QuestDefDB* m_object;

    // Methods
}

