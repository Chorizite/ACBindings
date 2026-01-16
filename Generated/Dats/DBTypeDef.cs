namespace ACBindings.Internal;


/// <summary>Encapsulates metadata for a database type, specifying its base and top data identifiers, update behavior, storage path, and numerous role flags such as client, server, engine, portal, cell, and local contexts.</summary>
public unsafe struct DBTypeDef
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID m_base_did;
    public ACBindings.Internal.IDClass____tagDataID m_top_did;
    public ACBindings.Internal.SmartArray___PStringBase__sbyte m_extensions;
    public uint m_packVersion;
    public ACBindings.Internal.DBUpdateType.Type m_updateType;
    public byte m_bHasFile;
    public byte m_bIsPortalType;
    public byte m_bIsCellType;
    public byte m_bIsLocalType;
    public ACBindings.Internal.PStringBase__sbyte m_strDataDir;
    public byte m_bIsClientType;
    public byte m_bIsServerType;
    public byte m_bIsEngineType;
    public byte m_bIsDIDPackedToDats;
    public byte m_bIsWBEditable;
    public byte m_bIsCategorized;
    public byte m_bForceExpire;
    public ACBindings.Internal.FreelistDef m_freelistDef;

    // Generated Constructor
    public DBTypeDef() {
        _ConstructorInternal();
    }
    public DBTypeDef(ACBindings.Internal.DBTypeDef* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Initializes a DBTypeDef instance with default values, setting identifiers to invalid, clearing extensions and data directory, resetting all type flags, and configuring the freelist with standard parameters.
    /// <code>Offset: 0x0041C380
    /// void __thiscall DBTypeDef::DBTypeDef(DBTypeDef*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBTypeDef, void>)0x0041C380)(ref this);

    /// <summary>Creates a new DBTypeDef by copying all fields from the supplied object, including identifiers, flags, and reference‑counted string resources.
    /// <code>Offset: 0x0041F850
    /// void __thiscall DBTypeDef::DBTypeDef(DBTypeDef*,const DBTypeDef*)</code>
    /// </summary>
    /// <param name="that">The source DBTypeDef whose data is copied into the new instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.DBTypeDef* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBTypeDef, ACBindings.Internal.DBTypeDef*, void>)0x0041F850)(ref this, that);
}

