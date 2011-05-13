open Microsoft.FSharp.Text.Lexing

open FSExternHelper.HeaderSyntax
open FSExternHelper.Lexer
open FSExternHelper.Parser

let rec allGenTypeNames (defs : CDef list) =
    let addType (t : CFullType) (set : Set<string>) =
        match t.baseType with
        | GeneralType typeName -> set.Add typeName
        | _ -> set

    match defs with
    | [] -> Set.empty
    | CFuncDef (retType, _, paramList) :: funcDefTail ->
        let set = addType retType Set.empty
        let set = List.fold (fun s (t, _) -> addType t s) set paramList
        Set.union set (allGenTypeNames funcDefTail)
    | _ :: funcDefTail -> allGenTypeNames funcDefTail

[<EntryPoint>]
let main (args : string array) =
    let lexbuf = LexBuffer<_>.FromTextReader stdin
    let parseResult = start tokenize lexbuf

    printfn "Type names:"
    Set.iter (printfn "%s") (allGenTypeNames parseResult)
    
    // Exit code
    0

