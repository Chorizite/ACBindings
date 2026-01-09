namespace ACBindings;

// QuestDef
public unsafe struct QuestDef : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // QuestDef_vtbl
    public unsafe struct QuestDef_vtbl
    {
        // Members
        public System.IntPtr QuestDef_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _fullname;
    public int _mindelta;
    public int _maxsolves;

    // Generated Constructor
    public QuestDef(ACBindings.QuestDef* that) {
        _ConstructorInternal(that);
    }
    public QuestDef() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall QuestDef::~QuestDef(QuestDef*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDef, void>)0x0059A280)(ref this);
    // void __thiscall QuestDef::QuestDef(QuestDef*,const QuestDef*)
    public void _ConstructorInternal(ACBindings.QuestDef* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDef, ACBindings.QuestDef*, void>)0x0059A6C0)(ref this, that);
    // unsigned int __thiscall QuestDef::Pack(QuestDef*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDef, void**, uint, uint>)0x005D3740)(ref this, addr, size);
    // void __thiscall QuestDef::QuestDef(QuestDef*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDef, void>)0x005D37A0)(ref this);
    // int __thiscall QuestDef::UnPack(QuestDef*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDef, void**, uint, int>)0x005D3810)(ref this, addr, size);
}

