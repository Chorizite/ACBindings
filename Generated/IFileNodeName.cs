namespace ACBindings.Internal;

public unsafe struct IFileNodeName
{
    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065AF90
    /// NodeNameType __cdecl IFileNodeName::GetNameType(IFileNodeName*)</code>
    /// </summary>
    public static ACBindings.Internal.NodeNameType GetNameType(ACBindings.Internal.IFileNodeName* i_pcName) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IFileNodeName*, ACBindings.Internal.NodeNameType>)0x0065AF90)(i_pcName);

    /// <summary>
    /// <code>Offset: 0x0065B7C0
    /// IFileNodeName* __cdecl IFileNodeName::CreateFromEnum(NodeNameType)</code>
    /// </summary>
    public static ACBindings.Internal.IFileNodeName* CreateFromEnum(ACBindings.Internal.NodeNameType i_enumType) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.NodeNameType, ACBindings.Internal.IFileNodeName*>)0x0065B7C0)(i_enumType);
}

