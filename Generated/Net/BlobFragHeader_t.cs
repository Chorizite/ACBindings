namespace ACBindings.Internal;


/// <summary>Identifies a fragment of a larger blob by storing metadata such as unique ID, fragment count, size, sequence number, and queue identifier. Enables reassembly and management of distributed data fragments within the system.</summary>
public unsafe struct BlobFragHeader_t
{
    // Members
    public ulong blobID;
    public ushort numFrags;
    public ushort blobFragSize;
    public ushort blobNum;
    public ushort queueID;

    // Methods
}

