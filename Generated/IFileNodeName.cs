namespace ACBindings.Internal;


/// <summary>Represents an interface that defines the contract for file node names, enabling polymorphic handling of name-related operations.</summary>
/// <remarks>This struct contains only a virtual function table pointer, indicating it serves as a base class for concrete implementations that manage file node identifiers.</remarks>
public unsafe struct IFileNodeName
{
    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>Retrieves the NodeNameType of a file node; if the supplied pointer is null, returns an invalid sentinel value.
    /// <code>Offset: 0x0065AF90
    /// NodeNameType __cdecl IFileNodeName::GetNameType(IFileNodeName*)</code>
    /// </summary>
    /// <param name="i_pcName">Pointer to the IFileNodeName instance whose type should be queried.</param>
    /// <returns>The NodeNameType of the specified file node or 255 when the input is null.</returns>
    public static ACBindings.Internal.NodeNameType GetNameType(ACBindings.Internal.IFileNodeName* i_pcName) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IFileNodeName*, ACBindings.Internal.NodeNameType>)0x0065AF90)(i_pcName);

    /// <summary>Creates an IFileNodeName object appropriate for the supplied NodeNameType enumeration, allocating a derived instance for each supported type.
    /// <code>Offset: 0x0065B7C0
    /// IFileNodeName* __cdecl IFileNodeName::CreateFromEnum(NodeNameType)</code>
    /// </summary>
    /// <param name="i_enumType">The enum value indicating which file node name implementation to create.</param>
    /// <returns>A pointer to the newly allocated IFileNodeName object, or nullptr if the type is unsupported or memory allocation fails.</returns>
    public static ACBindings.Internal.IFileNodeName* CreateFromEnum(ACBindings.Internal.NodeNameType i_enumType) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.NodeNameType, ACBindings.Internal.IFileNodeName*>)0x0065B7C0)(i_enumType);
}

