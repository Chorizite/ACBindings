namespace ACBindings;

// CInputMap
public unsafe struct CInputMap
{
    // Child Types
    // CInputMap::ActionBindingList
    public unsafe struct ActionBindingList
    {
        // Base Classes
        public ACBindings.HashList__QualifiedControl__uint BaseClass_HashList; // ACBindings.HashList__QualifiedControl__uint

        // Methods
        // bool __thiscall CInputMap::ActionBindingList::FindBestMatch(CInputMap::ActionBindingList*,const QualifiedControl*,unsigned int*,QualifiedControl*)
        public byte FindBestMatch(ACBindings.QualifiedControl* i_key, uint* o_data, ACBindings.QualifiedControl* o_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap.ActionBindingList, ACBindings.QualifiedControl*, uint*, ACBindings.QualifiedControl*, byte>)0x0068E3B0)(ref this, i_key, o_data, o_key);
        // BOOL __thiscall CInputMap::ActionBindingList::FindConflictingControls(_DWORD*,QualifiedControl*,_DWORD*)
        public byte FindConflictingControls(ACBindings.QualifiedControl* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap.ActionBindingList, ACBindings.QualifiedControl*, int*, byte>)0x0068E420)(ref this, a2, a3);
    }

    // Members
    public ACBindings.CMasterInputMap* m_pParent;
    public uint m_eInputMapID;
    public ACBindings.CInputMap.ActionBindingList m_listMappings;

    // Methods
    // bool __thiscall CInputMap::ToFileNode(CInputMap*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, ACBindings.PFileNode*, byte>)0x0068E1F0)(ref this, i_pNode);
    // bool __thiscall CInputMap::FindBestMatch(CInputMap*,const QualifiedControl*,unsigned int*,QualifiedControl*)
    public byte FindBestMatch(ACBindings.QualifiedControl* i_key, uint* o_idAction, ACBindings.QualifiedControl* o_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, ACBindings.QualifiedControl*, uint*, ACBindings.QualifiedControl*, byte>)0x0068E540)(ref this, i_key, o_idAction, o_key);
    // BOOL __thiscall CInputMap::FindConflictingControls(_DWORD*,QualifiedControl*,_DWORD*)
    public byte FindConflictingControls(ACBindings.QualifiedControl* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, ACBindings.QualifiedControl*, int*, byte>)0x0068E550)(ref this, a2, a3);
    // char __thiscall CInputMap::FindKeysForAction(_DWORD*,int,_DWORD*)
    public sbyte FindKeysForAction(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, int, int*, sbyte>)0x0068E560)(ref this, a2, a3);
    // bool __thiscall CInputMap::UnbindByKey(CInputMap*,QualifiedControl)
    public byte UnbindByKey(ACBindings.QualifiedControl i_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, ACBindings.QualifiedControl, byte>)0x0068F6B0)(ref this, i_key);
    // bool __thiscall CInputMap::UnbindAllByAction(CInputMap*,unsigned int)
    public byte UnbindAllByAction(uint i_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, uint, byte>)0x0068F950)(ref this, i_id);
    // void __thiscall CInputMap::Serialize(CInputMap*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, ACBindings.Archive*, void>)0x0068FDB0)(ref this, io_archive);
    // bool __thiscall CInputMap::AddMapping(CInputMap*,unsigned int,QualifiedControl)
    public byte AddMapping(uint id, ACBindings.QualifiedControl key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, uint, ACBindings.QualifiedControl, byte>)0x0068FEE0)(ref this, id, key);
    // char __thiscall CInputMap::Merge(CInputMap*,int,int,char)
    public sbyte Merge(int a2, int a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, int, int, sbyte, sbyte>)0x0068FFF0)(ref this, a2, a3, a4);
    // bool __thiscall CInputMap::FromFileNode(CInputMap*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputMap, ACBindings.PFileNode*, byte>)0x00690300)(ref this, i_pNode);
}

