namespace ACBindings.Internal;

public unsafe struct CCliDatEvent
{
    // Base Classes
    public ACBindings.Internal.NetBlob BaseClass_NetBlob; // ACBindings.Internal.NetBlob

    // Child Types
    public unsafe struct CCliDatEvent_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CCliDatEvent*, void> CCliDatEvent_dtor_0; // function pointer

        // Methods
    }
    public unsafe struct CDataFormat
    {
        // Members
        public uint eventType;

        // Methods
    }

    // Generated Constructor
    public CCliDatEvent(byte* pData, int DataLen) {
        _ConstructorInternal(pData, DataLen);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A82F0
    /// void __thiscall CCliDatEvent::CCliDatEvent(CCliDatEvent*,unsigned __int8*,int)</code>
    /// </summary>
    public void _ConstructorInternal(byte* pData, int DataLen) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCliDatEvent, byte*, int, void>)0x005A82F0)(ref this, pData, DataLen);
}

