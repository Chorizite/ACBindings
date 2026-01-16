namespace ACBindings.Internal;


/// <summary>Represents fade transition data for a media object, including start and end opacity values, the fade duration, and the timestamp at which the effect begins.</summary>
public unsafe struct MD_Data_Fade
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Fade_vtbl
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
    public float m_startAlpha;
    public float m_endAlpha;
    public float m_duration;
    public double m_startTime;

    // Generated Constructor
    public MD_Data_Fade(ACBindings.Internal.MD_Data_Fade* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Returns the framerate of the supplied animation sequence node.
    /// <code>Offset: 0x0069EDA0
    /// float __thiscall MD_Data_Fade::GetDuration(AnimSequenceNode*)</code>
    /// </summary>
    /// <returns>The framerate value from the specified AnimSequenceNode.</returns>
    public float GetDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Fade, float>)0x0069EDA0)(ref this);

    /// <summary>Initializes an MD_Data_Fade object, setting default fade parameters and copying values from another instance if supplied.
    /// <code>Offset: 0x0069EDB0
    /// void __thiscall MD_Data_Fade::MD_Data_Fade(MD_Data_Fade*,const MD_Data_Fade*)</code>
    /// </summary>
    /// <param name="rhs">Source MD_Data_Fade to copy startAlpha, endAlpha, and duration from; defaults are used when this equals rhs or no source is provided.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Fade* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Fade, ACBindings.Internal.MD_Data_Fade*, void>)0x0069EDB0)(ref this, rhs);

    /// <summary>Serializes the fade parameters (start alpha, end alpha, duration) into a hierarchical file node structure.
    /// <code>Offset: 0x0069EEA0
    /// bool __thiscall MD_Data_Fade::ToFileNode(MD_Data_Fade*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The target file node to which fade data will be appended as subnodes.</param>
    /// <returns>True if all subnode creations succeeded; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Fade, ACBindings.Internal.PFileNode*, byte>)0x0069EEA0)(ref this, file_node);

    /// <summary>Parses a fade definition from the supplied file node, extracting start alpha, end alpha and duration values into the current MD_Data_Fade instance. Unknown or malformed entries trigger an error report and cause failure.
    /// <code>Offset: 0x0069EF80
    /// bool __thiscall MD_Data_Fade::FromFileNode(MD_Data_Fade*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The XML node containing fade parameters; if null parsing fails immediately.</param>
    /// <returns>True if all expected subnodes were read successfully; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Fade, ACBindings.Internal.PFileNode*, byte>)0x0069EF80)(ref this, file_node);
}

