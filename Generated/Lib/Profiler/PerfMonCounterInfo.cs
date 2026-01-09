namespace ACBindings;

// PerfMonCounterInfo
public unsafe struct PerfMonCounterInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // PerfMonCounterInfo_vtbl
    public unsafe struct PerfMonCounterInfo_vtbl
    {
        // Members
        public System.IntPtr PerfMonCounterInfo_dtor_0; // function pointer
        public System.IntPtr GetValueAsInt64; // function pointer
        public System.IntPtr LookupByLanguage;

        // Methods
    }
    // PerfMonCounterInfo::EPerfCounterType
    public enum EPerfCounterType : byte
    {
        NORMAL = 0x0,
        NORMAL_HEX = 0x1,
        PER_SEC = 0x2
    }
    // PerfMonCounterInfo::PerfMonCounterNameHelp
    public unsafe struct PerfMonCounterNameHelp : System.IDisposable
    {
        // Members
        public ushort m_languageID;
        public ACBindings.PStringBase__ushort m_name;
        public ACBindings.PStringBase__ushort m_help;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods
        // void __thiscall PerfMonCounterInfo::PerfMonCounterNameHelp::~PerfMonCounterNameHelp(PerfMonCounterInfo::PerfMonCounterNameHelp*)
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterInfo.PerfMonCounterNameHelp, void>)0x00541F40)(ref this);
    }

    // Members
    public uint m_CounterType;
    public ACBindings.List__PerfMonCounterInfo_PerfMonCounterNameHelp m_CounterNamesList;
    public byte m_fCounterExistedPreviously;

    // Generated Constructor
    public PerfMonCounterInfo(int a2, int* a3, int* a4, short a5) {
        _ConstructorInternal(a2, a3, a4, a5);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall PerfMonCounterInfo::~PerfMonCounterInfo(PerfMonCounterInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterInfo, void>)0x00542300)(ref this);
    // int __cdecl PerfMonCounterInfo::LookupExistingCounterByName(const wchar_t**,int)
    public static int LookupExistingCounterByName(System.IntPtr a1, int a2) => ((delegate* unmanaged[Cdecl]<System.IntPtr, int, int>)0x00683A80)(a1, a2);
    // void** __thiscall PerfMonCounterInfo::GetFirstName(_DWORD*,void**,_WORD*)
    public void** GetFirstName(void** a2, System.IntPtr a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterInfo, void**, System.IntPtr, void**>)0x00683AF0)(ref this, a2, a3);
    // char __thiscall PerfMonCounterInfo::LookupByLanguage(_DWORD*,unsigned __int16,void**)
    public sbyte LookupByLanguage(ushort a2, void** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterInfo, ushort, void**, sbyte>)0x00683B40)(ref this, a2, a3);
    // char __thiscall PerfMonCounterInfo::AddLanguageNameAndHelp(_DWORD*,__int16,int*,int*)
    public sbyte AddLanguageNameAndHelp(short a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterInfo, short, int*, int*, sbyte>)0x00683DA0)(ref this, a2, a3, a4);
    // PerfMonCounterInfo* __thiscall PerfMonCounterInfo::PerfMonCounterInfo(PerfMonCounterInfo*,int,int*,int*,__int16)
    public ACBindings.PerfMonCounterInfo* _ConstructorInternal(int a2, int* a3, int* a4, short a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerfMonCounterInfo, int, int*, int*, short, ACBindings.PerfMonCounterInfo*>)0x00683E60)(ref this, a2, a3, a4, a5);
}

