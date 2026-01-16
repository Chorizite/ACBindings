namespace ACBindings.Internal;


/// <summary>Holds metadata for an alpha data file, including base media description and a unique identifier for the associated file resource.</summary>
public unsafe struct MD_Data_Alpha
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Alpha_vtbl
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

    // Generated Constructor
    public MD_Data_Alpha(ACBindings.Internal.MD_Data_Alpha* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Initializes an MD_Data_Alpha instance and optionally copies media description and file identifier from another instance when the source differs.
    /// <code>Offset: 0x0069F8B0
    /// void __thiscall MD_Data_Alpha::MD_Data_Alpha(MD_Data_Alpha*,const MD_Data_Alpha*)</code>
    /// </summary>
    /// <param name="rhs">The object to copy data from; if equal to this, only default initialization occurs.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Alpha* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Alpha, ACBindings.Internal.MD_Data_Alpha*, void>)0x0069F8B0)(ref this, rhs);

    /// <summary>Serializes or deserializes an MD_Data_Alpha object by delegating to its MediaDesc base class and handling the 4‑byte file ID within the provided Archive, respecting alignment requirements.
    /// <code>Offset: 0x0069F8F0
    /// void __thiscall MD_Data_Alpha::Serialize(MD_Data_Alpha*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading from or writing to the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Alpha, ACBindings.Internal.Archive*, void>)0x0069F8F0)(ref this, io_archive);

    /// <summary>Retrieves the file identifier of the current sound data, updates rent payment notice, and appends a qualified data ID representing this file to the supplied array.
    /// <code>Offset: 0x0069F930
    /// void __thiscall MD_Data_Alpha::GetSubDataIDs(MD_Data_Sound*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="this">The MD_Data_Sound instance whose sub‑data identifiers are being gathered.</param>
    /// <param name="id_array">Array collecting qualified data IDs; the function adds the current object's file ID as a new entry.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Alpha, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069F930)(ref this, id_array);
}

