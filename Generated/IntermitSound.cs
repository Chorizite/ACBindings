namespace ACBindings.Internal;


/// <summary>Represents an intermittent ambient sound with directional distance ranges, play chance and aggregate play count for dynamic audio handling.</summary>
public unsafe struct IntermitSound
{
    // Base Classes
    public ACBindings.Internal.AmbientSound BaseClass_AmbientSound; // ACBindings.Internal.AmbientSound

    // Child Types
    public unsafe struct IntermitSound_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, void> ResetCount; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float> GetVolume; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, int> CanHear; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, int> PlayNow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float> GetPlayInterval; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void> AddTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float, void> UpdateSound; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, ACBindings.Internal.Position*, int> GetSoundPos; // function pointer

        // Methods
    }

    // Members
    public float play_chance;
    public fixed float min_dist[8];
    public fixed float max_dist[8];
    public uint num_dir;
    public fixed byte sound_dir_Raw[32];
    public ACBindings.Internal.LandDefs.Direction* sound_dir => (ACBindings.Internal.LandDefs.Direction*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref sound_dir_Raw[0]);

    // Methods

    /// <summary>Adds a directional sound range to an IntermitSound or updates an existing entry's min/max distances if the provided values extend its current range.
    /// <code>Offset: 0x00551910
    /// void __thiscall IntermitSound::AddDir(IntermitSound*,LandDefs::Direction,float,float)</code>
    /// </summary>
    /// <param name="dir">The direction for which the sound range is defined.</param>
    /// <param name="min">Minimum audible distance in that direction.</param>
    /// <param name="max">Maximum audible distance in that direction.</param>
    public void AddDir(ACBindings.Internal.LandDefs.Direction dir, float min, float max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, ACBindings.Internal.LandDefs.Direction, float, float, void>)0x00551910)(ref this, dir, min, max);

    /// <summary>Determines whether the sound is audible by evaluating its play chance.
    /// <code>Offset: 0x00551BA0
    /// int __thiscall IntermitSound::CanHear(IntermitSound*)</code>
    /// </summary>
    /// <returns>Non‑zero if play_chance exceeds zero, indicating the sound can be heard; otherwise zero.</returns>
    public int CanHear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, int>)0x00551BA0)(ref this);

    /// <summary>Attempts to play the sound immediately according to its play chance probability.
    /// <code>Offset: 0x00551BC0
    /// int __thiscall IntermitSound::PlayNow(IntermitSound*)</code>
    /// </summary>
    /// <returns>Returns 1 if the random roll succeeded and the sound should be played; otherwise returns 0.</returns>
    public int PlayNow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, int>)0x00551BC0)(ref this);

    /// <summary>Retrieves the current volume level for the intermitent sound.
    /// <code>Offset: 0x00551C90
    /// float __thiscall IntermitSound::GetVolume(IntermitSound*)</code>
    /// </summary>
    /// <returns>The volume of the associated ambient sound as a floating‑point value.</returns>
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float>)0x00551C90)(ref this);

    /// <summary>Retrieves a random play interval for the sound based on its configured minimum and maximum rates.
    /// <code>Offset: 0x00551CA0
    /// float __thiscall IntermitSound::GetPlayInterval(IntermitSound*)</code>
    /// </summary>
    /// <returns>The computed play interval in seconds.</returns>
    public float GetPlayInterval() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float>)0x00551CA0)(ref this);

    /// <summary>Adjusts the sound's play chance based on its current ambient sound count and a supplied total weight, while incrementing the associated play counter.
    /// <code>Offset: 0x00551F30
    /// void __thiscall IntermitSound::UpdateSound(IntermitSound*,float)</code>
    /// </summary>
    /// <param name="total_weight">The cumulative weight used to normalize the base chance for this sound.</param>
    public void UpdateSound(float total_weight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float, void>)0x00551F30)(ref this, total_weight);

    /// <summary>Calculates a random sound origin offset based on defined directions and distance ranges, then updates the supplied Position’s frame origin with this new location.
    /// <code>Offset: 0x00551F70
    /// int __thiscall IntermitSound::GetSoundPos(IntermitSound*,Position*)</code>
    /// </summary>
    /// <param name="base_pos">The current position to be adjusted; after execution contains the computed sound source location.</param>
    /// <returns>An integer status code (1) indicating successful calculation of the position.</returns>
    public int GetSoundPos(ACBindings.Internal.Position* base_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, ACBindings.Internal.Position*, int>)0x00551F70)(ref this, base_pos);

    /// <summary>Adds an intermittent sound with the given weight and spatial offset to the IntermitSound instance, updating its play count and adding directional distance ranges based on the supplied direction.
    /// <code>Offset: 0x00552070
    /// void __thiscall IntermitSound::AddTo(IntermitSound*,float,const AC1Legacy::Vector3*,LandDefs::Direction)</code>
    /// </summary>
    /// <param name="weight">The incremental value added to the sound's current play count.</param>
    /// <param name="diff">A 3‑D vector whose magnitude determines distance-based min/max bounds for the sound when a direction is specified.</param>
    /// <param name="dir">If nonzero, limits the addition to that specific direction; otherwise distributes the sound across all eight cardinal and intercardinal directions with fixed bounds.</param>
    public void AddTo(float weight, ACBindings.Internal.AC1Legacy.Vector3* diff, ACBindings.Internal.LandDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void>)0x00552070)(ref this, weight, diff, dir);
}

