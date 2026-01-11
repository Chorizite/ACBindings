namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0053C740
    /// void __thiscall ClipPlaneList::ClipPlaneList(ClipPlaneList*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlaneList, void>)0x0053C740)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053C760
    /// void __thiscall ClipPlaneList::~ClipPlaneList(ClipPlaneList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClipPlaneList, void>)0x0053C760)(ref this);
}

