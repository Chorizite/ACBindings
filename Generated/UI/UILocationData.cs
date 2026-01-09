namespace ACBindings;

// UILocationData
public unsafe struct UILocationData
{
    // Members
    public float m_x0;
    public float m_y0;
    public float m_x1;
    public float m_y1;
    public byte m_shown;

    // Generated Constructor
    public UILocationData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall UILocationData::UILocationData(UILocationData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UILocationData, void>)0x006791D0)(ref this);
}

