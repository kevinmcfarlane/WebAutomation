namespace MyApp

module Program =

    [<EntryPoint>]
    let main argv =
        match argv with
        | [||]         -> printfn "Expected at least one argument"
        | [|skill; _; _|] -> Source.itjobswatch skill
        | [|skill; _|]    -> Source.jobServePerm skill
        | [|skill|]       -> Source.jobServe skill
        | _               -> printfn "Too many arguments"
        0 
