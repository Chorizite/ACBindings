namespace ACBindings;

// ItemExamineUI
public unsafe struct ItemExamineUI : System.IDisposable
{
    // Base Classes
    public ACBindings.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.ExamineSubUI

    // Child Types
    // ItemExamineUI_vtbl
    public unsafe struct ItemExamineUI_vtbl
    {
        // Members
        public System.IntPtr Init; // function pointer
        public System.IntPtr SetAppraiseInfo; // function pointer
        public System.IntPtr Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement* m_itemExamineBaseField;
    public ACBindings.UIElement_Text* m_itemValueText;
    public ACBindings.UIElement_Text* m_itemBurdenText;
    public ACBindings.UIElement_Text* m_itemDisplayText;
    public ACBindings.UIElement_Text* m_itemInscriptionText;
    public ACBindings.UIElement_Text* m_itemInscriptionSignatureText;
    public ACBindings.UIElement* m_itemInscriptionBackground;
    public ACBindings.UIElement* m_itemIcon;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_scribe_name;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_scribe_account;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_old_inscription;
    public int mod_high_font;
    public int mod_low_font;

    // Generated Constructor
    public ItemExamineUI(ACBindings.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ItemExamineUI::Show(SpellExamineUI*,bool)
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, byte, void>)0x004AB980)(ref this, shown);
    // void __thiscall ItemExamineUI::ItemExamineUI(ItemExamineUI*,gmExaminationUI*)
    public void _ConstructorInternal(ACBindings.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.gmExaminationUI*, void>)0x004ABB70)(ref this, parentElement);
    // void __thiscall ItemExamineUI::~ItemExamineUI(ItemExamineUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, void>)0x004ABCC0)(ref this);
    // LONG __thiscall ItemExamineUI::AddItemInfo(UIRegion**,int*,unsigned int,int)
    public int AddItemInfo(int* a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, int*, uint, int, int>)0x004AC3D0)(ref this, a2, a3, a4);
    // void __thiscall ItemExamineUI::HandleInscriptionGainingFocus(ItemExamineUI*)
    public void HandleInscriptionGainingFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, void>)0x004AC460)(ref this);
    // void __thiscall ItemExamineUI::HandleInscriptionMousePresses(ItemExamineUI*)
    public void HandleInscriptionMousePresses() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, void>)0x004AC5B0)(ref this);
    // void __thiscall ItemExamineUI::SetInscriptionEditableState(ItemExamineUI*)
    public void SetInscriptionEditableState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, void>)0x004ACAA0)(ref this);
    // void __userpurge ItemExamineUI::GetAppraisalStringFromRequirements(int,volatile LONG*,const char*,CLogonHeader::HandshakeWireData)
//     public static ACBindings.void __userpurge GetAppraisalStringFromRequirements(int a1, int* a2, sbyte* a3, ACBindings.CLogonHeader.HandshakeWireData a4) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte*, ACBindings.CLogonHeader.HandshakeWireData, ACBindings.void __userpurge>)0x004ACE40)(a1, a2, a3, a4);
    // void __thiscall ItemExamineUI::AddItemInfo(ItemExamineUI*,const char*,int,int)
    public void AddItemInfo(sbyte* ability_txt, int font, int surpressDoubleSpacing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, sbyte*, int, int, void>)0x004AE020)(ref this, ability_txt, font, surpressDoubleSpacing);
    // void __thiscall ItemExamineUI::SetValueText(ItemExamineUI*,const AppraisalProfile*)
    public void SetValueText(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004AE0E0)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowValueInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowValueInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004AE220)(ref this, prof);
    // void __thiscall ItemExamineUI::SetBurdenText(ItemExamineUI*,const AppraisalProfile*)
    public void SetBurdenText(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004AE390)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowBurdenInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowBurdenInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004AE500)(ref this, prof);
    // void __thiscall ItemExamineUI::SetInscription(ItemExamineUI*,const AppraisalProfile*)
    public void SetInscription(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004AE670)(ref this, prof);
    // void __thiscall ItemExamineUI::HandleInscriptionLosingFocus(ItemExamineUI*)
    public void HandleInscriptionLosingFocus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, void>)0x004AE9A0)(ref this);
    // int __thiscall ItemExamineUI::Appraisal_ShowSet(ItemExamineUI*,const AppraisalProfile*)
    public int Appraisal_ShowSet(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, int>)0x004AEC00)(ref this, prof);
    // int __thiscall ItemExamineUI::Appraisal_ShowRatings(ItemExamineUI*,const AppraisalProfile*)
    public int Appraisal_ShowRatings(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, int>)0x004AF400)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowUsage(ItemExamineUI*,unsigned int,const AppraisalProfile*)
    public void Appraisal_ShowUsage(uint lm, ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, uint, ACBindings.AppraisalProfile*, void>)0x004AFFD0)(ref this, lm, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowWieldRequirements(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowWieldRequirements(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B0040)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowSpecialProperties(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowSpecialProperties(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B07E0)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowCraftsman(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowCraftsman(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B1440)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowTinkeringInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowTinkeringInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B1510)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowWeaponAndArmorData(ItemExamineUI*,unsigned int,const AppraisalProfile*)
    public void Appraisal_ShowWeaponAndArmorData(uint lm, ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, uint, ACBindings.AppraisalProfile*, void>)0x004B1780)(ref this, lm, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowCasterData(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowCasterData(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B21B0)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowDefenseModData(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowDefenseModData(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B2490)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowArmorMods(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowArmorMods(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B2600)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowBoostValue(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowBoostValue(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B2B20)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowHealKitValues(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowHealKitValues(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B2C40)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowCapacity(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowCapacity(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B2D20)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowLockAppraiseInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowLockAppraiseInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B2E30)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowLevelLimitInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowLevelLimitInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B2FC0)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowUsageLimitInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowUsageLimitInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B3110)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowShortMagicInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowShortMagicInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B3330)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowMagicInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowMagicInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B34B0)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowActivationRequirements(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowActivationRequirements(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B3910)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowManaStoneInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowManaStoneInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B3FA0)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowRemainingUses(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowRemainingUses(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B40C0)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowRareInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowRareInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B4200)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowItemLevelInfo(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowItemLevelInfo(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B4300)(ref this, prof);
    // void __thiscall ItemExamineUI::Appraisal_ShowDescription(ItemExamineUI*,const AppraisalProfile*)
    public void Appraisal_ShowDescription(ACBindings.AppraisalProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, void>)0x004B75B0)(ref this, prof);
    // void __thiscall ItemExamineUI::SetAppraiseInfo(ItemExamineUI*,const AppraisalProfile*,int)
    public void SetAppraiseInfo(ACBindings.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemExamineUI, ACBindings.AppraisalProfile*, int, void>)0x004B7ED0)(ref this, prof, is_new);
}

