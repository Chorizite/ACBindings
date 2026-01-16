namespace ACBindings.Internal;


/// <summary>Captures the state of a transmission receiver, tracking received entries, mode, overflow thresholds, highest timestamp, and any blocked entries.</summary>
public unsafe struct TSRecv : System.IDisposable
{
    // Members
    public int receivedFirstEntry_;
    public ACBindings.Internal.TSRecvMode mode_;
    public uint overflowLimit_;
    public uint highestStamp_;
    public ACBindings.Internal.TSBlockedEntry head_;
    public int numBlockedStamps_;
    public double blockedSince_;

    // Generated Constructor
    public TSRecv(ACBindings.Internal.TSRecvMode mode, uint TSOverflowLimit) {
        _ConstructorInternal(mode, TSOverflowLimit);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a TSRecv instance with the specified mode and overflow limit, resetting all internal counters and block lists.
    /// <code>Offset: 0x005B0F00
    /// void __thiscall TSRecv::TSRecv(TSRecv*,TSRecvMode,unsigned int)</code>
    /// </summary>
    /// <param name="mode">Operation mode determining how received data is processed.</param>
    /// <param name="TSOverflowLimit">Maximum number of entries allowed before overflow handling triggers.</param>
    public void _ConstructorInternal(ACBindings.Internal.TSRecvMode mode, uint TSOverflowLimit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, ACBindings.Internal.TSRecvMode, uint, void>)0x005B0F00)(ref this, mode, TSOverflowLimit);

    /// <summary>Retrieves the next ready blocked entry, updates internal state, and frees the entry.
    /// <code>Offset: 0x005B0F30
    /// int __thiscall TSRecv::GetNextReadyEntry(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Receives the stamp of the retrieved entry.</param>
    /// <param name="a3">Receives a pointer to the entry's data or callback function.</param>
    /// <returns>Non‑zero if an entry was returned; zero otherwise.</returns>
    public int GetNextReadyEntry(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, int*, int*, int>)0x005B0F30)(ref this, a2, a3);

    /// <summary>Releases all blocked entries owned by TSRecv, decrementing reference counts and invoking cleanup callbacks for objects whose count reaches zero before freeing allocated memory.
    /// <code>Offset: 0x005B0FF0
    /// void __thiscall TSRecv::~TSRecv(TSRecv*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, void>)0x005B0FF0)(ref this);

    /// <summary>Adds a timestamp entry to the TSRecv instance when the supplied stamp is newer than the current highest stamp, accounting for wrap‑around. Updates internal state and atomically increments an external counter.
    /// <code>Offset: 0x005B1060
    /// int __thiscall TSRecv::AddEntryLatest(_DWORD*,unsigned int,int,unsigned int*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The new timestamp value to consider adding.</param>
    /// <param name="a3">Pointer whose 4‑byte field at offset +4 will be incremented when a new entry is accepted.</param>
    /// <param name="a4">Receives the previous highest stamp before any update.</param>
    /// <param name="a5">Receives the value of a3 after successful update.</param>
    /// <returns>1 if the entry was accepted and state updated; 3 otherwise (stamp not newer).</returns>
    public int AddEntryLatest(uint a2, int a3, uint* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, uint, int, uint*, int*, int>)0x005B1060)(ref this, a2, a3, a4, a5);

    /// <summary>Adds a new entry into the TSRecv block list, inserting it in order based on its stamp value and updating internal counters.
    /// <code>Offset: 0x005B10E0
    /// int __thiscall TSRecv::AddEntry(_DWORD*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">The stamp or key used to position the entry within the sorted linked list.</param>
    /// <param name="a3">An optional pointer whose reference count is incremented when the entry is created; typically a resource that must be retained.</param>
    /// <param name="a4">Reserved for future use; currently ignored.</param>
    /// <returns>The total number of blocked entries after the insertion has been performed.</returns>
    public int AddEntry(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, int, int, int, int>)0x005B10E0)(ref this, a2, a3, a4);

    /// <summary>Adds an entry to the TSRecv buffer in blocking mode. If the supplied stamp is next expected, the entry is accepted immediately; otherwise it is enqueued until prior stamps become available.
    /// <code>Offset: 0x005B11A0
    /// int __thiscall TSRecv::AddEntryBlocking(int,unsigned int,int,unsigned int*,int*)</code>
    /// </summary>
    /// <param name="a2">The sequence number (stamp) of the incoming entry.</param>
    /// <param name="a3">A pointer to data whose reference count should be incremented if the entry is accepted; zero indicates no data.</param>
    /// <param name="a4">Receives the stamp that was actually stored for this entry.</param>
    /// <param name="a5">Receives the count/value associated with the entry, or 0 if the entry could not be added.</param>
    /// <returns>1 if the entry is accepted and ready; 2 if it has been queued and will become ready later; 3 if the stamp is too old/duplicate or an error occurred.</returns>
    public int AddEntryBlocking(uint a2, int a3, uint* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, uint, int, uint*, int*, int>)0x005B11A0)(ref this, a2, a3, a4, a5);

    /// <summary>Selects the appropriate entry‑adding strategy based on the receiver’s mode and delegates to AddEntryBlocking or AddEntryLatest.
    /// <code>Offset: 0x005B12D0
    /// int __thiscall TSRecv::AddAndCheck(_DWORD*,unsigned int,int,unsigned int*,int*)</code>
    /// </summary>
    /// <param name="this">The TSRecv instance.</param>
    /// <param name="a2">Timestamp for the entry to add.</param>
    /// <param name="a3">Associated data value of the entry.</param>
    /// <param name="a4">Pointer to auxiliary data passed to the underlying add function.</param>
    /// <param name="a5">Output flag; initialized to 0 and may be updated by the called function.</param>
    /// <returns>Result code from AddEntryBlocking or AddEntryLatest, or 0 if the mode is unsupported.</returns>
    public int AddAndCheck(uint a2, int a3, uint* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, uint, int, uint*, int*, int>)0x005B12D0)(ref this, a2, a3, a4, a5);
}

