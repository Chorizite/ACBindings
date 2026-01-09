namespace ACBindings;

// Emote
public unsafe struct Emote : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Emote_vtbl
    public unsafe struct Emote_vtbl
    {
        // Members
        public System.IntPtr Emote_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    public ACBindings.PScriptType pscript;
    public ACBindings.SoundType sound;
    public ACBindings.CreationProfile cprof;
    public ACBindings.Frame frame;
    public uint spellid;
    public ACBindings.AC1Legacy.PStringBase__sbyte teststring;
    public ACBindings.AC1Legacy.PStringBase__sbyte msg;
    public double percent;
    public int display;
    public uint wealth_rating;
    public uint treasure_class;
    public int treasure_type;
    public ACBindings.Position mPosition;

    // Generated Constructor
    public Emote() {
        _ConstructorInternal();
    }
    public Emote(ACBindings.Emote* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall Emote::IsValid(Emote*)
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Emote, int>)0x005CE970)(ref this);
    // void __thiscall Emote::Emote(Emote*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Emote, void>)0x005CED20)(ref this);
    // void __thiscall Emote::~Emote(Emote*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Emote, void>)0x005CEE30)(ref this);
    // unsigned int __thiscall Emote::pack_size(Emote*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Emote, uint>)0x005CF060)(ref this);
    // unsigned int __thiscall Emote::Pack(Emote*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Emote, void**, uint, uint>)0x005CF310)(ref this, addr, size);
    // void __thiscall Emote::Emote(Emote*,const Emote*)
    public void _ConstructorInternal(ACBindings.Emote* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Emote, ACBindings.Emote*, void>)0x005CF850)(ref this, rhs);
    // int __thiscall Emote::UnPack(Emote*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Emote, void**, uint, int>)0x005CF900)(ref this, addr, size);
}

