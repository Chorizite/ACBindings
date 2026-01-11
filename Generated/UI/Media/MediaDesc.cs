namespace ACBindings.Internal;

public unsafe struct MediaDesc : System.IDisposable
{
    // Child Types
    public unsafe struct MediaDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, void> MediaDesc_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Anim*> DynamicCast_Anim; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Image*> DynamicCast_Image; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Alpha*> DynamicCast_Alpha; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Pause*> DynamicCast_Pause; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Jump*> DynamicCast_Jump; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Message*> DynamicCast_Message; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Sound*> DynamicCast_Sound; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_State*> DynamicCast_State; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Movie*> DynamicCast_Movie; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Cursor*> DynamicCast_Cursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Fade*> DynamicCast_Fade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, float> GetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_type;

    // Generated Constructor
    public MediaDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0069E1D0
    /// void __thiscall MediaDesc::MediaDesc(MediaDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, void>)0x0069E1D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069E200
    /// void __thiscall MediaDesc::~MediaDesc(MediaDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, void>)0x0069E200)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069E230
    /// MediaDesc* __cdecl MediaDesc::CreateMediaType(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.MediaDesc* CreateMediaType(uint type) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.MediaDesc*>)0x0069E230)(type);

    /// <summary>
    /// <code>Offset: 0x0069E380
    /// MediaDesc* __cdecl MediaDesc::CreateMediaType(const MediaDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.MediaDesc* CreateMediaType(ACBindings.Internal.MediaDesc* rhs) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MediaDesc*>)0x0069E380)(rhs);

    /// <summary>
    /// <code>Offset: 0x0069E510
    /// void __thiscall MediaDesc::Serialize(MediaDesc*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, ACBindings.Internal.Archive*, void>)0x0069E510)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0069E550
    /// bool __thiscall MediaDesc::ToFileNode(MediaDesc*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MediaDesc, ACBindings.Internal.PFileNode*, byte>)0x0069E550)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069E5F0
    /// MediaDesc* __cdecl MediaDesc::CreateFromFileNode(const PFileNode*)</code>
    /// </summary>
    public static ACBindings.Internal.MediaDesc* CreateFromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PFileNode*, ACBindings.Internal.MediaDesc*>)0x0069E5F0)(file_node);
}

