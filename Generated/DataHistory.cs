namespace ACBindings.Internal;

public unsafe struct DataHistory
{
    // Child Types
    public unsafe struct DataIDHistoryData
    {
        // Members
        public ACBindings.Internal.QualifiedDataID qdid;
        public uint cbCompressed;
        public ACBindings.Internal.DataHistory.UpdateType utAction;

        // Methods
    }
    public unsafe struct IterationData
    {
        // Members
        public ACBindings.Internal.SmartArray___DataHistory_DataIDHistoryData m_IDs;
        public uint m_cbCompressed;
        public uint m_nIDsToPatch;
        public uint m_nIDsToPurge;
        public ACBindings.Internal.DataHistory.IterationType m_IterationType;
        public int m_AliasedIteration;
        public ACBindings.Internal.IterationKey m_Key;
        public ACBindings.Internal.PStringBase__sbyte m_BuildString;

        // Methods
    }
    // DataHistory::IterationType
    public enum IterationType : byte
    {
        Normal_Iteration = 0x0,
        NoPatch_Iteration = 0x1,
        Alias_Iteration = 0x2,
        Invalid_IterationType = 0x3
    }
    // DataHistory::UpdateType
    public enum UpdateType : byte
    {
        utPatch = 0x0,
        utPurge = 0x1,
        utIgnore = 0x2,
        utInvalid = 0x3
    }
    public unsafe struct WriteOnlyData
    {
        // Members
        public ACBindings.Internal.PStringBase__ushort HistFileName;
        public ACBindings.Internal.DataHistory.IterationData* pCurrentIteration;
        public ACBindings.Internal.AutoGrowHashTable___QualifiedDataID__int BackHash;

        // Methods
    }

    // Members
    public ACBindings.Internal.AutoGrowHashTable__int___DataHistory_IterationData m_Iterations;
    public ACBindings.Internal.CMostlyConsecutiveIntSet m_IterList;
    public ACBindings.Internal.DatIDStamp m_guidStamp;
    public ulong m_CorrespondingDatFileID;
    public int m_idCurrentIteration;
    public byte m_bNewXPackMode;
    public ACBindings.Internal.PStringBase__sbyte m_CurrentBuildString;
    public ACBindings.Internal.DataHistory.WriteOnlyData* m_pWriteData;

    // Methods
}

