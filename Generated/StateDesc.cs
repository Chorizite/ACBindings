namespace ACBindings;

// StateDesc
public unsafe struct StateDesc : System.IDisposable
{
    // Child Types
    // StateDesc_vtbl
    public unsafe struct StateDesc_vtbl
    {
        // Members
        public System.IntPtr StateDesc_dtor_0; // function pointer
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
    public ACBindings.PropertyCollection m_properties;
    public ACBindings.SmartArray__MediaDesc_ptr m_media;

    // Generated Constructor
    public StateDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall StateDesc::GetSubDataIDs(StateDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.QualifiedDataIDArray*, void>)0x0069CD60)(ref this, id_array);
    // void __thiscall StateDesc::UpdateSizeAndPosition(StateDesc*,const Box2D*,const Box2D*,unsigned int,unsigned int,unsigned int,unsigned int)
    public void UpdateSizeAndPosition(ACBindings.Box2D* oldParent, ACBindings.Box2D* newParent, uint leftEdge, uint topEdge, uint rightEdge, uint bottomEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.Box2D*, ACBindings.Box2D*, uint, uint, uint, uint, void>)0x0069CDB0)(ref this, oldParent, newParent, leftEdge, topEdge, rightEdge, bottomEdge);
    // void __thiscall StateDesc::StateDesc(StateDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, void>)0x0069D010)(ref this);
    // bool __thiscall StateDesc::PositionToFileNode(StateDesc*,PFileNode*)
    public byte PositionToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.PFileNode*, byte>)0x0069D060)(ref this, file_node);
    // void __thiscall StateDesc::CleanupMedia(StateDesc*)
    public void CleanupMedia() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, void>)0x0069D070)(ref this);
    // void __thiscall StateDesc::~StateDesc(StateDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, void>)0x0069D120)(ref this);
    // bool __thiscall StateDesc::ToFileNode(StateDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.PFileNode*, byte>)0x0069D160)(ref this, file_node);
    // bool __thiscall StateDesc::CheckFFN(StateDesc*,const PFileNode*)
    public byte CheckFFN(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.PFileNode*, byte>)0x0069D2D0)(ref this, file_node);
    // void __thiscall StateDesc::Serialize(StateDesc*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.Archive*, void>)0x0069D480)(ref this, io_archive);
    // bool __thiscall StateDesc::FromFileNode(StateDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.PFileNode*, byte>)0x0069D640)(ref this, file_node);
    // bool __thiscall StateDesc::LoadMedia(StateDesc*,const PFileNode*)
    public byte LoadMedia(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.PFileNode*, byte>)0x0069D7E0)(ref this, node);
    // void __thiscall StateDesc::ConcatenateMedia(StateDesc*,const StateDesc*)
    public void ConcatenateMedia(ACBindings.StateDesc* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.StateDesc*, void>)0x0069D840)(ref this, rhs);
    // bool __thiscall StateDesc::ContainsProperty(StateDesc*,const unsigned int)
    public byte ContainsProperty(uint property) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, uint, byte>)0x0069D8D0)(ref this, property);
    // void __thiscall StateDesc::SetMediaImage(_DWORD*,int,int)
    public void SetMediaImage(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, int, int, void>)0x0069D8E0)(ref this, a2, a3);
    // bool __thiscall StateDesc::HandleNode(StateDesc*,const PFileNode*,bool*)
    public byte HandleNode(ACBindings.PFileNode* node, byte* handled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.PFileNode*, byte*, byte>)0x0069D990)(ref this, node, handled);
    // bool __thiscall StateDesc::Incorporate(StateDesc*,const StateDesc*)
    public byte Incorporate(ACBindings.StateDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StateDesc, ACBindings.StateDesc*, byte>)0x0069DB30)(ref this, desc);
}

