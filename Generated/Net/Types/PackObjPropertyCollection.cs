namespace ACBindings;

// PackObjPropertyCollection
public unsafe struct PackObjPropertyCollection
{
    // Base Classes
    public ACBindings.PackUsingSerialize__PackObj BaseClass_PackUsingSerialize; // ACBindings.PackUsingSerialize__PackObj
    public ACBindings.PropertyCollection BaseClass_PropertyCollection; // ACBindings.PropertyCollection

    // Child Types
    // PackObjPropertyCollection_vtbl
    public unsafe struct PackObjPropertyCollection_vtbl
    {
        // Members
        public System.IntPtr PackObjPropertyCollection_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Methods
    // void __thiscall PackObjPropertyCollection::Serialize(PackObjPropertyCollection*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PackObjPropertyCollection, ACBindings.Archive*, void>)0x005D60D0)(ref this, io_archive);
}

