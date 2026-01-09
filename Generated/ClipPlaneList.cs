namespace ACBindings;

// ClipPlaneList
public unsafe struct ClipPlaneList : System.IDisposable
{
    // Members
    public uint cplane_num;
    public ACBindings.DArray__ClipPlane cplane_list;
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
    // void __thiscall ClipPlaneList::ClipPlaneList(ClipPlaneList*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClipPlaneList, void>)0x0053C740)(ref this);
    // void __thiscall ClipPlaneList::~ClipPlaneList(ClipPlaneList*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClipPlaneList, void>)0x0053C760)(ref this);
}

