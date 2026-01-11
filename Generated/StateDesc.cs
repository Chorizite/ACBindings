namespace ACBindings.Internal;

public unsafe struct StateDesc : System.IDisposable
{
    // Child Types
    public unsafe struct StateDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, void> StateDesc_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> PositionToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte*, byte> HandleNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.PFileNode*, byte> CheckFFN; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.StateDesc*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void> UpdateSizeAndPosition; // function pointer

        // Methods
    }
    // StateDesc::INCORPORATIONFLAGS
    public enum INCORPORATIONFLAGS : byte
    {
        IF_PASSTOCHILDREN = 0x1,
        IF_X = 0x2,
        IF_Y = 0x4,
        IF_WIDTH = 0x8,
        IF_HEIGHT = 0x10,
        IF_ZLEVEL = 0x20
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_uiIncorporationFlags;
    public uint m_stateID;
    public byte m_bIsCode;
    public byte m_bPassToChildren;
    public int m_x;
    public int m_y;
    public int m_width;
    public int m_height;
    public int m_zLevel;
    public ACBindings.Internal.PropertyCollection m_properties;
    public ACBindings.Internal.SmartArray___MediaDesc_ptr m_media;

    // Generated Constructor
    public StateDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0069CD60
    /// void __thiscall StateDesc::GetSubDataIDs(StateDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069CD60)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x0069CDB0
    /// void __thiscall StateDesc::UpdateSizeAndPosition(StateDesc*,const Box2D*,const Box2D*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void UpdateSizeAndPosition(ACBindings.Internal.Box2D* oldParent, ACBindings.Internal.Box2D* newParent, uint leftEdge, uint topEdge, uint rightEdge, uint bottomEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, uint, uint, uint, uint, void>)0x0069CDB0)(ref this, oldParent, newParent, leftEdge, topEdge, rightEdge, bottomEdge);

    /// <summary>
    /// <code>Offset: 0x0069D010
    /// void __thiscall StateDesc::StateDesc(StateDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, void>)0x0069D010)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069D060
    /// bool __thiscall StateDesc::PositionToFileNode(StateDesc*,PFileNode*)</code>
    /// </summary>
    public byte PositionToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D060)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069D070
    /// void __thiscall StateDesc::CleanupMedia(StateDesc*)</code>
    /// </summary>
    public void CleanupMedia() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, void>)0x0069D070)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069D120
    /// void __thiscall StateDesc::~StateDesc(StateDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, void>)0x0069D120)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069D160
    /// bool __thiscall StateDesc::ToFileNode(StateDesc*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D160)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069D2D0
    /// bool __thiscall StateDesc::CheckFFN(StateDesc*,const PFileNode*)</code>
    /// </summary>
    public byte CheckFFN(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D2D0)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069D480
    /// void __thiscall StateDesc::Serialize(StateDesc*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.Archive*, void>)0x0069D480)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0069D640
    /// bool __thiscall StateDesc::FromFileNode(StateDesc*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D640)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069D7E0
    /// bool __thiscall StateDesc::LoadMedia(StateDesc*,const PFileNode*)</code>
    /// </summary>
    public byte LoadMedia(ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte>)0x0069D7E0)(ref this, node);

    /// <summary>
    /// <code>Offset: 0x0069D840
    /// void __thiscall StateDesc::ConcatenateMedia(StateDesc*,const StateDesc*)</code>
    /// </summary>
    public void ConcatenateMedia(ACBindings.Internal.StateDesc* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.StateDesc*, void>)0x0069D840)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0069D8D0
    /// bool __thiscall StateDesc::ContainsProperty(StateDesc*,const unsigned int)</code>
    /// </summary>
    public byte ContainsProperty(uint property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, uint, byte>)0x0069D8D0)(ref this, property);

    /// <summary>
    /// <code>Offset: 0x0069D8E0
    /// void __thiscall StateDesc::SetMediaImage(_DWORD*,int,int)</code>
    /// </summary>
    public void SetMediaImage(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, int, int, void>)0x0069D8E0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0069D990
    /// bool __thiscall StateDesc::HandleNode(StateDesc*,const PFileNode*,bool*)</code>
    /// </summary>
    public byte HandleNode(ACBindings.Internal.PFileNode* node, byte* handled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.PFileNode*, byte*, byte>)0x0069D990)(ref this, node, handled);

    /// <summary>
    /// <code>Offset: 0x0069DB30
    /// bool __thiscall StateDesc::Incorporate(StateDesc*,const StateDesc*)</code>
    /// </summary>
    public byte Incorporate(ACBindings.Internal.StateDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StateDesc, ACBindings.Internal.StateDesc*, byte>)0x0069DB30)(ref this, desc);
}

