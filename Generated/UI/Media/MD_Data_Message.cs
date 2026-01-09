namespace ACBindings;

// MD_Data_Message
public unsafe struct MD_Data_Message
{
    // Base Classes
    public ACBindings.MediaDesc BaseClass_MediaDesc; // ACBindings.MediaDesc

    // Child Types
    // MD_Data_Message_vtbl
    public unsafe struct MD_Data_Message_vtbl
    {
        // Members
        public System.IntPtr MediaDesc_dtor_0; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr DynamicCast_Anim; // function pointer
        public System.IntPtr DynamicCast_Image; // function pointer
        public System.IntPtr DynamicCast_Alpha; // function pointer
        public System.IntPtr DynamicCast_Pause; // function pointer
        public System.IntPtr DynamicCast_Jump; // function pointer
        public System.IntPtr DynamicCast_Message; // function pointer
        public System.IntPtr DynamicCast_Sound; // function pointer
        public System.IntPtr DynamicCast_State; // function pointer
        public System.IntPtr DynamicCast_Movie; // function pointer
        public System.IntPtr DynamicCast_Cursor; // function pointer
        public System.IntPtr DynamicCast_Fade; // function pointer
        public System.IntPtr GetDuration; // function pointer
        public System.IntPtr ToFileNode; // function pointer
        public System.IntPtr FromFileNode; // function pointer

        // Methods
    }

    // Members
    public uint m_messageID;
    public float m_probability;

    // Methods
    // bool __thiscall MD_Data_Message::ToFileNode(MD_Data_Message*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Message, ACBindings.PFileNode*, byte>)0x0069EAC0)(ref this, file_node);
    // bool __thiscall MD_Data_Message::FromFileNode(MD_Data_Message*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* file_node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MD_Data_Message, ACBindings.PFileNode*, byte>)0x0069EB60)(ref this, file_node);
}

