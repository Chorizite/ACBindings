namespace ACBindings;

// CObjectInventory
public unsafe struct CObjectInventory : System.IDisposable
{
    // Base Classes
    public ACBindings.LongHashData BaseClass_LongHashData; // ACBindings.LongHashData

    // Child Types
    // CObjectInventory_vtbl
    public unsafe struct CObjectInventory_vtbl
    {
        // Members
        public System.IntPtr CObjectInventory_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDList _itemsList;
    public ACBindings.IDList _containersList;
    public ACBindings.PackableList__InventoryPlacement _invPlacement;

    // Generated Constructor
    public CObjectInventory(uint objectID) {
        _ConstructorInternal(objectID);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CObjectInventory::CObjectInventory(CObjectInventory*,unsigned int)
    public void _ConstructorInternal(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectInventory, uint, void>)0x006B5BC0)(ref this, objectID);
    // void __thiscall CObjectInventory::~CObjectInventory(CObjectInventory*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CObjectInventory, void>)0x006B5C00)(ref this);
}

