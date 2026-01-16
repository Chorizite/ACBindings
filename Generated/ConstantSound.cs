namespace ACBindings.Internal;


/// <summary>Represents a runtime instance of an ambient sound, storing its base ambient data and current playback volume. It supports updating the volume based on active ambient counts and determining if the sound is audible.</summary>
public unsafe struct ConstantSound
{
    // Base Classes
    public ACBindings.Internal.AmbientSound BaseClass_AmbientSound; // ACBindings.Internal.AmbientSound

    // Child Types
    public unsafe struct ConstantSound_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, void> ResetCount; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float> GetVolume; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, int> CanHear; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, int> PlayNow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float> GetPlayInterval; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void> AddTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float, void> UpdateSound; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, ACBindings.Internal.Position*, int> GetSoundPos; // function pointer

        // Methods
    }

    // Members
    public float current_volume;

    // Methods

    /// <summary>Retrieves the current volume of a constant sound.
    /// <code>Offset: 0x005519A0
    /// float __thiscall ConstantSound::GetVolume(ConstantSound*)</code>
    /// </summary>
    /// <returns>The volume level as a floating‑point value.</returns>
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float>)0x005519A0)(ref this);

    /// <summary>Determines whether this constant sound meets the minimum volume threshold and has a valid sound table, indicating that it can be heard.
    /// <code>Offset: 0x00551BF0
    /// int __thiscall ConstantSound::CanHear(ConstantSound*)</code>
    /// </summary>
    /// <returns>Non-zero if the sound is audible; zero otherwise.</returns>
    public int CanHear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, int>)0x00551BF0)(ref this);

    /// <summary>Adds the specified weight to the ambient sound's count, updating its internal counter.
    /// <code>Offset: 0x00551C20
    /// void __thiscall ConstantSound::AddTo(ConstantSound*,float,const AC1Legacy::Vector3*,LandDefs::Direction)</code>
    /// </summary>
    /// <param name="weight">The amount to increase the sound count by.</param>
    /// <param name="diff">Vector indicating positional difference for the added sound (currently unused).</param>
    /// <param name="dir">Direction of the sound addition relative to the source (unused in current implementation).</param>
    public void AddTo(float weight, ACBindings.Internal.AC1Legacy.Vector3* diff, ACBindings.Internal.LandDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void>)0x00551C20)(ref this, weight, diff, dir);

    /// <summary>Retrieves the minimum playback interval for this constant sound from its ambient description.
    /// <code>Offset: 0x00551CC0
    /// float __thiscall ConstantSound::GetPlayInterval(ConstantSound*)</code>
    /// </summary>
    /// <returns>The minimum interval between consecutive playbacks as specified in the ambient sound data.</returns>
    public float GetPlayInterval() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float>)0x00551CC0)(ref this);

    /// <summary>Updates the constant sound’s volume according to the number of active ambient sounds and normalizes it by the supplied total weight.
    /// <code>Offset: 0x00552160
    /// void __thiscall ConstantSound::UpdateSound(ConstantSound*,float)</code>
    /// </summary>
    /// <param name="total_weight">The aggregate weight of all ambient sounds used for normalization.</param>
    public void UpdateSound(float total_weight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float, void>)0x00552160)(ref this, total_weight);
}

