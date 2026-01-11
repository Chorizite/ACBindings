namespace ACBindings.Internal;

public unsafe struct ShortCutManager
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ShortCutManager_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, void> ShortCutManager_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutManager*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public fixed byte shortCuts__Raw[18 * 4];
    public ACBindings.Internal.ShortCutData** shortCuts_ => (ACBindings.Internal.ShortCutData**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref shortCuts__Raw[0]);

    // Generated Constructor
    public ShortCutManager() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D6770
    /// void __thiscall ShortCutManager::Destroy(ShortCutManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void>)0x005D6770)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D67A0
    /// void __thiscall ShortCutManager::RemoveShortCut(ShortCutManager*,const int)</code>
    /// </summary>
    public void RemoveShortCut(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, int, void>)0x005D67A0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x005D67D0
    /// unsigned int __thiscall ShortCutManager::pack_size(ShortCutManager*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, uint>)0x005D67D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D6820
    /// unsigned int __thiscall ShortCutManager::Pack(ShortCutManager*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void**, uint, uint>)0x005D6820)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D6880
    /// void __thiscall ShortCutManager::ShortCutManager(ShortCutManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void>)0x005D6880)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D68A0
    /// int __thiscall ShortCutManager::AddShortCut(ShortCutManager*,const ShortCutData*)</code>
    /// </summary>
    public int AddShortCut(ACBindings.Internal.ShortCutData* scData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, ACBindings.Internal.ShortCutData*, int>)0x005D68A0)(ref this, scData);

    /// <summary>
    /// <code>Offset: 0x005D6930
    /// int __thiscall ShortCutManager::UnPack(ShortCutManager*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutManager, void**, uint, int>)0x005D6930)(ref this, addr, size);
}

