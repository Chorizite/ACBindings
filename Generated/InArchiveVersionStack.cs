namespace ACBindings;

// InArchiveVersionStack
public unsafe struct InArchiveVersionStack : System.IDisposable
{
    // Base Classes
    public ACBindings.IArchiveVersionStack BaseClass_IArchiveVersionStack; // ACBindings.IArchiveVersionStack

    // Child Types
    // InArchiveVersionStack_vtbl
    public unsafe struct InArchiveVersionStack_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetVersionByToken; // function pointer
        public System.IntPtr SetVersion; // function pointer
        public fixed byte gap20[4];
        public System.IntPtr PushVersionRow;
        public System.IntPtr PopVersionRow;
        public System.IntPtr GetRowByHandle;
        public System.IntPtr GetCurrentVersionHandle;
        public System.IntPtr Reset; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // InArchiveVersionStack::Enum3
    public enum Enum3 : uint
    {
    }
    // InArchiveVersionStack::VersionRowHolder
    public unsafe struct VersionRowHolder
    {
        // Base Classes
        public ACBindings.IntrusiveHashListData__IDClass___tagVersionHandle__InArchiveVersionStack_VersionRowHolder_ptr BaseClass_IntrusiveHashListData; // ACBindings.IntrusiveHashListData__IDClass___tagVersionHandle__InArchiveVersionStack_VersionRowHolder_ptr

        // Members
        public ACBindings.ArchiveVersionRow m_VersionRow;

        // Methods
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.IntrusiveHashList__IDClass___tagVersionHandle__InArchiveVersionStack_VersionRowHolder_ptr m_hlVersions;
    public ACBindings.InArchiveVersionStack.VersionRowHolder m_vrDefaultRow;
    public uint m_iLastSerialNumber;

    // Generated Constructor
    public InArchiveVersionStack() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall InArchiveVersionStack::InArchiveVersionStack(InArchiveVersionStack*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, void>)0x0040AE30)(ref this);
    // unsigned int __thiscall InArchiveVersionStack::AddRef(InArchiveVersionStack*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, uint>)0x0040AEB0)(ref this);
    // unsigned int __thiscall InArchiveVersionStack::Release(InArchiveVersionStack*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, uint>)0x0040AEC0)(ref this);
    // DialogBoxGateway::ThisFunctionHasBeenRenamed __thiscall InArchiveVersionStack::You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy(DialogBoxGateway*)
    public ACBindings.DialogBoxGateway.ThisFunctionHasBeenRenamed You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, ACBindings.DialogBoxGateway.ThisFunctionHasBeenRenamed>)0x0040E710)(ref this);
    // TResult* __thiscall InArchiveVersionStack::QueryInterface(InArchiveVersionStack*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rInterfaceType, void** o_pOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x004108D0)(ref this, result, i_rInterfaceType, o_pOutInterface);
    // unsigned int __thiscall InArchiveVersionStack::GetVersionByToken(InArchiveVersionStack*,unsigned int)
    public uint GetVersionByToken(uint i_tokVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, uint, uint>)0x00410970)(ref this, i_tokVersion);
    // bool __thiscall InArchiveVersionStack::SetVersion(InArchiveVersionStack*,unsigned int,unsigned int)
    public byte SetVersion(uint i_tokVersion, uint i_iVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, uint, uint, byte>)0x004109A0)(ref this, i_tokVersion, i_iVersion);
    // unsigned int* __thiscall InArchiveVersionStack::GetCurrentVersionHandle(_DWORD*,unsigned int*)
    public uint* GetCurrentVersionHandle(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, uint*, uint*>)0x004109D0)(ref this, a2);
    // char __thiscall InArchiveVersionStack::GetRowByHandle(_DWORD*,unsigned int,_DWORD*)
    public sbyte GetRowByHandle(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, uint, int*, sbyte>)0x00410AF0)(ref this, a2, a3);
    // DLListData** __thiscall InArchiveVersionStack::PushVersionRow(int,DLListData**)
    public ACBindings.DLListData** PushVersionRow(ACBindings.DLListData** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, ACBindings.DLListData**, ACBindings.DLListData**>)0x00410D40)(ref this, a2);
    // DLListData** __thiscall InArchiveVersionStack::PushVersionRow(_DWORD*,DLListData**,int)
    public ACBindings.DLListData** PushVersionRow(ACBindings.DLListData** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, ACBindings.DLListData**, int, ACBindings.DLListData**>)0x00410DE0)(ref this, a2, a3);
    // char __thiscall InArchiveVersionStack::PopVersionRow(int,int)
    public sbyte PopVersionRow(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, int, sbyte>)0x00410F30)(ref this, a2);
    // void __thiscall InArchiveVersionStack::Reset(InArchiveVersionStack*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, void>)0x00410F90)(ref this);
    // void __thiscall InArchiveVersionStack::~InArchiveVersionStack(InArchiveVersionStack*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InArchiveVersionStack, void>)0x004110C0)(ref this);
}

