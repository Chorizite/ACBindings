namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00586D80
    /// int __thiscall ComponentTracker::DetermineComponentCategory(SpellComponentTable**,unsigned int)</code>
    /// </summary>
    public int DetermineComponentCategory(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, int>)0x00586D80)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00586E10
    /// void __thiscall ComponentTracker::GetNumComponent(SpellComponentTable**,unsigned int,unsigned int (__thiscall**a3)(Interface*this))</code>
    /// </summary>
    public void GetNumComponent(uint a2, delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint>* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint>*, void>)0x00586E10)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00586EC0
    /// LONG __thiscall ComponentTracker::GetCompNameFromWCID(SpellComponentTable**,unsigned int,int*)</code>
    /// </summary>
    public int GetCompNameFromWCID(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, int*, int>)0x00586EC0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00587010
    /// int __thiscall ComponentTracker::ObjectIsOwnedComponent(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    public int ObjectIsOwnedComponent(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, int*, int>)0x00587010)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005872B0
    /// BOOL __thiscall ComponentTracker::ComponentIsOwned(_DWORD*,unsigned int)</code>
    /// </summary>
    public byte ComponentIsOwned(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, uint, byte>)0x005872B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005875A0
    /// void __thiscall ComponentTracker::ComponentTracker(ComponentTracker*,SpellComponentTable*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SpellComponentTable* spellComponentTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.SpellComponentTable*, void>)0x005875A0)(ref this, spellComponentTable);

    /// <summary>
    /// <code>Offset: 0x00587610
    /// void __thiscall ComponentTracker::UpdateComponentStackSize(ComponentTracker*,ACCWeenieObject*,ComponentTrackerUpdate*)</code>
    /// </summary>
    public void UpdateComponentStackSize(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ComponentTrackerUpdate*, void>)0x00587610)(ref this, weenObj, change);

    /// <summary>
    /// <code>Offset: 0x005877F0
    /// char __thiscall ComponentTracker::InsertNewComponentData(_DWORD*,ACCWeenieObject*,DLListBase*,DLListData*)</code>
    /// </summary>
    public sbyte InsertNewComponentData(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.DLListBase* a3, ACBindings.Internal.DLListData* where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.DLListBase*, ACBindings.Internal.DLListData*, sbyte>)0x005877F0)(ref this, weenObj, a3, where);

    /// <summary>
    /// <code>Offset: 0x00587850
    /// void __thiscall ComponentTracker::AddComponent(ComponentTracker*,ACCWeenieObject*)</code>
    /// </summary>
    public void AddComponent(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, void>)0x00587850)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x00587980
    /// void __thiscall ComponentTracker::RemoveComponent(ComponentTracker*,ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveComponent(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, void>)0x00587980)(ref this, weenObj);

    /// <summary>
    /// <code>Offset: 0x00587A40
    /// void __thiscall ComponentTracker::~ComponentTracker(ComponentTracker*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, void>)0x00587A40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00587C10
    /// void __thiscall ComponentTracker::UpdateComponent(ComponentTracker*,ACCWeenieObject*,ComponentTrackerUpdate*)</code>
    /// </summary>
    public void UpdateComponent(ACBindings.Internal.ACCWeenieObject* weenObj, ACBindings.Internal.ComponentTrackerUpdate* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ComponentTracker, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.ComponentTrackerUpdate*, void>)0x00587C10)(ref this, weenObj, change);
}

