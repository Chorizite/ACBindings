namespace ACBindings;

// ContractInfo
public unsafe struct ContractInfo : System.IDisposable
{
    // Members
    public ACBindings.PStringBase__ushort m_Name;
    public ACBindings.PStringBase__ushort m_Status;
    public ACBindings.CContractTracker m_ContractTracker;

    // Generated Constructor
    public ContractInfo() {
        _ConstructorInternal();
    }
    public ContractInfo(ACBindings.ContractInfo* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ContractInfo::~ContractInfo(ContractInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContractInfo, void>)0x00497DF0)(ref this);
    // void __thiscall ContractInfo::ContractInfo(ContractInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContractInfo, void>)0x00497E40)(ref this);
    // void __thiscall ContractInfo::ContractInfo(ContractInfo*,const ContractInfo*)
    public void _ConstructorInternal(ACBindings.ContractInfo* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContractInfo, ACBindings.ContractInfo*, void>)0x00497FE0)(ref this, rhs);
}

