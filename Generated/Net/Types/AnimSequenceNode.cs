namespace ACBindings;

// AnimSequenceNode
public unsafe struct AnimSequenceNode
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj
    public ACBindings.DLListData BaseClass_DLListData; // ACBindings.DLListData

    // Child Types
    // AnimSequenceNode_vtbl
    public unsafe struct AnimSequenceNode_vtbl
    {
        // Members
        public System.IntPtr AnimSequenceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CAnimation* anim;
    public float framerate;
    public int low_frame;
    public int high_frame;

    // Generated Constructor
    public AnimSequenceNode() {
        _ConstructorInternal();
    }
    public AnimSequenceNode(ACBindings.AnimData* data) {
        _ConstructorInternal(data);
    }

    // Methods
    // unsigned int __thiscall AnimSequenceNode::get_high_frame(ChatRoomTracker*)
    public uint get_high_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, uint>)0x004F24E0)(ref this);
    // const AFrame* __thiscall AnimSequenceNode::get_pos_frame(AnimSequenceNode*,long double)
    public ACBindings.AFrame* get_pos_frame(double frame_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, double, ACBindings.AFrame*>)0x005253B0)(ref this, frame_number);
    // void __thiscall AnimSequenceNode::multiply_framerate(AnimSequenceNode*,float)
    public void multiply_framerate(float multiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, float, void>)0x005267E0)(ref this, multiplier);
    // const AFrame* __thiscall AnimSequenceNode::get_pos_frame(AnimSequenceNode*,int)
    public ACBindings.AFrame* get_pos_frame(int fn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, int, ACBindings.AFrame*>)0x00526810)(ref this, fn);
    // const AnimFrame* __thiscall AnimSequenceNode::get_part_frame(AnimSequenceNode*,int)
    public ACBindings.AnimFrame* get_part_frame(int fn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, int, ACBindings.AnimFrame*>)0x00526840)(ref this, fn);
    // int __thiscall AnimSequenceNode::has_anim(AppraisalProfile*)
    public int has_anim() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, int>)0x00526870)(ref this);
    // float __thiscall AnimSequenceNode::get_starting_frame(AnimSequenceNode*)
    public float get_starting_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, float>)0x00526880)(ref this);
    // float __thiscall AnimSequenceNode::get_ending_frame(AnimSequenceNode*)
    public float get_ending_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, float>)0x005268B0)(ref this);
    // void __thiscall AnimSequenceNode::AnimSequenceNode(AnimSequenceNode*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, void>)0x00526930)(ref this);
    // int __thiscall AnimSequenceNode::set_animation_id(_DWORD*,int)
    public int set_animation_id(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, int, int>)0x00526960)(ref this, a2);
    // const AnimSequenceNode* __thiscall AnimSequenceNode::GetNext(AnimSequenceNode*)
    public ACBindings.AnimSequenceNode* GetNext() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, ACBindings.AnimSequenceNode*>)0x005269E0)(ref this);
    // const AnimSequenceNode* __thiscall AnimSequenceNode::GetPrev(AnimSequenceNode*)
    public ACBindings.AnimSequenceNode* GetPrev() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, ACBindings.AnimSequenceNode*>)0x005269F0)(ref this);
    // unsigned int __thiscall AnimSequenceNode::Pack(AnimSequenceNode*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, void**, uint, uint>)0x00526AE0)(ref this, addr, size);
    // int __thiscall AnimSequenceNode::UnPack(AnimSequenceNode*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, void**, uint, int>)0x00526B40)(ref this, addr, size);
    // void __thiscall AnimSequenceNode::AnimSequenceNode(AnimSequenceNode*,const AnimData*)
    public void _ConstructorInternal(ACBindings.AnimData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimSequenceNode, ACBindings.AnimData*, void>)0x00526B90)(ref this, data);
}

