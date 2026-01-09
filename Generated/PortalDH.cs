namespace ACBindings;

// PortalDH
public unsafe struct PortalDH
{
    // Members
    public ACBindings.AC1Legacy.vlong shared_base_;
    public ACBindings.AC1Legacy.vlong shared_prime_;

    // Methods
    // int __thiscall PortalDH::Init(PortalDH*,AC1Legacy::vlong*,AC1Legacy::vlong*)
    public int Init(ACBindings.AC1Legacy.vlong* shared_base, ACBindings.AC1Legacy.vlong* shared_prime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalDH, ACBindings.AC1Legacy.vlong*, ACBindings.AC1Legacy.vlong*, int>)0x005B1300)(ref this, shared_base, shared_prime);
}

