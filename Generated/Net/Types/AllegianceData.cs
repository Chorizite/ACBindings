namespace ACBindings.Internal;


/// <summary>Stores data for a character’s allegiance profile, encompassing identification, name, gender, honor, rank, level, loyalty, leadership, and time‑related statistics. Facilitates tracking of status within the game world and informs gameplay mechanics such as faction interactions and progression.</summary>
public unsafe struct AllegianceData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, void> AllegianceData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public uint _gender;
    public uint _hg;
    public uint _rank;
    public uint _level;
    public uint _bitfield;
    public uint _cp_tithed;
    public uint _cp_cached;
    public uint _loyalty;
    public uint _leadership;
    public int _time_online;
    public int _allegiance_age;

    // Generated Constructor
    public AllegianceData() {
        _ConstructorInternal();
    }
    public AllegianceData(ACBindings.Internal.AllegianceData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves an allegiance title using stored data and external context.
    /// <code>Offset: 0x005B7620
    /// int __thiscall AllegianceData::GetTitle(int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to buffer or structure that will receive the generated title.</param>
    /// <returns>Integer result from AllegianceSystem::GetTitle, typically a status code or length of the produced title.</returns>
    public int GetTitle(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int*, int>)0x005B7620)(ref this, a2);

    /// <summary>Indicates whether the allegiance data represents a currently logged-in entity.
    /// <code>Offset: 0x005B7640
    /// int __thiscall AllegianceData::IsLoggedIn(AllegianceData*)</code>
    /// </summary>
    /// <returns>Non‑zero if logged in, zero otherwise.</returns>
    public int IsLoggedIn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int>)0x005B7640)(ref this);

    /// <summary>Sets whether the allegiance may pass up experience points.
    /// <code>Offset: 0x005B7650
    /// void __thiscall AllegianceData::SetMayPassupExperience(AllegianceData*,int)</code>
    /// </summary>
    /// <param name="bMayPassupExperience">If true, enable passing up experience; if false, disable it.</param>
    public void SetMayPassupExperience(int bMayPassupExperience) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int, void>)0x005B7650)(ref this, bMayPassupExperience);

    /// <summary>Creates an AllegianceData instance initialized with default values, setting identifiers, attributes, and statistics to zero and assigning an empty string to the name.
    /// <code>Offset: 0x005B7670
    /// void __thiscall AllegianceData::AllegianceData(AllegianceData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void>)0x005B7670)(ref this);

    /// <summary>Destroys an AllegianceData instance, releasing owned resources such as the name string and resetting the base class vtable to the PackObj implementation. The destructor decrements the reference counter of the name buffer and triggers its cleanup routine when the count reaches zero.
    /// <code>Offset: 0x005B76C0
    /// void __thiscall AllegianceData::~AllegianceData(AllegianceData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void>)0x005B76C0)(ref this);

    /// <summary>Calculates the total byte count required to pack this AllegianceData into a buffer, including its name string and structural overhead.
    /// <code>Offset: 0x005B77E0
    /// unsigned int __thiscall AllegianceData::GetPackSize(AllegianceData*)</code>
    /// </summary>
    /// <returns>The packed size in bytes as an unsigned integer.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, uint>)0x005B77E0)(ref this);

    /// <summary>Serializes AllegianceData into a memory buffer, writing all fields and the name string in packed format. If the supplied buffer has sufficient space, data is written sequentially and the address pointer advances accordingly.
    /// <code>Offset: 0x005B7800
    /// unsigned int __thiscall AllegianceData::Pack(AllegianceData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; updated to point after serialized data if packing succeeds.</param>
    /// <param name="size">Number of bytes remaining in the buffer; packing occurs only when this value is at least the required size.</param>
    /// <returns>Unsigned integer representing the total number of bytes needed to pack the object, regardless of whether packing was performed.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void**, uint, uint>)0x005B7800)(ref this, addr, size);

    /// <summary>Creates an AllegianceData instance, initializing all fields to default values and then copying data from a provided source object.
    /// <code>Offset: 0x005B78E0
    /// void __thiscall AllegianceData::AllegianceData(AllegianceData*,const AllegianceData*)</code>
    /// </summary>
    /// <param name="rhs">Source AllegianceData whose state is duplicated into the new instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.AllegianceData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, ACBindings.Internal.AllegianceData*, void>)0x005B78E0)(ref this, rhs);

    /// <summary>Unpacks serialized allegiance information from a buffer into the current object, interpreting an embedded bitfield to determine which optional values are present.
    /// <code>Offset: 0x005B7940
    /// int __thiscall AllegianceData::UnPack(AllegianceData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer location; advanced as data is consumed.</param>
    /// <param name="size">Remaining size of the buffer; if smaller than the required header size (0x20 bytes) the operation fails.</param>
    /// <returns>Non‑zero on success, zero when input data is too small.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void**, uint, int>)0x005B7940)(ref this, addr, size);

    /// <summary>Builds the alliance's full name by concatenating its title (if any) with the base name and stores it in the supplied string buffer.
    /// <code>Offset: 0x005B7A40
    /// int __thiscall AllegianceData::GetFullName(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a PStringBase object that will receive the constructed full name.</param>
    /// <returns>1 if a title was present and appended; otherwise 0.</returns>
    public int GetFullName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int, int>)0x005B7A40)(ref this, a2);
}

