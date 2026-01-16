namespace ACBindings.Internal;


/// <summary>Handles displaying item information within the game's examination UI, managing text fields, icons, inscriptions, and font styles.</summary>
public unsafe struct ItemExamineUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.Internal.ExamineSubUI

    // Child Types
    public unsafe struct ItemExamineUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_itemExamineBaseField;
    public ACBindings.Internal.UIElement_Text* m_itemValueText;
    public ACBindings.Internal.UIElement_Text* m_itemBurdenText;
    public ACBindings.Internal.UIElement_Text* m_itemDisplayText;
    public ACBindings.Internal.UIElement_Text* m_itemInscriptionText;
    public ACBindings.Internal.UIElement_Text* m_itemInscriptionSignatureText;
    public ACBindings.Internal.UIElement* m_itemInscriptionBackground;
    public ACBindings.Internal.UIElement* m_itemIcon;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_scribe_name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_scribe_account;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_old_inscription;
    public int mod_high_font;
    public int mod_low_font;

    // Generated Constructor
    public ItemExamineUI(ACBindings.Internal.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Shows or hides the spell examination interface according to the supplied state.
    /// <code>Offset: 0x004AB980
    /// void __thiscall ItemExamineUI::Show(SpellExamineUI*,bool)</code>
    /// </summary>
    /// <param name="shown">True to display, false to hide the UI element.</param>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, byte, void>)0x004AB980)(ref this, shown);

    /// <summary>Initializes a new item examination UI, linking it to the specified parent element and locating child text fields for display.
    /// <code>Offset: 0x004ABB70
    /// void __thiscall ItemExamineUI::ItemExamineUI(ItemExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    /// <param name="parentElement">The parent examination UI that owns this component.</param>
    public void _ConstructorInternal(ACBindings.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.gmExaminationUI*, void>)0x004ABB70)(ref this, parentElement);

    /// <summary>Destroys an ItemExamineUI instance, releasing its string resources and cleaning up the embedded appraisal profile.
    /// <code>Offset: 0x004ABCC0
    /// void __thiscall ItemExamineUI::~ItemExamineUI(ItemExamineUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004ABCC0)(ref this);

    /// <summary>Adds formatted item information to the UI element of this ItemExamineUI instance, inserting an appropriate line break based on the newline flag before appending the text.
    /// <code>Offset: 0x004AC3D0
    /// LONG __thiscall ItemExamineUI::AddItemInfo(UIRegion**,int*,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer specifying the font or style index used when appending the text.</param>
    /// <param name="a3">Unsigned integer value containing the text content (or identifier) to append to the UI element.</param>
    /// <param name="a4">Flag determining newline behavior; non‑zero inserts a single line break, zero inserts two consecutive line breaks before the text.</param>
    /// <returns>The result code from AppendTextWithFont, typically 0 on success or a negative value on failure.</returns>
    public int AddItemInfo(int* a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, int*, uint, int, int>)0x004AC3D0)(ref this, a2, a3, a4);

    /// <summary>Handles focus on the inscription field in the item examination UI, resetting associated text elements and displaying a placeholder followed by the item’s name when necessary.
    /// <code>Offset: 0x004AC460
    /// void __thiscall ItemExamineUI::HandleInscriptionGainingFocus(ItemExamineUI*)</code>
    /// </summary>
    public void HandleInscriptionGainingFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004AC460)(ref this);

    /// <summary>Processes mouse press actions on the item inscription field, validating the player’s authority and inventory status before allowing edits or displaying relevant feedback messages.
    /// <code>Offset: 0x004AC5B0
    /// void __thiscall ItemExamineUI::HandleInscriptionMousePresses(ItemExamineUI*)</code>
    /// </summary>
    public void HandleInscriptionMousePresses() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004AC5B0)(ref this);

    /// <summary>Determines whether the currently examined item’s inscription can be edited by the viewer and updates the UI to enable or disable editing accordingly.
    /// <code>Offset: 0x004ACAA0
    /// void __thiscall ItemExamineUI::SetInscriptionEditableState(ItemExamineUI*)</code>
    /// </summary>
    public void SetInscriptionEditableState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004ACAA0)(ref this);

    /// <summary>Creates an appraisal requirement description based on the specified type and ID, storing the resulting text in the supplied HandshakeWireData's ClientVersion buffer.
    /// <code>Offset: 0x004ACE40
    /// void __userpurge ItemExamineUI::GetAppraisalStringFromRequirements(int,volatile LONG*,const char*,CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    /// <param name="requirementType">Specifies the kind of requirement to describe (e.g., skill, attribute, level, or group).</param>
    /// <param name="requirementId">Pointer to a LONG value that identifies the particular skill or attribute involved in the requirement.</param>
    /// <param name="extraInfo">Optional string used for additional data such as creature or heritage group identifiers when constructing the description.</param>
    /// <param name="wireData">HandshakeWireData structure containing a mutable buffer where the generated appraisal string is written; its reference count is adjusted appropriately.</param>
//     public static ACBindings.Internal.void __userpurge GetAppraisalStringFromRequirements(int a1, int* a2, sbyte* a3, ACBindings.Internal.CLogonHeader.HandshakeWireData a4) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte*, ACBindings.Internal.CLogonHeader.HandshakeWireData, ACBindings.Internal.void __userpurge>)0x004ACE40)(a1, a2, a3, a4);

    /// <summary>Adds an ability description to the item's display field, appending it in the specified font and inserting a single or double line break based on current content and the suppress flag.
    /// <code>Offset: 0x004AE020
    /// void __thiscall ItemExamineUI::AddItemInfo(ItemExamineUI*,const char*,int,int)</code>
    /// </summary>
    /// <param name="ability_txt">The text of the ability to append to the item's display.</param>
    /// <param name="font">Identifier for the font style used when adding the ability text.</param>
    /// <param name="surpressDoubleSpacing">Non‑zero indicates that only one newline should precede the new text; zero causes two newlines if multiple lines already exist in the display field.</param>
    public void AddItemInfo(sbyte* ability_txt, int font, int surpressDoubleSpacing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, sbyte*, int, int, void>)0x004AE020)(ref this, ability_txt, font, surpressDoubleSpacing);

    /// <summary>Updates the item value text element using data from the supplied appraisal profile.
    /// <code>Offset: 0x004AE0E0
    /// void __thiscall ItemExamineUI::SetValueText(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile that supplies the item's value to display. If no valid value is present, a placeholder ("???") is shown instead.</param>
    public void SetValueText(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE0E0)(ref this, prof);

    /// <summary>Shows the item’s value in the examination UI using information from an appraisal profile.
    /// <code>Offset: 0x004AE220
    /// void __thiscall ItemExamineUI::Appraisal_ShowValueInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">AppraisalProfile containing the item's value data; if the value is unavailable, a placeholder ("???") is displayed.</param>
    public void Appraisal_ShowValueInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE220)(ref this, prof);

    /// <summary>Updates the item examination UI's burden field based on the supplied appraisal profile, displaying either the numeric burden value followed by "Burden Units" or “Unknown Burden” when no value is available.
    /// <code>Offset: 0x004AE390
    /// void __thiscall ItemExamineUI::SetBurdenText(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal data containing potential burden information for the examined item.</param>
    public void SetBurdenText(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE390)(ref this, prof);

    /// <summary>Displays the burden (weight) of an examined item in the UI using data from the supplied appraisal profile. If the weight cannot be retrieved, shows “Unknown”.
    /// <code>Offset: 0x004AE500
    /// void __thiscall ItemExamineUI::Appraisal_ShowBurdenInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing the item's statistical information.</param>
    public void Appraisal_ShowBurdenInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE500)(ref this, prof);

    /// <summary>Updates the item’s inscription display within the examination UI using data from an appraisal profile, setting the inscription text, signature, and editability based on whether the item can be inscribed.
    /// <code>Offset: 0x004AE670
    /// void __thiscall ItemExamineUI::SetInscription(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance whose inscription fields are updated.</param>
    /// <param name="prof">AppraisalProfile providing the item’s current inscription and scribe details.</param>
    public void SetInscription(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE670)(ref this, prof);

    /// <summary>Handles loss of focus on an item's inscription field during examination. Determines whether the inscription text has changed, updates the item's data accordingly, resets placeholder or clears signature fields when appropriate, and stores scribe information.
    /// <code>Offset: 0x004AE9A0
    /// void __thiscall ItemExamineUI::HandleInscriptionLosingFocus(ItemExamineUI*)</code>
    /// </summary>
    public void HandleInscriptionLosingFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004AE9A0)(ref this);

    /// <summary>Displays set details of an item by interpreting its appraisal profile and updating the examination UI.
    /// <code>Offset: 0x004AEC00
    /// int __thiscall ItemExamineUI::Appraisal_ShowSet(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">Appraisal data that includes a set identifier to be shown.</param>
    /// <returns>1 if the set was successfully added to the UI; otherwise 0.</returns>
    public int Appraisal_ShowSet(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, int>)0x004AEC00)(ref this, prof);

    /// <summary>Displays the item’s appraisal ratings in the examination UI by constructing a formatted string of all non‑zero rating values and adding it as an info line. If any rating or vitality bonus is present, the function also appends the item name and base armor values.
    /// <code>Offset: 0x004AF400
    /// int __thiscall ItemExamineUI::Appraisal_ShowRatings(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing the item's statistical data to be displayed.</param>
    /// <returns>1 if at least one rating or a vitality bonus was shown; otherwise 0.</returns>
    public int Appraisal_ShowRatings(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, int>)0x004AF400)(ref this, prof);

    /// <summary>Adds usage text from the given appraisal profile to the item examination UI.
    /// <code>Offset: 0x004AFFD0
    /// void __thiscall ItemExamineUI::Appraisal_ShowUsage(ItemExamineUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="lm">Identifier for the usage context (unused in this implementation).</param>
    /// <param name="prof">The appraisal profile containing the usage string.</param>
    public void Appraisal_ShowUsage(uint lm, ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004AFFD0)(ref this, lm, prof);

    /// <summary>Shows the conditions required to wield an item by parsing its appraisal profile and adding formatted requirement text to the examination UI.
    /// <code>Offset: 0x004B0040
    /// void __thiscall ItemExamineUI::Appraisal_ShowWieldRequirements(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance whose display is updated.</param>
    /// <param name="prof">AppraisalProfile containing data about the inspected item.</param>
    public void Appraisal_ShowWieldRequirements(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B0040)(ref this, prof);

    /// <summary>Displays the item’s special appraisal properties in the examination interface by querying the supplied AppraisalProfile and adding formatted property lines to the UI.
    /// <code>Offset: 0x004B07E0
    /// void __thiscall ItemExamineUI::Appraisal_ShowSpecialProperties(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The profile containing appraisal data for the examined item.</param>
    public void Appraisal_ShowSpecialProperties(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B07E0)(ref this, prof);

    /// <summary>Displays the craftsman’s name for an examined item when the appraisal profile contains a creator string and no specific flags override it.
    /// <code>Offset: 0x004B1440
    /// void __thiscall ItemExamineUI::Appraisal_ShowCraftsman(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance that manages the examination UI.</param>
    /// <param name="prof">The AppraisalProfile providing data about the current item, including optional creator information.</param>
    public void Appraisal_ShowCraftsman(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B1440)(ref this, prof);

    /// <summary>Populates the item examination UI with tinkering‑related information extracted from an appraisal profile, including tweak counts, last tinkerer, imbuer, and workmanship rating.
    /// <code>Offset: 0x004B1510
    /// void __thiscall ItemExamineUI::Appraisal_ShowTinkeringInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">Appraisal profile containing data about the item’s tinkering history and workmanship.</param>
    public void Appraisal_ShowTinkeringInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B1510)(ref this, prof);

    /// <summary>Displays weapon or armor information within the item examination user interface using the supplied appraisal profile. The content shown depends on a bitmask of display options, rendering details such as level, damage, speed, range, enchantments, and ammunition type.
    /// <code>Offset: 0x004B1780
    /// void __thiscall ItemExamineUI::Appraisal_ShowWeaponAndArmorData(ItemExamineUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">Instance of ItemExamineUI where data will be displayed.</param>
    /// <param name="lm">Bitmask specifying which categories of weapon or armor data should be shown.</param>
    /// <param name="prof">AppraisalProfile containing the item's statistical information to present.</param>
    public void Appraisal_ShowWeaponAndArmorData(uint lm, ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004B1780)(ref this, lm, prof);

    /// <summary>Displays caster statistics of the examined item—including mana‑conversion bonus and elemental damage modifiers—in the item examination interface, formatting the information according to whether the bonuses are enchanted.
    /// <code>Offset: 0x004B21B0
    /// void __thiscall ItemExamineUI::Appraisal_ShowCasterData(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">Reference to the ItemExamineUI instance handling the display.</param>
    /// <param name="prof">Appraisal profile containing the item's statistics.</param>
    public void Appraisal_ShowCasterData(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B21B0)(ref this, prof);

    /// <summary>Displays the item's melee, missile, and magic defense bonuses in the examination UI when they differ from default values.
    /// <code>Offset: 0x004B2490
    /// void __thiscall ItemExamineUI::Appraisal_ShowDefenseModData(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance whose display is being updated.</param>
    /// <param name="prof">Profile containing appraisal data for the item.</param>
    public void Appraisal_ShowDefenseModData(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2490)(ref this, prof);

    /// <summary>Shows armor level and individual damage type resistances from the provided appraisal profile, formatting each modifier with appropriate font based on enchantment status.
    /// <code>Offset: 0x004B2600
    /// void __thiscall ItemExamineUI::Appraisal_ShowArmorMods(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing armor statistics to display.</param>
    public void Appraisal_ShowArmorMods(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2600)(ref this, prof);

    /// <summary>Displays a formatted message indicating whether the examined item restores or depletes Health, Stamina, or Mana when used.
    /// <code>Offset: 0x004B2B20
    /// void __thiscall ItemExamineUI::Appraisal_ShowBoostValue(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance that presents the examination UI.</param>
    /// <param name="prof">The AppraisalProfile containing the item's statistical data.</param>
    public void Appraisal_ShowBoostValue(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2B20)(ref this, prof);

    /// <summary>Displays healing kit values in the examination UI when the examined object is a healer or a hooked item healer, showing bonus healing skill and restoration bonus.
    /// <code>Offset: 0x004B2C40
    /// void __thiscall ItemExamineUI::Appraisal_ShowHealKitValues(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile of the item being examined.</param>
    public void Appraisal_ShowHealKitValues(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2C40)(ref this, prof);

    /// <summary>Displays the storage capacity of the currently examined object in the UI, drawing item and container limits directly from the object's data. If page usage information is available in the appraisal profile, it also shows how many pages are filled.
    /// <code>Offset: 0x004B2D20
    /// void __thiscall ItemExamineUI::Appraisal_ShowCapacity(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile for the examined item; its page statistics may be displayed if present.</param>
    public void Appraisal_ShowCapacity(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2D20)(ref this, prof);

    /// <summary>Displays lock status, pickability estimate, and any lockpick skill bonus for an item in the examination UI using data from its appraisal profile.
    /// <code>Offset: 0x004B2E30
    /// void __thiscall ItemExamineUI::Appraisal_ShowLockAppraiseInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance responsible for rendering the information.</param>
    /// <param name="prof">AppraisalProfile containing lock-related attributes such as locked flag, resistance, success percent, and bonus.</param>
    public void Appraisal_ShowLockAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2E30)(ref this, prof);

    /// <summary>Displays level restriction information for an item based on its appraisal profile, formatting a message that indicates whether the item is limited to characters of a certain level or range, and appends any destination string if present.
    /// <code>Offset: 0x004B2FC0
    /// void __thiscall ItemExamineUI::Appraisal_ShowLevelLimitInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing level limit data and optional destination information.</param>
    public void Appraisal_ShowLevelLimitInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2FC0)(ref this, prof);

    /// <summary>Displays usage restrictions for an item based on its appraisal profile, adding messages that indicate the required level, skill prerequisites, or specialized skill needed to use the item.
    /// <code>Offset: 0x004B3110
    /// void __thiscall ItemExamineUI::Appraisal_ShowUsageLimitInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance displaying the examination UI.</param>
    /// <param name="prof">The appraisal data of the examined item, containing usage requirement information.</param>
    public void Appraisal_ShowUsageLimitInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3110)(ref this, prof);

    /// <summary>Displays a brief list of spells associated with the examined item, or indicates that spell information is unavailable.
    /// <code>Offset: 0x004B3330
    /// void __thiscall ItemExamineUI::Appraisal_ShowShortMagicInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ItemExamineUI instance responsible for rendering the UI.</param>
    /// <param name="prof">AppraisalProfile containing the item's spell data and status flags.</param>
    public void Appraisal_ShowShortMagicInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3330)(ref this, prof);

    /// <summary>Displays the magical details of an item, including spell descriptions, enchantments, and associated statistics such as spellcraft, mana cost, and usage, by extracting data from the supplied appraisal profile. If the profile indicates no known spells or failure, a generic “Spells: unknown.” message is shown instead.
    /// <code>Offset: 0x004B34B0
    /// void __thiscall ItemExamineUI::Appraisal_ShowMagicInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance that manages the UI elements for examining an item.</param>
    /// <param name="prof">A read‑only appraisal profile containing spellbook data and related magic attributes to present in the UI.</param>
    public void Appraisal_ShowMagicInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B34B0)(ref this, prof);

    /// <summary>Shows the activation requirements of the currently examined item using its appraisal profile and updates the UI with descriptive text.
    /// <code>Offset: 0x004B3910
    /// void __thiscall ItemExamineUI::Appraisal_ShowActivationRequirements(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance displaying the item.</param>
    /// <param name="prof">Profile containing the item's appraisal data used to determine activation conditions.</param>
    public void Appraisal_ShowActivationRequirements(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3910)(ref this, prof);

    /// <summary>Shows stored mana, efficiency, and chance of destruction for a mana stone in the examination UI when the item has no spellbook.
    /// <code>Offset: 0x004B3FA0
    /// void __thiscall ItemExamineUI::Appraisal_ShowManaStoneInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing the item's attributes to query.</param>
    public void Appraisal_ShowManaStoneInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3FA0)(ref this, prof);

    /// <summary>Shows remaining usage information for an item in the examination UI, including key counts, unlimited or specific usage count, or unknown status when appraisal fails.
    /// <code>Offset: 0x004B40C0
    /// void __thiscall ItemExamineUI::Appraisal_ShowRemainingUses(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing item statistics and flags used to determine remaining uses.</param>
    public void Appraisal_ShowRemainingUses(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B40C0)(ref this, prof);

    /// <summary>Displays rare item details in the examination UI, such as timer restrictions and rarity number.
    /// <code>Offset: 0x004B4200
    /// void __thiscall ItemExamineUI::Appraisal_ShowRareInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">AppraisalProfile containing data used to determine rarity information.</param>
    public void Appraisal_ShowRareInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B4200)(ref this, prof);

    /// <summary>Displays the item's current level and accumulated experience in the examination UI, using data from the supplied appraisal profile. If the item is a special cloak that can reduce incoming damage, an additional informational line is shown.
    /// <code>Offset: 0x004B4300
    /// void __thiscall ItemExamineUI::Appraisal_ShowItemLevelInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="prof">Profile containing the appraisal data for the examined item.</param>
    public void Appraisal_ShowItemLevelInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B4300)(ref this, prof);

    /// <summary>Shows the detailed description of an examined item using data from an appraisal profile, updating the UI with expiration information, inscriptions, material details, and portal restrictions.
    /// <code>Offset: 0x004B75B0
    /// void __thiscall ItemExamineUI::Appraisal_ShowDescription(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="this">The ItemExamineUI instance displaying the item.</param>
    /// <param name="prof">Profile containing appraisal information for the item.</param>
    public void Appraisal_ShowDescription(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B75B0)(ref this, prof);

    /// <summary>Configures the item examination UI with data from an AppraisalProfile, updating icons, value and burden displays, inscriptions, and a comprehensive list of stats and properties for the currently examined object.
    /// <code>Offset: 0x004B7ED0
    /// void __thiscall ItemExamineUI::SetAppraiseInfo(ItemExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing all information about the item to be displayed.</param>
    /// <param name="is_new">If non‑zero, scrolls the display text back to the top after updating.</param>
    public void SetAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, int, void>)0x004B7ED0)(ref this, prof, is_new);
}

