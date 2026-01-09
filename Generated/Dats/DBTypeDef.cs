namespace ACBindings;

// DBTypeDef
public unsafe struct DBTypeDef
{
    // Members
    public ACBindings.IDClass___tagDataID m_base_did;
    public ACBindings.IDClass___tagDataID m_top_did;
    public ACBindings.SmartArray__PStringBase__sbyte m_extensions;
    public uint m_packVersion;
    public ACBindings.DBUpdateType.Type m_updateType;
    public byte m_bHasFile;
    public byte m_bIsPortalType;
    public byte m_bIsCellType;
    public byte m_bIsLocalType;
    public ACBindings.PStringBase__sbyte m_strDataDir;
    public byte m_bIsClientType;
    public byte m_bIsServerType;
    public byte m_bIsEngineType;
    public byte m_bIsDIDPackedToDats;
    public byte m_bIsWBEditable;
    public byte m_bIsCategorized;
    public byte m_bForceExpire;
    public ACBindings.FreelistDef m_freelistDef;

    // Generated Constructor
    public DBTypeDef() {
        _ConstructorInternal();
    }
    public DBTypeDef(ACBindings.DBTypeDef* that) {
        _ConstructorInternal(that);
    }

    // Methods
    // void __thiscall DBTypeDef::DBTypeDef(DBTypeDef*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBTypeDef, void>)0x0041C380)(ref this);
    // void __thiscall DBTypeDef::DBTypeDef(DBTypeDef*,const DBTypeDef*)
    public void _ConstructorInternal(ACBindings.DBTypeDef* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBTypeDef, ACBindings.DBTypeDef*, void>)0x0041F850)(ref this, that);
}

