namespace ACBindings.Internal;

public unsafe struct CInputMap
{
    // Child Types
    public unsafe struct ActionBindingList
    {
        // Base Classes
        public ACBindings.Internal.HashList___QualifiedControl__uint BaseClass_HashList; // ACBindings.Internal.HashList___QualifiedControl__uint

        // Methods

        /// <summary>
        /// <code>Offset: 0x0068E3B0
        /// bool __thiscall CInputMap::ActionBindingList::FindBestMatch(CInputMap::ActionBindingList*,const QualifiedControl*,unsigned int*,QualifiedControl*)</code>
        /// </summary>
        public byte FindBestMatch(ACBindings.Internal.QualifiedControl* i_key, uint* o_data, ACBindings.Internal.QualifiedControl* o_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap.ActionBindingList, ACBindings.Internal.QualifiedControl*, uint*, ACBindings.Internal.QualifiedControl*, byte>)0x0068E3B0)(ref this, i_key, o_data, o_key);

        /// <summary>
        /// <code>Offset: 0x0068E420
        /// BOOL __thiscall CInputMap::ActionBindingList::FindConflictingControls(_DWORD*,QualifiedControl*,_DWORD*)</code>
        /// </summary>
        public byte FindConflictingControls(ACBindings.Internal.QualifiedControl* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap.ActionBindingList, ACBindings.Internal.QualifiedControl*, int*, byte>)0x0068E420)(ref this, a2, a3);
    }

    // Members
    public ACBindings.Internal.CMasterInputMap* m_pParent;
    public uint m_eInputMapID;
    public ACBindings.Internal.CInputMap.ActionBindingList m_listMappings;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0068E1F0
    /// bool __thiscall CInputMap::ToFileNode(CInputMap*,PFileNode*)</code>
    /// </summary>
    public byte ToFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.PFileNode*, byte>)0x0068E1F0)(ref this, i_pNode);

    /// <summary>
    /// <code>Offset: 0x0068E540
    /// bool __thiscall CInputMap::FindBestMatch(CInputMap*,const QualifiedControl*,unsigned int*,QualifiedControl*)</code>
    /// </summary>
    public byte FindBestMatch(ACBindings.Internal.QualifiedControl* i_key, uint* o_idAction, ACBindings.Internal.QualifiedControl* o_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.QualifiedControl*, uint*, ACBindings.Internal.QualifiedControl*, byte>)0x0068E540)(ref this, i_key, o_idAction, o_key);

    /// <summary>
    /// <code>Offset: 0x0068E550
    /// BOOL __thiscall CInputMap::FindConflictingControls(_DWORD*,QualifiedControl*,_DWORD*)</code>
    /// </summary>
    public byte FindConflictingControls(ACBindings.Internal.QualifiedControl* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.QualifiedControl*, int*, byte>)0x0068E550)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0068E560
    /// char __thiscall CInputMap::FindKeysForAction(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    public sbyte FindKeysForAction(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, int, int*, sbyte>)0x0068E560)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0068F6B0
    /// bool __thiscall CInputMap::UnbindByKey(CInputMap*,QualifiedControl)</code>
    /// </summary>
    public byte UnbindByKey(ACBindings.Internal.QualifiedControl i_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.QualifiedControl, byte>)0x0068F6B0)(ref this, i_key);

    /// <summary>
    /// <code>Offset: 0x0068F950
    /// bool __thiscall CInputMap::UnbindAllByAction(CInputMap*,unsigned int)</code>
    /// </summary>
    public byte UnbindAllByAction(uint i_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, uint, byte>)0x0068F950)(ref this, i_id);

    /// <summary>
    /// <code>Offset: 0x0068FDB0
    /// void __thiscall CInputMap::Serialize(CInputMap*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.Archive*, void>)0x0068FDB0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0068FEE0
    /// bool __thiscall CInputMap::AddMapping(CInputMap*,unsigned int,QualifiedControl)</code>
    /// </summary>
    public byte AddMapping(uint id, ACBindings.Internal.QualifiedControl key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, uint, ACBindings.Internal.QualifiedControl, byte>)0x0068FEE0)(ref this, id, key);

    /// <summary>
    /// <code>Offset: 0x0068FFF0
    /// char __thiscall CInputMap::Merge(CInputMap*,int,int,char)</code>
    /// </summary>
    public sbyte Merge(int a2, int a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, int, int, sbyte, sbyte>)0x0068FFF0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00690300
    /// bool __thiscall CInputMap::FromFileNode(CInputMap*,const PFileNode*)</code>
    /// </summary>
    public byte FromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.PFileNode*, byte>)0x00690300)(ref this, i_pNode);
}

