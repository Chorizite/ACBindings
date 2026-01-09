namespace ACBindings;

// Attribute2ndBase
public unsafe struct Attribute2ndBase
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Attribute2ndBase_vtbl
    public unsafe struct Attribute2ndBase_vtbl
    {
        // Members
        public System.IntPtr Attribute2ndBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SkillFormula _formula;

    // Methods
}

