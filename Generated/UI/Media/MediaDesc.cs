namespace ACBindings;

// MediaDesc
public unsafe struct MediaDesc : System.IDisposable
{
    // Child Types
    // MediaDesc_vtbl
    public unsafe struct MediaDesc_vtbl
    {
        // Members
        public System.IntPtr MediaDesc_dtor_0; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr DynamicCast_Anim; // function pointer
        public System.IntPtr DynamicCast_Image; // function pointer
        public System.IntPtr DynamicCast_Alpha; // function pointer
        public System.IntPtr DynamicCast_Pause; // function pointer
        public System.IntPtr DynamicCast_Jump; // function pointer
        public System.IntPtr DynamicCast_Message; // function pointer
        public System.IntPtr DynamicCast_Sound; // function pointer
        public System.IntPtr DynamicCast_State; // function pointer
        public System.IntPtr DynamicCast_Movie; // function pointer
        public System.IntPtr DynamicCast_Cursor; // function pointer
        public System.IntPtr DynamicCast_Fade; // function pointer
        public System.IntPtr GetDuration; // function pointer
        public System.IntPtr ToFileNode; // function pointer
        public System.IntPtr FromFileNode; // function pointer

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
    // void __thiscall MediaDesc::MediaDesc(MediaDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaDesc, void>)0x0069E1D0)(ref this);
    // void __thiscall MediaDesc::~MediaDesc(MediaDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaDesc, void>)0x0069E200)(ref this);
    // MediaDesc* __cdecl MediaDesc::CreateMediaType(unsigned int)
    public static ACBindings.MediaDesc* CreateMediaType(uint type) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.MediaDesc*>)0x0069E230)(type);
    // MediaDesc* __cdecl MediaDesc::CreateMediaType(const MediaDesc*)
    public static ACBindings.MediaDesc* CreateMediaType(ACBindings.MediaDesc* rhs) => ((delegate* unmanaged[Cdecl]<ACBindings.MediaDesc*, ACBindings.MediaDesc*>)0x0069E380)(rhs);
    // void __thiscall MediaDesc::Serialize(MediaDesc*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaDesc, ACBindings.Archive*, void>)0x0069E510)(ref this, io_archive);
    // bool __thiscall MediaDesc::ToFileNode(MediaDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MediaDesc, ACBindings.PFileNode*, byte>)0x0069E550)(ref this, file_node);
    // MediaDesc* __cdecl MediaDesc::CreateFromFileNode(const PFileNode*)
    public static ACBindings.MediaDesc* CreateFromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Cdecl]<ACBindings.PFileNode*, ACBindings.MediaDesc*>)0x0069E5F0)(file_node);
}

