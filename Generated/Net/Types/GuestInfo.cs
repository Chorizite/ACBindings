namespace ACBindings.Internal;


/// <summary>
/// Stores data for a guest character, including its name and whether it is allowed to store items in the game world.
/// </summary>
public unsafe struct GuestInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GuestInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, void> GuestInfo_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int _item_storage_permission;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _char_name;

    // Generated Constructor
    public GuestInfo() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Destructs a GuestInfo instance, releasing its character name buffer and restoring the base PackObj vtable.
    /// 
    /// <code>Offset: 0x005B0220
    /// void __thiscall GuestInfo::~GuestInfo(GuestInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void>)0x005B0220)(ref this);

    /// <summary>Resets the guest’s item‑storage permission to zero and safely releases the character name string buffer, handling reference counts appropriately.
    /// <code>Offset: 0x005B0370
    /// void __thiscall GuestInfo::Clear(GuestInfo*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void>)0x005B0370)(ref this);

    /// <summary>Calculates the size in bytes necessary to serialize the guest's character name, including a 4‑byte length prefix.
    /// <code>Offset: 0x005B03C0
    /// unsigned int __thiscall GuestInfo::GetPackSize(GuestInfo*)</code>
    /// </summary>
    /// <returns>The total number of bytes required for packing.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, uint>)0x005B03C0)(ref this);

    /// <summary>Serializes the guest information into a binary format, writing permission flag and character name into the provided buffer.
    /// <code>Offset: 0x005B03E0
    /// unsigned int __thiscall GuestInfo::Pack(GuestInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; updated to point after written data.</param>
    /// <param name="size">Available size in bytes of the destination buffer.</param>
    /// <returns>The total number of bytes required to pack the object, regardless of whether the actual write succeeded.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void**, uint, uint>)0x005B03E0)(ref this, addr, size);

    /// <summary>Constructs a GuestInfo instance with an empty character name and zero item storage permission.
    /// <code>Offset: 0x005B0420
    /// void __thiscall GuestInfo::GuestInfo(GuestInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void>)0x005B0420)(ref this);

    /// <summary>Unpacks guest information from a binary buffer into this instance, reading the storage permission flag and character name while first clearing existing data.
    /// <code>Offset: 0x005B0490
    /// int __thiscall GuestInfo::UnPack(GuestInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; advanced internally past the processed bytes.</param>
    /// <param name="size">Number of remaining bytes available for unpacking; read only, not modified by the method.</param>
    /// <returns>Non‑zero if all fields were successfully extracted and assigned; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void**, uint, int>)0x005B0490)(ref this, addr, size);

    /// <summary>Appends the guest’s information to the supplied string buffer.
    /// <code>Offset: 0x005B05D0
    /// int __thiscall GuestInfo::Dump(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an AC1Legacy::PStringBase&lt;char&gt; that receives the formatted line: two spaces, the character name, an optional “ *” if storage permission is granted, and a newline.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int Dump(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, int, int>)0x005B05D0)(ref this, a2);
}

