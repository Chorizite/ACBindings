namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00586D60
    /// unsigned int __thiscall ComponentData::GetFirstObjectID(ComponentData*)</code>
    /// </summary>
    public uint GetFirstObjectID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, uint>)0x00586D60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00587440
    /// void __thiscall ComponentData::AddItem(ComponentData*,ACCWeenieObject*)</code>
    /// </summary>
    public void AddItem(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, void>)0x00587440)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x005874B0
    /// void __thiscall ComponentData::RemoveItem(ComponentData*,ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveItem(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, void>)0x005874B0)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x00587500
    /// void __thiscall ComponentData::UpdateStackSize(ComponentData*,ACCWeenieObject*,ComponentTrackerUpdate*)</code>
    /// </summary>
    public void UpdateStackSize(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ComponentTrackerUpdate*, void>)0x00587500)(ref this, weenObj, change);

    /// <summary>
    /// <code>Offset: 0x00587660
    /// void __thiscall ComponentData::ComponentData(ComponentData*,ACCWeenieObject*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, ACBindings.Internal.ACCWeenieObject*, void>)0x00587660)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x00587790
    /// void __thiscall ComponentData::~ComponentData(ComponentData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentData, void>)0x00587790)(ref this);
}

