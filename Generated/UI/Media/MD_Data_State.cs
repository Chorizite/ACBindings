namespace ACBindings.Internal;


/// <summary>Media descriptor state linking a base media description to an identifier and probability value for selection logic.</summary>
/// <remarks>Contains MediaDesc baseclass_, m_stateID, and m_probability used in runtime decisions.</remarks>
public unsafe struct MD_Data_State
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_State_vtbl
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
    public uint m_stateID;
    public float m_probability;

    // Generated Constructor
    public MD_Data_State(ACBindings.Internal.MD_Data_State* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Constructs a new MD_Data_State object, initializing its MediaDesc base class and setting default values for state ID and probability. If a non‑null source instance is supplied and differs from the current object, copies its state information.
    /// <code>Offset: 0x0069E760
    /// void __thiscall MD_Data_State::MD_Data_State(MD_Data_State*,const MD_Data_State*)</code>
    /// </summary>
    /// <param name="rhs">Pointer to an existing MD_Data_State whose data will be copied if not identical to this instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_State* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_State, ACBindings.Internal.MD_Data_State*, void>)0x0069E760)(ref this, rhs);

    /// <summary>Serializes an MD_Data_State object into a file node structure by first delegating to its MediaDesc base class and then adding subnodes for the state ID and probability values.
    /// <code>Offset: 0x0069E7A0
    /// bool __thiscall MD_Data_State::ToFileNode(MD_Data_State*,PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The parent PFileNode that will receive the serialized data as child nodes.</param>
    /// <returns>True if all serialization steps succeed; otherwise, false.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_State, ACBindings.Internal.PFileNode*, byte>)0x0069E7A0)(ref this, file_node);

    /// <summary>Parses STATE and PROBABILITY child nodes of a file node, filling the MD_Data_State's m_stateID and m_probability fields while reporting any errors for malformed or unknown entries.
    /// <code>Offset: 0x0069E840
    /// bool __thiscall MD_Data_State::FromFileNode(MD_Data_State*,const PFileNode*)</code>
    /// </summary>
    /// <param name="file_node">The PFileNode containing the state description; must not be null.</param>
    /// <returns>True if all encountered subnodes were parsed successfully (or no subnodes exist); false if a parsing error occurs or an unexpected keyword is found.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_State, ACBindings.Internal.PFileNode*, byte>)0x0069E840)(ref this, file_node);
}

