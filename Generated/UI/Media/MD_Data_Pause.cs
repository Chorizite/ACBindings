namespace ACBindings;

// MD_Data_Pause
public unsafe struct MD_Data_Pause
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Pause_vtbl
    public unsafe struct MD_Data_Pause_vtbl
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
    public float m_minDuration;
    public float m_maxDuration;
    public double m_endTime;

    // Generated Constructor
    public MD_Data_Pause(ACBindings.MD_Data_Pause* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall MD_Data_Pause::MD_Data_Pause(MD_Data_Pause*,const MD_Data_Pause*)
    public void _ConstructorInternal(ACBindings.MD_Data_Pause* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Pause, ACBindings.MD_Data_Pause*, void>)0x0069F550)(ref this, rhs);
    // void __thiscall MD_Data_Pause::Serialize(MD_Data_State*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Pause, ACBindings.Archive*, void>)0x0069F5A0)(ref this, io_archive);
    // bool __thiscall MD_Data_Pause::ToFileNode(MD_Data_Pause*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Pause, ACBindings.PFileNode*, byte>)0x0069F610)(ref this, file_node);
    // bool __thiscall MD_Data_Pause::FromFileNode(MD_Data_Pause*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Pause, ACBindings.PFileNode*, byte>)0x0069F6B0)(ref this, file_node);
}

