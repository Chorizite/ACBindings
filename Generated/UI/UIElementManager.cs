namespace ACBindings;

// UIElementManager
public unsafe struct UIElementManager : System.IDisposable
{
    // Base Classes
    public ACBindings.CInputHandler BaseClass_CInputHandler; // ACBindings.CInputHandler
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback

    // Statics
    public static ACBindings.UIElementManager* s_pInstance = (ACBindings.UIElementManager*)0x0083E03C;

    // Child Types
    // UIElementManager_vtbl
    public unsafe struct UIElementManager_vtbl
    {
        // Members
        public System.IntPtr ActionHandler; // function pointer
        public System.IntPtr MouseMoveHandler; // function pointer
        public System.IntPtr MouseLookHandler; // function pointer
        public System.IntPtr FocusSwitchHandler; // function pointer
        public System.IntPtr CharacterHandler; // function pointer
        public System.IntPtr KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__UIElement_ptr m_deleteQueue;
    public ACBindings.SmartArray__UIElement_ptr m_elementList;
    public ACBindings.HashTable__uint__void_ptr m_classCreateMethodTable;
    public ACBindings.LayoutDesc* m_pHollowLayoutDesc;
    public ACBindings.ElementDesc* m_pHollowElementDesc;
    public ACBindings.UIElement* m_pRootElement;
    public ACBindings.Vector3 m_vGlobalScale;
    public ACBindings.AutoGrowHashTable__uint__AutoGrowHashTable__uint__SmartArray__UIMessageData m_elementListenerTable;
    public ACBindings.AutoGrowHashTable__uint__SmartArray__UIMessageData m_globalMessageListenerTable;
    public ACBindings.SmartArray__UIMessageRemovalData m_aUIMessageRemovalData;
    public ACBindings.AutoGrowHashTable__uint__SmartArray__UIElement_ptr m_elementInputActionListenerTable;
    public ACBindings.List__UIElementMessageInfo m_listQueuedElementMessages;
    public byte m_bBroadcastingMessage;
    public ACBindings.IDClass___tagDataID m_defaultCursorDID;
    public int m_defaultCursorHotX;
    public int m_defaultCursorHotY;
    public ACBindings.IDClass___tagDataID m_lastCursorDID;
    public int m_lastCursorHotX;
    public int m_lastCursorHotY;
    public byte m_bPerformMouseHitTest;
    public ACBindings.UIElement* m_pElementLastOver;
    public ACBindings.UIElement* m_pElementLastEntered;
    public ACBindings.UIElement* m_pElementWithMouseCapture;
    public ACBindings.UIElement* m_pElementLastDragCursorOver;
    public ACBindings.HashSet__uint m_setActionsTriggeringCapture;
    public uint m_nMouseCapture;
    public byte m_bDoVisualMouseDebugging;
    public ACBindings.IDClass___tagDataID m_debugFontDID;
    public byte m_bMouseHasLeftTheWindow;
    public double m_lastMouseMoveTime;
    public double m_tooltipStart;
    public byte m_tooltipEnable;
    public float m_tooltipDelay;
    public float m_tooltipDuration;
    public ACBindings.UIElement* m_pTooltipOwner;
    public ACBindings.UIElement* m_pTooltipElement;
    public double m_buttonDownTime;
    public int m_dragX;
    public int m_dragY;
    public int m_dragBaseX;
    public int m_dragBaseY;
    public ACBindings.UIElement* m_pcPotentialDragElement;
    public ACBindings.UIElement* m_dragElement;
    public ACBindings.UIElement* m_dragOwner;
    public byte m_bDragStarted;
    public byte m_bHoverStarted;
    public ACBindings.UIElement* m_focusElement;
    public ACBindings.UIElement* m_activeElement;
    public ACBindings.SmartArray__UIElement_ptr m_activatableElements;
    public ACBindings.ContextMenu* m_pCSM;

    // Generated Constructor
    public UIElementManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __cdecl UIElementManager::DestroyUIElementManager()
    public static void DestroyUIElementManager() => ((delegate* unmanaged[Cdecl]<void>)0x00459310)();
    // void __thiscall UIElementManager::StartHover(UIElementManager*,int,int)
    public void StartHover(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, int, int, void>)0x00459370)(ref this, i_xWindow, i_yWindow);
    // void __thiscall UIElementManager::StopHover(UIElementManager*)
    public void StopHover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x004593A0)(ref this);
    // void __thiscall UIElementManager::SetDurationForCurrentTooltip(UIElementManager*,float)
    public void SetDurationForCurrentTooltip(float i_secCustomDuration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, float, void>)0x004593E0)(ref this, i_secCustomDuration);
    // bool __thiscall UIElementManager::ClearDragandDrop(UIElementManager*)
    public byte ClearDragandDrop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, byte>)0x00459400)(ref this);
    // void __thiscall UIElementManager::SetVisible(UIElementManager*,bool)
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, byte, void>)0x00459440)(ref this, visible);
    // void __thiscall UIElementManager::ProcessUIMessageRemovalData(UIElementManager*)
    public void ProcessUIMessageRemovalData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x004596B0)(ref this);
    // void __thiscall UIElementManager::StartTooltip(UIElementManager*,UIElement*,UIElement*)
    public void StartTooltip(ACBindings.UIElement* i_pElementOwner, ACBindings.UIElement* i_pElementTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, ACBindings.UIElement*, void>)0x00459770)(ref this, i_pElementOwner, i_pElementTooltip);
    // void __thiscall UIElementManager::StopDragandDrop(UIElementManager*)
    public void StopDragandDrop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x00459880)(ref this);
    // void __thiscall UIElementManager::UnregisterActivatable(UIElementManager*,UIElement*)
    public void UnregisterActivatable(ACBindings.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x00459960)(ref this, element);
    // void __thiscall UIElementManager::ActivateNext(UIElementManager*,bool)
    public void ActivateNext(byte backwards) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, byte, void>)0x00459980)(ref this, backwards);
    // UIElement* __thiscall UIElementManager::GetElement(UIElementManager*,unsigned int)
    public ACBindings.UIElement* GetElement(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, ACBindings.UIElement*>)0x00459A00)(ref this, ID);
    // void __thiscall UIElementManager::CleanDeleteQueue(UIElementManager*)
    public void CleanDeleteQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045A350)(ref this);
    // const RenderSurface* __thiscall UIElementManager::SetCursor(_DWORD*,int,unsigned int,unsigned int,char)
    public ACBindings.RenderSurface* SetCursor(int a2, uint xHotSpot, uint yHotSpot, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, int, uint, uint, sbyte, ACBindings.RenderSurface*>)0x0045A910)(ref this, a2, xHotSpot, yHotSpot, a5);
    // bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,const UIElementMessageInfo*)
    public byte BroadcastElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElementMessageInfo*, byte>)0x0045AC50)(ref this, i_rMsg);
    // void __thiscall UIElementManager::CheckCursor(UIElementManager*)
    public void CheckCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045AD00)(ref this);
    // void __thiscall UIElementManager::DrawRegionWithObject(UIElementManager*,UIElement*,UIObject**)
    public void DrawRegionWithObject(ACBindings.UIElement* i_pElementWithObject, ACBindings.UIObject** io_pPrevObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, ACBindings.UIObject**, void>)0x0045AD80)(ref this, i_pElementWithObject, io_pPrevObject);
    // UIElement* __thiscall UIElementManager::CreateElementRecursiveFromFullDesc(UIElementManager*,const LayoutDesc*,const ElementDesc*)
    public ACBindings.UIElement* CreateElementRecursiveFromFullDesc(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0045B1A0)(ref this, layout, full_desc);
    // void __thiscall UIElementManager::AddElementToDeleteQueue(UIElementManager*,UIElement*)
    public void AddElementToDeleteQueue(ACBindings.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045B350)(ref this, element);
    // bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,unsigned int,UIElement*,unsigned int,int)
    public byte BroadcastElementMessage(uint elementID, ACBindings.UIElement* element, uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, ACBindings.UIElement*, uint, int, byte>)0x0045B3A0)(ref this, elementID, element, messageID, data_int);
    // bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,UIElement*,unsigned int,unsigned int,unsigned int)
    public byte BroadcastElementMessage(ACBindings.UIElement* i_pElement, uint i_idMessage, uint i_dwParam1, uint i_dwParam2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, uint, uint, uint, byte>)0x0045B450)(ref this, i_pElement, i_idMessage, i_dwParam1, i_dwParam2);
    // void __thiscall UIElementManager::BroadcastGlobalMessage(UIElementManager*,unsigned int,int)
    public void BroadcastGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, int, void>)0x0045B4C0)(ref this, messageID, data_int);
    // void __thiscall UIElementManager::UnRegisterForMessageInternal(int*,int,_DWORD*,int)
    public void UnRegisterForMessageInternal(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, int, int*, int, void>)0x0045B540)(ref this, a2, a3, a4);
    // void __thiscall UIElementManager::UnRegisterForAllMessagesInternal(int*,int,int)
    public void UnRegisterForAllMessagesInternal(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, int, int, void>)0x0045B5D0)(ref this, a2, a3);
    // void __thiscall UIElementManager::SwitchMouseOver(UIElementManager*,UIElement*)
    public void SwitchMouseOver(ACBindings.UIElement* pCurMouseOver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045B640)(ref this, pCurMouseOver);
    // bool __thiscall UIElementManager::DoVisibilityToggleAction(UIElementManager*,unsigned int)
    public byte DoVisibilityToggleAction(uint action) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, byte>)0x0045B740)(ref this, action);
    // void __thiscall UIElementManager::CheckTooltip(UIElementManager*)
    public void CheckTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045B7C0)(ref this);
    // void __thiscall UIElementManager::DrawRegion(UIElementManager*,UIElement*,UIObject**)
    public void DrawRegion(ACBindings.UIElement* i_pElement, ACBindings.UIObject** io_pPrevObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, ACBindings.UIObject**, void>)0x0045B8A0)(ref this, i_pElement, io_pPrevObject);
    // void __thiscall UIElementManager::DrawDirtyRegions(UIElementManager*)
    public void DrawDirtyRegions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045B900)(ref this);
    // void __thiscall UIElementManager::SetFocusElement(UIElementManager*,UIElement*)
    public void SetFocusElement(ACBindings.UIElement* focusElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045B970)(ref this, focusElement);
    // UIElement* __thiscall UIElementManager::CreateElementRecursiveFromPartialDesc(UIElementManager*,const LayoutDesc*,const ElementDesc*)
    public ACBindings.UIElement* CreateElementRecursiveFromPartialDesc(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0045C090)(ref this, layout, desc);
    // void __thiscall UIElementManager::RemoveAndDeleteRootElement(UIElementManager*,UIElement*)
    public void RemoveAndDeleteRootElement(ACBindings.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045C160)(ref this, element);
    // void __thiscall UIElementManager::UnRegisterForElementMessage(UIElementManager*,UIListener*,unsigned int,unsigned int)
    public void UnRegisterForElementMessage(ACBindings.UIListener* listener, uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIListener*, uint, uint, void>)0x0045C1B0)(ref this, listener, elementID, messageID);
    // void __thiscall UIElementManager::UnRegisterForGlobalMessage(UIElementManager*,UIListener*,unsigned int)
    public void UnRegisterForGlobalMessage(ACBindings.UIListener* listener, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIListener*, uint, void>)0x0045C1F0)(ref this, listener, messageID);
    // void __thiscall UIElementManager::UnRegisterForAllMessages(UIElementManager*,UIListener*)
    public void UnRegisterForAllMessages(ACBindings.UIListener* listener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIListener*, void>)0x0045C210)(ref this, listener);
    // void __thiscall UIElementManager::MouseLeaveEvent(UIElementManager*)
    public void MouseLeaveEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045C380)(ref this);
    // void __thiscall UIElementManager::UpdateMouseOver(UIElementManager*,int,int)
    public void UpdateMouseOver(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, int, int, void>)0x0045C390)(ref this, i_xWindow, i_yWindow);
    // void __thiscall UIElementManager::KeyPressEvent(UIElementManager*,unsigned int,float)
    public void KeyPressEvent(uint action, float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, float, void>)0x0045C3E0)(ref this, action, extent);
    // void __thiscall UIElementManager::ResetTooltip(UIElementManager*)
    public void ResetTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045C440)(ref this);
    // void __thiscall UIElementManager::RegisterActivatable(UIElementManager*,UIElement*)
    public void RegisterActivatable(ACBindings.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045C4A0)(ref this, element);
    // void __thiscall UIElementManager::ActivationAlert(UIElementManager*,UIElement*,bool)
    public void ActivationAlert(ACBindings.UIElement* element, byte active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, byte, void>)0x0045C540)(ref this, element, active);
    // UIElement* __thiscall UIElementManager::CreateElement(UIElementManager*,const LayoutDesc*,const ElementDesc*)
    public ACBindings.UIElement* CreateElement(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0045CCF0)(ref this, layout, desc);
    // void __cdecl UIElementManager::HandlePreferenceCallback(const char**)
    public static void HandlePreferenceCallback(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, void>)0x0045CD20)(a1);
    // void __thiscall UIElementManager::DoMouseUpdate(UIElementManager*)
    public void DoMouseUpdate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045CDE0)(ref this);
    // void __thiscall UIElementManager::UseTime(UIElementManager*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045D0B0)(ref this);
    // UIElement* __thiscall UIElementManager::CreateRootElement(UIElementManager*,const LayoutDesc*,const ElementDesc*)
    public ACBindings.UIElement* CreateRootElement(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0045D100)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElementManager::CreateChildElement(UIElementManager*,UIElement*,const LayoutDesc*,const ElementDesc*)
    public ACBindings.UIElement* CreateChildElement(ACBindings.UIElement* i_pParent, ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0045D160)(ref this, i_pParent, layout, full_desc);
    // UIElement* __thiscall UIElementManager::CreateHollowElement(UIElementManager*,UIElement*)
    public ACBindings.UIElement* CreateHollowElement(ACBindings.UIElement* i_pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, ACBindings.UIElement*>)0x0045D1C0)(ref this, i_pParent);
    // void __thiscall UIElementManager::RegisterElementClass(UIElementManager*,unsigned int,UIElement*(__cdecl*createMethod)(const LayoutDesc*, const ElementDesc*))
    public void RegisterElementClass(uint type, delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*> createMethod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>, void>)0x0045D310)(ref this, type, createMethod);
    // void __thiscall UIElementManager::SetMouseCapture(UIElementManager*,UIElement*)
    public void SetMouseCapture(ACBindings.UIElement* i_pElementToGetAllMouseMessages) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045D350)(ref this, i_pElementToGetAllMouseMessages);
    // void __thiscall UIElementManager::ReleaseMouseCapture(UIElementManager*,UIElement*)
    public void ReleaseMouseCapture(ACBindings.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045D390)(ref this, i_pElement);
    // UIElement* __thiscall UIElementManager::CreateRootElement(UIElementManager*,const LayoutDesc*,unsigned int)
    public ACBindings.UIElement* CreateRootElement(ACBindings.LayoutDesc* layout, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.LayoutDesc*, uint, ACBindings.UIElement*>)0x0045D880)(ref this, layout, elementID);
    // UIElement* __thiscall UIElementManager::CreateChildElement(UIElementManager*,UIElement*,const LayoutDesc*,unsigned int)
    public ACBindings.UIElement* CreateChildElement(ACBindings.UIElement* i_pParent, ACBindings.LayoutDesc* i_layout, uint i_elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, ACBindings.LayoutDesc*, uint, ACBindings.UIElement*>)0x0045D8B0)(ref this, i_pParent, i_layout, i_elementID);
    // void __thiscall UIElementManager::RegisterElementForInputAction(UIElementManager*,unsigned int,UIElement*)
    public void RegisterElementForInputAction(uint i_eInputAction, ACBindings.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, ACBindings.UIElement*, void>)0x0045D8E0)(ref this, i_eInputAction, i_pElement);
    // void __thiscall UIElementManager::UnRegisterElementForAllInputActions(UIElementManager*,UIElement*)
    public void UnRegisterElementForAllInputActions(ACBindings.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045D970)(ref this, i_pElement);
    // void __stdcall UIElementManager::RegisterForMessageInternal(int,_DWORD*,int)
    public static void RegisterForMessageInternal(int a1, int* a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int*, int, void>)0x0045DBA0)(a1, a2, a3);
    // void __thiscall UIElementManager::MouseDownEvent(UIElementManager*,unsigned int,float)
    public void MouseDownEvent(uint action, float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, float, void>)0x0045DC40)(ref this, action, extent);
    // void __thiscall UIElementManager::MouseUpEvent(UIElementManager*,unsigned int,IInputActionCallback*)
    public void MouseUpEvent(uint action, ACBindings.IInputActionCallback* i_pcCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, uint, ACBindings.IInputActionCallback*, void>)0x0045DE30)(ref this, action, i_pcCallback);
    // void __userpurge UIElementManager::StartTooltip(UIElementManager*this@<ecx>,int a2@<ebx>,StringInfo*,UIElement*,unsigned int,int,int)
//     public static ACBindings.void __userpurge StartTooltip(ACBindings.UIElementManager*this@__ecx __param1, ACBindings.int a2@__ebx __param2, ACBindings.StringInfo* info, ACBindings.UIElement* i_pElementOwner, uint elementID, int a6, int a7) => ((delegate* unmanaged[Cdecl]<ACBindings.UIElementManager*this@__ecx, ACBindings.int a2@__ebx, ACBindings.StringInfo*, ACBindings.UIElement*, uint, int, int, ACBindings.void __userpurge>)0x0045DF70)(__param1, __param2, info, i_pElementOwner, elementID, a6, a7);
    // bool __thiscall UIElementManager::StartDragandDrop(UIElementManager*,UIElement*,int,int)
    public byte StartDragandDrop(ACBindings.UIElement* elem, int i_iClickX, int i_iClickY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, int, int, byte>)0x0045E120)(ref this, elem, i_iClickX, i_iClickY);
    // UIElement* __thiscall UIElementManager::CreateRootElementByDataID(UIElementManager*,int,unsigned int)
    public ACBindings.UIElement* CreateRootElementByDataID(int a2, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, int, uint, ACBindings.UIElement*>)0x0045E4B0)(ref this, a2, elementID);
    // UIElement* __thiscall UIElementManager::CreateChildElementByEnum(UIElementManager*,UIElement*,const unsigned int,unsigned int)
    public ACBindings.UIElement* CreateChildElementByEnum(ACBindings.UIElement* i_pParent, uint layoutEnum, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, uint, uint, ACBindings.UIElement*>)0x0045E520)(ref this, i_pParent, layoutEnum, elementID);
    // LayoutDesc* __thiscall UIElementManager::CreateChildElementByDid(UIElementManager*,UIElement*,int,unsigned int)
    public ACBindings.LayoutDesc* CreateChildElementByDid(ACBindings.UIElement* i_pParent, int a3, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, int, uint, ACBindings.LayoutDesc*>)0x0045E580)(ref this, i_pParent, a3, elementID);
    // void __thiscall UIElementManager::DeletingElement(UIElementManager*,UIElement*)
    public void DeletingElement(ACBindings.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIElement*, void>)0x0045E600)(ref this, element);
    // void __thiscall UIElementManager::RegisterForGlobalMessage(UIElementManager*,UIListener*,unsigned int)
    public void RegisterForGlobalMessage(ACBindings.UIListener* listener, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIListener*, uint, void>)0x0045E760)(ref this, listener, messageID);
    // bool __thiscall UIElementManager::OnAction(UIElementManager*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.InputEvent*, byte>)0x0045E780)(ref this, i_evt);
    // void __thiscall UIElementManager::MouseMoveHandler(UIElementManager*,int,int)
    public void MouseMoveHandler(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, int, int, void>)0x0045E7F0)(ref this, i_xWindow, i_yWindow);
    // bool __cdecl UIElementManager::ConsoleCommand_PrintUISurfaceUsage()
    public static byte ConsoleCommand_PrintUISurfaceUsage() => ((delegate* unmanaged[Cdecl]<byte>)0x0045E930)();
    // bool __thiscall UIElementManager::Init(UIElementManager*)
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, byte>)0x0045EEF0)(ref this);
    // void __thiscall UIElementManager::Cleanup(UIElementManager*)
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045F200)(ref this);
    // void __thiscall UIElementManager::RegisterForElementMessage(UIElementManager*,UIListener*,unsigned int,unsigned int)
    public void RegisterForElementMessage(ACBindings.UIListener* listener, uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, ACBindings.UIListener*, uint, uint, void>)0x0045F380)(ref this, listener, elementID, messageID);
    // void __thiscall UIElementManager::~UIElementManager(UIElementManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045F4C0)(ref this);
    // void __thiscall UIElementManager::UIElementManager(UIElementManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElementManager, void>)0x0045F6B0)(ref this);
    // void __cdecl UIElementManager::CreateUIElementManager()
    public static void CreateUIElementManager() => ((delegate* unmanaged[Cdecl]<void>)0x0045F900)();
}

