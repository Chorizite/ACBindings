namespace ACBindings;

// SearchCommandExecuteErrors
public enum SearchCommandExecuteErrors : byte
{
    SCEE_PATHNOTFOUND = 0x1,
    SCEE_MAXFILESFOUND = 0x2,
    SCEE_INDEXSEARCH = 0x3,
    SCEE_CONSTRAINT = 0x4,
    SCEE_SCOPEMISMATCH = 0x5,
    SCEE_CASESENINDEX = 0x6,
    SCEE_INDEXNOTCOMPLETE = 0x7
}

