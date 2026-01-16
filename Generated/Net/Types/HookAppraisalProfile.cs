namespace ACBindings.Internal;


/// <summary>Stores appraisal metadata such as display flags, valid locations, and ammo type for use in chat UI rendering and serialization.</summary>
/// <remarks>Provides methods to clear defaults, pack into a contiguous buffer, and retrieve validity information for chat display logic.</remarks>
public unsafe struct HookAppraisalProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HookAppraisalProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, void> HookAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }
    // HookAppraisalProfile::HookAppraisal_BF
    public enum HookAppraisal_BF : uint
    {
    }

    // Members
    public uint mBitfield;
    public uint mValidLocations;
    public ACBindings.Internal.AMMO_TYPE mAmmoType;

    // Methods

    /// <summary>Retrieves the display flag from a chat message, indicating whether it should be shown.
    /// <code>Offset: 0x004F8D90
    /// int __thiscall HookAppraisalProfile::GetValidLocations(ChatDisplayInfo*)</code>
    /// </summary>
    /// <param name="this">The ChatDisplayInfo instance containing the message to query.</param>
    /// <returns>The integer value of the m_doDisplayText field; non‑zero when the text is set for display.</returns>
    public int GetValidLocations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HookAppraisalProfile, int>)0x004F8D90)(ref this);

    /// <summary>Resets the appraisal profile to its default state, clearing all bitfields, valid locations, and setting ammo type to none.
    /// <code>Offset: 0x005B7560
    /// void __thiscall HookAppraisalProfile::Clear(HookAppraisalProfile*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HookAppraisalProfile, void>)0x005B7560)(ref this);

    /// <summary>Packs HookAppraisalProfile fields into a contiguous memory block, writing mBitfield, mValidLocations, and mAmmoType sequentially while advancing the destination pointer.
    /// <code>Offset: 0x005B75A0
    /// unsigned int __thiscall HookAppraisalProfile::Pack(HookAppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer address; will be updated to point after the written data.</param>
    /// <param name="size">Size of the available buffer in bytes; write occurs only if at least 12 bytes are available.</param>
    /// <returns>Number of bytes written (always 12).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HookAppraisalProfile, void**, uint, uint>)0x005B75A0)(ref this, addr, size);
}

