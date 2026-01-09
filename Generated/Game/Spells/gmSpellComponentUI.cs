namespace ACBindings;

// gmSpellComponentUI
public unsafe struct gmSpellComponentUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmSpellComponentUI_vtbl
    public unsafe struct gmSpellComponentUI_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer

        // Methods
    }
    // gmSpellComponentUI::ListBoxEntryType
    public enum ListBoxEntryType : byte
    {
        ComponentCategory_ListBoxEntryType = 0x0,
        Component_ListBoxEntryType = 0x1
    }

    // Members
    public uint selObjectID;
    public ACBindings.UIElement_ListBox* m_pComponentListBox;
    public ACBindings.SmartArray__uint m_aCategoryTitles;
    public ACBindings.HashTable__IDClass___tagDataID__SpellComponentRegion_ptr m_hashComponentRegions;
    public byte m_bBroadcastSelection;

    // Generated Constructor
    public gmSpellComponentUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmSpellComponentUI::RecvNotice_SelectionChanged(gmSpellComponentUI*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, void>)0x00489F70)(ref this);
    // void __stdcall gmSpellComponentUI::MakeIcon(unsigned int,UIRegion*)
    public static void MakeIcon(uint a1, ACBindings.UIRegion* a2) => ((delegate* unmanaged[Stdcall]<uint, ACBindings.UIRegion*, void>)0x0048A250)(a1, a2);
    // void __thiscall gmSpellComponentUI::UpdateBuyRates(_DWORD*,int)
    public void UpdateBuyRates(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, int, void>)0x0048A310)(ref this, a2);
    // void __thiscall gmSpellComponentUI::PostInit(gmSpellComponentUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, void>)0x0048A4C0)(ref this);
    // void __thiscall gmSpellComponentUI::RecvNotice_PlayerDescReceived(gmSpellComponentUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x0048A650)(ref this, i_playerDesc, i_playerModule);
    // UIElementMessageListenResult __thiscall gmSpellComponentUI::ListenToElementMessage(gmSpellComponentUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0048A700)(ref this, i_rMsg);
    // void __thiscall gmSpellComponentUI::SyncComponentRegionWithData(gmSpellComponentUI*,const UIElement*,const ComponentData*)
    public void SyncComponentRegionWithData(ACBindings.UIElement* pListBoxEntry, ACBindings.ComponentData* i_pData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, ACBindings.UIElement*, ACBindings.ComponentData*, void>)0x0048A900)(ref this, pListBoxEntry, i_pData);
    // void __thiscall gmSpellComponentUI::gmSpellComponentUI(gmSpellComponentUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0048AA50)(ref this, layout, full_desc);
    // UIElement* __thiscall gmSpellComponentUI::DynamicCast(gmSpellComponentUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, uint, ACBindings.UIElement*>)0x0048AAD0)(ref this, i_eType);
    // unsigned int __thiscall gmSpellComponentUI::GetUIElementType(gmSpellComponentUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, uint>)0x0048AAF0)(ref this);
    // void __thiscall gmSpellComponentUI::~gmSpellComponentUI(gmSpellComponentUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, void>)0x0048AB00)(ref this);
    // UIElement* __cdecl gmSpellComponentUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0048ABC0)(layout, full_desc);
    // void __thiscall gmSpellComponentUI::UpdateComponents(gmSpellComponentUI*,ComponentTrackerUpdate)
    public void UpdateComponents(ACBindings.ComponentTrackerUpdate change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, ACBindings.ComponentTrackerUpdate, void>)0x0048ABF0)(ref this, change);
    // void __cdecl gmSpellComponentUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048B0D0)();
    // void __thiscall gmSpellComponentUI::RecvNotice_UpdateSpellComponents(gmSpellComponentUI*,int)
    public void RecvNotice_UpdateSpellComponents(int i_change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSpellComponentUI, int, void>)0x0048B0F0)(ref this, i_change);
}

