namespace ACBindings.Internal;


/// <summary>Manages the user interface for examining spells, presenting details such as name, school, mana cost, range, duration, description, icon, and component list.</summary>
/// <remarks>Linked to gmExaminationUI; updates UI elements when a spell is selected and handles component ownership display.</remarks>
public unsafe struct SpellExamineUI
{
    // Base Classes
    public ACBindings.Internal.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.Internal.ExamineSubUI

    // Child Types
    public unsafe struct SpellExamineUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_spellExamineBaseField;
    public ACBindings.Internal.UIElement_Text* m_magicSchoolText;
    public ACBindings.Internal.UIElement_Text* m_spellManaText;
    public ACBindings.Internal.UIElement_Text* m_spellRangeText;
    public ACBindings.Internal.UIElement_Text* m_spellDurationText;
    public ACBindings.Internal.UIElement_Text* m_spellDisplayText;
    public ACBindings.Internal.UIElement* m_spellIcon;
    public ACBindings.Internal.UIElement_ListBox* m_formulaListBox;
    public uint cur_spellid;
    public int m_componentListX;
    public int m_componentListW;

    // Generated Constructor
    public SpellExamineUI(ACBindings.Internal.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods

    /// <summary>Initializes the spell examination UI, linking it to its parent examination interface and caching child UI elements such as text fields, icon, and formula list box for later use.
    /// <code>Offset: 0x004ABFD0
    /// void __thiscall SpellExamineUI::SpellExamineUI(SpellExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    /// <param name="parentElement">The examination UI that owns this sub‑UI instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, ACBindings.Internal.gmExaminationUI*, void>)0x004ABFD0)(ref this, parentElement);

    /// <summary>Removes all entries from the spell examination formula list box, clearing any displayed icons for this UI instance.
    /// <code>Offset: 0x004AC170
    /// void __thiscall SpellExamineUI::ClearIcons(SpellExamineUI*)</code>
    /// </summary>
    public void ClearIcons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, void>)0x004AC170)(ref this);

    /// <summary>Refreshes the spell component list displayed in the UI, updating each item’s icon state based on component ownership and invoking any associated action callbacks.
    /// <code>Offset: 0x004AC1A0
    /// void __thiscall SpellExamineUI::UpdateComponents(SpellExamineUI*,ComponentTrackerUpdate)</code>
    /// </summary>
    public void UpdateComponents(ACBindings.Internal.ComponentTrackerUpdate change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, ACBindings.Internal.ComponentTrackerUpdate, void>)0x004AC1A0)(ref this, change);

    /// <summary>Retrieves the object ID of a spell component by its component ID from the player's component tracker, returning zero if no matching component is found.
    /// <code>Offset: 0x004AC2E0
    /// unsigned int __thiscall SpellExamineUI::GetComponentObjectID(SpellExamineUI*,unsigned int)</code>
    /// </summary>
    /// <param name="scid">The identifier of the spell component to look up.</param>
    /// <returns>The first object ID associated with the specified component, or 0 when the component does not exist.</returns>
    public uint GetComponentObjectID(uint scid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, uint, uint>)0x004AC2E0)(ref this, scid);

    /// <summary>Computes the effective range of a spell for the current player by applying skill-based modifiers to the spell's base range, then limits the result to a maximum of 75 units.
    /// <code>Offset: 0x004AD7D0
    /// float __thiscall SpellExamineUI::DetermineSpellRange(SpellExamineUI*,CSpellBase*)</code>
    /// </summary>
    /// <param name="spellBase">The spell whose range is being evaluated.</param>
    /// <returns>The calculated spell range as a float.</returns>
    public float DetermineSpellRange(ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, ACBindings.Internal.CSpellBase*, float>)0x004AD7D0)(ref this, spellBase);

    /// <summary>Sets the spell's mana cost display text, formatting the base mana and optional per-target modifier.
    /// <code>Offset: 0x004B6A60
    /// void __thiscall SpellExamineUI::SetManaText(SpellExamineUI*,wchar_t*,int)</code>
    /// </summary>
    /// <param name="baseMana">The base mana cost to show; if null or zero displays 0.</param>
    /// <param name="manaMod">An additional mana amount added for each target; positive values are appended to the displayed text.</param>
    public void SetManaText(System.IntPtr baseMana, int manaMod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, System.IntPtr, int, void>)0x004B6A60)(ref this, baseMana, manaMod);

    /// <summary>Adds the specified text as a new line in the spell display field, inserting a newline before if content already exists.
    /// <code>Offset: 0x004B6C20
    /// void __thiscall SpellExamineUI::AddItemInfo(SpellExamineUI*,const char*)</code>
    /// </summary>
    /// <param name="txt">Text to append to the spell display UI element.</param>
    public void AddItemInfo(sbyte* txt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, sbyte*, void>)0x004B6C20)(ref this, txt);

    /// <summary>
    /// ExamineSpell loads the spell identified by spellid from the magic system and updates the examination UI with its name, school, mana cost, duration, range, description, icon, and component list. Returns 1 on success or 0 if spellid is zero or data cannot be retrieved.
    /// 
    /// <code>Offset: 0x004B6E30
    /// int __thiscall SpellExamineUI::ExamineSpell(SpellExamineUI*,const unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the SpellExamineUI instance.</param>
    /// <param name="spellid">Identifier of the spell to examine; must be non‑zero.</param>
    /// <returns>Non‑zero value if the UI was successfully updated, otherwise zero.</returns>
    public int ExamineSpell(uint spellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, uint, int>)0x004B6E30)(ref this, spellid);
}

