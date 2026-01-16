namespace ACBindings.Internal;


/// <summary>Represents a UI region that displays information about a specific spell effect, including its name, icon, and remaining duration. It is linked to the underlying magic system and updates automatically when the player’s enchantments change.</summary>
public unsafe struct EffectInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct EffectInfoRegion_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, void> EffectInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, byte> Update; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EffectInfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_Spell;

    // Generated Constructor
    public EffectInfoRegion(ACBindings.Internal.UIElement_ListBox* i_pParent, int i_internalID, uint i_spell, byte i_bRegisterForUpdates) {
        _ConstructorInternal(i_pParent, i_internalID, i_spell, i_bRegisterForUpdates);
    }

    // Methods

    /// <summary>Updates the value text of an effect region to display the remaining duration of an active spell when a player system is available and the spell has a valid duration. The duration is formatted as HH:MM:SS for hours or MM:SS otherwise.
    /// <code>Offset: 0x004F2860
    /// bool __thiscall EffectInfoRegion::Update(EffectInfoRegion*,long double)</code>
    /// </summary>
    /// <param name="duration">Remaining spell duration in seconds.</param>
    /// <returns>True if a player system was found (even if no UI update occurs); false if no player system could be retrieved.</returns>
    public byte Update(double duration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, double, byte>)0x004F2860)(ref this, duration);

    /// <summary>Returns the remaining duration of the spell effect linked to this info region by examining the player’s current enchantments.
    /// <code>Offset: 0x004F2FF0
    /// long double __thiscall EffectInfoRegion::GetDuration(EffectInfoRegion*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player's quality descriptor that contains active enchantments.</param>
    /// <returns>The time left for the matching enchantment, or 0 if no such enchantment is present.</returns>
    public double GetDuration(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, ACBindings.Internal.CACQualities*, double>)0x004F2FF0)(ref this, i_playerDesc);

    /// <summary>Retrieves the name of the spell associated with this effect region and assigns it to the supplied output parameter.
    /// <code>Offset: 0x004F30A0
    /// char __thiscall EffectInfoRegion::GetLabel(unsigned int*,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Output pointer that will receive a Unicode string containing the spell's label; the returned string is reference‑counted.</param>
    /// <returns>Non‑zero when the label was successfully obtained and assigned; zero if the magic system is unavailable or an error occurs.</returns>
    public sbyte GetLabel(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, System.IntPtr, sbyte>)0x004F30A0)(ref this, a2);

    /// <summary>Updates the effect info region's duration based on the player's current spell state and qualities.
    /// <code>Offset: 0x004F3160
    /// bool __thiscall EffectInfoRegion::Update(EffectInfoRegion*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality description used to calculate the new duration.</param>
    /// <returns>True if the region was updated or no active spell; false if the player system is unavailable.</returns>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F3160)(ref this, i_playerDesc);

    /// <summary>Initializes an EffectInfoRegion within a UI list box by assigning it an internal ID, linking it to a specific spell, updating its label text with the spell name, and configuring its icon if available.
    /// <code>Offset: 0x004F31C0
    /// void __thiscall EffectInfoRegion::EffectInfoRegion(EffectInfoRegion*,UIElement_ListBox*,int,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_pParent">The parent UI list box that will contain this region.</param>
    /// <param name="i_internalID">An identifier used internally for this effect info region.</param>
    /// <param name="i_spell">The unique ID of the spell whose information is displayed by this region.</param>
    /// <param name="i_bRegisterForUpdates">Flag indicating whether the region should register itself to receive periodic updates (currently unused).</param>
    public void _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* i_pParent, int i_internalID, uint i_spell, byte i_bRegisterForUpdates) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EffectInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, uint, byte, void>)0x004F31C0)(ref this, i_pParent, i_internalID, i_spell, i_bRegisterForUpdates);
}

