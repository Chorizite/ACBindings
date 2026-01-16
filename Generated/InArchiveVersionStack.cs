namespace ACBindings.Internal;


/// <summary>
/// Manages archive versions by storing version rows in an intrusive hash list, handling reference counting, and exposing query interfaces to retrieve or modify version data.
/// </summary>
public unsafe struct InArchiveVersionStack : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IArchiveVersionStack BaseClass_IArchiveVersionStack; // ACBindings.Internal.IArchiveVersionStack

    // Child Types
    public unsafe struct InArchiveVersionStack_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IArchiveVersionStack*, uint, uint> GetVersionByToken; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IArchiveVersionStack*, uint, uint, byte> SetVersion; // function pointer
        public fixed byte gap20[4];
        public System.IntPtr PushVersionRow;
        public System.IntPtr PopVersionRow;
        public System.IntPtr GetRowByHandle;
        public System.IntPtr GetCurrentVersionHandle;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IArchiveVersionStack*, void> Reset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InArchiveVersionStack*, ACBindings.Internal.InArchiveVersionStack.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // InArchiveVersionStack::Enum3
    public enum Enum3 : uint
    {
    }

    /// <summary>Maintains a single entry in the archive version stack, connecting via an intrusive hash list to enable efficient lookup while storing the associated ArchiveVersionRow data.</summary>
    public unsafe struct VersionRowHolder
    {
        // Base Classes
        public ACBindings.Internal.IntrusiveHashListData___IDClass____tagVersionHandle___InArchiveVersionStack_VersionRowHolder_ptr BaseClass_IntrusiveHashListData; // ACBindings.Internal.IntrusiveHashListData___IDClass____tagVersionHandle___InArchiveVersionStack_VersionRowHolder_ptr

        // Members
        public ACBindings.Internal.ArchiveVersionRow m_VersionRow;

        // Methods
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.IntrusiveHashList___IDClass____tagVersionHandle___InArchiveVersionStack_VersionRowHolder_ptr m_hlVersions;
    public ACBindings.Internal.InArchiveVersionStack.VersionRowHolder m_vrDefaultRow;
    public uint m_iLastSerialNumber;

    // Generated Constructor
    public InArchiveVersionStack() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes an InArchiveVersionStack instance, setting up its reference counter, hash table for version rows, a default empty row, and the initial serial number.
    /// <code>Offset: 0x0040AE30
    /// void __thiscall InArchiveVersionStack::InArchiveVersionStack(InArchiveVersionStack*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, void>)0x0040AE30)(ref this);

    /// <summary>Increments the internal reference counter of the archive version stack and returns the new reference count.
    /// <code>Offset: 0x0040AEB0
    /// unsigned int __thiscall InArchiveVersionStack::AddRef(InArchiveVersionStack*)</code>
    /// </summary>
    /// <returns>The updated reference count after the increment operation.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, uint>)0x0040AEB0)(ref this);

    /// <summary>Releases a reference to the archive version stack, decrementing its internal reference counter and destroying the instance when the count drops to zero.
    /// <code>Offset: 0x0040AEC0
    /// unsigned int __thiscall InArchiveVersionStack::Release(InArchiveVersionStack*)</code>
    /// </summary>
    /// <returns>The updated reference count after the release operation.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, uint>)0x0040AEC0)(ref this);

    /// <summary>Determines whether the InArchiveVersionStack hierarchy contains multiple AddRef implementations; currently always reports none.
    /// <code>Offset: 0x0040E710
    /// DialogBoxGateway::ThisFunctionHasBeenRenamed __thiscall InArchiveVersionStack::You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy(DialogBoxGateway*)</code>
    /// </summary>
    /// <param name="this">Pointer to a DialogBoxGateway instance providing context for the check.</param>
    /// <returns>Zero, indicating that no duplicate AddRef implementations were detected (placeholder implementation).</returns>
    public ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed>)0x0040E710)(ref this);

    /// <summary>Retrieves an interface implementation matching the supplied GUID from an InArchiveVersionStack instance, populating the result structure and optionally returning a reference to the requested interface.
    /// <code>Offset: 0x004108D0
    /// TResult* __thiscall InArchiveVersionStack::QueryInterface(InArchiveVersionStack*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Pointer to a TResult where the method writes a status code (0 for success, -2147467262 for E_NOINTERFACE).</param>
    /// <param name="i_rInterfaceType">GUID specifying the desired interface type.</param>
    /// <param name="o_pOutInterface">If non‑null and the requested interface is supported, receives a pointer to that interface; otherwise left unchanged. The returned interface has its reference count incremented.</param>
    /// <returns>Returns the TResult* passed in, with result->m_val set to indicate success or failure.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rInterfaceType, void** o_pOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x004108D0)(ref this, result, i_rInterfaceType, o_pOutInterface);

    /// <summary>Retrieves the archive version corresponding to a specified token from this stack.
    /// <code>Offset: 0x00410970
    /// unsigned int __thiscall InArchiveVersionStack::GetVersionByToken(InArchiveVersionStack*,unsigned int)</code>
    /// </summary>
    /// <param name="i_tokVersion">The token identifying an archive version.</param>
    /// <returns>The matching version number, or zero if no entry is found.</returns>
    public uint GetVersionByToken(uint i_tokVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, uint, uint>)0x00410970)(ref this, i_tokVersion);

    /// <summary>Sets the token and internal version numbers for the most recent archive version row stored within the stack.
    /// <code>Offset: 0x004109A0
    /// bool __thiscall InArchiveVersionStack::SetVersion(InArchiveVersionStack*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_tokVersion">The token identifying the archive version to update.</param>
    /// <param name="i_iVersion">The new internal version number associated with that token.</param>
    /// <returns>True if a row existed and the underlying SetVersion succeeded; otherwise false (e.g., no rows present or SetVersion failed).</returns>
    public byte SetVersion(uint i_tokVersion, uint i_iVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, uint, uint, byte>)0x004109A0)(ref this, i_tokVersion, i_iVersion);

    /// <summary>Retrieves the current archive version handle and stores it in the supplied output parameter. If no valid handle is present, assigns an invalid handle identifier.
    /// <code>Offset: 0x004109D0
    /// unsigned int* __thiscall InArchiveVersionStack::GetCurrentVersionHandle(_DWORD*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a unsigned int that receives the current version handle ID.</param>
    /// <returns>Returns the same pointer provided in a2 for chaining convenience.</returns>
    public uint* GetCurrentVersionHandle(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, uint*, uint*>)0x004109D0)(ref this, a2);

    /// <summary>Retrieves the archive row corresponding to the given handle if it exists.
    /// <code>Offset: 0x00410AF0
    /// char __thiscall InArchiveVersionStack::GetRowByHandle(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Handle identifying the desired row.</param>
    /// <param name="a3">Pointer that receives a pointer to the located row data on success.</param>
    /// <returns>Non‑zero if the row was found; otherwise zero.</returns>
    public sbyte GetRowByHandle(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, uint, int*, sbyte>)0x00410AF0)(ref this, a2, a3);

    /// <summary>Pushes a new archive version row onto the stack, allocating a VersionRowHolder when necessary and inserting it into the internal hash list.
    /// <code>Offset: 0x00410D40
    /// DLListData** __thiscall InArchiveVersionStack::PushVersionRow(int,DLListData**)</code>
    /// </summary>
    /// <param name="a2">Receives the previous top of the DLListData chain before the push operation.</param>
    /// <returns>Returns the same pointer that was passed in as the output parameter (the address of the DLListData**).</returns>
    public ACBindings.Internal.DLListData** PushVersionRow(ACBindings.Internal.DLListData** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, ACBindings.Internal.DLListData**, ACBindings.Internal.DLListData**>)0x00410D40)(ref this, a2);

    /// <summary>Inserts a new version row into the stack and returns the former top of the list via an output parameter.
    /// <code>Offset: 0x00410DE0
    /// DLListData** __thiscall InArchiveVersionStack::PushVersionRow(_DWORD*,DLListData**,int)</code>
    /// </summary>
    /// <param name="this">The InArchiveVersionStack instance on which to operate.</param>
    /// <param name="a2">A pointer that receives the current head of the list before insertion.</param>
    /// <param name="a3">Pointer to data for the new row; the structure at offset 4 is copied into the node’s storage.</param>
    /// <returns>Same as a2, providing the previous top of the stack for convenience.</returns>
    public ACBindings.Internal.DLListData** PushVersionRow(ACBindings.Internal.DLListData** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, ACBindings.Internal.DLListData**, int, ACBindings.Internal.DLListData**>)0x00410DE0)(ref this, a2, a3);

    /// <summary>Removes the version row identified by the supplied key from the stack and deallocates its resources.
    /// <code>Offset: 0x00410F30
    /// char __thiscall InArchiveVersionStack::PopVersionRow(int,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the version row to remove.</param>
    /// <returns>Non‑zero if a row was found and removed; zero otherwise.</returns>
    public sbyte PopVersionRow(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, int, sbyte>)0x00410F30)(ref this, a2);

    /// <summary>Clears all entries in the archive version stack, freeing allocated resources and resetting internal structures to an empty state.
    /// <code>Offset: 0x00410F90
    /// void __thiscall InArchiveVersionStack::Reset(InArchiveVersionStack*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, void>)0x00410F90)(ref this);

    /// <summary>Destroys an InArchiveVersionStack instance, freeing its hash table buckets, deallocating any allocated version row data, and resetting internal state and reference counters.
    /// <code>Offset: 0x004110C0
    /// void __thiscall InArchiveVersionStack::~InArchiveVersionStack(InArchiveVersionStack*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InArchiveVersionStack, void>)0x004110C0)(ref this);
}

