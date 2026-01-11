namespace ACBindings.Internal;

public unsafe struct CObjectInventory : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct CObjectInventory_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectInventory*, void> CObjectInventory_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDList _itemsList;
    public ACBindings.Internal.IDList _containersList;
    public ACBindings.Internal.PackableList___InventoryPlacement _invPlacement;

    // Generated Constructor
    public CObjectInventory(uint objectID) {
        _ConstructorInternal(objectID);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B5BC0
    /// void __thiscall CObjectInventory::CObjectInventory(CObjectInventory*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectInventory, uint, void>)0x006B5BC0)(ref this, objectID);

    /// <summary>
    /// <code>Offset: 0x006B5C00
    /// void __thiscall CObjectInventory::~CObjectInventory(CObjectInventory*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectInventory, void>)0x006B5C00)(ref this);
}

