namespace ACBindings.Internal;


/// <summary>
/// Represents animation data for a media object, including duration, rendering mode, frame identifiers, playback start time, and the current displayed frame number.
/// </summary>
public unsafe struct MD_Data_Anim
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Anim_vtbl
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
    public float m_duration;
    public uint m_drawMode;
    public ACBindings.Internal.SmartArray___IDClass____tagDataID m_frames;
    public double m_StartTime;
    public int m_displayedFrameNum;

    // Generated Constructor
    public MD_Data_Anim(ACBindings.Internal.MD_Data_Anim* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Retrieves the sub‑data IDs associated with an animation frame set and writes them into a supplied QualifiedDataIDArray.
    /// <code>Offset: 0x0069F970
    /// void __thiscall MD_Data_Anim::GetSubDataIDs(MD_Data_Anim*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the data IDs of each frame in the animation.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Anim, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069F970)(ref this, id_array);

    /// <summary>Retrieves the total duration of the animation.
    /// <code>Offset: 0x0069F9F0
    /// float __thiscall MD_Data_Anim::GetDuration(MD_Data_Anim*)</code>
    /// </summary>
    /// <returns>The length, in seconds, of the animation sequence.</returns>
    public float GetDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Anim, float>)0x0069F9F0)(ref this);

    /// <summary>Constructs an MD_Data_Anim object, initializing members and optionally copying data from a source instance if provided.
    /// <code>Offset: 0x0069FAE0
    /// void __thiscall MD_Data_Anim::MD_Data_Anim(MD_Data_Anim*,const MD_Data_Anim*)</code>
    /// </summary>
    /// <param name="rhs">The instance to copy values from; if the same as the target, defaults are used instead of copying.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Anim* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Anim, ACBindings.Internal.MD_Data_Anim*, void>)0x0069FAE0)(ref this, rhs);

    /// <summary>Serializes or deserializes the animation data, including duration, draw mode, and frame list, to or from an Archive object while maintaining proper alignment.
    /// <code>Offset: 0x0069FB50
    /// void __thiscall MD_Data_Anim::Serialize(MD_Data_Anim*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading or writing the object's state.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Anim, ACBindings.Internal.Archive*, void>)0x0069FB50)(ref this, io_archive);
}

