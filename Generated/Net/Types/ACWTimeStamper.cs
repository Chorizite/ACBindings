namespace ACBindings.Internal;

public unsafe struct ACWTimeStamper
{
    // Base Classes
    public ACBindings.Internal.WTimeStamper BaseClass_WTimeStamper; // ACBindings.Internal.WTimeStamper

    // Child Types
    public unsafe struct ACWTimeStamper_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACWTimeStamper*, void> ACWTimeStamper_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACWTimeStamper*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACWTimeStamper*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACWTimeStamper*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public ACWTimeStamper() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BE470
    /// void __thiscall ACWTimeStamper::ACWTimeStamper(ACWTimeStamper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACWTimeStamper, void>)0x005BE470)(ref this);
}

