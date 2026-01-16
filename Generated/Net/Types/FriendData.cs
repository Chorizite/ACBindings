namespace ACBindings.Internal;


/// <summary>Represents a friend's profile in the game, storing a unique ID, display name, online status flags, and two lists of friend relationships for quick serialization and deserialization.</summary>
public unsafe struct FriendData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct FriendData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, void> FriendData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FriendData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_id;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_name;
    public int m_online;
    public int m_appearOffline;
    public ACBindings.Internal.PList__uint m_friendsList;
    public ACBindings.Internal.PList__uint m_friendOfList;

    // Generated Constructor
    public FriendData() {
        _ConstructorInternal();
    }
    public FriendData(ACBindings.Internal.FriendData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destructs a FriendData instance, releasing its friends and friend‑of lists and decrementing the reference count of its name string.
    /// <code>Offset: 0x0048C960
    /// void __thiscall FriendData::~FriendData(FriendData*)</code>
    /// </summary>
    /// <param name="this">The FriendData object to be destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void>)0x0048C960)(ref this);

    /// <summary>Calculates the total byte size needed to serialize this friend data object.
    /// <code>Offset: 0x005BADA0
    /// unsigned int __thiscall FriendData::GetPackSize(FriendData*)</code>
    /// </summary>
    /// <returns>The packed size in bytes, including the name string, friends lists, base class data, and an additional 12‑byte overhead.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, uint>)0x005BADA0)(ref this);

    /// <summary>Serializes the FriendData object into a binary stream, writing its identifier, status flags, name, and friend lists when sufficient space is supplied.
    /// <code>Offset: 0x005BADF0
    /// unsigned int __thiscall FriendData::Pack(FriendData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that references the current write position in the buffer; updated to point past the written data.</param>
    /// <param name="size">Number of bytes remaining in the buffer from the current address.</param>
    /// <returns>Size, in bytes, required to serialize the entire FriendData object. If size is insufficient, no data is written and this value still indicates how many bytes would be needed.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void**, uint, uint>)0x005BADF0)(ref this, addr, size);

    /// <summary>Unpacks a FriendData object from the supplied byte buffer, extracting ID, online status, appearance flag, name string, friend list and reciprocal list.
    /// <code>Offset: 0x005BAE60
    /// int __thiscall FriendData::UnPack(FriendData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; advanced as data is consumed.</param>
    /// <param name="size">Total remaining size of the buffer; must be at least 12 bytes for the fixed fields.</param>
    /// <returns>1 if unpacking succeeded, or 0 if the buffer was too small to contain all required fields.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void**, uint, int>)0x005BAE60)(ref this, addr, size);

    /// <summary>Initializes a new FriendData instance with default values: zero ID, an empty name string, offline status flags cleared, and both friend lists set to empty.
    /// <code>Offset: 0x005BAED0
    /// void __thiscall FriendData::FriendData(FriendData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, void>)0x005BAED0)(ref this);

    /// <summary>Creates a FriendData instance, initializing all fields to default values and then copying the contents from another FriendData object.
    /// <code>Offset: 0x005BAFC0
    /// void __thiscall FriendData::FriendData(FriendData*,const FriendData*)</code>
    /// </summary>
    /// <param name="rhs">The source FriendData whose data is duplicated into the newly constructed instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.FriendData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FriendData, ACBindings.Internal.FriendData*, void>)0x005BAFC0)(ref this, rhs);
}

