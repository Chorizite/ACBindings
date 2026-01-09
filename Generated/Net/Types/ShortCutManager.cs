namespace ACBindings;

// ShortCutManager
public unsafe struct ShortCutManager
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ShortCutManager_vtbl
    public unsafe struct ShortCutManager_vtbl
    {
        // Members
        public System.IntPtr ShortCutManager_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public fixed byte shortCuts__Raw[18 * 4];
    public ACBindings.ShortCutData** shortCuts_ => (ACBindings.ShortCutData**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref shortCuts__Raw[0]);

    // Generated Constructor
    public ShortCutManager() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall ShortCutManager::Destroy(ShortCutManager*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutManager, void>)0x005D6770)(ref this);
    // void __thiscall ShortCutManager::RemoveShortCut(ShortCutManager*,const int)
    public void RemoveShortCut(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutManager, int, void>)0x005D67A0)(ref this, index);
    // unsigned int __thiscall ShortCutManager::pack_size(ShortCutManager*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutManager, uint>)0x005D67D0)(ref this);
    // unsigned int __thiscall ShortCutManager::Pack(ShortCutManager*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutManager, void**, uint, uint>)0x005D6820)(ref this, addr, size);
    // void __thiscall ShortCutManager::ShortCutManager(ShortCutManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutManager, void>)0x005D6880)(ref this);
    // int __thiscall ShortCutManager::AddShortCut(ShortCutManager*,const ShortCutData*)
    public int AddShortCut(ACBindings.ShortCutData* scData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutManager, ACBindings.ShortCutData*, int>)0x005D68A0)(ref this, scData);
    // int __thiscall ShortCutManager::UnPack(ShortCutManager*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ShortCutManager, void**, uint, int>)0x005D6930)(ref this, addr, size);
}

