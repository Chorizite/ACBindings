namespace ACBindings;

// PageInfo
public unsafe struct PageInfo
{
    // Members
    public ACBindings.PStringBase__ushort m_Label;
    public ACBindings.PStringBase__ushort m_Title;
    public ACBindings.PStringBase__ushort m_Notes;
    public int m_PageNumber;
    public byte m_TimerRunning;
    public double m_TimerStamp;
    public int m_Days;
    public int m_Hours;
    public int m_Minutes;
    public byte m_LocationSet;
    public double m_xCoord;
    public double m_yCoord;

    // Generated Constructor
    public PageInfo() {
        _ConstructorInternal();
    }
    public PageInfo(ACBindings.PageInfo* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall PageInfo::PageInfo(PageInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageInfo, void>)0x00494E50)(ref this);
    // void __thiscall PageInfo::Clear(PageInfo*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageInfo, void>)0x00494F70)(ref this);
    // void __thiscall PageInfo::PageInfo(PageInfo*,const PageInfo*)
    public void _ConstructorInternal(ACBindings.PageInfo* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PageInfo, ACBindings.PageInfo*, void>)0x004951D0)(ref this, rhs);
}

