namespace ACBindings.Internal;

public unsafe struct MD_Data_Cursor
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Cursor_vtbl
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
    public ACBindings.Internal.IDClass____tagDataID m_file;
    public int m_xHotspot;
    public int m_yHotspot;

    // Generated Constructor
    public MD_Data_Cursor(ACBindings.Internal.MD_Data_Cursor* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0069E6E0
    /// void __thiscall MD_Data_Cursor::MD_Data_Cursor(MD_Data_Cursor*,const MD_Data_Cursor*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Cursor* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Cursor, ACBindings.Internal.MD_Data_Cursor*, void>)0x0069E6E0)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0069EE10
    /// void __thiscall MD_Data_Cursor::Serialize(MD_Data_Fade*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Cursor, ACBindings.Internal.Archive*, void>)0x0069EE10)(ref this, io_archive);
}

