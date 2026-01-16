namespace ACBindings.Internal;


/// <summary>Encapsulates the quality state of a body part, maintaining its current and saved values while linking to UI controls that present damage, variance, and armor statistics.</summary>
public unsafe struct BodyPartQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindings.Internal.BodyPart m_partSavedValue;
    public ACBindings.Internal.BodyPart m_partCurValue;
    public ACBindings.Internal.UIElement_Menu* m_pDamageTypeMenu;
    public ACBindings.Internal.UIElement_Text* m_pCurDamage;
    public ACBindings.Internal.UIElement_Text* m_pCurDamageVariance;
    public ACBindings.Internal.UIElement_Text* m_pSlashArmorValue;
    public ACBindings.Internal.UIElement_Text* m_pPierceArmorValue;
    public ACBindings.Internal.UIElement_Text* m_pBludgeonArmorValue;
    public ACBindings.Internal.UIElement_Text* m_pColdArmorValue;
    public ACBindings.Internal.UIElement_Text* m_pFireArmorValue;
    public ACBindings.Internal.UIElement_Text* m_pAcidArmorValue;
    public ACBindings.Internal.UIElement_Text* m_pElectricArmorValue;

    // Methods
}

