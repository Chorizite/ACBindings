namespace ACBindings.Internal;


/// <summary>Holds information required to delete an internal transaction between a target and donor data entity on disk, including identifiers, offsets, and indices for both sides.</summary>
public unsafe struct DeleteInternalTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_cTargetDID;
    public ACBindings.Internal.IDClass____tagDataID m_cDonorDID;
    public int m_nTargetOffset;
    public int m_nDonorOffset;
    public int m_nTargetIndex;
    public int m_nDonorIndex;

    // Generated Constructor
    public DeleteInternalTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Constructs a DeleteInternalTransactInfo instance with default values for an internal deletion operation, initializing the base DiskTransactInfo and setting target/donor identifiers, offsets, and indices to invalid or zero.
    /// <code>Offset: 0x00677400
    /// void __thiscall DeleteInternalTransactInfo::DeleteInternalTransactInfo(DeleteInternalTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DeleteInternalTransactInfo, void>)0x00677400)(ref this);

    /// <summary>Serializes the internal transaction information to or from the provided archive, writing or reading each field depending on the archive's mode.
    /// <code>Offset: 0x00677440
    /// void __thiscall DeleteInternalTransactInfo::Serialize(DeleteInternalTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="this">The DeleteInternalTransactInfo instance being serialized.</param>
    /// <param name="io_rcArchive">The archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DeleteInternalTransactInfo, ACBindings.Internal.Archive*, void>)0x00677440)(ref this, io_rcArchive);
}

