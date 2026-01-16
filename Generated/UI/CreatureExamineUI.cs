namespace ACBindings.Internal;


/// <summary>Specialized examination UI that displays detailed information about a creature, extending basic examination functionality with a dedicated display name element.</summary>
/// <remarks>Handles presentation of appraisal data and toggles visibility of the examine interface within the game’s user interface system.</remarks>
public unsafe struct CreatureExamineUI
{
    // Base Classes
    public ACBindings.Internal.BasicCreatureExamineUI BaseClass_BasicCreatureExamineUI; // ACBindings.Internal.BasicCreatureExamineUI

    // Child Types
    public unsafe struct CreatureExamineUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_creatureDisplayName;

    // Methods

    /// <summary>Shows or hides the creature examination interface by updating its primary field and information panel visibility.
    /// <code>Offset: 0x004AB920
    /// void __thiscall CreatureExamineUI::Show(CreatureExamineUI*,bool)</code>
    /// </summary>
    /// <param name="shown">True to display the UI, false to hide it.</param>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureExamineUI, byte, void>)0x004AB920)(ref this, shown);

    /// <summary>Updates the creature examination UI with appraisal data, including name, rating, damage, resistances, and additional combat statistics, then delegates to the base class implementation.
    /// <code>Offset: 0x004B4690
    /// void __thiscall CreatureExamineUI::SetAppraiseInfo(CreatureExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing the creature's stats and attributes.</param>
    /// <param name="is_new">Flag indicating whether this is a fresh appraisal session (used by the base UI logic).</param>
    public void SetAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureExamineUI, ACBindings.Internal.AppraisalProfile*, int, void>)0x004B4690)(ref this, prof, is_new);
}

