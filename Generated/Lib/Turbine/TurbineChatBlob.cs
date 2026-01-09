namespace ACBindings;

// TurbineChatBlob
public unsafe struct TurbineChatBlob
{
    // Members
    public uint m_targetID;
    public int m_hResult;
    public uint m_ChatType;

    // Methods
    // void __thiscall TurbineChatBlob::SetTargetID(TurbineChatBlob*,unsigned int)
    public void SetTargetID(uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TurbineChatBlob, uint, void>)0x0051C6F0)(ref this, targetID);
    // tagBLOB __thiscall TurbineChatBlob::GetBlob(TurbineChatBlob*)
    public ACBindings.tagBLOB GetBlob() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TurbineChatBlob, ACBindings.tagBLOB>)0x005CE950)(ref this);
}

