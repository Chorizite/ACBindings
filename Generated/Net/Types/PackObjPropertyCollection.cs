namespace ACBindings.Internal;


/// <summary>Combines a serializable pack object with its associated properties, enabling unified handling of data payloads and corresponding metadata. This structure serves as the core representation for objects that require both binary serialization and property management within the system.</summary>
public unsafe struct PackObjPropertyCollection
{
    // Base Classes
    public ACBindings.Internal.PackUsingSerialize___PackObj BaseClass_PackUsingSerialize; // ACBindings.Internal.PackUsingSerialize___PackObj
    public ACBindings.Internal.PropertyCollection BaseClass_PropertyCollection; // ACBindings.Internal.PropertyCollection

    // Child Types
    public unsafe struct PackObjPropertyCollection_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, void> PackObjPropertyCollection_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PackObjPropertyCollection*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Serializes the property collection of this PackObjPropertyCollection instance to or from an Archive.
    /// <code>Offset: 0x005D60D0
    /// void __thiscall PackObjPropertyCollection::Serialize(PackObjPropertyCollection*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization, which determines whether data is written to or read from the stream.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PackObjPropertyCollection, ACBindings.Internal.Archive*, void>)0x005D60D0)(ref this, io_archive);
}

