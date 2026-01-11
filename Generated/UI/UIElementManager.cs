namespace ACBindings.Internal;

public unsafe struct UIElementManager : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct UIElementManager_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, int, int, void> MouseMoveHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, int, int, void> MouseLookHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, byte, int, void> FocusSwitchHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, System.Char, void> CharacterHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___UIElement_ptr m_deleteQueue;
    public ACBindings.Internal.SmartArray___UIElement_ptr m_elementList;
    public ACBindings.Internal.HashTable__uint__void_ptr m_classCreateMethodTable;
    public ACBindings.Internal.LayoutDesc* m_pHollowLayoutDesc;
    public ACBindings.Internal.ElementDesc* m_pHollowElementDesc;
    public ACBindings.Internal.UIElement* m_pRootElement;
    public ACBindings.Internal.Vector3 m_vGlobalScale;
    public ACBindings.Internal.AutoGrowHashTable__uint___AutoGrowHashTable__uint___SmartArray___UIMessageData m_elementListenerTable;
    public ACBindings.Internal.AutoGrowHashTable__uint___SmartArray___UIMessageData m_globalMessageListenerTable;
    public ACBindings.Internal.SmartArray___UIMessageRemovalData m_aUIMessageRemovalData;
    public ACBindings.Internal.AutoGrowHashTable__uint___SmartArray___UIElement_ptr m_elementInputActionListenerTable;
    public ACBindings.Internal.List___UIElementMessageInfo m_listQueuedElementMessages;
    public byte m_bBroadcastingMessage;
    public ACBindings.Internal.IDClass____tagDataID m_defaultCursorDID;
    public int m_defaultCursorHotX;
    public int m_defaultCursorHotY;
    public ACBindings.Internal.IDClass____tagDataID m_lastCursorDID;
    public int m_lastCursorHotX;
    public int m_lastCursorHotY;
    public byte m_bPerformMouseHitTest;
    public ACBindings.Internal.UIElement* m_pElementLastOver;
    public ACBindings.Internal.UIElement* m_pElementLastEntered;
    public ACBindings.Internal.UIElement* m_pElementWithMouseCapture;
    public ACBindings.Internal.UIElement* m_pElementLastDragCursorOver;
    public ACBindings.Internal.HashSet__uint m_setActionsTriggeringCapture;
    public uint m_nMouseCapture;
    public byte m_bDoVisualMouseDebugging;
    public ACBindings.Internal.IDClass____tagDataID m_debugFontDID;
    public byte m_bMouseHasLeftTheWindow;
    public double m_lastMouseMoveTime;
    public double m_tooltipStart;
    public byte m_tooltipEnable;
    public float m_tooltipDelay;
    public float m_tooltipDuration;
    public ACBindings.Internal.UIElement* m_pTooltipOwner;
    public ACBindings.Internal.UIElement* m_pTooltipElement;
    public double m_buttonDownTime;
    public int m_dragX;
    public int m_dragY;
    public int m_dragBaseX;
    public int m_dragBaseY;
    public ACBindings.Internal.UIElement* m_pcPotentialDragElement;
    public ACBindings.Internal.UIElement* m_dragElement;
    public ACBindings.Internal.UIElement* m_dragOwner;
    public byte m_bDragStarted;
    public byte m_bHoverStarted;
    public ACBindings.Internal.UIElement* m_focusElement;
    public ACBindings.Internal.UIElement* m_activeElement;
    public ACBindings.Internal.SmartArray___UIElement_ptr m_activatableElements;
    public ACBindings.Internal.ContextMenu* m_pCSM;

    // Generated Constructor
    public UIElementManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00459310
    /// void __cdecl UIElementManager::DestroyUIElementManager()</code>
    /// </summary>
    public static void DestroyUIElementManager() => ((delegate* unmanaged[Cdecl]<void>)0x00459310)();

    /// <summary>
    /// <code>Offset: 0x00459370
    /// void __thiscall UIElementManager::StartHover(UIElementManager*,int,int)</code>
    /// </summary>
    public void StartHover(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x00459370)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// <code>Offset: 0x004593A0
    /// void __thiscall UIElementManager::StopHover(UIElementManager*)</code>
    /// </summary>
    public void StopHover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x004593A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004593E0
    /// void __thiscall UIElementManager::SetDurationForCurrentTooltip(UIElementManager*,float)</code>
    /// </summary>
    public void SetDurationForCurrentTooltip(float i_secCustomDuration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, float, void>)0x004593E0)(ref this, i_secCustomDuration);

    /// <summary>
    /// <code>Offset: 0x00459400
    /// bool __thiscall UIElementManager::ClearDragandDrop(UIElementManager*)</code>
    /// </summary>
    public byte ClearDragandDrop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte>)0x00459400)(ref this);

    /// <summary>
    /// <code>Offset: 0x00459440
    /// void __thiscall UIElementManager::SetVisible(UIElementManager*,bool)</code>
    /// </summary>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte, void>)0x00459440)(ref this, visible);

    /// <summary>
    /// <code>Offset: 0x004596B0
    /// void __thiscall UIElementManager::ProcessUIMessageRemovalData(UIElementManager*)</code>
    /// </summary>
    public void ProcessUIMessageRemovalData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x004596B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00459770
    /// void __thiscall UIElementManager::StartTooltip(UIElementManager*,UIElement*,UIElement*)</code>
    /// </summary>
    public void StartTooltip(ACBindings.Internal.UIElement* i_pElementOwner, ACBindings.Internal.UIElement* i_pElementTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void>)0x00459770)(ref this, i_pElementOwner, i_pElementTooltip);

    /// <summary>
    /// <code>Offset: 0x00459880
    /// void __thiscall UIElementManager::StopDragandDrop(UIElementManager*)</code>
    /// </summary>
    public void StopDragandDrop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x00459880)(ref this);

    /// <summary>
    /// <code>Offset: 0x00459960
    /// void __thiscall UIElementManager::UnregisterActivatable(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void UnregisterActivatable(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x00459960)(ref this, element);

    /// <summary>
    /// <code>Offset: 0x00459980
    /// void __thiscall UIElementManager::ActivateNext(UIElementManager*,bool)</code>
    /// </summary>
    public void ActivateNext(byte backwards) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte, void>)0x00459980)(ref this, backwards);

    /// <summary>
    /// <code>Offset: 0x00459A00
    /// UIElement* __thiscall UIElementManager::GetElement(UIElementManager*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetElement(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.UIElement*>)0x00459A00)(ref this, ID);

    /// <summary>
    /// <code>Offset: 0x0045A350
    /// void __thiscall UIElementManager::CleanDeleteQueue(UIElementManager*)</code>
    /// </summary>
    public void CleanDeleteQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045A350)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045A910
    /// const RenderSurface* __thiscall UIElementManager::SetCursor(_DWORD*,int,unsigned int,unsigned int,char)</code>
    /// </summary>
    public ACBindings.Internal.RenderSurface* SetCursor(int a2, uint xHotSpot, uint yHotSpot, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, uint, uint, sbyte, ACBindings.Internal.RenderSurface*>)0x0045A910)(ref this, a2, xHotSpot, yHotSpot, a5);

    /// <summary>
    /// <code>Offset: 0x0045AC50
    /// bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,const UIElementMessageInfo*)</code>
    /// </summary>
    public byte BroadcastElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElementMessageInfo*, byte>)0x0045AC50)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0045AD00
    /// void __thiscall UIElementManager::CheckCursor(UIElementManager*)</code>
    /// </summary>
    public void CheckCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045AD00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045AD80
    /// void __thiscall UIElementManager::DrawRegionWithObject(UIElementManager*,UIElement*,UIObject**)</code>
    /// </summary>
    public void DrawRegionWithObject(ACBindings.Internal.UIElement* i_pElementWithObject, ACBindings.Internal.UIObject** io_pPrevObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, void>)0x0045AD80)(ref this, i_pElementWithObject, io_pPrevObject);

    /// <summary>
    /// <code>Offset: 0x0045B1A0
    /// UIElement* __thiscall UIElementManager::CreateElementRecursiveFromFullDesc(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateElementRecursiveFromFullDesc(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045B1A0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0045B350
    /// void __thiscall UIElementManager::AddElementToDeleteQueue(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void AddElementToDeleteQueue(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045B350)(ref this, element);

    /// <summary>
    /// <code>Offset: 0x0045B3A0
    /// bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,unsigned int,UIElement*,unsigned int,int)</code>
    /// </summary>
    public byte BroadcastElementMessage(uint elementID, ACBindings.Internal.UIElement* element, uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.UIElement*, uint, int, byte>)0x0045B3A0)(ref this, elementID, element, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x0045B450
    /// bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public byte BroadcastElementMessage(ACBindings.Internal.UIElement* i_pElement, uint i_idMessage, uint i_dwParam1, uint i_dwParam2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, uint, uint, uint, byte>)0x0045B450)(ref this, i_pElement, i_idMessage, i_dwParam1, i_dwParam2);

    /// <summary>
    /// <code>Offset: 0x0045B4C0
    /// void __thiscall UIElementManager::BroadcastGlobalMessage(UIElementManager*,unsigned int,int)</code>
    /// </summary>
    public void BroadcastGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, int, void>)0x0045B4C0)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x0045B540
    /// void __thiscall UIElementManager::UnRegisterForMessageInternal(int*,int,_DWORD*,int)</code>
    /// </summary>
    public void UnRegisterForMessageInternal(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int*, int, void>)0x0045B540)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x0045B5D0
    /// void __thiscall UIElementManager::UnRegisterForAllMessagesInternal(int*,int,int)</code>
    /// </summary>
    public void UnRegisterForAllMessagesInternal(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x0045B5D0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0045B640
    /// void __thiscall UIElementManager::SwitchMouseOver(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void SwitchMouseOver(ACBindings.Internal.UIElement* pCurMouseOver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045B640)(ref this, pCurMouseOver);

    /// <summary>
    /// <code>Offset: 0x0045B740
    /// bool __thiscall UIElementManager::DoVisibilityToggleAction(UIElementManager*,unsigned int)</code>
    /// </summary>
    public byte DoVisibilityToggleAction(uint action) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, byte>)0x0045B740)(ref this, action);

    /// <summary>
    /// <code>Offset: 0x0045B7C0
    /// void __thiscall UIElementManager::CheckTooltip(UIElementManager*)</code>
    /// </summary>
    public void CheckTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045B7C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045B8A0
    /// void __thiscall UIElementManager::DrawRegion(UIElementManager*,UIElement*,UIObject**)</code>
    /// </summary>
    public void DrawRegion(ACBindings.Internal.UIElement* i_pElement, ACBindings.Internal.UIObject** io_pPrevObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, void>)0x0045B8A0)(ref this, i_pElement, io_pPrevObject);

    /// <summary>
    /// <code>Offset: 0x0045B900
    /// void __thiscall UIElementManager::DrawDirtyRegions(UIElementManager*)</code>
    /// </summary>
    public void DrawDirtyRegions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045B900)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045B970
    /// void __thiscall UIElementManager::SetFocusElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void SetFocusElement(ACBindings.Internal.UIElement* focusElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045B970)(ref this, focusElement);

    /// <summary>
    /// <code>Offset: 0x0045C090
    /// UIElement* __thiscall UIElementManager::CreateElementRecursiveFromPartialDesc(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateElementRecursiveFromPartialDesc(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045C090)(ref this, layout, desc);

    /// <summary>
    /// <code>Offset: 0x0045C160
    /// void __thiscall UIElementManager::RemoveAndDeleteRootElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void RemoveAndDeleteRootElement(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045C160)(ref this, element);

    /// <summary>
    /// <code>Offset: 0x0045C1B0
    /// void __thiscall UIElementManager::UnRegisterForElementMessage(UIElementManager*,UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    public void UnRegisterForElementMessage(ACBindings.Internal.UIListener* listener, uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, uint, void>)0x0045C1B0)(ref this, listener, elementID, messageID);

    /// <summary>
    /// <code>Offset: 0x0045C1F0
    /// void __thiscall UIElementManager::UnRegisterForGlobalMessage(UIElementManager*,UIListener*,unsigned int)</code>
    /// </summary>
    public void UnRegisterForGlobalMessage(ACBindings.Internal.UIListener* listener, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, void>)0x0045C1F0)(ref this, listener, messageID);

    /// <summary>
    /// <code>Offset: 0x0045C210
    /// void __thiscall UIElementManager::UnRegisterForAllMessages(UIElementManager*,UIListener*)</code>
    /// </summary>
    public void UnRegisterForAllMessages(ACBindings.Internal.UIListener* listener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, void>)0x0045C210)(ref this, listener);

    /// <summary>
    /// <code>Offset: 0x0045C380
    /// void __thiscall UIElementManager::MouseLeaveEvent(UIElementManager*)</code>
    /// </summary>
    public void MouseLeaveEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045C380)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045C390
    /// void __thiscall UIElementManager::UpdateMouseOver(UIElementManager*,int,int)</code>
    /// </summary>
    public void UpdateMouseOver(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x0045C390)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// <code>Offset: 0x0045C3E0
    /// void __thiscall UIElementManager::KeyPressEvent(UIElementManager*,unsigned int,float)</code>
    /// </summary>
    public void KeyPressEvent(uint action, float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, float, void>)0x0045C3E0)(ref this, action, extent);

    /// <summary>
    /// <code>Offset: 0x0045C440
    /// void __thiscall UIElementManager::ResetTooltip(UIElementManager*)</code>
    /// </summary>
    public void ResetTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045C440)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045C4A0
    /// void __thiscall UIElementManager::RegisterActivatable(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void RegisterActivatable(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045C4A0)(ref this, element);

    /// <summary>
    /// <code>Offset: 0x0045C540
    /// void __thiscall UIElementManager::ActivationAlert(UIElementManager*,UIElement*,bool)</code>
    /// </summary>
    public void ActivationAlert(ACBindings.Internal.UIElement* element, byte active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, byte, void>)0x0045C540)(ref this, element, active);

    /// <summary>
    /// <code>Offset: 0x0045CCF0
    /// UIElement* __thiscall UIElementManager::CreateElement(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateElement(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045CCF0)(ref this, layout, desc);

    /// <summary>
    /// <code>Offset: 0x0045CD20
    /// void __cdecl UIElementManager::HandlePreferenceCallback(const char**)</code>
    /// </summary>
    public static void HandlePreferenceCallback(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, void>)0x0045CD20)(a1);

    /// <summary>
    /// <code>Offset: 0x0045CDE0
    /// void __thiscall UIElementManager::DoMouseUpdate(UIElementManager*)</code>
    /// </summary>
    public void DoMouseUpdate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045CDE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045D0B0
    /// void __thiscall UIElementManager::UseTime(UIElementManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045D0B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045D100
    /// UIElement* __thiscall UIElementManager::CreateRootElement(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateRootElement(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045D100)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0045D160
    /// UIElement* __thiscall UIElementManager::CreateChildElement(UIElementManager*,UIElement*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateChildElement(ACBindings.Internal.UIElement* i_pParent, ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045D160)(ref this, i_pParent, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0045D1C0
    /// UIElement* __thiscall UIElementManager::CreateHollowElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateHollowElement(ACBindings.Internal.UIElement* i_pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0045D1C0)(ref this, i_pParent);

    /// <summary>
    /// <code>Offset: 0x0045D310
    /// void __thiscall UIElementManager::RegisterElementClass(UIElementManager*,unsigned int,UIElement*(__cdecl*createMethod)(const LayoutDesc*, const ElementDesc*))</code>
    /// </summary>
    public void RegisterElementClass(uint type, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*> createMethod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>, void>)0x0045D310)(ref this, type, createMethod);

    /// <summary>
    /// <code>Offset: 0x0045D350
    /// void __thiscall UIElementManager::SetMouseCapture(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void SetMouseCapture(ACBindings.Internal.UIElement* i_pElementToGetAllMouseMessages) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045D350)(ref this, i_pElementToGetAllMouseMessages);

    /// <summary>
    /// <code>Offset: 0x0045D390
    /// void __thiscall UIElementManager::ReleaseMouseCapture(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void ReleaseMouseCapture(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045D390)(ref this, i_pElement);

    /// <summary>
    /// <code>Offset: 0x0045D880
    /// UIElement* __thiscall UIElementManager::CreateRootElement(UIElementManager*,const LayoutDesc*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateRootElement(ACBindings.Internal.LayoutDesc* layout, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, uint, ACBindings.Internal.UIElement*>)0x0045D880)(ref this, layout, elementID);

    /// <summary>
    /// <code>Offset: 0x0045D8B0
    /// UIElement* __thiscall UIElementManager::CreateChildElement(UIElementManager*,UIElement*,const LayoutDesc*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateChildElement(ACBindings.Internal.UIElement* i_pParent, ACBindings.Internal.LayoutDesc* i_layout, uint i_elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.LayoutDesc*, uint, ACBindings.Internal.UIElement*>)0x0045D8B0)(ref this, i_pParent, i_layout, i_elementID);

    /// <summary>
    /// <code>Offset: 0x0045D8E0
    /// void __thiscall UIElementManager::RegisterElementForInputAction(UIElementManager*,unsigned int,UIElement*)</code>
    /// </summary>
    public void RegisterElementForInputAction(uint i_eInputAction, ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.UIElement*, void>)0x0045D8E0)(ref this, i_eInputAction, i_pElement);

    /// <summary>
    /// <code>Offset: 0x0045D970
    /// void __thiscall UIElementManager::UnRegisterElementForAllInputActions(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void UnRegisterElementForAllInputActions(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045D970)(ref this, i_pElement);

    /// <summary>
    /// <code>Offset: 0x0045DBA0
    /// void __stdcall UIElementManager::RegisterForMessageInternal(int,_DWORD*,int)</code>
    /// </summary>
    public static void RegisterForMessageInternal(int a1, int* a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int*, int, void>)0x0045DBA0)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0045DC40
    /// void __thiscall UIElementManager::MouseDownEvent(UIElementManager*,unsigned int,float)</code>
    /// </summary>
    public void MouseDownEvent(uint action, float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, float, void>)0x0045DC40)(ref this, action, extent);

    /// <summary>
    /// <code>Offset: 0x0045DE30
    /// void __thiscall UIElementManager::MouseUpEvent(UIElementManager*,unsigned int,IInputActionCallback*)</code>
    /// </summary>
    public void MouseUpEvent(uint action, ACBindings.Internal.IInputActionCallback* i_pcCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.IInputActionCallback*, void>)0x0045DE30)(ref this, action, i_pcCallback);

    /// <summary>
    /// <code>Offset: 0x0045DF70
    /// void __userpurge UIElementManager::StartTooltip(UIElementManager*this@&lt;ecx&gt;,int a2@&lt;ebx&gt;,StringInfo*,UIElement*,unsigned int,int,int)</code>
    /// </summary>
//     public static ACBindings.Internal.void __userpurge StartTooltip(ACBindings.Internal.UIElementManager*this@___ecx __param1, ACBindings.Internal.int a2@___ebx __param2, ACBindings.Internal.StringInfo* info, ACBindings.Internal.UIElement* i_pElementOwner, uint elementID, int a6, int a7) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIElementManager*this@___ecx, ACBindings.Internal.int a2@___ebx, ACBindings.Internal.StringInfo*, ACBindings.Internal.UIElement*, uint, int, int, ACBindings.Internal.void __userpurge>)0x0045DF70)(__param1, __param2, info, i_pElementOwner, elementID, a6, a7);

    /// <summary>
    /// <code>Offset: 0x0045E120
    /// bool __thiscall UIElementManager::StartDragandDrop(UIElementManager*,UIElement*,int,int)</code>
    /// </summary>
    public byte StartDragandDrop(ACBindings.Internal.UIElement* elem, int i_iClickX, int i_iClickY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, int, int, byte>)0x0045E120)(ref this, elem, i_iClickX, i_iClickY);

    /// <summary>
    /// <code>Offset: 0x0045E4B0
    /// UIElement* __thiscall UIElementManager::CreateRootElementByDataID(UIElementManager*,int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateRootElementByDataID(int a2, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, uint, ACBindings.Internal.UIElement*>)0x0045E4B0)(ref this, a2, elementID);

    /// <summary>
    /// <code>Offset: 0x0045E520
    /// UIElement* __thiscall UIElementManager::CreateChildElementByEnum(UIElementManager*,UIElement*,const unsigned int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* CreateChildElementByEnum(ACBindings.Internal.UIElement* i_pParent, uint layoutEnum, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, uint, uint, ACBindings.Internal.UIElement*>)0x0045E520)(ref this, i_pParent, layoutEnum, elementID);

    /// <summary>
    /// <code>Offset: 0x0045E580
    /// LayoutDesc* __thiscall UIElementManager::CreateChildElementByDid(UIElementManager*,UIElement*,int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.LayoutDesc* CreateChildElementByDid(ACBindings.Internal.UIElement* i_pParent, int a3, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, int, uint, ACBindings.Internal.LayoutDesc*>)0x0045E580)(ref this, i_pParent, a3, elementID);

    /// <summary>
    /// <code>Offset: 0x0045E600
    /// void __thiscall UIElementManager::DeletingElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    public void DeletingElement(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045E600)(ref this, element);

    /// <summary>
    /// <code>Offset: 0x0045E760
    /// void __thiscall UIElementManager::RegisterForGlobalMessage(UIElementManager*,UIListener*,unsigned int)</code>
    /// </summary>
    public void RegisterForGlobalMessage(ACBindings.Internal.UIListener* listener, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, void>)0x0045E760)(ref this, listener, messageID);

    /// <summary>
    /// <code>Offset: 0x0045E780
    /// bool __thiscall UIElementManager::OnAction(UIElementManager*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.InputEvent*, byte>)0x0045E780)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x0045E7F0
    /// void __thiscall UIElementManager::MouseMoveHandler(UIElementManager*,int,int)</code>
    /// </summary>
    public void MouseMoveHandler(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x0045E7F0)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// <code>Offset: 0x0045E930
    /// bool __cdecl UIElementManager::ConsoleCommand_PrintUISurfaceUsage()</code>
    /// </summary>
    public static byte ConsoleCommand_PrintUISurfaceUsage() => ((delegate* unmanaged[Cdecl]<byte>)0x0045E930)();

    /// <summary>
    /// <code>Offset: 0x0045EEF0
    /// bool __thiscall UIElementManager::Init(UIElementManager*)</code>
    /// </summary>
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte>)0x0045EEF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045F200
    /// void __thiscall UIElementManager::Cleanup(UIElementManager*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045F200)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045F380
    /// void __thiscall UIElementManager::RegisterForElementMessage(UIElementManager*,UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RegisterForElementMessage(ACBindings.Internal.UIListener* listener, uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, uint, void>)0x0045F380)(ref this, listener, elementID, messageID);

    /// <summary>
    /// <code>Offset: 0x0045F4C0
    /// void __thiscall UIElementManager::~UIElementManager(UIElementManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045F4C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045F6B0
    /// void __thiscall UIElementManager::UIElementManager(UIElementManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045F6B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045F900
    /// void __cdecl UIElementManager::CreateUIElementManager()</code>
    /// </summary>
    public static void CreateUIElementManager() => ((delegate* unmanaged[Cdecl]<void>)0x0045F900)();
}

