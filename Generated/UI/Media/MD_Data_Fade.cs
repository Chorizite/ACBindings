namespace ACBindings;

// MD_Data_Fade
public unsafe struct MD_Data_Fade
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Fade_vtbl
    public unsafe struct MD_Data_Fade_vtbl
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
    public float m_startAlpha;
    public float m_endAlpha;
    public float m_duration;
    public double m_startTime;

    // Generated Constructor
    public MD_Data_Fade(ACBindings.MD_Data_Fade* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // float __thiscall MD_Data_Fade::GetDuration(AnimSequenceNode*)
    public float GetDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Fade, float>)0x0069EDA0)(ref this);
    // void __thiscall MD_Data_Fade::MD_Data_Fade(MD_Data_Fade*,const MD_Data_Fade*)
    public void _ConstructorInternal(ACBindings.MD_Data_Fade* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Fade, ACBindings.MD_Data_Fade*, void>)0x0069EDB0)(ref this, rhs);
    // bool __thiscall MD_Data_Fade::ToFileNode(MD_Data_Fade*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Fade, ACBindings.PFileNode*, byte>)0x0069EEA0)(ref this, file_node);
    // bool __thiscall MD_Data_Fade::FromFileNode(MD_Data_Fade*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Fade, ACBindings.PFileNode*, byte>)0x0069EF80)(ref this, file_node);
}

