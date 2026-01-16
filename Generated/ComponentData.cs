namespace ACBindings.Internal;


/// <summary>Represents a component within the game's inventory system, storing its class ID, icon, name, and a collection of associated objects with item counts.</summary>
public unsafe struct ComponentData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DLListData BaseClass_DLListData; // ACBindings.Internal.DLListData

    // Members
    public ACBindings.Internal.IDClass____tagDataID classID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte componentName;
    public ACBindings.Internal.IDClass____tagDataID componentIconID;
    public ACBindings.Internal.HashTable__uint__uint objects;
    public uint numItems;

    // Generated Constructor
    public ComponentData(ACBindings.Internal.ACCWeenieObject* weenObj) {
        _ConstructorInternal(weenObj);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the identifier of the first object stored in this component's collection.
    /// <code>Offset: 0x00586D60
    /// unsigned int __thiscall ComponentData::GetFirstObjectID(ComponentData*)</code>
    /// </summary>
    /// <returns>The unique ID of the first object; undefined behavior if the collection is empty.</returns>
    public uint GetFirstObjectID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, uint>)0x00586D60)(ref this);

    /// <summary>Adds a WeenieObject to the component's internal collection and updates the item count based on its stack size.
    /// <code>Offset: 0x00587440
    /// void __thiscall ComponentData::AddItem(ComponentData*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="this">The ComponentData instance receiving the item.</param>
    /// <param name="weenObj">The ACCWeenieObject to add to the component.</param>
    public void AddItem(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, void>)0x00587440)(ref this, weenObj);

    /// <summary>Removes an item from the component's internal object table by its identifier, deleting the hash entry and decreasing the stored item count accordingly.
    /// <code>Offset: 0x005874B0
    /// void __thiscall ComponentData::RemoveItem(ComponentData*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The weenie object whose data is to be removed from the component.</param>
    public void RemoveItem(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, void>)0x005874B0)(ref this, weenObj);

    /// <summary>Adjusts component tracking information for an object by comparing its current stack size against a stored value and updates the change status accordingly.
    /// <code>Offset: 0x00587500
    /// void __thiscall ComponentData::UpdateStackSize(ComponentData*,ACCWeenieObject*,ComponentTrackerUpdate*)</code>
    /// </summary>
    /// <param name="this">The ComponentData instance containing the tracker hash table.</param>
    /// <param name="weenObj">The object whose stack size is being evaluated.</param>
    /// <param name="change">Pointer to receive the resulting component tracker update (increase, decrease, or none).</param>
    public void UpdateStackSize(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ComponentTrackerUpdate*, void>)0x00587500)(ref this, weenObj, change);

    /// <summary>Initializes a ComponentData instance from an ACCWeenieObject, copying its class ID, icon ID, and name into the component data structure, setting up internal hash table entries for associated objects, and recording item counts.
    /// <code>Offset: 0x00587660
    /// void __thiscall ComponentData::ComponentData(ComponentData*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="weenObj">The source ACCWeenieObject providing data for the new component.</param>
    public void _ConstructorInternal(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, void>)0x00587660)(ref this, weenObj);

    /// <summary>Destroys a ComponentData instance, freeing the object hash table and decrementing the reference count on the component name string buffer.
    /// <code>Offset: 0x00587790
    /// void __thiscall ComponentData::~ComponentData(ComponentData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, void>)0x00587790)(ref this);
}

