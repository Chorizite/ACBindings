namespace ACBindings.Internal;

public unsafe struct Trade
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Trade_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, void> Trade_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Trade*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableList___ContentProfile _self_list;
    public ACBindings.Internal.PackableList___ContentProfile _partner_list;
    public uint _partner;
    public double _stamp;
    public uint _status;
    public int _initiator;
    public int _accepted;
    public int _p_accepted;

    // Generated Constructor
    public Trade() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BB030
    /// int __thiscall Trade::Register(Trade*,unsigned int,long double)</code>
    /// </summary>
    public int Register(uint partner, double stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, double, int>)0x005BB030)(ref this, partner, stamp);

    /// <summary>
    /// <code>Offset: 0x005BB060
    /// unsigned int __thiscall Trade::GetPackSize(Trade*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB060)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB0E0
    /// int __thiscall Trade::IsPartnerTradingItem(Trade*,unsigned int)</code>
    /// </summary>
    public int IsPartnerTradingItem(uint item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, int>)0x005BB0E0)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x005BB130
    /// unsigned int __thiscall Trade::Pack(Trade*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, void**, uint, uint>)0x005BB130)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BB1C0
    /// unsigned int __thiscall Trade::GetNumItems(Trade*)</code>
    /// </summary>
    public uint GetNumItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB1C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB1E0
    /// unsigned int __thiscall Trade::GetNumContainers(Trade*)</code>
    /// </summary>
    public uint GetNumContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB1E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB200
    /// unsigned int __thiscall Trade::GetNumPartnerItems(Trade*)</code>
    /// </summary>
    public uint GetNumPartnerItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB200)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB220
    /// unsigned int __thiscall Trade::GetNumPartnerContainers(Trade*)</code>
    /// </summary>
    public uint GetNumPartnerContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint>)0x005BB220)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB2F0
    /// int __stdcall Trade::AddItem(unsigned int,_DWORD*,int)</code>
    /// </summary>
    public static int AddItem(uint iid, int* a2, int a3) => ((delegate* unmanaged[Stdcall]<uint, int*, int, int>)0x005BB2F0)(iid, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005BB450
    /// int __thiscall Trade::AddItem(Trade*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public int AddItem(uint item, uint id, uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, uint, uint, int>)0x005BB450)(ref this, item, id, loc);

    /// <summary>
    /// <code>Offset: 0x005BB4E0
    /// int __thiscall Trade::RemoveItem(Trade*,unsigned int,unsigned int)</code>
    /// </summary>
    public int RemoveItem(uint item, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, uint, uint, int>)0x005BB4E0)(ref this, item, id);

    /// <summary>
    /// <code>Offset: 0x005BB570
    /// int __thiscall Trade::Reset(Trade*)</code>
    /// </summary>
    public int Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, int>)0x005BB570)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BB5A0
    /// int __thiscall Trade::UnPack(Trade*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, void**, uint, int>)0x005BB5A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BB6A0
    /// void __thiscall Trade::Trade(Trade*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Trade, void>)0x005BB6A0)(ref this);
}

