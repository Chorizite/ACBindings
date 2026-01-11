namespace ACBindings.Internal;

public unsafe struct AnimSequenceNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.DLListData BaseClass_DLListData; // ACBindings.Internal.DLListData

    // Child Types
    public unsafe struct AnimSequenceNode_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, void> AnimSequenceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimSequenceNode*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CAnimation* anim;
    public float framerate;
    public int low_frame;
    public int high_frame;

    // Generated Constructor
    public AnimSequenceNode() {
        _ConstructorInternal();
    }
    public AnimSequenceNode(ACBindings.Internal.AnimData* data) {
        _ConstructorInternal(data);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F24E0
    /// unsigned int __thiscall AnimSequenceNode::get_high_frame(ChatRoomTracker*)</code>
    /// </summary>
    public uint get_high_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, uint>)0x004F24E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005253B0
    /// const AFrame* __thiscall AnimSequenceNode::get_pos_frame(AnimSequenceNode*,long double)</code>
    /// </summary>
    public ACBindings.Internal.AFrame* get_pos_frame(double frame_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, double, ACBindings.Internal.AFrame*>)0x005253B0)(ref this, frame_number);

    /// <summary>
    /// <code>Offset: 0x005267E0
    /// void __thiscall AnimSequenceNode::multiply_framerate(AnimSequenceNode*,float)</code>
    /// </summary>
    public void multiply_framerate(float multiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, float, void>)0x005267E0)(ref this, multiplier);

    /// <summary>
    /// <code>Offset: 0x00526810
    /// const AFrame* __thiscall AnimSequenceNode::get_pos_frame(AnimSequenceNode*,int)</code>
    /// </summary>
    public ACBindings.Internal.AFrame* get_pos_frame(int fn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int, ACBindings.Internal.AFrame*>)0x00526810)(ref this, fn);

    /// <summary>
    /// <code>Offset: 0x00526840
    /// const AnimFrame* __thiscall AnimSequenceNode::get_part_frame(AnimSequenceNode*,int)</code>
    /// </summary>
    public ACBindings.Internal.AnimFrame* get_part_frame(int fn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int, ACBindings.Internal.AnimFrame*>)0x00526840)(ref this, fn);

    /// <summary>
    /// <code>Offset: 0x00526870
    /// int __thiscall AnimSequenceNode::has_anim(AppraisalProfile*)</code>
    /// </summary>
    public int has_anim() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int>)0x00526870)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526880
    /// float __thiscall AnimSequenceNode::get_starting_frame(AnimSequenceNode*)</code>
    /// </summary>
    public float get_starting_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, float>)0x00526880)(ref this);

    /// <summary>
    /// <code>Offset: 0x005268B0
    /// float __thiscall AnimSequenceNode::get_ending_frame(AnimSequenceNode*)</code>
    /// </summary>
    public float get_ending_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, float>)0x005268B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526930
    /// void __thiscall AnimSequenceNode::AnimSequenceNode(AnimSequenceNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, void>)0x00526930)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526960
    /// int __thiscall AnimSequenceNode::set_animation_id(_DWORD*,int)</code>
    /// </summary>
    public int set_animation_id(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, int, int>)0x00526960)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005269E0
    /// const AnimSequenceNode* __thiscall AnimSequenceNode::GetNext(AnimSequenceNode*)</code>
    /// </summary>
    public ACBindings.Internal.AnimSequenceNode* GetNext() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, ACBindings.Internal.AnimSequenceNode*>)0x005269E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005269F0
    /// const AnimSequenceNode* __thiscall AnimSequenceNode::GetPrev(AnimSequenceNode*)</code>
    /// </summary>
    public ACBindings.Internal.AnimSequenceNode* GetPrev() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, ACBindings.Internal.AnimSequenceNode*>)0x005269F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526AE0
    /// unsigned int __thiscall AnimSequenceNode::Pack(AnimSequenceNode*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, void**, uint, uint>)0x00526AE0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00526B40
    /// int __thiscall AnimSequenceNode::UnPack(AnimSequenceNode*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, void**, uint, int>)0x00526B40)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00526B90
    /// void __thiscall AnimSequenceNode::AnimSequenceNode(AnimSequenceNode*,const AnimData*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.AnimData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimSequenceNode, ACBindings.Internal.AnimData*, void>)0x00526B90)(ref this, data);
}

