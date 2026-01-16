namespace ACBindings.Internal;


/// <summary>
/// Stores the current user's emoticon string and a complementary partner's emoticon, enabling packing into a binary format for network transmission.
/// Provides serialization support through Pack and UnPack methods.
/// Manages reference counting of shared string buffers to ensure proper memory handling.
/// </summary>
public unsafe struct ChatEmoteData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ChatEmoteData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, void> ChatEmoteData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatEmoteData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte myEmote;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte otherEmote;

    // Generated Constructor
    public ChatEmoteData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a ChatEmoteData instance by decrementing reference counts of its stored emotes, freeing them if no longer referenced, and restoring the base class virtual table to its default state.
    /// <code>Offset: 0x004FD9D0
    /// void __thiscall ChatEmoteData::~ChatEmoteData(ChatEmoteData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void>)0x004FD9D0)(ref this);

    /// <summary>Packs the chat emote data into a binary format by serializing its internal strings into the supplied buffer.
    /// <code>Offset: 0x004FDA20
    /// unsigned int __thiscall ChatEmoteData::Pack(ChatEmoteData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the ChatEmoteData instance being serialized.</param>
    /// <param name="addr">Address of the buffer where the packed data will be written.</param>
    /// <param name="size">Current offset within the buffer for packing operations.</param>
    /// <returns>The total number of bytes written to the buffer.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void**, uint, uint>)0x004FDA20)(ref this, addr, size);

    /// <summary>Unpacks the emote strings from a serialized buffer into the ChatEmoteData object, returning true only if both fields were successfully unpacked.
    /// <code>Offset: 0x004FDBE0
    /// int __thiscall ChatEmoteData::UnPack(ChatEmoteData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the data buffer location used for unpacking.</param>
    /// <param name="size">Size of the available serialized data.</param>
    /// <returns>Non‑zero value if both emotes were unpacked successfully; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void**, uint, int>)0x004FDBE0)(ref this, addr, size);

    /// <summary>Initializes a new ChatEmoteData instance by linking the base class vtable, assigning empty buffers to its string members, and incrementing the reference count of the shared null buffer.
    /// <code>Offset: 0x004FE2A0
    /// void __thiscall ChatEmoteData::ChatEmoteData(ChatEmoteData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatEmoteData, void>)0x004FE2A0)(ref this);
}

