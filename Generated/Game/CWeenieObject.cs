namespace ACBindings;

// CWeenieObject
public unsafe struct CWeenieObject
{
    // Base Classes
    public ACBindings.LongHashData BaseClass_LongHashData; // ACBindings.LongHashData
    public ACBindings.NoticeRegistrar BaseClass_NoticeRegistrar; // ACBindings.NoticeRegistrar

    // Statics
    public static ACBindings.CObjectMaint* objMaint = (ACBindings.CObjectMaint*)0x00842B98;

    // Child Types
    // CWeenieObject_vtbl
    public unsafe struct CWeenieObject_vtbl
    {
        // Members
        public System.IntPtr CWeenieObject_dtor_0; // function pointer
        public System.IntPtr ObjectBeingDeleted; // function pointer
        public System.IntPtr process_netblobs; // function pointer
        public System.IntPtr SetParentedState; // function pointer
        public System.IntPtr IsPlayer; // function pointer
        public System.IntPtr IsThePlayer; // function pointer
        public System.IntPtr InqType; // function pointer
        public System.IntPtr IsPlayerKiller; // function pointer
        public System.IntPtr IsPK; // function pointer
        public System.IntPtr IsPKLite; // function pointer
        public System.IntPtr IsImpenetrable; // function pointer
        public System.IntPtr IsCreature; // function pointer
        public System.IntPtr InqJumpVelocity; // function pointer
        public System.IntPtr InqRunRate; // function pointer
        public System.IntPtr InqMaxRunRate; // function pointer
        public System.IntPtr CanJump; // function pointer
        public System.IntPtr JumpStaminaCost; // function pointer
        public System.IntPtr CanMoveInto; // function pointer
        public System.IntPtr CanBypassMoveRestrictions; // function pointer
        public fixed byte gap4C[8];
        public System.IntPtr DoCollision; // function pointer
        public System.IntPtr DoCollisionEnd; // function pointer
        public System.IntPtr InqCollisionProfile; // function pointer
        public System.IntPtr ResetCollisions; // function pointer
        public System.IntPtr InqIconID;
        public System.IntPtr PlayScript; // function pointer
        public System.IntPtr GetNumEmitters; // function pointer
        public System.IntPtr GetGlobalVelocity; // function pointer
        public System.IntPtr IsHook; // function pointer
        public System.IntPtr IsStorage; // function pointer
        public System.IntPtr IsCorpse; // function pointer

        // Methods
    }

    // Members
    public double update_time;
    public System.IntPtr netblob_list;
    public ACBindings.TSRecv blobOrdering;

    // Methods
    // void __thiscall CWeenieObject::queue_netblob(CWeenieObject*,unsigned int,NetBlob*)
    public void queue_netblob(uint inStamp, ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CWeenieObject, uint, ACBindings.NetBlob*, void>)0x00509F00)(ref this, inStamp, blob);
    // int __thiscall CWeenieObject::fIsNextBlob(CWeenieObject*,unsigned int,NetBlob*,NetBlob**)
    public int fIsNextBlob(uint inStamp, ACBindings.NetBlob* pBlob, ACBindings.NetBlob** ppBlobIndicated) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CWeenieObject, uint, ACBindings.NetBlob*, ACBindings.NetBlob**, int>)0x00509F30)(ref this, inStamp, pBlob, ppBlobIndicated);
    // void __thiscall CWeenieObject::queue_netblob(CWeenieObject*,NetBlob*)
    public void queue_netblob(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CWeenieObject, ACBindings.NetBlob*, void>)0x00509F50)(ref this, blob);
    // void __thiscall CWeenieObject::process_netblobs(CWeenieObject*)
    public void process_netblobs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CWeenieObject, void>)0x00509FD0)(ref this);
}

