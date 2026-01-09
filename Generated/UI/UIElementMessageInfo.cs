namespace ACBindings;

// UIElementMessageInfo
public unsafe struct UIElementMessageInfo
{
    // Members
    public uint idElement;
    public ACBindings.UIElement* pElement;
    public uint idMessage;
    public uint dwParam1;
    public uint dwParam2;
    public ACBindings.tagPOINT ptWindow;
    public ACBindings.tagPOINT ptElement;
    public ACBindings.CTimestamp__uint tsSerialNumber;

    // Generated Constructor
    public UIElementMessageInfo(uint i_idElement, ACBindings.UIElement* i_pElement, uint i_idMessage, uint i_dwParam1, uint i_dwParam2, int i_xWindow, int i_yWindow, int i_xElement, int i_yElement) {
        _ConstructorInternal(i_idElement, i_pElement, i_idMessage, i_dwParam1, i_dwParam2, i_xWindow, i_yWindow, i_xElement, i_yElement);
    }
    public UIElementMessageInfo(ACBindings.UIElementMessageInfo* that) {
        _ConstructorInternal(that);
    }

    // Methods
    // void __thiscall UIElementMessageInfo::UIElementMessageInfo(UIElementMessageInfo*,unsigned int,UIElement*,unsigned int,unsigned int,unsigned int,int,int,int,int)
    public void _ConstructorInternal(uint i_idElement, ACBindings.UIElement* i_pElement, uint i_idMessage, uint i_dwParam1, uint i_dwParam2, int i_xWindow, int i_yWindow, int i_xElement, int i_yElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementMessageInfo, uint, ACBindings.UIElement*, uint, uint, uint, int, int, int, int, void>)0x00459660)(ref this, i_idElement, i_pElement, i_idMessage, i_dwParam1, i_dwParam2, i_xWindow, i_yWindow, i_xElement, i_yElement);
    // void __thiscall UIElementMessageInfo::UIElementMessageInfo(UIElementMessageInfo*,const UIElementMessageInfo*)
    public void _ConstructorInternal(ACBindings.UIElementMessageInfo* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementMessageInfo, ACBindings.UIElementMessageInfo*, void>)0x00459CE0)(ref this, that);
}

