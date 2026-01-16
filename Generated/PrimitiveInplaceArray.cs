namespace ACBindings.Internal;


/// <summary>Provides an efficient storage container for up to eight ArchiveVersionRow::VersionEntry objects, packing them directly into a 64‑byte buffer for low‑overhead access.</summary>
public unsafe struct PrimitiveInplaceArray___ArchiveVersionRow_VersionEntry
{
    // Base Classes
    public ACBindings.Internal.SmartArray___ArchiveVersionRow_VersionEntry BaseClass_SmartArray; // ACBindings.Internal.SmartArray___ArchiveVersionRow_VersionEntry

    // Members
    public fixed byte m_aPrimitiveInplaceMemory[64];

    // Methods
}

