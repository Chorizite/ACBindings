namespace ACBindings.Internal;


/// <summary>Represents a UI region that displays and manages a single stat type, updating its visual components in response to quality changes.</summary>
public unsafe struct InfoRegion : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct InfoRegion_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, void> InfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, byte> Update; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.StatType m_StatType;
    public ACBindings.Internal.UIElement* m_pElement;
    public ACBindings.Internal.UIElement_Text* m_pLabelText;
    public ACBindings.Internal.UIElement_Text* m_pValueText;

    // Generated Constructor
    public InfoRegion(ACBindings.Internal.UIElement_ListBox* a2, int here, int i_id, ACBindings.Internal.StatType a5, int a6, uint a7) {
        _ConstructorInternal(a2, here, i_id, a5, a6, a7);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destructs an InfoRegion instance, resetting its base class virtual table and unregistering it from the global QualityRegistrar.
    /// <code>Offset: 0x004F1B00
    /// void __thiscall InfoRegion::~InfoRegion(InfoRegion*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, void>)0x004F1B00)(ref this);

    /// <summary>Returns a vita‑modifier associated with the specified enchantment for this info region, currently always zero.
    /// <code>Offset: 0x004F1B30
    /// int __thiscall InfoRegion::GetVitaeModifier(Spell*,Enchantment*)</code>
    /// </summary>
    /// <param name="e">The enchantment whose vitae modifier is requested.</param>
    /// <returns>An integer, presently 0, representing the vita‑modifier.</returns>
    public int GetVitaeModifier(ACBindings.Internal.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, ACBindings.Internal.Enchantment*, int>)0x004F1B30)(ref this, e);

    /// <summary>Notifies the UI of a quality removal by first retrieving the current stat value, broadcasting it to the associated element, and then delegating to the base handler for further processing.
    /// <code>Offset: 0x004F1B40
    /// void __thiscall InfoRegion::OnQualityRemoved(InfoRegion*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004F1B40)(ref this, cwobj, stype, senum);

    /// <summary>Forwards the specified state to the region's UI element by invoking its input action callback, returning success status.
    /// <code>Offset: 0x004F1B70
    /// bool __thiscall InfoRegion::SetState(InfoRegion*,unsigned int)</code>
    /// </summary>
    /// <param name="state">The new state value to apply.</param>
    /// <returns>True if an associated UI element handled the state change; otherwise, false.</returns>
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, uint, byte>)0x004F1B70)(ref this, state);

    /// <summary>Assigns a new identifier to the info region, updating its UI element and managing property references.
    /// <code>Offset: 0x004F1CF0
    /// void __thiscall InfoRegion::SetID(InfoRegion*,int)</code>
    /// </summary>
    /// <param name="i_id">The identifier value to set on the region.</param>
    public void SetID(int i_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, int, void>)0x004F1CF0)(ref this, i_id);

    /// <summary>Initializes an InfoRegion with the specified stat type, optionally adding it to a list box and creating associated label/value text elements, setting an optional image, and assigning an identifier.
    /// <code>Offset: 0x004F20B0
    /// InfoRegion* __thiscall InfoRegion::InfoRegion(InfoRegion*,UIElement_ListBox*,int,int,StatType,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The UIElement_ListBox to which this region will be added; if null, no UI element is created.</param>
    /// <param name="here">Index at which the item should be inserted in the list box (-1 indicates append); ignored when a2 is null.</param>
    /// <param name="i_id">Identifier assigned to this InfoRegion via SetID.</param>
    /// <param name="a5">StatType value stored as m_StatType for this region.</param>
    /// <param name="a6">Unspecified parameter currently unused; reserved for future extensions.</param>
    /// <param name="a7">DID of an optional image to set on a child element (ID 0x10000129); ignored if INVALID_DID_185 or not found.</param>
    /// <returns>The constructed InfoRegion instance (this pointer).</returns>
    public ACBindings.Internal.InfoRegion* _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int here, int i_id, ACBindings.Internal.StatType a5, int a6, uint a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, ACBindings.Internal.StatType, int, uint, ACBindings.Internal.InfoRegion*>)0x004F20B0)(ref this, a2, here, i_id, a5, a6, a7);

    /// <summary>Updates the displayed information for this region by retrieving the player’s descriptor and invoking the associated quality‑change handler.
    /// <code>Offset: 0x004F2940
    /// bool __thiscall InfoRegion::Update(InfoRegion*)</code>
    /// </summary>
    /// <returns>True if the update succeeded; otherwise, false.</returns>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InfoRegion, byte>)0x004F2940)(ref this);
}

