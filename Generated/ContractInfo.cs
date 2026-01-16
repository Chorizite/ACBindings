namespace ACBindings.Internal;


/// <summary>Defines contract metadata, storing name and status strings while managing lifecycle via a contract tracker.</summary>
/// <remarks>Represents a contractual entity within the system, facilitating state transitions and providing descriptive information for runtime operations.</remarks>
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

    /// <summary>Destroys a ContractInfo instance, releasing its status and name strings and resetting the contract tracker base class vtable.
    /// <code>Offset: 0x00497DF0
    /// void __thiscall ContractInfo::~ContractInfo(ContractInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContractInfo, void>)0x00497DF0)(ref this);

    /// <summary>Creates a ContractInfo object, initializing the name and status strings to empty values with proper reference counting and constructing its contract tracker.
    /// <code>Offset: 0x00497E40
    /// void __thiscall ContractInfo::ContractInfo(ContractInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContractInfo, void>)0x00497E40)(ref this);

    /// <summary>Copies the contents of another ContractInfo into this instance, initializing its name, status strings and contract tracker with values from the source object.
    /// <code>Offset: 0x00497FE0
    /// void __thiscall ContractInfo::ContractInfo(ContractInfo*,const ContractInfo*)</code>
    /// </summary>
    /// <param name="rhs">The ContractInfo instance whose data will be copied.</param>
    public void _ConstructorInternal(ACBindings.Internal.ContractInfo* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContractInfo, ACBindings.Internal.ContractInfo*, void>)0x00497FE0)(ref this, rhs);
}

