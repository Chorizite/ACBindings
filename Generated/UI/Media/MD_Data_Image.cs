namespace ACBindings.Internal;


/// <summary>Represents an image asset within the media system, linking to its source file via a unique ID and specifying rendering behavior.</summary>
public unsafe struct MD_Data_Image
{
    // Base Classes
    public ACBindings.Internal.MediaDesc BaseClass_MediaDesc; // ACBindings.Internal.MediaDesc

    // Child Types
    public unsafe struct MD_Data_Image_vtbl
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
    public uint m_drawMode;

    // Generated Constructor
    public MD_Data_Image() {
        _ConstructorInternal();
    }
    public MD_Data_Image(ACBindings.Internal.MD_Data_Image* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Initializes a new MD_Data_Image instance with default values, assigning the appropriate virtual table, setting an invalid file identifier, and enabling default draw mode.
    /// <code>Offset: 0x0069DC60
    /// void __thiscall MD_Data_Image::MD_Data_Image(MD_Data_Image*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Image, void>)0x0069DC60)(ref this);

    /// <summary>Initializes an MD_Data_Image instance by setting up its base MediaDesc and assigning a file identifier and drawing mode; when supplied with another instance, copies the media descriptor, file ID, and draw mode from it.
    /// <code>Offset: 0x0069DC90
    /// void __thiscall MD_Data_Image::MD_Data_Image(MD_Data_Image*,const MD_Data_Image*)</code>
    /// </summary>
    /// <param name="rhs">The source image to copy from. Must not be null; if this is the same pointer as rhs, no copying occurs.</param>
    public void _ConstructorInternal(ACBindings.Internal.MD_Data_Image* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MD_Data_Image, ACBindings.Internal.MD_Data_Image*, void>)0x0069DC90)(ref this, rhs);
}

