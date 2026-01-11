namespace ACBindings.Internal;

public unsafe struct PerfMonCounterInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct PerfMonCounterInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterInfo*, void> PerfMonCounterInfo_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PerfMonCounterInfo*, long> GetValueAsInt64; // function pointer
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
    public unsafe struct PerfMonCounterNameHelp : System.IDisposable
    {
        // Members
        public ushort m_languageID;
        public ACBindings.Internal.PStringBase__ushort m_name;
        public ACBindings.Internal.PStringBase__ushort m_help;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods

        /// <summary>
        /// <code>Offset: 0x00541F40
        /// void __thiscall PerfMonCounterInfo::PerfMonCounterNameHelp::~PerfMonCounterNameHelp(PerfMonCounterInfo::PerfMonCounterNameHelp*)</code>
        /// </summary>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo.PerfMonCounterNameHelp, void>)0x00541F40)(ref this);
    }

    // Members
    public uint m_CounterType;
    public ACBindings.Internal.List___PerfMonCounterInfo_PerfMonCounterNameHelp m_CounterNamesList;
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

    /// <summary>
    /// <code>Offset: 0x00542300
    /// void __thiscall PerfMonCounterInfo::~PerfMonCounterInfo(PerfMonCounterInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, void>)0x00542300)(ref this);

    /// <summary>
    /// <code>Offset: 0x00683A80
    /// int __cdecl PerfMonCounterInfo::LookupExistingCounterByName(const wchar_t**,int)</code>
    /// </summary>
    public static int LookupExistingCounterByName(System.IntPtr a1, int a2) => ((delegate* unmanaged[Cdecl]<System.IntPtr, int, int>)0x00683A80)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00683AF0
    /// void** __thiscall PerfMonCounterInfo::GetFirstName(_DWORD*,void**,_WORD*)</code>
    /// </summary>
    public void** GetFirstName(void** a2, System.IntPtr a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, void**, System.IntPtr, void**>)0x00683AF0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00683B40
    /// char __thiscall PerfMonCounterInfo::LookupByLanguage(_DWORD*,unsigned __int16,void**)</code>
    /// </summary>
    public sbyte LookupByLanguage(ushort a2, void** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, ushort, void**, sbyte>)0x00683B40)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00683DA0
    /// char __thiscall PerfMonCounterInfo::AddLanguageNameAndHelp(_DWORD*,__int16,int*,int*)</code>
    /// </summary>
    public sbyte AddLanguageNameAndHelp(short a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, short, int*, int*, sbyte>)0x00683DA0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00683E60
    /// PerfMonCounterInfo* __thiscall PerfMonCounterInfo::PerfMonCounterInfo(PerfMonCounterInfo*,int,int*,int*,__int16)</code>
    /// </summary>
    public ACBindings.Internal.PerfMonCounterInfo* _ConstructorInternal(int a2, int* a3, int* a4, short a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerfMonCounterInfo, int, int*, int*, short, ACBindings.Internal.PerfMonCounterInfo*>)0x00683E60)(ref this, a2, a3, a4, a5);
}

