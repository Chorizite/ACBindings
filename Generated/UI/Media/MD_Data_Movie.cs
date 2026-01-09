namespace ACBindings;

// MD_Data_Movie
public unsafe struct MD_Data_Movie
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Movie_vtbl
    public unsafe struct MD_Data_Movie_vtbl
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
    public ACBindings.PStringBase__sbyte m_strFileName;
    public byte m_StretchToFullScreen;
    public ACBindings.MovieTheatre* m_pMovieTheatre;

    // Generated Constructor
    public MD_Data_Movie(ACBindings.MD_Data_Movie* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall MD_Data_Movie::MD_Data_Movie(MD_Data_Movie*,const MD_Data_Movie*)
    public void _ConstructorInternal(ACBindings.MD_Data_Movie* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Movie, ACBindings.MD_Data_Movie*, void>)0x0069DE10)(ref this, rhs);
    // void __thiscall MD_Data_Movie::Serialize(MD_Data_Movie*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Movie, ACBindings.Archive*, void>)0x0069DEC0)(ref this, io_archive);
    // bool __thiscall MD_Data_Movie::ToFileNode(MD_Data_Movie*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Movie, ACBindings.PFileNode*, byte>)0x0069DEF0)(ref this, file_node);
    // bool __thiscall MD_Data_Movie::FromFileNode(MD_Data_Movie*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Movie, ACBindings.PFileNode*, byte>)0x0069DFA0)(ref this, file_node);
}

