namespace ACBindings.Internal;


/// <summary>
/// Manages individual inventory slots for a character, holding pointers to CInvSlotInfo objects that represent equipped items across all body locations.
/// </summary>
public unsafe struct CInvSlotModule : System.IDisposable
{
    // Members
    public ACBindings.Internal.CInvSlotInfo* neckSlot;
    public ACBindings.Internal.CInvSlotInfo* leftWristSlot;
    public ACBindings.Internal.CInvSlotInfo* leftRingSlot;
    public ACBindings.Internal.CInvSlotInfo* rightWristSlot;
    public ACBindings.Internal.CInvSlotInfo* rightRingSlot;
    public ACBindings.Internal.CInvSlotInfo* weaponReadySlot;
    public ACBindings.Internal.CInvSlotInfo* ammoReadySlot;
    public ACBindings.Internal.CInvSlotInfo* shieldReadySlot;
    public ACBindings.Internal.CInvSlotInfo* clothesPantsSlot;
    public ACBindings.Internal.CInvSlotInfo* clothesShirtSlot;
    public ACBindings.Internal.CInvSlotInfo* trinketOneSlot;
    public ACBindings.Internal.CInvSlotInfo* cloakSlot;
    public ACBindings.Internal.CInvSlotInfo* sigilOneSlot;
    public ACBindings.Internal.CInvSlotInfo* sigilTwoSlot;
    public ACBindings.Internal.CInvSlotInfo* sigilThreeSlot;
    public ACBindings.Internal.CInvSlotInfo* headSlot;
    public ACBindings.Internal.CInvSlotInfo* chestSlot;
    public ACBindings.Internal.CInvSlotInfo* abdomenSlot;
    public ACBindings.Internal.CInvSlotInfo* upperArmSlot;
    public ACBindings.Internal.CInvSlotInfo* lowerArmSlot;
    public ACBindings.Internal.CInvSlotInfo* handSlot;
    public ACBindings.Internal.CInvSlotInfo* upperLegSlot;
    public ACBindings.Internal.CInvSlotInfo* lowerLegSlot;
    public ACBindings.Internal.CInvSlotInfo* footSlot;

    // Generated Constructor
    public CInvSlotModule() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes an inventory slot module by allocating and configuring individual slot objects with default values for each equipment location.
    /// <code>Offset: 0x0055E680
    /// void __thiscall CInvSlotModule::CInvSlotModule(CInvSlotModule*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInvSlotModule, void>)0x0055E680)(ref this);

    /// <summary>Resets every equipment slot in the inventory module, clearing all assigned items by setting each slot’s item ID to zero.
    /// <code>Offset: 0x0055E9C0
    /// void __thiscall CInvSlotModule::Reset(CInvSlotModule*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInvSlotModule, void>)0x0055E9C0)(ref this);

    /// <summary>Releases all inventory slots owned by the module, deleting any allocated CInvSlotInfo objects and clearing member pointers.
    /// <code>Offset: 0x0055F240
    /// void __thiscall CInvSlotModule::~CInvSlotModule(CInvSlotModule*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInvSlotModule, void>)0x0055F240)(ref this);
}

