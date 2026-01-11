namespace ACBindings.Internal;

public unsafe struct HookAppraisalProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct HookAppraisalProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, void> HookAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HookAppraisalProfile*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004F8D90
    /// int __thiscall HookAppraisalProfile::GetValidLocations(ChatDisplayInfo*)</code>
    /// </summary>
    public int GetValidLocations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HookAppraisalProfile, int>)0x004F8D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B7560
    /// void __thiscall HookAppraisalProfile::Clear(HookAppraisalProfile*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HookAppraisalProfile, void>)0x005B7560)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B75A0
    /// unsigned int __thiscall HookAppraisalProfile::Pack(HookAppraisalProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HookAppraisalProfile, void**, uint, uint>)0x005B75A0)(ref this, addr, size);
}

