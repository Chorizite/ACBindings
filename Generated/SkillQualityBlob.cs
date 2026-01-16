namespace ACBindings.Internal;


/// <summary>Represents the state and presentation of a skill’s quality, storing its current and saved values along with related UI components for progression and level display.</summary>
public unsafe struct SkillQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindings.Internal.Skill m_skillSavedValue;
    public ACBindings.Internal.Skill m_skillCurValue;
    public ACBindings.Internal.UIElement_Menu* m_pAdvancementMenu;
    public ACBindings.Internal.UIElement_Text* m_pCurInitLevelText;

    // Methods
}

