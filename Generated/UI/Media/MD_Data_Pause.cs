namespace ACBindings.Internal;

public unsafe struct MD_Data_Pause
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Pause_vtbl
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
    public float m_minDuration;
    public float m_maxDuration;
    public double m_endTime;

    // Generated Constructor
    public MD_Data_Pause(ACBindings.Internal.MD_Data_Pause* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0069F550
    /// void __thiscall MD_Data_Pause::MD_Data_Pause(MD_Data_Pause*,const MD_Data_Pause*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Pause* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.MD_Data_Pause*, void>)0x0069F550)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0069F5A0
    /// void __thiscall MD_Data_Pause::Serialize(MD_Data_State*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.Archive*, void>)0x0069F5A0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0069F610
    /// bool __thiscall MD_Data_Pause::ToFileNode(MD_Data_Pause*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.PFileNode*, byte>)0x0069F610)(ref this, file_node);

    /// <summary>
    /// <code>Offset: 0x0069F6B0
    /// bool __thiscall MD_Data_Pause::FromFileNode(MD_Data_Pause*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.PFileNode*, byte>)0x0069F6B0)(ref this, file_node);
}

