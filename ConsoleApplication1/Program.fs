// Weitere Informationen zu F# unter "http://fsharp.net".
// Weitere Hilfe finden Sie im Projekt "F#-Lernprogramm".
open System
open Adam.Core

[<EntryPoint>]
let main argv = 
    let s = new SemanticNetwork()
    let e = new Edge()
    let v1 = new Node()
    let v2 = new Node()

    v1.Value <- "trololo"
    v2.Value <- "-.-"

    e.Add v1
    e.Add v2

    e.Relationship <- Is

    s.Add e


    v2.AreNeighbors(v2)
    |> printfn "Are v1 and v2 neighbors? %A" 

    printf "Neighbours of %A: " v1.Value

    v1.Neighbors 
        |> Seq.map(fun item -> item.Value) 
        |> printfn "%A" 

    printf "Neighbours of %A: " v2.Value

    v2.Neighbors 
        |> Seq.map(fun item -> item.Value) 
        |> printfn "Neighbours: %A" 

    Console.ReadKey(true) |> ignore
    0 // Exitcode aus ganzen Zahlen zurückgeben
