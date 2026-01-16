namespace ACBindings.Internal;


/// <summary>Associates input device control names with semantic identifiers across keyboards, mice, joysticks, and virtual devices, enabling consistent lookup and registration of controls.</summary>
public unsafe struct ControlNameMapper : System.IDisposable
{
    // Members
    public ACBindings.Internal.HashTable___PStringBase__sbyte__uint m_hashKeyboardSemantics;
    public ACBindings.Internal.HashTable___PStringBase__sbyte__uint m_hashMouseSemantics;
    public ACBindings.Internal.HashTable___PStringBase__sbyte__uint m_hashJoystickSemantics;
    public ACBindings.Internal.HashTable___PStringBase__sbyte__uint m_hashVirtualSemantics;

    // Generated Constructor
    public ControlNameMapper() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves a control name that matches the given semantic key and writes it into the provided string buffer.
    /// <code>Offset: 0x0068B800
    /// PStringBase&lt;char&gt;* __thiscall ControlNameMapper::GetNameBySemantic(_DWORD*,PStringBase&lt;char&gt;*,int,void*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ControlNameMapper instance.</param>
    /// <param name="a2">Output buffer that receives the found name or remains unchanged if no match is found (contains the null string).</param>
    /// <param name="a3">Semantic category identifier: 1 for keyboard, 2 for mouse, 3 for joystick; any other value returns a null string.</param>
    /// <param name="a4">Pointer to the semantic key used as the lookup key in the selected hash table.</param>
    /// <returns>Returns the same pointer supplied as a2 after updating its contents.</returns>
    public ACBindings.Internal.PStringBase__sbyte* GetNameBySemantic(ACBindings.Internal.PStringBase__sbyte* a2, int a3, System.IntPtr a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, ACBindings.Internal.PStringBase__sbyte*, int, System.IntPtr, ACBindings.Internal.PStringBase__sbyte*>)0x0068B800)(ref this, a2, a3, a4);

    /// <summary>Returns the semantic identifier associated with the supplied name by searching through keyboard, mouse, joystick, and virtual control mappings. If no match is found, a default lookup is performed and –1 is returned when the name cannot be resolved.
    /// <code>Offset: 0x0068BD50
    /// int __thiscall ControlNameMapper::GetSemanticByName(_DWORD*,char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to the null‑terminated string that names the desired semantic.</param>
    /// <returns>Integer representing the semantic ID; -1 if the name does not exist in any mapping.</returns>
    public int GetSemanticByName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, sbyte**, int>)0x0068BD50)(ref this, a2);

    /// <summary>Registers a semantic identifier and its corresponding value into the appropriate mapping table based on the prefix of the name.
    /// <code>Offset: 0x0068C560
    /// void __thiscall ControlNameMapper::AddKeySemantic(ControlNameMapper*,const char*,unsigned int)</code>
    /// </summary>
    /// <param name="pszName">The semantic identifier string to be added.</param>
    /// <param name="dwValue">The unsigned integer value associated with the semantic.</param>
    public void AddKeySemantic(sbyte* pszName, uint dwValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, sbyte*, uint, void>)0x0068C560)(ref this, pszName, dwValue);

    /// <summary>Destroys a ControlNameMapper instance by clearing all internal semantic hash tables and freeing any allocated bucket memory for keyboard, mouse, joystick, and virtual control mappings.
    /// <code>Offset: 0x0068C680
    /// void __thiscall ControlNameMapper::~ControlNameMapper(ControlNameMapper*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, void>)0x0068C680)(ref this);

    /// <summary>Populates the ControlNameMapper's hash tables with mappings between DirectInput key, mouse, and joystick names and their semantic identifiers for later input processing.
    /// <code>Offset: 0x0068C770
    /// void __thiscall ControlNameMapper::LoadSemantics(ControlNameMapper*)</code>
    /// </summary>
    public void LoadSemantics() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, void>)0x0068C770)(ref this);

    /// <summary>Initializes hash tables for keyboard, mouse, joystick, and virtual control semantics, then loads their contents via LoadSemantics.
    /// <code>Offset: 0x0068D5B0
    /// void __thiscall ControlNameMapper::ControlNameMapper(ControlNameMapper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, void>)0x0068D5B0)(ref this);
}

