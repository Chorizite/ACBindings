namespace ACBindings;

// SmartBuffer
public unsafe struct SmartBuffer
{
    // Members
    public uint m_startOffset;
    public uint m_size;
    public ACBindings.GrowBuffer* m_masterBuffer;

    // Generated Constructor
    public SmartBuffer() {
        _ConstructorInternal();
    }
    public SmartBuffer(ACBindings.SmartBuffer* i_rhs) {
        _ConstructorInternal(i_rhs);
    }
    public SmartBuffer(byte* i_addr, uint i_size) {
        _ConstructorInternal(i_addr, i_size);
    }

    // Methods
    // void __thiscall SmartBuffer::SmartBuffer(SmartBuffer*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, void>)0x00406D60)(ref this);
    // char __thiscall SmartBuffer::CanGrow(SmartBuffer*)
    public sbyte CanGrow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, sbyte>)0x00406D70)(ref this);
    // unsigned __int8* __thiscall SmartBuffer::GetBuffer(SmartBuffer*)
    public byte* GetBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, byte*>)0x00406D80)(ref this);
    // unsigned __int8* __thiscall SmartBuffer::Orphan(SmartBuffer*)
    public byte* Orphan() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, byte*>)0x00406D90)(ref this);
    // unsigned int __thiscall SmartBuffer::GetSize(SmartBuffer*)
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, uint>)0x00406DB0)(ref this);
    // unsigned int __thiscall SmartBuffer::GetShareCount(SmartBuffer*)
    public uint GetShareCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, uint>)0x00406DC0)(ref this);
    // void __thiscall SmartBuffer::SmartBuffer(SmartBuffer*,const SmartBuffer*)
    public void _ConstructorInternal(ACBindings.SmartBuffer* i_rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, ACBindings.SmartBuffer*, void>)0x00406F60)(ref this, i_rhs);
    // void __thiscall SmartBuffer::ReleaseMasterBuffer(SmartBuffer*)
    public void ReleaseMasterBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, void>)0x00406F90)(ref this);
    // void __thiscall SmartBuffer::SmartBuffer(SmartBuffer*,unsigned __int8*,unsigned int)
    public void _ConstructorInternal(byte* i_addr, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, byte*, uint, void>)0x00407060)(ref this, i_addr, i_size);
    // SmartBuffer* __thiscall SmartBuffer::MakeWindow(SmartBuffer*,SmartBuffer*,unsigned int,unsigned int)
    public ACBindings.SmartBuffer* MakeWindow(ACBindings.SmartBuffer* result, uint i_start, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, ACBindings.SmartBuffer*, uint, uint, ACBindings.SmartBuffer*>)0x00407140)(ref this, result, i_start, i_size);
    // void __thiscall SmartBuffer::CreateNewMasterBuffer(SmartBuffer*)
    public void CreateNewMasterBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, void>)0x004071E0)(ref this);
    // SmartBuffer* __thiscall SmartBuffer::MakeWindow(SmartBuffer*,SmartBuffer*,unsigned int)
    public ACBindings.SmartBuffer* MakeWindow(ACBindings.SmartBuffer* result, uint i_start) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, ACBindings.SmartBuffer*, uint, ACBindings.SmartBuffer*>)0x00407390)(ref this, result, i_start);
    // void __thiscall SmartBuffer::Borrow(SmartBuffer*,unsigned __int8*,unsigned int)
    public void Borrow(byte* i_addr, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, byte*, uint, void>)0x004073B0)(ref this, i_addr, i_size);
    // SmartBuffer* __thiscall SmartBuffer::Clone(SmartBuffer*,SmartBuffer*)
    public ACBindings.SmartBuffer* Clone(ACBindings.SmartBuffer* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, ACBindings.SmartBuffer*, ACBindings.SmartBuffer*>)0x004073F0)(ref this, result);
    // void __thiscall SmartBuffer::ReconfigureAllocation(SmartBuffer*,unsigned int,char)
    public void ReconfigureAllocation(uint i_sizeNeeded, sbyte i_dwBehaviorBits) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SmartBuffer, uint, sbyte, void>)0x004074B0)(ref this, i_sizeNeeded, i_dwBehaviorBits);
}

