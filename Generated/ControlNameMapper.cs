namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0068B800
    /// PStringBase&lt;char&gt;* __thiscall ControlNameMapper::GetNameBySemantic(_DWORD*,PStringBase&lt;char&gt;*,int,void*)</code>
    /// </summary>
    public ACBindings.Internal.PStringBase__sbyte* GetNameBySemantic(ACBindings.Internal.PStringBase__sbyte* a2, int a3, System.IntPtr a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, ACBindings.Internal.PStringBase__sbyte*, int, System.IntPtr, ACBindings.Internal.PStringBase__sbyte*>)0x0068B800)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x0068BD50
    /// int __thiscall ControlNameMapper::GetSemanticByName(_DWORD*,char**)</code>
    /// </summary>
    public int GetSemanticByName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, sbyte**, int>)0x0068BD50)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0068C560
    /// void __thiscall ControlNameMapper::AddKeySemantic(ControlNameMapper*,const char*,unsigned int)</code>
    /// </summary>
    public void AddKeySemantic(sbyte* pszName, uint dwValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, sbyte*, uint, void>)0x0068C560)(ref this, pszName, dwValue);

    /// <summary>
    /// <code>Offset: 0x0068C680
    /// void __thiscall ControlNameMapper::~ControlNameMapper(ControlNameMapper*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, void>)0x0068C680)(ref this);

    /// <summary>
    /// <code>Offset: 0x0068C770
    /// void __thiscall ControlNameMapper::LoadSemantics(ControlNameMapper*)</code>
    /// </summary>
    public void LoadSemantics() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, void>)0x0068C770)(ref this);

    /// <summary>
    /// <code>Offset: 0x0068D5B0
    /// void __thiscall ControlNameMapper::ControlNameMapper(ControlNameMapper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlNameMapper, void>)0x0068D5B0)(ref this);
}

