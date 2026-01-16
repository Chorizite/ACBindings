namespace ACBindings.Internal;


/// <summary>Associates input controls with actions within a specific input configuration, maintaining a list of bindings for runtime lookup and conflict resolution.</summary>
public unsafe struct CInputMap
{
    // Child Types

    /// <summary>Manages a collection of input bindings for actions, enabling efficient lookup and conflict detection among qualified controls.</summary>
    public unsafe struct ActionBindingList
    {
        // Base Classes
        public ACBindings.Internal.HashList___QualifiedControl__uint BaseClass_HashList; // ACBindings.Internal.HashList___QualifiedControl__uint

        // Methods

        /// <summary>Finds the most suitable action binding for the specified key within the map, returning both the matched control and its associated data. Returns true when a match exists; otherwise, false.
        /// <code>Offset: 0x0068E3B0
        /// bool __thiscall CInputMap::ActionBindingList::FindBestMatch(CInputMap::ActionBindingList*,const QualifiedControl*,unsigned int*,QualifiedControl*)</code>
        /// </summary>
        /// <param name="i_key">Search criteria used to locate candidate bindings in the list.</param>
        /// <param name="o_data">Outputs additional data (e.g., an identifier) from the selected binding.</param>
        /// <param name="o_key">Receives the best‑matching QualifiedControl instance.</param>
        /// <returns>True if a matching binding was found; otherwise, false.</returns>
        public byte FindBestMatch(ACBindings.Internal.QualifiedControl* i_key, uint* o_data, ACBindings.Internal.QualifiedControl* o_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap.ActionBindingList, ACBindings.Internal.QualifiedControl*, uint*, ACBindings.Internal.QualifiedControl*, byte>)0x0068E3B0)(ref this, i_key, o_data, o_key);

        /// <summary>
        /// Finds all bindings in the action binding list that conflict with a specified control and stores them in an array.
        /// 
        /// <code>Offset: 0x0068E420
        /// BOOL __thiscall CInputMap::ActionBindingList::FindConflictingControls(_DWORD*,QualifiedControl*,_DWORD*)</code>
        /// </summary>
        /// <param name="a2">The control to check for conflicts against existing bindings.</param>
        /// <param name="a3">
        /// An output buffer initialized by the caller. After execution, it contains zero or more conflicting controls; its third element (index 2) holds the number of entries added.
        /// </param>
        /// <returns>True if at least one conflicting binding was found; otherwise false.</returns>
        public byte FindConflictingControls(ACBindings.Internal.QualifiedControl* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap.ActionBindingList, ACBindings.Internal.QualifiedControl*, int*, byte>)0x0068E420)(ref this, a2, a3);
    }

    // Members
    public ACBindings.Internal.CMasterInputMap* m_pParent;
    public uint m_eInputMapID;
    public ACBindings.Internal.CInputMap.ActionBindingList m_listMappings;

    // Methods

    /// <summary>Serializes the input map's action bindings into a file node hierarchy, adding each mapping as a sub‑node under the supplied root node.
    /// <code>Offset: 0x0068E1F0
    /// bool __thiscall CInputMap::ToFileNode(CInputMap*,PFileNode*)</code>
    /// </summary>
    /// <param name="i_pNode">Root file node to which the serialized mappings are added.</param>
    /// <returns>True if all mappings were written successfully; false if any write operation failed.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.PFileNode*, byte>)0x0068E1F0)(ref this, i_pNode);

    /// <summary>Locates the most appropriate action binding that matches the supplied qualified control and outputs the corresponding action identifier and bound control.
    /// <code>Offset: 0x0068E540
    /// bool __thiscall CInputMap::FindBestMatch(CInputMap*,const QualifiedControl*,unsigned int*,QualifiedControl*)</code>
    /// </summary>
    /// <param name="i_key">The input qualified control to be matched against the map's bindings.</param>
    /// <param name="o_idAction">Receives the identifier of the best‑matching action if one is found.</param>
    /// <param name="o_key">Receives a copy of the qualified key that produced the match; remains unchanged when no match is found.</param>
    /// <returns>True when a matching binding is located; otherwise false.</returns>
    public byte FindBestMatch(ACBindings.Internal.QualifiedControl* i_key, uint* o_idAction, ACBindings.Internal.QualifiedControl* o_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.QualifiedControl*, uint*, ACBindings.Internal.QualifiedControl*, byte>)0x0068E540)(ref this, i_key, o_idAction, o_key);

    /// <summary>Determines whether the specified control conflicts with any bindings in this input map and optionally returns information about the conflicting mapping.
    /// <code>Offset: 0x0068E550
    /// BOOL __thiscall CInputMap::FindConflictingControls(_DWORD*,QualifiedControl*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The control specification to test for conflicts.</param>
    /// <param name="a3">Receives details of a conflicting binding, if one exists.</param>
    /// <returns>True if a conflict is found; otherwise false.</returns>
    public byte FindConflictingControls(ACBindings.Internal.QualifiedControl* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.QualifiedControl*, int*, byte>)0x0068E550)(ref this, a2, a3);

    /// <summary>Collects all key bindings associated with the specified action ID into the supplied list.
    /// <code>Offset: 0x0068E560
    /// char __thiscall CInputMap::FindKeysForAction(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="actionId">Identifier of the action whose key bindings are sought.</param>
    /// <param name="outputList">Array to receive pointers to newly allocated binding nodes; fields: head, tail, and count of matched entries.</param>
    /// <returns>Non‑zero if at least one mapping was found; otherwise zero.</returns>
    public sbyte FindKeysForAction(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, int, int*, sbyte>)0x0068E560)(ref this, a2, a3);

    /// <summary>Detaches the specified qualified control from the input map’s binding list.
    /// <code>Offset: 0x0068F6B0
    /// bool __thiscall CInputMap::UnbindByKey(CInputMap*,QualifiedControl)</code>
    /// </summary>
    /// <param name="i_key">Control specification, metamode and activation identifying the binding to remove.</param>
    /// <returns>True when a binding was found and removed; otherwise false.</returns>
    public byte UnbindByKey(ACBindings.Internal.QualifiedControl i_key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.QualifiedControl, byte>)0x0068F6B0)(ref this, i_key);

    /// <summary>Removes all input bindings associated with a specified action identifier from this input map.
    /// <code>Offset: 0x0068F950
    /// bool __thiscall CInputMap::UnbindAllByAction(CInputMap*,unsigned int)</code>
    /// </summary>
    /// <param name="i_id">The unique identifier of the action whose bindings should be removed.</param>
    /// <returns>True if one or more bindings were removed; otherwise, false.</returns>
    public byte UnbindAllByAction(uint i_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, uint, byte>)0x0068F950)(ref this, i_id);

    /// <summary>Serializes the input map's action binding list to or from the supplied archive, handling element counts and node links based on archive flags.
    /// <code>Offset: 0x0068FDB0
    /// void __thiscall CInputMap::Serialize(CInputMap*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading or writing the input map data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.Archive*, void>)0x0068FDB0)(ref this, io_archive);

    /// <summary>Attempts to register a control mapping through the global input map manager; if that fails or is unavailable, stores the mapping in this object’s local list.
    /// <code>Offset: 0x0068FEE0
    /// bool __thiscall CInputMap::AddMapping(CInputMap*,unsigned int,QualifiedControl)</code>
    /// </summary>
    /// <param name="id">The identifier associated with the mapping when stored locally.</param>
    /// <param name="key">The QualifiedControl describing the input specification, metamode, and activation.</param>
    /// <returns>True if the mapping was added to the local list; false if it was successfully registered globally or on failure.</returns>
    public byte AddMapping(uint id, ACBindings.Internal.QualifiedControl key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, uint, ACBindings.Internal.QualifiedControl, byte>)0x0068FEE0)(ref this, id, key);

    /// <summary>Copies all action bindings from a source input map into this map. If the force flag is set, continues adding remaining bindings even if an individual add fails.
    /// <code>Offset: 0x0068FFF0
    /// char __thiscall CInputMap::Merge(CInputMap*,int,int,char)</code>
    /// </summary>
    /// <param name="this">Target input map that will receive the merged bindings.</param>
    /// <param name="a2">Source input map from which to copy bindings.</param>
    /// <param name="a3">Unused parameter.</param>
    /// <param name="a4">When non‑zero, forces the merge to continue after a failed add operation.</param>
    /// <returns>True (1) if all bindings were added successfully or no bindings existed; false (0) if an add failed and the force flag was not set.</returns>
    public sbyte Merge(int a2, int a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, int, int, sbyte, sbyte>)0x0068FFF0)(ref this, a2, a3, a4);

    /// <summary>Parses an input map configuration from the provided file node and populates the CInputMap's action bindings.
    /// <code>Offset: 0x00690300
    /// bool __thiscall CInputMap::FromFileNode(CInputMap*,const PFileNode*)</code>
    /// </summary>
    /// <param name="this">The CInputMap instance to populate.</param>
    /// <param name="i_pNode">File node containing mapping definitions.</param>
    /// <returns>True if all mappings were successfully added; otherwise false when an error occurs or the node is null.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputMap, ACBindings.Internal.PFileNode*, byte>)0x00690300)(ref this, i_pNode);
}

