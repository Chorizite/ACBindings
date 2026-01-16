namespace ACBindings.Internal;


/// <summary>Encapsulates data representing an in‑game emote, including type, timing, visual and audio effects, positioning, and metadata for network serialization.</summary>
/// <remarks>Provides validation, packing, and unpacking logic tailored to each emote subtype.</remarks>
public unsafe struct Emote : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Emote_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, void> Emote_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint type;
    public float delay;
    public float extent;
    public uint amount;
    public ulong amount64;
    public ulong heroxp64;
    public ulong min64;
    public ulong max64;
    public uint min;
    public uint max;
    public double fmin;
    public double fmax;
    public uint stat;
    public uint motion;
    public ACBindings.Internal.PScriptType pscript;
    public ACBindings.Internal.SoundType sound;
    public ACBindings.Internal.CreationProfile cprof;
    public ACBindings.Internal.Frame frame;
    public uint spellid;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte teststring;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte msg;
    public double percent;
    public int display;
    public uint wealth_rating;
    public uint treasure_class;
    public int treasure_type;
    public ACBindings.Internal.Position mPosition;

    // Generated Constructor
    public Emote() {
        _ConstructorInternal();
    }
    public Emote(ACBindings.Internal.Emote* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Validates an Emote instance, verifying that its delay, extent, amounts, and other fields satisfy the constraints required for the specific emote type. Returns a non‑zero value when all checks pass and zero when any condition is violated.
    /// <code>Offset: 0x005CE970
    /// int __thiscall Emote::IsValid(Emote*)</code>
    /// </summary>
    /// <returns>A non‑zero integer indicates the emote is valid; zero means invalid.</returns>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, int>)0x005CE970)(ref this);

    /// <summary>Initializes an Emote instance by setting identity orientation, zero position, default values for all numeric fields, and preparing string buffers with a null buffer reference count.
    /// <code>Offset: 0x005CED20
    /// void __thiscall Emote::Emote(Emote*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void>)0x005CED20)(ref this);

    /// <summary>Destroys an Emote object, decrementing reference counts on its message and test strings and freeing the buffers when unreferenced. Resets internal virtual tables to base class defaults.
    /// <code>Offset: 0x005CEE30
    /// void __thiscall Emote::~Emote(Emote*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void>)0x005CEE30)(ref this);

    /// <summary>
    /// Determines the size, in bytes, required to pack an Emote object into a network packet based on its type and associated data such as strings, frames, positions, or sub‑objects.
    /// 
    /// <code>Offset: 0x005CF060
    /// unsigned int __thiscall Emote::pack_size(Emote*)</code>
    /// </summary>
    /// <returns>The total number of bytes needed to serialize this Emote.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, uint>)0x005CF060)(ref this);

    /// <summary>Serializes an Emote into a buffer, writing type, delay, extent and fields specific to the emote’s subtype. If the provided buffer is too small, no data is written and the function returns the required size.
    /// <code>Offset: 0x005CF310
    /// unsigned int __thiscall Emote::Pack(Emote*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; will be advanced past the packed data.</param>
    /// <param name="size">Number of bytes available in the buffer starting at *addr.</param>
    /// <returns>The number of bytes that would be written (the emote’s serialized size).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void**, uint, uint>)0x005CF310)(ref this, addr, size);

    /// <summary>Initializes a new Emote instance by copying the contents of another Emote while resetting default values such as frame, position and string buffers.
    /// <code>Offset: 0x005CF850
    /// void __thiscall Emote::Emote(Emote*,const Emote*)</code>
    /// </summary>
    /// <param name="rhs">The source Emote from which to copy data.</param>
    public void _ConstructorInternal(ACBindings.Internal.Emote* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, ACBindings.Internal.Emote*, void>)0x005CF850)(ref this, rhs);

    /// <summary>Deserializes an Emote object from a binary buffer based on its type field, advancing the buffer pointer as data is consumed.
    /// <code>Offset: 0x005CF900
    /// int __thiscall Emote::UnPack(Emote*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; will be updated to point past the processed bytes.</param>
    /// <param name="size">Number of bytes remaining in the buffer; used to guard against reading beyond the available data.</param>
    /// <returns>Non‑zero if the emote was successfully unpacked and validated via Emote::IsValid, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void**, uint, int>)0x005CF900)(ref this, addr, size);
}

