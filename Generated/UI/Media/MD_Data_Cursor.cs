namespace ACBindings;

// MD_Data_Cursor
public unsafe struct MD_Data_Cursor
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Cursor_vtbl
    public unsafe struct MD_Data_Cursor_vtbl
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
    public int m_xHotspot;
    public int m_yHotspot;

    // Generated Constructor
    public MD_Data_Cursor(ACBindings.MD_Data_Cursor* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall MD_Data_Cursor::MD_Data_Cursor(MD_Data_Cursor*,const MD_Data_Cursor*)
    public void _ConstructorInternal(ACBindings.MD_Data_Cursor* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Cursor, ACBindings.MD_Data_Cursor*, void>)0x0069E6E0)(ref this, rhs);
    // void __thiscall MD_Data_Cursor::Serialize(MD_Data_Fade*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Cursor, ACBindings.Archive*, void>)0x0069EE10)(ref this, io_archive);
}

