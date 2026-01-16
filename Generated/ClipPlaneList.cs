namespace ACBindings.Internal;


/// <summary>Represents a collection of clip planes tied to a spatial leaf, storing the plane count, the array of planes, and whether the leaf contains any objects.</summary>
public unsafe struct ClipPlaneList : System.IDisposable
{
    // Members
    public uint cplane_num;
    public ACBindings.Internal.DArray___ClipPlane cplane_list;
    public int leaf_contains_obj;

    // Generated Constructor
    public ClipPlaneList() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates an empty ClipPlaneList instance, initializing internal counters and preparing storage for up to 128 clip planes.
    /// <code>Offset: 0x0053C740
    /// void __thiscall ClipPlaneList::ClipPlaneList(ClipPlaneList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlaneList, void>)0x0053C740)(ref this);

    /// <summary>Destroys a ClipPlaneList, deallocating its internal clip plane array and invoking cleanup for each stored clip plane.
    /// <code>Offset: 0x0053C760
    /// void __thiscall ClipPlaneList::~ClipPlaneList(ClipPlaneList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlaneList, void>)0x0053C760)(ref this);
}

