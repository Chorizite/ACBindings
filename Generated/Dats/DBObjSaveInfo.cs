namespace ACBindings.Internal;


/// <summary>Represents a node in the database object's save structure, linking a qualified data identifier to its associated DBObjSaveInfo instance and storing flags that describe sub‑data attributes.</summary>
public unsafe struct DBObjSaveInfo
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashData___QualifiedDataID___DBObjSaveInfo_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData___QualifiedDataID___DBObjSaveInfo_ptr

    // Members
    public uint m_dwSubDataIDFlags;

    // Methods
}

