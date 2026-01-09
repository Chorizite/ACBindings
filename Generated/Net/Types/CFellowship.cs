namespace ACBindings;

// CFellowship
public unsafe struct CFellowship
{
    // Base Classes
    public ACBindings.Fellowship BaseClass_Fellowship; // ACBindings.Fellowship

    // Child Types
    // CFellowship_vtbl
    public unsafe struct CFellowship_vtbl
    {
        // Members
        public System.IntPtr CFellowship_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CFellowship() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CFellowship::CFellowship(CFellowship*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CFellowship, void>)0x0059B570)(ref this);
}

