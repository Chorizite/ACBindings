namespace ACBindings;

// Body
public unsafe struct Body
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Body_vtbl
    public unsafe struct Body_vtbl
    {
        // Members
        public System.IntPtr Body_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__int__BodyPart _body_part_table;

    // Generated Constructor
    public Body() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall Body::Body(Body*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Body, void>)0x005905B0)(ref this);
    // int __thiscall Body::UnPack(Body*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Body, void**, uint, int>)0x005D2040)(ref this, addr, size);
}

