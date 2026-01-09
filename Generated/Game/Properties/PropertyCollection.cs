namespace ACBindings;

// PropertyCollection
public unsafe struct PropertyCollection : System.IDisposable
{
    // Child Types
    // PropertyCollection_vtbl
    public unsafe struct PropertyCollection_vtbl
    {
        // Members
        public System.IntPtr PropertyCollection_dtor_0; // function pointer
        public System.IntPtr Destroy; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.AutoGrowHashTable__uint__BaseProperty m_hashProperties;

    // Generated Constructor
    public PropertyCollection() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall PropertyCollection::ContainsProperty(PropertyCollection*,const unsigned int)
    public byte ContainsProperty(uint propertyName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, uint, byte>)0x004643E0)(ref this, propertyName);
    // bool __thiscall PropertyCollection::AddProperty(PropertyCollection*,const BaseProperty*)
    public byte AddProperty(ACBindings.BaseProperty* property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, ACBindings.BaseProperty*, byte>)0x004753D0)(ref this, property);
    // void __thiscall PropertyCollection::GetSubDataIDs(PropertyCollection*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, ACBindings.QualifiedDataIDArray*, void>)0x00680EB0)(ref this, id_array);
    // bool __thiscall PropertyCollection::UpdateCollection(PropertyCollection*,const PropertyCollection*,const bool)
    public byte UpdateCollection(ACBindings.PropertyCollection* collection, byte bAddNewProperties) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, ACBindings.PropertyCollection*, byte, byte>)0x006817E0)(ref this, collection, bAddNewProperties);
    // char __thiscall PropertyCollection::InqPropertyGroupNames(_DWORD*,unsigned int**,PropertyGroupNameSort)
    public sbyte InqPropertyGroupNames(uint** a2, ACBindings.PropertyGroupNameSort a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, uint**, ACBindings.PropertyGroupNameSort, sbyte>)0x006818B0)(ref this, a2, a3);
    // char __thiscall PropertyCollection::InqPropertiesByGroup(_DWORD*,_DWORD*,BaseProperty**,BasePropertyNameSort)
    public sbyte InqPropertiesByGroup(int* a2, ACBindings.BaseProperty** a3, ACBindings.BasePropertyNameSort a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, int*, ACBindings.BaseProperty**, ACBindings.BasePropertyNameSort, sbyte>)0x006819F0)(ref this, a2, a3, a4);
    // bool __thiscall PropertyCollection::ToFileNode(PropertyCollection*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, ACBindings.PFileNode*, byte>)0x00681B30)(ref this, node);
    // void __thiscall PropertyCollection::PruneForServer(PropertyCollection*)
    public void PruneForServer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, void>)0x00681D60)(ref this);
    // void __thiscall PropertyCollection::PruneForClient(PropertyCollection*)
    public void PruneForClient() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, void>)0x00681E60)(ref this);
    // void __thiscall PropertyCollection::~PropertyCollection(PropertyCollection*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, void>)0x00681F60)(ref this);
    // bool __thiscall PropertyCollection::FromFileNode(PropertyCollection*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, ACBindings.PFileNode*, byte>)0x00681FB0)(ref this, node);
    // void __thiscall PropertyCollection::PropertyCollection(PropertyCollection*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, void>)0x006823D0)(ref this);
    // void __thiscall PropertyCollection::Serialize(PropertyCollection*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PropertyCollection, ACBindings.Archive*, void>)0x00682420)(ref this, io_rcArchive);
}

