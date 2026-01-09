namespace ACBindings;

// CInvSlotModule
public unsafe struct CInvSlotModule : System.IDisposable
{
    // Members
    public ACBindings.CInvSlotInfo* neckSlot;
    public ACBindings.CInvSlotInfo* leftWristSlot;
    public ACBindings.CInvSlotInfo* leftRingSlot;
    public ACBindings.CInvSlotInfo* rightWristSlot;
    public ACBindings.CInvSlotInfo* rightRingSlot;
    public ACBindings.CInvSlotInfo* weaponReadySlot;
    public ACBindings.CInvSlotInfo* ammoReadySlot;
    public ACBindings.CInvSlotInfo* shieldReadySlot;
    public ACBindings.CInvSlotInfo* clothesPantsSlot;
    public ACBindings.CInvSlotInfo* clothesShirtSlot;
    public ACBindings.CInvSlotInfo* trinketOneSlot;
    public ACBindings.CInvSlotInfo* cloakSlot;
    public ACBindings.CInvSlotInfo* sigilOneSlot;
    public ACBindings.CInvSlotInfo* sigilTwoSlot;
    public ACBindings.CInvSlotInfo* sigilThreeSlot;
    public ACBindings.CInvSlotInfo* headSlot;
    public ACBindings.CInvSlotInfo* chestSlot;
    public ACBindings.CInvSlotInfo* abdomenSlot;
    public ACBindings.CInvSlotInfo* upperArmSlot;
    public ACBindings.CInvSlotInfo* lowerArmSlot;
    public ACBindings.CInvSlotInfo* handSlot;
    public ACBindings.CInvSlotInfo* upperLegSlot;
    public ACBindings.CInvSlotInfo* lowerLegSlot;
    public ACBindings.CInvSlotInfo* footSlot;

    // Generated Constructor
    public CInvSlotModule() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CInvSlotModule::CInvSlotModule(CInvSlotModule*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInvSlotModule, void>)0x0055E680)(ref this);
    // void __thiscall CInvSlotModule::Reset(CInvSlotModule*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInvSlotModule, void>)0x0055E9C0)(ref this);
    // void __thiscall CInvSlotModule::~CInvSlotModule(CInvSlotModule*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInvSlotModule, void>)0x0055F240)(ref this);
}

