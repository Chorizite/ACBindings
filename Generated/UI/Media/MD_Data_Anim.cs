namespace ACBindings;

// MD_Data_Anim
public unsafe struct MD_Data_Anim
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Anim_vtbl
    public unsafe struct MD_Data_Anim_vtbl
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
    public float m_duration;
    public uint m_drawMode;
    public ACBindings.SmartArray__IDClass___tagDataID m_frames;
    public double m_StartTime;
    public int m_displayedFrameNum;

    // Generated Constructor
    public MD_Data_Anim(ACBindings.MD_Data_Anim* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall MD_Data_Anim::GetSubDataIDs(MD_Data_Anim*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Anim, ACBindings.QualifiedDataIDArray*, void>)0x0069F970)(ref this, id_array);
    // float __thiscall MD_Data_Anim::GetDuration(MD_Data_Anim*)
    public float GetDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Anim, float>)0x0069F9F0)(ref this);
    // void __thiscall MD_Data_Anim::MD_Data_Anim(MD_Data_Anim*,const MD_Data_Anim*)
    public void _ConstructorInternal(ACBindings.MD_Data_Anim* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Anim, ACBindings.MD_Data_Anim*, void>)0x0069FAE0)(ref this, rhs);
    // void __thiscall MD_Data_Anim::Serialize(MD_Data_Anim*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Anim, ACBindings.Archive*, void>)0x0069FB50)(ref this, io_archive);
}

