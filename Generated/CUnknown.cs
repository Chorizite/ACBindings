namespace ACBindings;

// CUnknown
public unsafe struct CUnknown
{
    // Base Classes
    public ACBindings.INonDelegatingUnknown BaseClass_INonDelegatingUnknown; // ACBindings.INonDelegatingUnknown

    // Child Types
    // CUnknown_vtbl
    public unsafe struct CUnknown_vtbl
    {
        // Members
        public System.IntPtr NonDelegatingQueryInterface; // function pointer
        public System.IntPtr NonDelegatingAddRef; // function pointer
        public System.IntPtr NonDelegatingRelease; // function pointer
        public System.IntPtr CUnknown_dtor_c; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IUnknown* m_pUnknown;
    public int m_cRef;

    // Generated Constructor
    public CUnknown(sbyte* pName, ACBindings.IUnknown* pUnk) {
        _ConstructorInternal(pName, pUnk);
    }

    // Methods
    // void __thiscall CUnknown::CUnknown(CUnknown*,const char*,IUnknown*)
    public void _ConstructorInternal(sbyte* pName, ACBindings.IUnknown* pUnk) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CUnknown, sbyte*, ACBindings.IUnknown*, void>)0x006C1EB0)(ref this, pName, pUnk);
    // unsigned int __stdcall CUnknown::NonDelegatingAddRef(CUnknown*)
    public static uint NonDelegatingAddRef(ACBindings.CUnknown* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.CUnknown*, uint>)0x006C1F30)(this_);
    // unsigned int __stdcall CUnknown::NonDelegatingRelease(CUnknown*)
    public static uint NonDelegatingRelease(ACBindings.CUnknown* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.CUnknown*, uint>)0x006C1F50)(this_);
}

