namespace ACBindings;

// ElementDesc
public unsafe struct ElementDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.StateDesc BaseClass_StateDesc; // ACBindings.StateDesc

    // Child Types
    // ElementDesc_vtbl
    public unsafe struct ElementDesc_vtbl
    {
        // Members
        public System.IntPtr ElementDesc_dtor_0; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr ToFileNode; // function pointer
        public System.IntPtr FromFileNode; // function pointer
        public System.IntPtr PositionToFileNode; // function pointer
        public System.IntPtr HandleNode; // function pointer
        public System.IntPtr CheckFFN; // function pointer
        public System.IntPtr UpdateSizeAndPosition; // function pointer

        // Methods
    }

    // Members
    public uint m_elementID;
    public uint m_type;
    public uint m_engineType;
    public uint m_baseElement;
    public ACBindings.IDClass___tagDataID m_baseLayout;
    public uint m_defaultState;
    public uint m_leftEdge;
    public uint m_topEdge;
    public uint m_rightEdge;
    public uint m_bottomEdge;
    public ACBindings.HashTable__uint__StateDesc m_states;
    public ACBindings.HashTable__uint__ElementDesc m_children;
    public uint m_uiReadOrder;
    public ACBindings.PStringBase__sbyte m_strComments;
    public ACBindings.PStringBase__sbyte m_strName;

    // Generated Constructor
    public ElementDesc() {
        _ConstructorInternal();
    }
    public ElementDesc(ACBindings.ElementDesc* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ElementDesc::UpdateSizeAndPosition(ElementDesc*,const Box2D*,const Box2D*,unsigned int,unsigned int,unsigned int,unsigned int)
    public void UpdateSizeAndPosition(ACBindings.Box2D* oldParent, ACBindings.Box2D* newParent, uint leftEdge, uint topEdge, uint rightEdge, uint bottomEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, ACBindings.Box2D*, ACBindings.Box2D*, uint, uint, uint, uint, void>)0x0069B6A0)(ref this, oldParent, newParent, leftEdge, topEdge, rightEdge, bottomEdge);
    // void __thiscall ElementDesc::GetSubDataIDs(ElementDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, ACBindings.QualifiedDataIDArray*, void>)0x0069B790)(ref this, id_array);
    // bool __thiscall ElementDesc::PositionToFileNode(ElementDesc*,PFileNode*)
    public byte PositionToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, ACBindings.PFileNode*, byte>)0x0069B8B0)(ref this, file_node);
    // bool __thiscall ElementDesc::CheckFFN(ElementDesc*,const PFileNode*)
    public byte CheckFFN(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, ACBindings.PFileNode*, byte>)0x0069BA20)(ref this, file_node);
    // StateDesc* __thiscall ElementDesc::AccessStateDesc(ElementDesc*,unsigned int)
    public ACBindings.StateDesc* AccessStateDesc(uint stateID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, uint, ACBindings.StateDesc*>)0x0069BAD0)(ref this, stateID);
    // void __thiscall ElementDesc::~ElementDesc(ElementDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, void>)0x0069C0C0)(ref this);
    // void __thiscall ElementDesc::ElementDesc(ElementDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, void>)0x0069C1A0)(ref this);
    // void __thiscall ElementDesc::ElementDesc(ElementDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.ElementDesc* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, ACBindings.ElementDesc*, void>)0x0069C3B0)(ref this, rhs);
    // bool __thiscall ElementDesc::Incorporate(ElementDesc*,const ElementDesc*)
    public byte Incorporate(ACBindings.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, ACBindings.ElementDesc*, byte>)0x0069C430)(ref this, desc);
    // void __thiscall ElementDesc::Serialize(ElementDesc*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ElementDesc, ACBindings.Archive*, void>)0x0069CA30)(ref this, io_archive);
}

