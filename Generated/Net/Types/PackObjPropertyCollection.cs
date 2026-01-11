namespace ACBindings.Internal;

public unsafe struct PackObjPropertyCollection
{
    // Base Classes
    public ACBindings.Internal.PackUsingSerialize___PackObj BaseClass_PackUsingSerialize; // ACBindings.Internal.PackUsingSerialize___PackObj
    public ACBindings.Internal.PropertyCollection BaseClass_PropertyCollection; // ACBindings.Internal.PropertyCollection

    // Child Types
    public unsafe struct PackObjPropertyCollection_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, void> PackObjPropertyCollection_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D60D0
    /// void __thiscall PackObjPropertyCollection::Serialize(PackObjPropertyCollection*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PackObjPropertyCollection, ACBindings.Internal.Archive*, void>)0x005D60D0)(ref this, io_archive);
}

