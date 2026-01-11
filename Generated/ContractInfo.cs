namespace ACBindings.Internal;

public unsafe struct ContractInfo : System.IDisposable
{
    // Members
    public ACBindings.Internal.PStringBase__ushort m_Name;
    public ACBindings.Internal.PStringBase__ushort m_Status;
    public ACBindings.Internal.CContractTracker m_ContractTracker;

    // Generated Constructor
    public ContractInfo() {
        _ConstructorInternal();
    }
    public ContractInfo(ACBindings.Internal.ContractInfo* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00497DF0
    /// void __thiscall ContractInfo::~ContractInfo(ContractInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContractInfo, void>)0x00497DF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00497E40
    /// void __thiscall ContractInfo::ContractInfo(ContractInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContractInfo, void>)0x00497E40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00497FE0
    /// void __thiscall ContractInfo::ContractInfo(ContractInfo*,const ContractInfo*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ContractInfo* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContractInfo, ACBindings.Internal.ContractInfo*, void>)0x00497FE0)(ref this, rhs);
}

