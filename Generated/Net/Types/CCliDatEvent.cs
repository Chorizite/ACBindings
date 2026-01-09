namespace ACBindings;

// CCliDatEvent
public unsafe struct CCliDatEvent
{
    // Base Classes
    public ACBindings.NetBlob BaseClass_NetBlob; // ACBindings.NetBlob

    // Child Types
    // CCliDatEvent_vtbl
    public unsafe struct CCliDatEvent_vtbl
    {
        // Members
        public System.IntPtr CCliDatEvent_dtor_0; // function pointer

        // Methods
    }
    // CCliDatEvent::CDataFormat
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
    // void __thiscall CCliDatEvent::CCliDatEvent(CCliDatEvent*,unsigned __int8*,int)
    public void _ConstructorInternal(byte* pData, int DataLen) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCliDatEvent, byte*, int, void>)0x005A82F0)(ref this, pData, DataLen);
}

