namespace ACBindings.Internal;


/// <summary>Defines pause metadata for media playback, including minimum and maximum durations and the timestamp marking its conclusion.</summary>
public unsafe struct MD_Data_Pause
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Pause_vtbl
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
    public float m_minDuration;
    public float m_maxDuration;
    public double m_endTime;

    // Generated Constructor
    public MD_Data_Pause(ACBindings.Internal.MD_Data_Pause* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Initializes a new MD_Data_Pause object with default duration limits and end time, optionally copying these values from an existing instance when supplied.
    /// <code>Offset: 0x0069F550
    /// void __thiscall MD_Data_Pause::MD_Data_Pause(MD_Data_Pause*,const MD_Data_Pause*)</code>
    /// </summary>
    /// <param name="rhs">The source MD_Data_Pause to copy values from; if it differs from the current instance, its durations are duplicated.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Pause* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.MD_Data_Pause*, void>)0x0069F550)(ref this, rhs);

    /// <summary>Serializes the pause object's data to or from an archive, including its media description, a 4‑byte state identifier and a 4‑byte probability value.
    /// <code>Offset: 0x0069F5A0
    /// void __thiscall MD_Data_Pause::Serialize(MD_Data_State*,Archive*)</code>
    /// </summary>
    /// <param name="this">The MD_Data_Pause instance whose fields are serialized.</param>
    /// <param name="io_archive">Archive used for reading or writing the serialized data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.Archive*, void>)0x0069F5A0)(ref this, io_archive);

    /// <summary>Writes the pause duration limits into the specified file node as sub‑nodes.
    /// <code>Offset: 0x0069F610
    /// bool __thiscall MD_Data_Pause::ToFileNode(MD_Data_Pause*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The target file node to receive the data.</param>
    /// <returns>True if the base class and all sub‑node creations succeeded; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.PFileNode*, byte>)0x0069F610)(ref this, file_node);

    /// <summary>Parses a pause data block from the given file node, extracting minimum and maximum duration values into the MD_Data_Pause instance.
    /// <code>Offset: 0x0069F6B0
    /// bool __thiscall MD_Data_Pause::FromFileNode(MD_Data_Pause*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The file node containing pause configuration data.</param>
    /// <returns>True if the min and max durations were successfully read; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Pause, ACBindings.Internal.PFileNode*, byte>)0x0069F6B0)(ref this, file_node);
}

