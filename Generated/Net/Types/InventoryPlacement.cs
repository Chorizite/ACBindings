namespace ACBindings.Internal;

public unsafe struct InventoryPlacement
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct InventoryPlacement_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, void> InventoryPlacement_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InventoryPlacement*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint iid_;
    public uint loc_;
    public uint priority_;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A3880
    /// unsigned int __thiscall InventoryPlacement::Pack(ShortCutData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InventoryPlacement, void**, uint, uint>)0x004A3880)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004A38C0
    /// int __thiscall InventoryPlacement::UnPack(InventoryPlacement*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InventoryPlacement, void**, uint, int>)0x004A38C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004A4820
    /// InventoryPlacement* __cdecl InventoryPlacement::DetermineHigherPriority(InventoryPlacement*,InventoryPlacement*,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.InventoryPlacement* DetermineHigherPriority(ACBindings.Internal.InventoryPlacement* ip1, ACBindings.Internal.InventoryPlacement* ip2, uint releventLocations) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.InventoryPlacement*, ACBindings.Internal.InventoryPlacement*, uint, ACBindings.Internal.InventoryPlacement*>)0x004A4820)(ip1, ip2, releventLocations);
}

