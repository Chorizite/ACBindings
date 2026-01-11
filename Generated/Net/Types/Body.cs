namespace ACBindings.Internal;

public unsafe struct Body
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Body_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, void> Body_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Body*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__int___BodyPart _body_part_table;

    // Generated Constructor
    public Body() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005905B0
    /// void __thiscall Body::Body(Body*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Body, void>)0x005905B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2040
    /// int __thiscall Body::UnPack(Body*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Body, void**, uint, int>)0x005D2040)(ref this, addr, size);
}

