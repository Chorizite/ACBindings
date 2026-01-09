namespace ACBindings;

// InstanceDiviner
public unsafe struct InstanceDiviner
{
    // Members
    public ACBindings.PStringBase__sbyte m_NameStem;
    public System.IntPtr m_hMutex;
    public uint m_Index;

    // Generated Constructor
    public InstanceDiviner(int a2, sbyte a3, int a4) {
        _ConstructorInternal(a2, a3, a4);
    }

    // Methods
    // const char* __thiscall InstanceDiviner::AllocateIndex(const char**,int,int)
    public sbyte* AllocateIndex(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceDiviner, int, int, sbyte*>)0x0040EB80)(ref this, a2, a3);
    // int __thiscall InstanceDiviner::InstanceDiviner(int,int,char,int)
    public int _ConstructorInternal(int a2, sbyte a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceDiviner, int, sbyte, int, int>)0x0040EE10)(ref this, a2, a3, a4);
}

