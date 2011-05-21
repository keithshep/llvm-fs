module FSExternHelper.HeaderSyntax

type CBaseType =
    | GeneralType of string
    | StructType of string
    | IntType
    | VoidType
    | CharType
    | UnsignedIntType
    | UnsignedLongLongType
    | LongLongType
    | UnsignedByteType
    | DoubleType
    override self.ToString() =
        match self with
        | GeneralType s -> s
        | StructType s -> "struct " + s
        | IntType -> "int"
        | VoidType -> "void"
        | CharType -> "char"
        | UnsignedIntType -> "unsigned"
        | UnsignedLongLongType -> "unsigned long long"
        | LongLongType -> "long long"
        | UnsignedByteType -> "uint8_t"
        | DoubleType -> "double"

type CFullType = {
    baseType : CBaseType
    isConst : bool
    pointerDepth: int} with
    override x.ToString() =
        let mutable str = x.baseType.ToString ()
        if x.isConst then
            str <- "const " + str
        for i = 0 to x.pointerDepth - 1 do
            str <- str + "*"
        str

type CDef =
    | CFuncDef of CFullType * string * (CFullType * string option) list
    | CEnumDef of string * (string * int option) list
    | CTypeAlias of CFullType * string

