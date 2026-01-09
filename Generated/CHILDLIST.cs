namespace ACBindings;

// CHILDLIST
public unsafe struct CHILDLIST : System.IDisposable
{
    // Members
    public ushort num_objects;
    public ACBindings.SArray__CPhysicsObj_ptr objects;
    public ACBindings.SArray__Frame frames;
    public ACBindings.SArray__uint part_numbers;
    public ACBindings.SArray__uint location_ids;

    // Generated Constructor
    public CHILDLIST() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CHILDLIST::remove_child(CHILDLIST*,CPhysicsObj*)
    public void remove_child(ACBindings.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CHILDLIST, ACBindings.CPhysicsObj*, void>)0x0051BAC0)(ref this, obj);
    // int __thiscall CHILDLIST::FindChildIndex(CHILDLIST*,const CPhysicsObj*,unsigned __int16*)
    public int FindChildIndex(ACBindings.CPhysicsObj* child, ushort* index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CHILDLIST, ACBindings.CPhysicsObj*, ushort*, int>)0x0051BBB0)(ref this, child, index);
    // void __thiscall CHILDLIST::CHILDLIST(CHILDLIST*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CHILDLIST, void>)0x0051BD30)(ref this);
    // void __thiscall CHILDLIST::~CHILDLIST(CHILDLIST*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CHILDLIST, void>)0x0051BD60)(ref this);
    // void __thiscall CHILDLIST::add_child(CHILDLIST*,CPhysicsObj*,const Frame*,unsigned int,unsigned int)
    public void add_child(ACBindings.CPhysicsObj* obj, ACBindings.Frame* frame, uint part_no, uint location_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CHILDLIST, ACBindings.CPhysicsObj*, ACBindings.Frame*, uint, uint, void>)0x0051BDA0)(ref this, obj, frame, part_no, location_id);
}

