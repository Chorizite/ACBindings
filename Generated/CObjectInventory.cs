namespace ACBindings.Internal;


/// <summary>
/// Represents an inventory container for a game object, maintaining separate lists of contained items and subcontainers while tracking placement information.
/// </summary>
public unsafe struct CObjectInventory : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct CObjectInventory_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjectInventory*, void> CObjectInventory_dtor_0; // function pointer

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

    /// <summary>Constructs a CObjectInventory, assigning it the supplied ID and initializing all internal data structures.
    /// <code>Offset: 0x006B5BC0
    /// void __thiscall CObjectInventory::CObjectInventory(CObjectInventory*,unsigned int)</code>
    /// </summary>
    /// <param name="objectID">Unique identifier for the new inventory instance.</param>
    public void _ConstructorInternal(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectInventory, uint, void>)0x006B5BC0)(ref this, objectID);

    /// <summary>Destroys an instance of CObjectInventory, clearing its item and container lists and resetting internal data structures.
    /// <code>Offset: 0x006B5C00
    /// void __thiscall CObjectInventory::~CObjectInventory(CObjectInventory*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjectInventory, void>)0x006B5C00)(ref this);
}

