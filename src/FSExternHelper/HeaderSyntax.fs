module FSExternHelper.HeaderSyntax

type CBaseType =
    | GeneralType of string
    | StructType of string
    | IntType
    | FloatType
    | VoidType
    | CharType
    | UnsignedIntType
    | UnsignedLongLongType
    | LongLongType
    | UnsignedByteType
    | DoubleType

type CFullType = {
    baseType : CBaseType
    isConst : bool
    pointerDepth: int}

type CDef =
    | CFuncDef of CFullType * string * (CFullType * string option) list
    | CEnumDef of string * (string * int option) list
    | CTypeAlias of CFullType * string

