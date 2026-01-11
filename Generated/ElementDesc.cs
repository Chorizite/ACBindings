namespace ACBindings.Internal;

public unsafe struct ElementDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.StateDesc BaseClass_StateDesc; // ACBindings.Internal.StateDesc

    // Child Types
    public unsafe struct ElementDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, void> ElementDesc_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> PositionToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte*, byte> HandleNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.PFileNode*, byte> CheckFFN; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void> UpdateSizeAndPosition; // function pointer

        // Methods
    }

    // Members
    public uint m_elementID;
    public uint m_type;
    public uint m_engineType;
    public uint m_baseElement;
    public ACBindings.Internal.IDClass____tagDataID m_baseLayout;
    public uint m_defaultState;
    public uint m_leftEdge;
    public uint m_topEdge;
    public uint m_rightEdge;
    public uint m_bottomEdge;
    public ACBindings.Internal.HashTable__uint___StateDesc m_states;
    public ACBindings.Internal.HashTable__uint___ElementDesc m_children;
    public uint m_uiReadOrder;
    public ACBindings.Internal.PStringBase__sbyte m_strComments;
    public ACBindings.Internal.PStringBase__sbyte m_strName;

    // Generated Constructor
    public ElementDesc() {
        _ConstructorInternal();
    }
    public ElementDesc(ACBindings.Internal.ElementDesc* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0069B6A0
    /// void __thiscall ElementDesc::UpdateSizeAndPosition(ElementDesc*,const Box2D*,const Box2D*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void UpdateSizeAndPosition(ACBindings.Internal.Box2D* oldParent, ACBindings.Internal.Box2D* newParent, uint leftEdge, uint topEdge, uint rightEdge, uint bottomEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void>)0x0069B6A0)(ref this, oldParent, newParent, leftEdge, topEdge, rightEdge, bottomEdge);

    /// <summary>
    /// <code>Offset: 0x0069B790
    /// void __thiscall ElementDesc::GetSubDataIDs(ElementDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069B790)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x0069B8B0
    /// bool __thiscall ElementDesc::PositionToFileNode(ElementDesc*,PFileNode*)</code>
    /// </summary>
    public byte PositionToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.PFileNode*, byte>)0x0069B8B0)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069BA20
    /// bool __thiscall ElementDesc::CheckFFN(ElementDesc*,const PFileNode*)</code>
    /// </summary>
    public byte CheckFFN(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.PFileNode*, byte>)0x0069BA20)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069BAD0
    /// StateDesc* __thiscall ElementDesc::AccessStateDesc(ElementDesc*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.StateDesc* AccessStateDesc(uint stateID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, uint, ACBindings.Internal.StateDesc*>)0x0069BAD0)(ref this, stateID);

    /// <summary>
    /// <code>Offset: 0x0069C0C0
    /// void __thiscall ElementDesc::~ElementDesc(ElementDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, void>)0x0069C0C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069C1A0
    /// void __thiscall ElementDesc::ElementDesc(ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, void>)0x0069C1A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069C3B0
    /// void __thiscall ElementDesc::ElementDesc(ElementDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ElementDesc* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.ElementDesc*, void>)0x0069C3B0)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0069C430
    /// bool __thiscall ElementDesc::Incorporate(ElementDesc*,const ElementDesc*)</code>
    /// </summary>
    public byte Incorporate(ACBindings.Internal.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.ElementDesc*, byte>)0x0069C430)(ref this, desc);

    /// <summary>
    /// <code>Offset: 0x0069CA30
    /// void __thiscall ElementDesc::Serialize(ElementDesc*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ElementDesc, ACBindings.Internal.Archive*, void>)0x0069CA30)(ref this, io_archive);
}

