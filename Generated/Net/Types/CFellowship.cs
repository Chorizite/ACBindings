namespace ACBindings.Internal;

public unsafe struct CFellowship
{
    // Base Classes
    public ACBindings.Internal.Fellowship BaseClass_Fellowship; // ACBindings.Internal.Fellowship

    // Child Types
    public unsafe struct CFellowship_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFellowship*, void> CFellowship_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFellowship*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFellowship*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFellowship*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CFellowship() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0059B570
    /// void __thiscall CFellowship::CFellowship(CFellowship*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFellowship, void>)0x0059B570)(ref this);
}

