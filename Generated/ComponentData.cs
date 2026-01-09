namespace ACBindings;

// ComponentData
public unsafe struct ComponentData : System.IDisposable
{
    // Base Classes
    public ACBindings.DLListData BaseClass_DLListData; // ACBindings.DLListData

    // Members
    public ACBindings.IDClass___tagDataID classID;
    public ACBindings.AC1Legacy.PStringBase__sbyte componentName;
    public ACBindings.IDClass___tagDataID componentIconID;
    public ACBindings.HashTable__uint__uint objects;
    public uint numItems;

    // Generated Constructor
    public ComponentData(ACBindings.ACCWeenieObject* weenObj) {
        _ConstructorInternal(weenObj);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall ComponentData::GetFirstObjectID(ComponentData*)
    public uint GetFirstObjectID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentData, uint>)0x00586D60)(ref this);
    // void __thiscall ComponentData::AddItem(ComponentData*,ACCWeenieObject*)
    public void AddItem(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentData, ACBindings.ACCWeenieObject*, void>)0x00587440)(ref this, weenObj);
    // void __thiscall ComponentData::RemoveItem(ComponentData*,ACCWeenieObject*)
    public void RemoveItem(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentData, ACBindings.ACCWeenieObject*, void>)0x005874B0)(ref this, weenObj);
    // void __thiscall ComponentData::UpdateStackSize(ComponentData*,ACCWeenieObject*,ComponentTrackerUpdate*)
    public void UpdateStackSize(ACBindings.ACCWeenieObject* weenObj, ACBindings.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentData, ACBindings.ACCWeenieObject*, ACBindings.ComponentTrackerUpdate*, void>)0x00587500)(ref this, weenObj, change);
    // void __thiscall ComponentData::ComponentData(ComponentData*,ACCWeenieObject*)
    public void _ConstructorInternal(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentData, ACBindings.ACCWeenieObject*, void>)0x00587660)(ref this, weenObj);
    // void __thiscall ComponentData::~ComponentData(ComponentData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentData, void>)0x00587790)(ref this);
}

