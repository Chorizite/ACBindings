namespace ACBindings.Internal;


/// <summary>Tracks spell components associated with game objects, maintaining hash tables of object identifiers and organized component lists by category; provides lookup, insertion, removal, and update functionality.</summary>
public unsafe struct ComponentTracker : System.IDisposable
{
    // Members
    public ACBindings.Internal.SpellComponentTable* spellComponentTable;
    public fixed byte componentLists_Raw[7 * 4];
    public System.IntPtr* componentLists => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref componentLists_Raw[0]);
    public ACBindings.Internal.HashTable__uint___IDClass____tagDataID objectIDHash;
    public ACBindings.Internal.HashSet___IDClass____tagDataID classIDHash;

    // Generated Constructor
    public ComponentTracker(ACBindings.Internal.SpellComponentTable* spellComponentTable) {
        _ConstructorInternal(spellComponentTable);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines the spell component category corresponding to a component ID using the tracker’s component table.
    /// <code>Offset: 0x00586D80
    /// int __thiscall ComponentTracker::DetermineComponentCategory(SpellComponentTable**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The component ID to query.</param>
    /// <returns>An integer value representing the SpellComponentCategory enumeration; returns 8 (unknown) if no matching component is found.</returns>
    public int DetermineComponentCategory(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, int>)0x00586D80)(ref this, a2);

    /// <summary>Obtains an AddRef callback for the spell component specified by its ID in the supplied component table, storing it via the output pointer; sets the pointer to null when no matching component exists.
    /// <code>Offset: 0x00586E10
    /// void __thiscall ComponentTracker::GetNumComponent(SpellComponentTable**,unsigned int,unsigned int (__thiscall**a3)(Interface*this))</code>
    /// </summary>
    /// <param name="this">Pointer to the SpellComponentTable used for lookup.</param>
    /// <param name="a2">Identifier of the desired spell component.</param>
    /// <param name="a3">Receives the AddRef method pointer if the component is found; otherwise set to null.</param>
    public void GetNumComponent(uint a2, delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint>* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint>*, void>)0x00586E10)(ref this, a2, a3);

    /// <summary>Retrieves a spell component’s name buffer for a world component ID, updates an output parameter with the internal component ID, and manages reference counts on the associated buffers.
    /// <code>Offset: 0x00586EC0
    /// LONG __thiscall ComponentTracker::GetCompNameFromWCID(SpellComponentTable**,unsigned int,int*)</code>
    /// </summary>
    /// <param name="a2">World component identifier used to locate the corresponding spell component in the table.</param>
    /// <param name="a3">Pointer to an integer that receives the internal component ID; its reference count is updated if the ID changes.</param>
    /// <returns>The reference count of the returned name buffer after it has been decremented, indicating whether the buffer remains referenced (non‑zero) or has been released (zero).</returns>
    public int GetCompNameFromWCID(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, int*, int>)0x00586EC0)(ref this, a2, a3);

    /// <summary>Checks whether a specified object ID is present in the tracker and obtains its associated component address.
    /// <code>Offset: 0x00587010
    /// int __thiscall ComponentTracker::ObjectIsOwnedComponent(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The object identifier to locate.</param>
    /// <param name="a3">Output parameter that receives the component address when found.</param>
    /// <returns>Non‑zero if the object was found; zero otherwise.</returns>
    public int ObjectIsOwnedComponent(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, int*, int>)0x00587010)(ref this, a2, a3);

    /// <summary>Determines whether the tracker contains a component with the specified identifier.
    /// <code>Offset: 0x005872B0
    /// BOOL __thiscall ComponentTracker::ComponentIsOwned(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="componentId">The ID of the component to search for.</param>
    /// <returns>True if the component is owned; otherwise false.</returns>
    public byte ComponentIsOwned(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, byte>)0x005872B0)(ref this, a2);

    /// <summary>Initializes a ComponentTracker with the provided spell component table and prepares empty structures for tracking components and class identifiers.
    /// <code>Offset: 0x005875A0
    /// void __thiscall ComponentTracker::ComponentTracker(ComponentTracker*,SpellComponentTable*)</code>
    /// </summary>
    /// <param name="spellComponentTable">Pointer to the SpellComponentTable that this tracker will use.</param>
    public void _ConstructorInternal(ACBindings.Internal.SpellComponentTable* spellComponentTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.SpellComponentTable*, void>)0x005875A0)(ref this, spellComponentTable);

    /// <summary>Adjusts the stack size of a tracked component for the specified object when an update occurs.
    /// <code>Offset: 0x00587610
    /// void __thiscall ComponentTracker::UpdateComponentStackSize(ComponentTracker*,ACCWeenieObject*,ComponentTrackerUpdate*)</code>
    /// </summary>
    /// <param name="weenObj">The object whose component stack is being updated.</param>
    /// <param name="change">Details describing how the component stack size should change.</param>
    public void UpdateComponentStackSize(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ComponentTrackerUpdate*, void>)0x00587610)(ref this, weenObj, change);

    /// <summary>Adds a new component record for the specified object, inserts it into the supplied list at the given position, and registers its ID in the tracker’s hash set.
    /// <code>Offset: 0x005877F0
    /// char __thiscall ComponentTracker::InsertNewComponentData(_DWORD*,ACCWeenieObject*,DLListBase*,DLListData*)</code>
    /// </summary>
    /// <param name="weenObj">The object whose component data is being created.</param>
    /// <param name="a3">The doubly linked list into which the new component record will be inserted.</param>
    /// <param name="where">The node after which the new component record should be placed in the list.</param>
    /// <returns>Non‑zero if the object's ID was successfully added to the hash set; zero otherwise.</returns>
    public sbyte InsertNewComponentData(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.DLListBase* a3, ACBindings.Internal.DLListData* where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.DLListBase*, ACBindings.Internal.DLListData*, sbyte>)0x005877F0)(ref this, weenObj, a3, where);

    /// <summary>Registers the given ween object as a component in the tracker, placing it into the appropriate category list and merging it with an existing component of the same name when found.
    /// <code>Offset: 0x00587850
    /// void __thiscall ComponentTracker::AddComponent(ComponentTracker*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The weenie object to add as a component.</param>
    public void AddComponent(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, void>)0x00587850)(ref this, weenObj);

    /// <summary>Removes the component associated with a specified object from the tracker, updating hash tables and doubly‑linked lists. If the removed component is the last reference, its data structures are deallocated.
    /// <code>Offset: 0x00587980
    /// void __thiscall ComponentTracker::RemoveComponent(ComponentTracker*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The object whose linked component should be removed from the tracker.</param>
    public void RemoveComponent(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, void>)0x00587980)(ref this, weenObj);

    /// <summary>Destroys a ComponentTracker instance, freeing all component lists and internal hash tables to release allocated memory.
    /// <code>Offset: 0x00587A40
    /// void __thiscall ComponentTracker::~ComponentTracker(ComponentTracker*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, void>)0x00587A40)(ref this);

    /// <summary>Updates component tracking for a given object, adding it to the tracker, updating its stack size, or removing it depending on ownership and presence, while recording the change type.
    /// <code>Offset: 0x00587C10
    /// void __thiscall ComponentTracker::UpdateComponent(ComponentTracker*,ACCWeenieObject*,ComponentTrackerUpdate*)</code>
    /// </summary>
    /// <param name="this">The ComponentTracker instance performing the update.</param>
    /// <param name="weenObj">The game object whose component status is being processed.</param>
    /// <param name="change">Pointer to a flag that receives the resulting action: add, remove, or none.</param>
    public void UpdateComponent(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ComponentTrackerUpdate*, void>)0x00587C10)(ref this, weenObj, change);
}

