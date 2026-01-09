namespace ACBindings;

// HookAppraisalProfile
public unsafe struct HookAppraisalProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // HookAppraisalProfile_vtbl
    public unsafe struct HookAppraisalProfile_vtbl
    {
        // Members
        public System.IntPtr HookAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }
    // HookAppraisalProfile::HookAppraisal_BF
    public enum HookAppraisal_BF : uint
    {
    }

    // Members
    public uint mBitfield;
    public uint mValidLocations;
    public ACBindings.AMMO_TYPE mAmmoType;

    // Methods
    // int __thiscall HookAppraisalProfile::GetValidLocations(ChatDisplayInfo*)
    public int GetValidLocations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HookAppraisalProfile, int>)0x004F8D90)(ref this);
    // void __thiscall HookAppraisalProfile::Clear(HookAppraisalProfile*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HookAppraisalProfile, void>)0x005B7560)(ref this);
    // unsigned int __thiscall HookAppraisalProfile::Pack(HookAppraisalProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HookAppraisalProfile, void**, uint, uint>)0x005B75A0)(ref this, addr, size);
}

