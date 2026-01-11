namespace ACBindings.Internal;

public unsafe struct PropertyCollection : System.IDisposable
{
    // Child Types
    public unsafe struct PropertyCollection_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PropertyCollection*, void> PropertyCollection_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PropertyCollection*, void> Destroy; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.AutoGrowHashTable__uint___BaseProperty m_hashProperties;

    // Generated Constructor
    public PropertyCollection() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004643E0
    /// bool __thiscall PropertyCollection::ContainsProperty(PropertyCollection*,const unsigned int)</code>
    /// </summary>
    public byte ContainsProperty(uint propertyName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, uint, byte>)0x004643E0)(ref this, propertyName);

    /// <summary>
    /// <code>Offset: 0x004753D0
    /// bool __thiscall PropertyCollection::AddProperty(PropertyCollection*,const BaseProperty*)</code>
    /// </summary>
    public byte AddProperty(ACBindings.Internal.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.BaseProperty*, byte>)0x004753D0)(ref this, property);

    /// <summary>
    /// <code>Offset: 0x00680EB0
    /// void __thiscall PropertyCollection::GetSubDataIDs(PropertyCollection*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00680EB0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x006817E0
    /// bool __thiscall PropertyCollection::UpdateCollection(PropertyCollection*,const PropertyCollection*,const bool)</code>
    /// </summary>
    public byte UpdateCollection(ACBindings.Internal.PropertyCollection* collection, byte bAddNewProperties) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.PropertyCollection*, byte, byte>)0x006817E0)(ref this, collection, bAddNewProperties);

    /// <summary>
    /// <code>Offset: 0x006818B0
    /// char __thiscall PropertyCollection::InqPropertyGroupNames(_DWORD*,unsigned int**,PropertyGroupNameSort)</code>
    /// </summary>
    public sbyte InqPropertyGroupNames(uint** a2, ACBindings.Internal.PropertyGroupNameSort a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, uint**, ACBindings.Internal.PropertyGroupNameSort, sbyte>)0x006818B0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006819F0
    /// char __thiscall PropertyCollection::InqPropertiesByGroup(_DWORD*,_DWORD*,BaseProperty**,BasePropertyNameSort)</code>
    /// </summary>
    public sbyte InqPropertiesByGroup(int* a2, ACBindings.Internal.BaseProperty** a3, ACBindings.Internal.BasePropertyNameSort a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, int*, ACBindings.Internal.BaseProperty**, ACBindings.Internal.BasePropertyNameSort, sbyte>)0x006819F0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00681B30
    /// bool __thiscall PropertyCollection::ToFileNode(PropertyCollection*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.PFileNode*, byte>)0x00681B30)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x00681D60
    /// void __thiscall PropertyCollection::PruneForServer(PropertyCollection*)</code>
    /// </summary>
    public void PruneForServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x00681D60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00681E60
    /// void __thiscall PropertyCollection::PruneForClient(PropertyCollection*)</code>
    /// </summary>
    public void PruneForClient() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x00681E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00681F60
    /// void __thiscall PropertyCollection::~PropertyCollection(PropertyCollection*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x00681F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00681FB0
    /// bool __thiscall PropertyCollection::FromFileNode(PropertyCollection*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.PFileNode*, byte>)0x00681FB0)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x006823D0
    /// void __thiscall PropertyCollection::PropertyCollection(PropertyCollection*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, void>)0x006823D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00682420
    /// void __thiscall PropertyCollection::Serialize(PropertyCollection*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PropertyCollection, ACBindings.Internal.Archive*, void>)0x00682420)(ref this, io_rcArchive);
}

