open System
open Haikunator

[<EntryPoint>]
let main argv =
    printfn "%A" Haikunator.generateRandomNumberOfRandomHaikus
    0 // return an integer exit code
