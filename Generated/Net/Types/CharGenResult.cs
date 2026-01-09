namespace ACBindings;

// CharGenResult
public unsafe struct CharGenResult
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CharGenResult_vtbl
    public unsafe struct CharGenResult_vtbl
    {
        // Members
        public System.IntPtr CharGenResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr GetName;
        public System.IntPtr SetName;
        public System.IntPtr GetSlot; // function pointer
        public System.IntPtr GetClassID;
        public System.IntPtr GetStartArea; // function pointer
        public System.IntPtr IsAdmin; // function pointer
        public System.IntPtr IsEnvoy; // function pointer
        public System.IntPtr VerifyCharacterGenerationResult; // function pointer

        // Methods
    }

    // Methods
}

