namespace ACBindings;

// ACWTimeStamper
public unsafe struct ACWTimeStamper
{
    // Base Classes
    public ACBindings.WTimeStamper BaseClass_WTimeStamper; // ACBindings.WTimeStamper

    // Child Types
    // ACWTimeStamper_vtbl
    public unsafe struct ACWTimeStamper_vtbl
    {
        // Members
        public System.IntPtr ACWTimeStamper_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public ACWTimeStamper() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall ACWTimeStamper::ACWTimeStamper(ACWTimeStamper*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACWTimeStamper, void>)0x005BE470)(ref this);
}

