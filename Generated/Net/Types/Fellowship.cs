namespace ACBindings;

// Fellowship
public unsafe struct Fellowship : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Fellowship_vtbl
    public unsafe struct Fellowship_vtbl
    {
        // Members
        public System.IntPtr Fellowship_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__uint__Fellow _fellowship_table;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public uint _leader;
    public int _share_xp;
    public int _even_xp_split;
    public int _open_fellow;
    public int _locked;
    public ACBindings.PackableHashTable__uint__int _fellows_departed;

    // Generated Constructor
    public Fellowship(ACBindings.Fellowship* that) {
        _ConstructorInternal(that);
    }
    public Fellowship() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // Fellow* __thiscall Fellowship::GetFellow(Fellowship*,unsigned int)
    public ACBindings.Fellow* GetFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint, ACBindings.Fellow*>)0x0048EDA0)(ref this, fellow);
    // void __thiscall Fellowship::~Fellowship(Fellowship*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, void>)0x0056AA40)(ref this);
    // void __thiscall Fellowship::Fellowship(Fellowship*,const Fellowship*)
    public void _ConstructorInternal(ACBindings.Fellowship* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, ACBindings.Fellowship*, void>)0x0056AAD0)(ref this, that);
    // int __thiscall Fellowship::IsFull(Fellowship*)
    public int IsFull() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, int>)0x005BA1B0)(ref this);
    // int __thiscall Fellowship::IsFellow(Fellowship*,unsigned int)
    public int IsFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint, int>)0x005BA1C0)(ref this, fellow);
    // int __thiscall Fellowship::InqFellow(Fellowship*,unsigned int,Fellow*)
    public int InqFellow(uint fellow, ACBindings.Fellow* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint, ACBindings.Fellow*, int>)0x005BA210)(ref this, fellow, retval);
    // unsigned int __thiscall Fellowship::CalculateExperienceProportionSum(Fellowship*)
    public uint CalculateExperienceProportionSum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint>)0x005BA270)(ref this);
    // unsigned int __thiscall Fellowship::GetLeadersLevel(Fellowship*)
    public uint GetLeadersLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint>)0x005BA2F0)(ref this);
    // unsigned int __thiscall Fellowship::GetNonLeaderFellowID(Fellowship*)
    public uint GetNonLeaderFellowID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint>)0x005BA340)(ref this);
    // void __thiscall Fellowship::HandleLockedRemoveFellow(Fellowship*,unsigned int)
    public void HandleLockedRemoveFellow(uint fellow_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint, void>)0x005BA3B0)(ref this, fellow_id);
    // void __thiscall Fellowship::RecalculateEvenXPSplitting(Fellowship*)
    public void RecalculateEvenXPSplitting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, void>)0x005BA420)(ref this);
    // unsigned int __thiscall Fellowship::GetPackSize(Fellowship*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint>)0x005BA4E0)(ref this);
    // unsigned int __thiscall Fellowship::Pack(Fellowship*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, void**, uint, uint>)0x005BA530)(ref this, addr, size);
    // int __thiscall Fellowship::AddFellow(Fellowship*,unsigned int,const Fellow*)
    public int AddFellow(uint fellow_id, ACBindings.Fellow* fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint, ACBindings.Fellow*, int>)0x005BA5C0)(ref this, fellow_id, fellow);
    // int __thiscall Fellowship::UnPack(Fellowship*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, void**, uint, int>)0x005BA630)(ref this, addr, size);
    // int __thiscall Fellowship::RemoveFellow(Fellowship*,unsigned int)
    public int RemoveFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint, int>)0x005BA7C0)(ref this, fellow);
    // int __thiscall Fellowship::UpdateFellow(Fellowship*,unsigned int,const Fellow*)
    public int UpdateFellow(uint fellow_id, ACBindings.Fellow* fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, uint, ACBindings.Fellow*, int>)0x005BA870)(ref this, fellow_id, fellow);
    // void __thiscall Fellowship::Fellowship(Fellowship*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellowship, void>)0x005BA8E0)(ref this);
}

