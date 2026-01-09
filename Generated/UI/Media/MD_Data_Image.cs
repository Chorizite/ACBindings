namespace ACBindings;

// MD_Data_Image
public unsafe struct MD_Data_Image
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Image_vtbl
    public unsafe struct MD_Data_Image_vtbl
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
    public uint m_drawMode;

    // Generated Constructor
    public MD_Data_Image() {
        _ConstructorInternal();
    }
    public MD_Data_Image(ACBindings.MD_Data_Image* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall MD_Data_Image::MD_Data_Image(MD_Data_Image*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Image, void>)0x0069DC60)(ref this);
    // void __thiscall MD_Data_Image::MD_Data_Image(MD_Data_Image*,const MD_Data_Image*)
    public void _ConstructorInternal(ACBindings.MD_Data_Image* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Image, ACBindings.MD_Data_Image*, void>)0x0069DC90)(ref this, rhs);
}

