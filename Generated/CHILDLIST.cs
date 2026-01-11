namespace ACBindings.Internal;

public unsafe struct CHILDLIST : System.IDisposable
{
    // Members
    public ushort num_objects;
    public ACBindings.Internal.SArray___CPhysicsObj_ptr objects;
    public ACBindings.Internal.SArray___Frame frames;
    public ACBindings.Internal.SArray__uint part_numbers;
    public ACBindings.Internal.SArray__uint location_ids;

    // Generated Constructor
    public CHILDLIST() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051BAC0
    /// void __thiscall CHILDLIST::remove_child(CHILDLIST*,CPhysicsObj*)</code>
    /// </summary>
    public void remove_child(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, ACBindings.Internal.CPhysicsObj*, void>)0x0051BAC0)(ref this, obj);

    /// <summary>
    /// <code>Offset: 0x0051BBB0
    /// int __thiscall CHILDLIST::FindChildIndex(CHILDLIST*,const CPhysicsObj*,unsigned __int16*)</code>
    /// </summary>
    public int FindChildIndex(ACBindings.Internal.CPhysicsObj* child, ushort* index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, ACBindings.Internal.CPhysicsObj*, ushort*, int>)0x0051BBB0)(ref this, child, index);

    /// <summary>
    /// <code>Offset: 0x0051BD30
    /// void __thiscall CHILDLIST::CHILDLIST(CHILDLIST*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, void>)0x0051BD30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051BD60
    /// void __thiscall CHILDLIST::~CHILDLIST(CHILDLIST*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, void>)0x0051BD60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051BDA0
    /// void __thiscall CHILDLIST::add_child(CHILDLIST*,CPhysicsObj*,const Frame*,unsigned int,unsigned int)</code>
    /// </summary>
    public void add_child(ACBindings.Internal.CPhysicsObj* obj, ACBindings.Internal.Frame* frame, uint part_no, uint location_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.Frame*, uint, uint, void>)0x0051BDA0)(ref this, obj, frame, part_no, location_id);
}

