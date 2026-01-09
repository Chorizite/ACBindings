namespace ACBindings;

// EmoteSet
public unsafe struct EmoteSet : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // EmoteSet_vtbl
    public unsafe struct EmoteSet_vtbl
    {
        // Members
        public System.IntPtr EmoteSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint category;
    public float probability;
    public ACBindings.IDClass___tagDataID classID;
    public ACBindings.AC1Legacy.PStringBase__sbyte quest;
    public uint style;
    public uint substyle;
    public uint vendorType;
    public float minhealth;
    public float maxhealth;
    public ACBindings.PackableList__Emote emotes;

    // Generated Constructor
    public EmoteSet() {
        _ConstructorInternal();
    }
    public EmoteSet(ACBindings.EmoteSet* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall EmoteSet::pack_size(EmoteSet*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EmoteSet, uint>)0x00597300)(ref this);
    // unsigned int __thiscall EmoteSet::Pack(EmoteSet*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EmoteSet, void**, uint, uint>)0x005973A0)(ref this, addr, size);
    // int __thiscall EmoteSet::UnPack(EmoteSet*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EmoteSet, void**, uint, int>)0x00597520)(ref this, addr, size);
    // void __thiscall EmoteSet::EmoteSet(EmoteSet*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EmoteSet, void>)0x00597750)(ref this);
    // void __thiscall EmoteSet::~EmoteSet(EmoteSet*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EmoteSet, void>)0x005977C0)(ref this);
    // void __thiscall EmoteSet::EmoteSet(EmoteSet*,const EmoteSet*)
    public void _ConstructorInternal(ACBindings.EmoteSet* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EmoteSet, ACBindings.EmoteSet*, void>)0x00597900)(ref this, rhs);
}

