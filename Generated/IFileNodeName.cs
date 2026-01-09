namespace ACBindings;

// IFileNodeName
public unsafe struct IFileNodeName
{
    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
    // NodeNameType __cdecl IFileNodeName::GetNameType(IFileNodeName*)
    public static ACBindings.NodeNameType GetNameType(ACBindings.IFileNodeName* i_pcName) => ((delegate* unmanaged[Cdecl]<ACBindings.IFileNodeName*, ACBindings.NodeNameType>)0x0065AF90)(i_pcName);
    // IFileNodeName* __cdecl IFileNodeName::CreateFromEnum(NodeNameType)
    public static ACBindings.IFileNodeName* CreateFromEnum(ACBindings.NodeNameType i_enumType) => ((delegate* unmanaged[Cdecl]<ACBindings.NodeNameType, ACBindings.IFileNodeName*>)0x0065B7C0)(i_enumType);
}

