namespace ACBindings;

// ControlNameMapper
public unsafe struct ControlNameMapper : System.IDisposable
{
    // Members
    public ACBindings.HashTable__PStringBase__sbyte__uint m_hashKeyboardSemantics;
    public ACBindings.HashTable__PStringBase__sbyte__uint m_hashMouseSemantics;
    public ACBindings.HashTable__PStringBase__sbyte__uint m_hashJoystickSemantics;
    public ACBindings.HashTable__PStringBase__sbyte__uint m_hashVirtualSemantics;

    // Generated Constructor
    public ControlNameMapper() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // PStringBase<char>* __thiscall ControlNameMapper::GetNameBySemantic(_DWORD*,PStringBase<char>*,int,void*)
    public ACBindings.PStringBase__sbyte* GetNameBySemantic(ACBindings.PStringBase__sbyte* a2, int a3, System.IntPtr a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlNameMapper, ACBindings.PStringBase__sbyte*, int, System.IntPtr, ACBindings.PStringBase__sbyte*>)0x0068B800)(ref this, a2, a3, a4);
    // int __thiscall ControlNameMapper::GetSemanticByName(_DWORD*,char**)
    public int GetSemanticByName(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlNameMapper, sbyte**, int>)0x0068BD50)(ref this, a2);
    // void __thiscall ControlNameMapper::AddKeySemantic(ControlNameMapper*,const char*,unsigned int)
    public void AddKeySemantic(sbyte* pszName, uint dwValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlNameMapper, sbyte*, uint, void>)0x0068C560)(ref this, pszName, dwValue);
    // void __thiscall ControlNameMapper::~ControlNameMapper(ControlNameMapper*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlNameMapper, void>)0x0068C680)(ref this);
    // void __thiscall ControlNameMapper::LoadSemantics(ControlNameMapper*)
    public void LoadSemantics() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlNameMapper, void>)0x0068C770)(ref this);
    // void __thiscall ControlNameMapper::ControlNameMapper(ControlNameMapper*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ControlNameMapper, void>)0x0068D5B0)(ref this);
}

