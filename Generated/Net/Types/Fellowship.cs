namespace ACBindings.Internal;

public unsafe struct Fellowship : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Fellowship_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, void> Fellowship_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellowship*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___Fellow _fellowship_table;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public uint _leader;
    public int _share_xp;
    public int _even_xp_split;
    public int _open_fellow;
    public int _locked;
    public ACBindings.Internal.PackableHashTable__uint__int _fellows_departed;

    // Generated Constructor
    public Fellowship(ACBindings.Internal.Fellowship* that) {
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

    /// <summary>
    /// <code>Offset: 0x0048EDA0
    /// Fellow* __thiscall Fellowship::GetFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.Fellow* GetFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*>)0x0048EDA0)(ref this, fellow);

    /// <summary>
    /// <code>Offset: 0x0056AA40
    /// void __thiscall Fellowship::~Fellowship(Fellowship*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void>)0x0056AA40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0056AAD0
    /// void __thiscall Fellowship::Fellowship(Fellowship*,const Fellowship*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Fellowship* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, ACBindings.Internal.Fellowship*, void>)0x0056AAD0)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005BA1B0
    /// int __thiscall Fellowship::IsFull(Fellowship*)</code>
    /// </summary>
    public int IsFull() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, int>)0x005BA1B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BA1C0
    /// int __thiscall Fellowship::IsFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    public int IsFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, int>)0x005BA1C0)(ref this, fellow);

    /// <summary>
    /// <code>Offset: 0x005BA210
    /// int __thiscall Fellowship::InqFellow(Fellowship*,unsigned int,Fellow*)</code>
    /// </summary>
    public int InqFellow(uint fellow, ACBindings.Internal.Fellow* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*, int>)0x005BA210)(ref this, fellow, retval);

    /// <summary>
    /// <code>Offset: 0x005BA270
    /// unsigned int __thiscall Fellowship::CalculateExperienceProportionSum(Fellowship*)</code>
    /// </summary>
    public uint CalculateExperienceProportionSum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA270)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BA2F0
    /// unsigned int __thiscall Fellowship::GetLeadersLevel(Fellowship*)</code>
    /// </summary>
    public uint GetLeadersLevel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA2F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BA340
    /// unsigned int __thiscall Fellowship::GetNonLeaderFellowID(Fellowship*)</code>
    /// </summary>
    public uint GetNonLeaderFellowID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA340)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BA3B0
    /// void __thiscall Fellowship::HandleLockedRemoveFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    public void HandleLockedRemoveFellow(uint fellow_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, void>)0x005BA3B0)(ref this, fellow_id);

    /// <summary>
    /// <code>Offset: 0x005BA420
    /// void __thiscall Fellowship::RecalculateEvenXPSplitting(Fellowship*)</code>
    /// </summary>
    public void RecalculateEvenXPSplitting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void>)0x005BA420)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BA4E0
    /// unsigned int __thiscall Fellowship::GetPackSize(Fellowship*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint>)0x005BA4E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BA530
    /// unsigned int __thiscall Fellowship::Pack(Fellowship*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void**, uint, uint>)0x005BA530)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BA5C0
    /// int __thiscall Fellowship::AddFellow(Fellowship*,unsigned int,const Fellow*)</code>
    /// </summary>
    public int AddFellow(uint fellow_id, ACBindings.Internal.Fellow* fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*, int>)0x005BA5C0)(ref this, fellow_id, fellow);

    /// <summary>
    /// <code>Offset: 0x005BA630
    /// int __thiscall Fellowship::UnPack(Fellowship*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void**, uint, int>)0x005BA630)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BA7C0
    /// int __thiscall Fellowship::RemoveFellow(Fellowship*,unsigned int)</code>
    /// </summary>
    public int RemoveFellow(uint fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, int>)0x005BA7C0)(ref this, fellow);

    /// <summary>
    /// <code>Offset: 0x005BA870
    /// int __thiscall Fellowship::UpdateFellow(Fellowship*,unsigned int,const Fellow*)</code>
    /// </summary>
    public int UpdateFellow(uint fellow_id, ACBindings.Internal.Fellow* fellow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, uint, ACBindings.Internal.Fellow*, int>)0x005BA870)(ref this, fellow_id, fellow);

    /// <summary>
    /// <code>Offset: 0x005BA8E0
    /// void __thiscall Fellowship::Fellowship(Fellowship*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellowship, void>)0x005BA8E0)(ref this);
}

