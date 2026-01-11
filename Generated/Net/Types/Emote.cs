namespace ACBindings.Internal;

public unsafe struct Emote : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Emote_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, void> Emote_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Emote*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005CE970
    /// int __thiscall Emote::IsValid(Emote*)</code>
    /// </summary>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, int>)0x005CE970)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CED20
    /// void __thiscall Emote::Emote(Emote*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void>)0x005CED20)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CEE30
    /// void __thiscall Emote::~Emote(Emote*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void>)0x005CEE30)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CF060
    /// unsigned int __thiscall Emote::pack_size(Emote*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, uint>)0x005CF060)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CF310
    /// unsigned int __thiscall Emote::Pack(Emote*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void**, uint, uint>)0x005CF310)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CF850
    /// void __thiscall Emote::Emote(Emote*,const Emote*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Emote* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, ACBindings.Internal.Emote*, void>)0x005CF850)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005CF900
    /// int __thiscall Emote::UnPack(Emote*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Emote, void**, uint, int>)0x005CF900)(ref this, addr, size);
}

