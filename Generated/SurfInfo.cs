namespace ACBindings.Internal;


/// <summary>Provides metadata for a rendering surface, including palette code, cell count, a pointer to the associated CSurface instance, and a unique surface number used by the graphics subsystem.</summary>
public unsafe struct SurfInfo
{
    // Members
    public uint palcode;
    public uint lcell_count;
    public ACBindings.Internal.CSurface* surface;
    public uint surf_num;

    // Methods
}

