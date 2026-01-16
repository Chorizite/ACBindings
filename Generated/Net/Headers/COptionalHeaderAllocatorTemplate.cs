namespace ACBindings.Internal;


/// <summary>Specialized allocator for optional headers defined by COnePrimHeader with a 512‑byte size, version 7, and a sockaddr_in payload, tailored for use in a 32‑bit Windows application.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___COnePrimHeader__int
{
    // Methods
}


/// <summary>Provides a fixed‑size memory allocator for CEchoRequestHeader objects, allocating 32 MB of buffer space to manage optional header data efficiently.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CEchoRequestHeader
{
    // Methods
}


/// <summary>Facilitates allocation of optional header blocks sized 65536 bytes, tailored for CLogonHeader structures.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CLogonHeader
{
    // Methods
}


/// <summary>Provides allocation and lifecycle management of optional headers for CICMDCommandStruct objects, enabling efficient command processing in the system.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___COnePrimHeader___CICMDCommandStruct
{
    // Methods
}


/// <summary>Handles allocation of optional header blocks for sequence ID list headers using a 8192‑byte buffer and supporting up to 33 identifiers.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CSeqIDListHeader
{
    // Methods
}


/// <summary>Specializes the optional header allocator template for CEchoResponseHeader types, enabling tailored allocation behavior within the networking subsystem.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CEchoResponseHeader
{
    // Methods
}


/// <summary>Specializes optional header allocation logic for CPackObjHeader&lt;NetError,1048576,7&gt;, configuring a 1 048 576‑byte memory block used by the allocator system.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CPackObjHeader___NetError
{
    // Methods
}


/// <summary>Configures a 16 MiB optional header allocation strategy for CTimeSyncHeader, enabling the system to reserve space for time‑synchronization data at compile time.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CTimeSyncHeader
{
    // Methods
}


/// <summary>Specializes an allocator for optional headers of 2048 bytes, leveraging the COnePrimHeader implementation identified by 1073741922 and linked to CReferralStruct.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___COnePrimHeader___CReferralStruct
{
    // Methods
}


/// <summary>Specializes optional header allocation behavior for prim headers sized 134217728 with an embedded CFlowStruct layout.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___COnePrimHeader___CFlowStruct
{
    // Methods
}


/// <summary>Specializes the optional header allocator for a 524 288‑byte block using a single primary header type identified by 0x20000007 and an unsigned 64‑bit size field, configuring allocation strategy at compile time for memory or executable image headers.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___COnePrimHeader__ulong
{
    // Methods
}


/// <summary>Allocates optional headers for a 32 KB memory region, leveraging an empty header type specialized with size and count parameters.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CEmptyHeader
{
    // Methods
}


/// <summary>Handles allocation of optional header regions for CServerSwitchStruct instances, ensuring proper alignment within 256‑byte primary headers that contain a 96‑byte subheader.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___COnePrimHeader___CServerSwitchStruct
{
    // Methods
}


/// <summary>Allocates and manages optional header structures of type CConnectHeader using a fixed-size buffer, enabling efficient memory reuse within the application.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___CConnectHeader
{
    // Methods
}


/// <summary>Provides allocation of optional headers for one‑primitive data structures sized 16384, using an unsigned long identifier to manage header instances.</summary>
public unsafe struct COptionalHeaderAllocatorTemplate___COnePrimHeader__uint
{
    // Methods
}

