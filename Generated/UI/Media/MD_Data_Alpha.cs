namespace ACBindings;

// MD_Data_Alpha
public unsafe struct MD_Data_Alpha
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Alpha_vtbl
    public unsafe struct MD_Data_Alpha_vtbl
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
    public ACBindings.IDClass___tagDataID m_file;

    // Generated Constructor
    public MD_Data_Alpha(ACBindings.MD_Data_Alpha* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall MD_Data_Alpha::MD_Data_Alpha(MD_Data_Alpha*,const MD_Data_Alpha*)
    public void _ConstructorInternal(ACBindings.MD_Data_Alpha* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Alpha, ACBindings.MD_Data_Alpha*, void>)0x0069F8B0)(ref this, rhs);
    // void __thiscall MD_Data_Alpha::Serialize(MD_Data_Alpha*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Alpha, ACBindings.Archive*, void>)0x0069F8F0)(ref this, io_archive);
    // void __thiscall MD_Data_Alpha::GetSubDataIDs(MD_Data_Sound*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Alpha, ACBindings.QualifiedDataIDArray*, void>)0x0069F930)(ref this, id_array);
}

