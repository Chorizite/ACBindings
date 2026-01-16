namespace ACBindings.Internal;


/// <summary>Holds collections of child physics objects and their associated frame, part number, and location data for hierarchical simulation management.</summary>
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

    /// <summary>Removes the specified physics object from the child list, updating internal arrays to keep the storage contiguous.
    /// <code>Offset: 0x0051BAC0
    /// void __thiscall CHILDLIST::remove_child(CHILDLIST*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="obj">The physics object to remove from the list.</param>
    public void remove_child(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, ACBindings.Internal.CPhysicsObj*, void>)0x0051BAC0)(ref this, obj);

    /// <summary>Finds the zero‑based position of a specified child object in the list.
    /// <code>Offset: 0x0051BBB0
    /// int __thiscall CHILDLIST::FindChildIndex(CHILDLIST*,const CPhysicsObj*,unsigned __int16*)</code>
    /// </summary>
    /// <param name="child">The child object to locate within the list.</param>
    /// <param name="index">Pointer that receives the index if the child is found; remains unchanged when not found.</param>
    /// <returns>Nonzero (1) when the child exists; zero when it does not or the list is empty.</returns>
    public int FindChildIndex(ACBindings.Internal.CPhysicsObj* child, ushort* index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, ACBindings.Internal.CPhysicsObj*, ushort*, int>)0x0051BBB0)(ref this, child, index);

    /// <summary>Initializes a CHILDLIST instance with zero objects and empty arrays for objects, frames, part numbers, and location identifiers.
    /// <code>Offset: 0x0051BD30
    /// void __thiscall CHILDLIST::CHILDLIST(CHILDLIST*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, void>)0x0051BD30)(ref this);

    /// <summary>Destroys a CHILDLIST instance by releasing all allocated memory for its internal arrays of objects, frames, part numbers, and location IDs.
    /// <code>Offset: 0x0051BD60
    /// void __thiscall CHILDLIST::~CHILDLIST(CHILDLIST*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, void>)0x0051BD60)(ref this);

    /// <summary>Adds a child physics object to the list along with its transform, part number, and location ID, expanding storage when necessary.
    /// <code>Offset: 0x0051BDA0
    /// void __thiscall CHILDLIST::add_child(CHILDLIST*,CPhysicsObj*,const Frame*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="obj">Pointer to the CPhysicsObj instance being added as a child.</param>
    /// <param name="frame">Reference to the Frame structure containing pose information for the new child.</param>
    /// <param name="part_no">Identifier of the part number associated with the child object.</param>
    /// <param name="location_id">Identifier representing the child's location within the parent hierarchy.</param>
    public void add_child(ACBindings.Internal.CPhysicsObj* obj, ACBindings.Internal.Frame* frame, uint part_no, uint location_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CHILDLIST, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.Frame*, uint, uint, void>)0x0051BDA0)(ref this, obj, frame, part_no, location_id);
}

