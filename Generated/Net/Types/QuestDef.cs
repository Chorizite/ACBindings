namespace ACBindings.Internal;

public unsafe struct QuestDef : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct QuestDef_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, void> QuestDef_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestDef*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _fullname;
    public int _mindelta;
    public int _maxsolves;

    // Generated Constructor
    public QuestDef(ACBindings.Internal.QuestDef* that) {
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

    /// <summary>
    /// <code>Offset: 0x0059A280
    /// void __thiscall QuestDef::~QuestDef(QuestDef*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void>)0x0059A280)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059A6C0
    /// void __thiscall QuestDef::QuestDef(QuestDef*,const QuestDef*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.QuestDef* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, ACBindings.Internal.QuestDef*, void>)0x0059A6C0)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005D3740
    /// unsigned int __thiscall QuestDef::Pack(QuestDef*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void**, uint, uint>)0x005D3740)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D37A0
    /// void __thiscall QuestDef::QuestDef(QuestDef*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void>)0x005D37A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D3810
    /// int __thiscall QuestDef::UnPack(QuestDef*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDef, void**, uint, int>)0x005D3810)(ref this, addr, size);
}

