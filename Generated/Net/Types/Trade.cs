namespace ACBindings;

// Trade
public unsafe struct Trade
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Trade_vtbl
    public unsafe struct Trade_vtbl
    {
        // Members
        public System.IntPtr Trade_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableList__ContentProfile _self_list;
    public ACBindings.PackableList__ContentProfile _partner_list;
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
    // int __thiscall Trade::Register(Trade*,unsigned int,long double)
    public int Register(uint partner, double stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint, double, int>)0x005BB030)(ref this, partner, stamp);
    // unsigned int __thiscall Trade::GetPackSize(Trade*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint>)0x005BB060)(ref this);
    // int __thiscall Trade::IsPartnerTradingItem(Trade*,unsigned int)
    public int IsPartnerTradingItem(uint item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint, int>)0x005BB0E0)(ref this, item);
    // unsigned int __thiscall Trade::Pack(Trade*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, void**, uint, uint>)0x005BB130)(ref this, addr, size);
    // unsigned int __thiscall Trade::GetNumItems(Trade*)
    public uint GetNumItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint>)0x005BB1C0)(ref this);
    // unsigned int __thiscall Trade::GetNumContainers(Trade*)
    public uint GetNumContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint>)0x005BB1E0)(ref this);
    // unsigned int __thiscall Trade::GetNumPartnerItems(Trade*)
    public uint GetNumPartnerItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint>)0x005BB200)(ref this);
    // unsigned int __thiscall Trade::GetNumPartnerContainers(Trade*)
    public uint GetNumPartnerContainers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint>)0x005BB220)(ref this);
    // int __stdcall Trade::AddItem(unsigned int,_DWORD*,int)
    public static int AddItem(uint iid, int* a2, int a3) => ((delegate* unmanaged[Stdcall]<uint, int*, int, int>)0x005BB2F0)(iid, a2, a3);
    // int __thiscall Trade::AddItem(Trade*,unsigned int,unsigned int,unsigned int)
    public int AddItem(uint item, uint id, uint loc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint, uint, uint, int>)0x005BB450)(ref this, item, id, loc);
    // int __thiscall Trade::RemoveItem(Trade*,unsigned int,unsigned int)
    public int RemoveItem(uint item, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, uint, uint, int>)0x005BB4E0)(ref this, item, id);
    // int __thiscall Trade::Reset(Trade*)
    public int Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, int>)0x005BB570)(ref this);
    // int __thiscall Trade::UnPack(Trade*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, void**, uint, int>)0x005BB5A0)(ref this, addr, size);
    // void __thiscall Trade::Trade(Trade*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Trade, void>)0x005BB6A0)(ref this);
}

