namespace ACBindings;

// DataHistory
public unsafe struct DataHistory
{
    // Child Types
    // DataHistory::DataIDHistoryData
    public unsafe struct DataIDHistoryData
    {
        // Members
        public ACBindings.QualifiedDataID qdid;
        public uint cbCompressed;
        public ACBindings.DataHistory.UpdateType utAction;

        // Methods
    }
    // DataHistory::IterationData
    public unsafe struct IterationData
    {
        // Members
        public ACBindings.SmartArray__DataHistory_DataIDHistoryData m_IDs;
        public uint m_cbCompressed;
        public uint m_nIDsToPatch;
        public uint m_nIDsToPurge;
        public ACBindings.DataHistory.IterationType m_IterationType;
        public int m_AliasedIteration;
        public ACBindings.IterationKey m_Key;
        public ACBindings.PStringBase__sbyte m_BuildString;

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
    // DataHistory::WriteOnlyData
    public unsafe struct WriteOnlyData
    {
        // Members
        public ACBindings.PStringBase__ushort HistFileName;
        public ACBindings.DataHistory.IterationData* pCurrentIteration;
        public ACBindings.AutoGrowHashTable__QualifiedDataID__int BackHash;

        // Methods
    }

    // Members
    public ACBindings.AutoGrowHashTable__int__DataHistory_IterationData m_Iterations;
    public ACBindings.CMostlyConsecutiveIntSet m_IterList;
    public ACBindings.DatIDStamp m_guidStamp;
    public ulong m_CorrespondingDatFileID;
    public int m_idCurrentIteration;
    public byte m_bNewXPackMode;
    public ACBindings.PStringBase__sbyte m_CurrentBuildString;
    public ACBindings.DataHistory.WriteOnlyData* m_pWriteData;

    // Methods
}

