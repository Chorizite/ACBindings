namespace ACBindings.Internal;


/// <summary>Contains metadata for a sound resource, including its media description, file identifier, and type classification.</summary>
public unsafe struct MD_Data_Sound
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Sound_vtbl
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
    public ACBindings.Internal.SoundType m_stype;

    // Generated Constructor
    public MD_Data_Sound(ACBindings.Internal.MD_Data_Sound* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Creates a new MD_Data_Sound instance, initializing its base MediaDesc and members, then copies data from the provided source if different.
    /// <code>Offset: 0x0069F450
    /// void __thiscall MD_Data_Sound::MD_Data_Sound(MD_Data_Sound*,const MD_Data_Sound*)</code>
    /// </summary>
    /// <param name="rhs">The source MD_Data_Sound to copy from; may be the same as the object being constructed.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Sound* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Sound, ACBindings.Internal.MD_Data_Sound*, void>)0x0069F450)(ref this, rhs);

    /// <summary>Serializes the sound data, writing its file identifier and type to an archive while ensuring proper alignment. Handles both saving and loading based on the archive's flags.
    /// <code>Offset: 0x0069F4A0
    /// void __thiscall MD_Data_Sound::Serialize(MD_Data_Sound*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for input or output of the sound data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Sound, ACBindings.Internal.Archive*, void>)0x0069F4A0)(ref this, io_archive);
}

