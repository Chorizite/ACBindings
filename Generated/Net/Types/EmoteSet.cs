namespace ACBindings.Internal;

public unsafe struct EmoteSet : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct EmoteSet_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, void> EmoteSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EmoteSet*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint category;
    public float probability;
    public ACBindings.Internal.IDClass____tagDataID classID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte quest;
    public uint style;
    public uint substyle;
    public uint vendorType;
    public float minhealth;
    public float maxhealth;
    public ACBindings.Internal.PackableList___Emote emotes;

    // Generated Constructor
    public EmoteSet() {
        _ConstructorInternal();
    }
    public EmoteSet(ACBindings.Internal.EmoteSet* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00597300
    /// unsigned int __thiscall EmoteSet::pack_size(EmoteSet*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, uint>)0x00597300)(ref this);

    /// <summary>
    /// <code>Offset: 0x005973A0
    /// unsigned int __thiscall EmoteSet::Pack(EmoteSet*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void**, uint, uint>)0x005973A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00597520
    /// int __thiscall EmoteSet::UnPack(EmoteSet*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void**, uint, int>)0x00597520)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00597750
    /// void __thiscall EmoteSet::EmoteSet(EmoteSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void>)0x00597750)(ref this);

    /// <summary>
    /// <code>Offset: 0x005977C0
    /// void __thiscall EmoteSet::~EmoteSet(EmoteSet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, void>)0x005977C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00597900
    /// void __thiscall EmoteSet::EmoteSet(EmoteSet*,const EmoteSet*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.EmoteSet* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EmoteSet, ACBindings.Internal.EmoteSet*, void>)0x00597900)(ref this, rhs);
}

