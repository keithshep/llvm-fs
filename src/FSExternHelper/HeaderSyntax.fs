module FSExternHelper.HeaderSyntax

type CBaseType =
    | GeneralType of string
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

type CFuncDef = CFuncDef of CFullType * string * (CFullType * string option) list

