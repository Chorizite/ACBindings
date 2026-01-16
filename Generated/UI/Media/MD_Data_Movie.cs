namespace ACBindings.Internal;


/// <summary>Represents data required to initialize and control a movie playback instance, storing the media description, file path, fullscreen stretch option, and link to its theatre object.</summary>
public unsafe struct MD_Data_Movie
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Movie_vtbl
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
    public ACBindings.Internal.PStringBase__sbyte m_strFileName;
    public byte m_StretchToFullScreen;
    public ACBindings.Internal.MovieTheatre* m_pMovieTheatre;

    // Generated Constructor
    public MD_Data_Movie(ACBindings.Internal.MD_Data_Movie* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Initializes a new MD_Data_Movie object by constructing its base MediaDesc, setting default values for the file name, full‑screen stretch flag, and movie theatre pointer, then copying all fields from another instance.
    /// <code>Offset: 0x0069DE10
    /// void __thiscall MD_Data_Movie::MD_Data_Movie(MD_Data_Movie*,const MD_Data_Movie*)</code>
    /// </summary>
    /// <param name="rhs">The source MD_Data_Movie to copy data from during construction.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Movie* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Movie, ACBindings.Internal.MD_Data_Movie*, void>)0x0069DE10)(ref this, rhs);

    /// <summary>Serializes the movie's media description, file path, and stretch‑to‑fullscreen flag to or from the provided archive.
    /// <code>Offset: 0x0069DEC0
    /// void __thiscall MD_Data_Movie::Serialize(MD_Data_Movie*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading from or writing to persistent storage.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Movie, ACBindings.Internal.Archive*, void>)0x0069DEC0)(ref this, io_archive);

    /// <summary>Writes movie metadata into a file node, including the filename and fullscreen stretch flag. Returns true if all subnodes are created successfully.
    /// <code>Offset: 0x0069DEF0
    /// bool __thiscall MD_Data_Movie::ToFileNode(MD_Data_Movie*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The file node to populate with movie information.</param>
    /// <returns>True when the movie data is serialized to the file node; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Movie, ACBindings.Internal.PFileNode*, byte>)0x0069DEF0)(ref this, file_node);

    /// <summary>
    /// Parses a movie configuration from the supplied file node, extracting the filename and optional full‑screen stretch flag while reporting errors for missing or unrecognized keywords.
    /// 
    /// <code>Offset: 0x0069DFA0
    /// bool __thiscall MD_Data_Movie::FromFileNode(MD_Data_Movie*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">Root node containing movie configuration information.</param>
    /// <returns>True if the file node was parsed successfully; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Movie, ACBindings.Internal.PFileNode*, byte>)0x0069DFA0)(ref this, file_node);
}

