namespace ACBindings.Internal;

public unsafe struct ItemExamineUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.Internal.ExamineSubUI

    // Child Types
    public unsafe struct ItemExamineUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemExamineUI*, byte, void> Show; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004AB980
    /// void __thiscall ItemExamineUI::Show(SpellExamineUI*,bool)</code>
    /// </summary>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, byte, void>)0x004AB980)(ref this, shown);

    /// <summary>
    /// <code>Offset: 0x004ABB70
    /// void __thiscall ItemExamineUI::ItemExamineUI(ItemExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.gmExaminationUI*, void>)0x004ABB70)(ref this, parentElement);

    /// <summary>
    /// <code>Offset: 0x004ABCC0
    /// void __thiscall ItemExamineUI::~ItemExamineUI(ItemExamineUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004ABCC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004AC3D0
    /// LONG __thiscall ItemExamineUI::AddItemInfo(UIRegion**,int*,unsigned int,int)</code>
    /// </summary>
    public int AddItemInfo(int* a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, int*, uint, int, int>)0x004AC3D0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x004AC460
    /// void __thiscall ItemExamineUI::HandleInscriptionGainingFocus(ItemExamineUI*)</code>
    /// </summary>
    public void HandleInscriptionGainingFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004AC460)(ref this);

    /// <summary>
    /// <code>Offset: 0x004AC5B0
    /// void __thiscall ItemExamineUI::HandleInscriptionMousePresses(ItemExamineUI*)</code>
    /// </summary>
    public void HandleInscriptionMousePresses() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004AC5B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ACAA0
    /// void __thiscall ItemExamineUI::SetInscriptionEditableState(ItemExamineUI*)</code>
    /// </summary>
    public void SetInscriptionEditableState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004ACAA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ACE40
    /// void __userpurge ItemExamineUI::GetAppraisalStringFromRequirements(int,volatile LONG*,const char*,CLogonHeader::HandshakeWireData)</code>
    /// </summary>
//     public static ACBindings.Internal.void __userpurge GetAppraisalStringFromRequirements(int a1, int* a2, sbyte* a3, ACBindings.Internal.CLogonHeader.HandshakeWireData a4) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte*, ACBindings.Internal.CLogonHeader.HandshakeWireData, ACBindings.Internal.void __userpurge>)0x004ACE40)(a1, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x004AE020
    /// void __thiscall ItemExamineUI::AddItemInfo(ItemExamineUI*,const char*,int,int)</code>
    /// </summary>
    public void AddItemInfo(sbyte* ability_txt, int font, int surpressDoubleSpacing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, sbyte*, int, int, void>)0x004AE020)(ref this, ability_txt, font, surpressDoubleSpacing);

    /// <summary>
    /// <code>Offset: 0x004AE0E0
    /// void __thiscall ItemExamineUI::SetValueText(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void SetValueText(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE0E0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004AE220
    /// void __thiscall ItemExamineUI::Appraisal_ShowValueInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowValueInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE220)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004AE390
    /// void __thiscall ItemExamineUI::SetBurdenText(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void SetBurdenText(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE390)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004AE500
    /// void __thiscall ItemExamineUI::Appraisal_ShowBurdenInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowBurdenInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE500)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004AE670
    /// void __thiscall ItemExamineUI::SetInscription(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void SetInscription(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004AE670)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004AE9A0
    /// void __thiscall ItemExamineUI::HandleInscriptionLosingFocus(ItemExamineUI*)</code>
    /// </summary>
    public void HandleInscriptionLosingFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, void>)0x004AE9A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004AEC00
    /// int __thiscall ItemExamineUI::Appraisal_ShowSet(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public int Appraisal_ShowSet(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, int>)0x004AEC00)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004AF400
    /// int __thiscall ItemExamineUI::Appraisal_ShowRatings(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public int Appraisal_ShowRatings(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, int>)0x004AF400)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004AFFD0
    /// void __thiscall ItemExamineUI::Appraisal_ShowUsage(ItemExamineUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowUsage(uint lm, ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004AFFD0)(ref this, lm, prof);

    /// <summary>
    /// <code>Offset: 0x004B0040
    /// void __thiscall ItemExamineUI::Appraisal_ShowWieldRequirements(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowWieldRequirements(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B0040)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B07E0
    /// void __thiscall ItemExamineUI::Appraisal_ShowSpecialProperties(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowSpecialProperties(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B07E0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B1440
    /// void __thiscall ItemExamineUI::Appraisal_ShowCraftsman(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowCraftsman(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B1440)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B1510
    /// void __thiscall ItemExamineUI::Appraisal_ShowTinkeringInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowTinkeringInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B1510)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B1780
    /// void __thiscall ItemExamineUI::Appraisal_ShowWeaponAndArmorData(ItemExamineUI*,unsigned int,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowWeaponAndArmorData(uint lm, ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, uint, ACBindings.Internal.AppraisalProfile*, void>)0x004B1780)(ref this, lm, prof);

    /// <summary>
    /// <code>Offset: 0x004B21B0
    /// void __thiscall ItemExamineUI::Appraisal_ShowCasterData(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowCasterData(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B21B0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B2490
    /// void __thiscall ItemExamineUI::Appraisal_ShowDefenseModData(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowDefenseModData(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2490)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B2600
    /// void __thiscall ItemExamineUI::Appraisal_ShowArmorMods(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowArmorMods(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2600)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B2B20
    /// void __thiscall ItemExamineUI::Appraisal_ShowBoostValue(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowBoostValue(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2B20)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B2C40
    /// void __thiscall ItemExamineUI::Appraisal_ShowHealKitValues(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowHealKitValues(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2C40)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B2D20
    /// void __thiscall ItemExamineUI::Appraisal_ShowCapacity(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowCapacity(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2D20)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B2E30
    /// void __thiscall ItemExamineUI::Appraisal_ShowLockAppraiseInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowLockAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2E30)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B2FC0
    /// void __thiscall ItemExamineUI::Appraisal_ShowLevelLimitInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowLevelLimitInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B2FC0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B3110
    /// void __thiscall ItemExamineUI::Appraisal_ShowUsageLimitInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowUsageLimitInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3110)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B3330
    /// void __thiscall ItemExamineUI::Appraisal_ShowShortMagicInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowShortMagicInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3330)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B34B0
    /// void __thiscall ItemExamineUI::Appraisal_ShowMagicInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowMagicInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B34B0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B3910
    /// void __thiscall ItemExamineUI::Appraisal_ShowActivationRequirements(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowActivationRequirements(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3910)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B3FA0
    /// void __thiscall ItemExamineUI::Appraisal_ShowManaStoneInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowManaStoneInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B3FA0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B40C0
    /// void __thiscall ItemExamineUI::Appraisal_ShowRemainingUses(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowRemainingUses(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B40C0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B4200
    /// void __thiscall ItemExamineUI::Appraisal_ShowRareInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowRareInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B4200)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B4300
    /// void __thiscall ItemExamineUI::Appraisal_ShowItemLevelInfo(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowItemLevelInfo(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B4300)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B75B0
    /// void __thiscall ItemExamineUI::Appraisal_ShowDescription(ItemExamineUI*,const AppraisalProfile*)</code>
    /// </summary>
    public void Appraisal_ShowDescription(ACBindings.Internal.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, void>)0x004B75B0)(ref this, prof);

    /// <summary>
    /// <code>Offset: 0x004B7ED0
    /// void __thiscall ItemExamineUI::SetAppraiseInfo(ItemExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    public void SetAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemExamineUI, ACBindings.Internal.AppraisalProfile*, int, void>)0x004B7ED0)(ref this, prof, is_new);
}

