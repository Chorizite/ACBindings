namespace ACBindings;

// ComponentTracker
public unsafe struct ComponentTracker : System.IDisposable
{
    // Members
    public ACBindings.SpellComponentTable* spellComponentTable;
    public fixed byte componentLists_Raw[7 * 4];
    public System.IntPtr* componentLists => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref componentLists_Raw[0]);
    public ACBindings.HashTable__uint__IDClass___tagDataID objectIDHash;
    public ACBindings.HashSet__IDClass___tagDataID classIDHash;

    // Generated Constructor
    public ComponentTracker(ACBindings.SpellComponentTable* spellComponentTable) {
        _ConstructorInternal(spellComponentTable);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall ComponentTracker::DetermineComponentCategory(SpellComponentTable**,unsigned int)
    public int DetermineComponentCategory(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, uint, int>)0x00586D80)(ref this, a2);
    // void __thiscall ComponentTracker::GetNumComponent(SpellComponentTable**,unsigned int,unsigned int (__thiscall**a3)(Interface*this))
    public void GetNumComponent(uint a2, delegate* unmanaged[Thiscall]<ACBindings.Interface*, uint>* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, uint, delegate* unmanaged[Thiscall]<ACBindings.Interface*, uint>*, void>)0x00586E10)(ref this, a2, a3);
    // LONG __thiscall ComponentTracker::GetCompNameFromWCID(SpellComponentTable**,unsigned int,int*)
    public int GetCompNameFromWCID(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, uint, int*, int>)0x00586EC0)(ref this, a2, a3);
    // int __thiscall ComponentTracker::ObjectIsOwnedComponent(_DWORD*,unsigned int,_DWORD*)
    public int ObjectIsOwnedComponent(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, uint, int*, int>)0x00587010)(ref this, a2, a3);
    // BOOL __thiscall ComponentTracker::ComponentIsOwned(_DWORD*,unsigned int)
    public byte ComponentIsOwned(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, uint, byte>)0x005872B0)(ref this, a2);
    // void __thiscall ComponentTracker::ComponentTracker(ComponentTracker*,SpellComponentTable*)
    public void _ConstructorInternal(ACBindings.SpellComponentTable* spellComponentTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, ACBindings.SpellComponentTable*, void>)0x005875A0)(ref this, spellComponentTable);
    // void __thiscall ComponentTracker::UpdateComponentStackSize(ComponentTracker*,ACCWeenieObject*,ComponentTrackerUpdate*)
    public void UpdateComponentStackSize(ACBindings.ACCWeenieObject* weenObj, ACBindings.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, ACBindings.ACCWeenieObject*, ACBindings.ComponentTrackerUpdate*, void>)0x00587610)(ref this, weenObj, change);
    // char __thiscall ComponentTracker::InsertNewComponentData(_DWORD*,ACCWeenieObject*,DLListBase*,DLListData*)
    public sbyte InsertNewComponentData(ACBindings.ACCWeenieObject* weenObj, ACBindings.DLListBase* a3, ACBindings.DLListData* where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, ACBindings.ACCWeenieObject*, ACBindings.DLListBase*, ACBindings.DLListData*, sbyte>)0x005877F0)(ref this, weenObj, a3, where);
    // void __thiscall ComponentTracker::AddComponent(ComponentTracker*,ACCWeenieObject*)
    public void AddComponent(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, ACBindings.ACCWeenieObject*, void>)0x00587850)(ref this, weenObj);
    // void __thiscall ComponentTracker::RemoveComponent(ComponentTracker*,ACCWeenieObject*)
    public void RemoveComponent(ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, ACBindings.ACCWeenieObject*, void>)0x00587980)(ref this, weenObj);
    // void __thiscall ComponentTracker::~ComponentTracker(ComponentTracker*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, void>)0x00587A40)(ref this);
    // void __thiscall ComponentTracker::UpdateComponent(ComponentTracker*,ACCWeenieObject*,ComponentTrackerUpdate*)
    public void UpdateComponent(ACBindings.ACCWeenieObject* weenObj, ACBindings.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ComponentTracker, ACBindings.ACCWeenieObject*, ACBindings.ComponentTrackerUpdate*, void>)0x00587C10)(ref this, weenObj, change);
}

