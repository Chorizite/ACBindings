namespace ACBindings;

// BasePropertyDesc
public unsafe struct BasePropertyDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Statics
    public static ACBindings.AvailablePropertySet* s_allAvailableProperties = (ACBindings.AvailablePropertySet*)0x008189D8;

    // Child Types
    // BasePropertyDesc_vtbl
    public unsafe struct BasePropertyDesc_vtbl
    {
        // Members
        public System.IntPtr BasePropertyDesc_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint m_propertyName;
    public uint m_propertyType;
    public uint m_propertyGroup;
    public uint m_propertyProvider;
    public uint m_data;
    public uint m_ePatchFlags;
    public ACBindings.BasePropertyValue* m_defaultValue;
    public ACBindings.BasePropertyValue* m_minValue;
    public ACBindings.BasePropertyValue* m_maxValue;
    public ACBindings.AvailablePropertySet m_availableProperties;
    public ACBindings.PropertyInheritanceType.Type m_inheritanceType;
    public ACBindings.PropertyDatFileType.Type m_datFileType;
    public ACBindings.PropertyPropagationType.Type m_propagationType;
    public ACBindings.PropertyCachingType.Type m_cachingType;
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
    public ACBindings.PStringBase__sbyte m_strHelp;
    public float m_fPredictionTimeout;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall BasePropertyDesc::InqPatchFlags(BasePropertyDesc*,unsigned int*)
    public byte InqPatchFlags(uint* o_ePatchFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasePropertyDesc, uint*, byte>)0x00429920)(ref this, o_ePatchFlags);
    // char __thiscall BasePropertyDesc::InqDataID(_DWORD*,_DWORD*)
    public sbyte InqDataID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasePropertyDesc, int*, sbyte>)0x00429A70)(ref this, a2);
    // char __thiscall BasePropertyDesc::InqPropertyEnum(_DWORD*,int,int*)
    public sbyte InqPropertyEnum(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasePropertyDesc, int, int*, sbyte>)0x0042A500)(ref this, a2, a3);
    // void __thiscall BasePropertyDesc::GetSubDataIDs(BasePropertyDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasePropertyDesc, ACBindings.QualifiedDataIDArray*, void>)0x0042A580)(ref this, id_array);
    // void __thiscall BasePropertyDesc::Serialize(BasePropertyDesc*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasePropertyDesc, ACBindings.Archive*, void>)0x0042A600)(ref this, io_archive);
    // void __cdecl BasePropertyDesc::InitializeAllAvailablePropertySet()
    public static void InitializeAllAvailablePropertySet() => ((delegate* unmanaged[Cdecl]<void>)0x0042AA20)();
    // void __thiscall BasePropertyDesc::~BasePropertyDesc(BasePropertyDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasePropertyDesc, void>)0x0042ACE0)(ref this);
}

