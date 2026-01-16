namespace ACBindings.Internal;


/// <summary>Represents a cursor asset with metadata, file reference, and hotspot positioning.</summary>
public unsafe struct MD_Data_Cursor
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Cursor_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, void> MediaDesc_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Anim*> DynamicCast_Anim; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Image*> DynamicCast_Image; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Alpha*> DynamicCast_Alpha; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Pause*> DynamicCast_Pause; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Jump*> DynamicCast_Jump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Message*> DynamicCast_Message; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Sound*> DynamicCast_Sound; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_State*> DynamicCast_State; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Movie*> DynamicCast_Movie; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Cursor*> DynamicCast_Cursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.MD_Data_Fade*> DynamicCast_Fade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, float> GetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MediaDesc*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer

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

    /// <summary>Initializes a new MD_Data_Cursor by copying the data from another cursor, or by setting default values when the source is identical to the destination.
    /// <code>Offset: 0x0069E6E0
    /// void __thiscall MD_Data_Cursor::MD_Data_Cursor(MD_Data_Cursor*,const MD_Data_Cursor*)</code>
    /// </summary>
    /// <param name="rhs">The cursor whose fields are copied into this instance; if it references this object itself, only default initialization occurs.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Cursor* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Cursor, ACBindings.Internal.MD_Data_Cursor*, void>)0x0069E6E0)(ref this, rhs);

    /// <summary>Serializes the base media description and three float properties (m_startAlpha, m_endAlpha, m_duration) to or from an Archive, handling alignment and read/write based on the archive's flags.
    /// <code>Offset: 0x0069EE10
    /// void __thiscall MD_Data_Cursor::Serialize(MD_Data_Fade*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading or writing data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Cursor, ACBindings.Internal.Archive*, void>)0x0069EE10)(ref this, io_archive);
}

