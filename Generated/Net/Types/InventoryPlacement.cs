namespace ACBindings;

// InventoryPlacement
public unsafe struct InventoryPlacement
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // InventoryPlacement_vtbl
    public unsafe struct InventoryPlacement_vtbl
    {
        // Members
        public System.IntPtr InventoryPlacement_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint iid_;
    public uint loc_;
    public uint priority_;

    // Methods
    // unsigned int __thiscall InventoryPlacement::Pack(ShortCutData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InventoryPlacement, void**, uint, uint>)0x004A3880)(ref this, addr, size);
    // int __thiscall InventoryPlacement::UnPack(InventoryPlacement*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InventoryPlacement, void**, uint, int>)0x004A38C0)(ref this, addr, size);
    // InventoryPlacement* __cdecl InventoryPlacement::DetermineHigherPriority(InventoryPlacement*,InventoryPlacement*,unsigned int)
    public static ACBindings.InventoryPlacement* DetermineHigherPriority(ACBindings.InventoryPlacement* ip1, ACBindings.InventoryPlacement* ip2, uint releventLocations) => ((delegate* unmanaged[Cdecl]<ACBindings.InventoryPlacement*, ACBindings.InventoryPlacement*, uint, ACBindings.InventoryPlacement*>)0x004A4820)(ip1, ip2, releventLocations);
}

