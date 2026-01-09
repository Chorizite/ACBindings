namespace ACBindings;

// MD_Data_Sound
public unsafe struct MD_Data_Sound
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Sound_vtbl
    public unsafe struct MD_Data_Sound_vtbl
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
    public ACBindings.SoundType m_stype;

    // Generated Constructor
    public MD_Data_Sound(ACBindings.MD_Data_Sound* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall MD_Data_Sound::MD_Data_Sound(MD_Data_Sound*,const MD_Data_Sound*)
    public void _ConstructorInternal(ACBindings.MD_Data_Sound* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Sound, ACBindings.MD_Data_Sound*, void>)0x0069F450)(ref this, rhs);
    // void __thiscall MD_Data_Sound::Serialize(MD_Data_Sound*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Sound, ACBindings.Archive*, void>)0x0069F4A0)(ref this, io_archive);
}

