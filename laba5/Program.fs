open System

[<EntryPoint>]
let main argv =
    printfn "5 + 3 = %d" (MathFunctions.add 5 3)
    printfn "5 - 3 = %d" (MathFunctions.subtract 5 3)
    printfn "5 * 3 = %d" (MathFunctions.multiply 5 3)
    printfn "6 / 3 = %d" (MathFunctions.divide 6 3)
    printfn "Факториал 5 = %d" (MathFunctions.factorial 5)
    
    let add5 = MathFunctions.add 5
    printfn "add5 3 = %d" (add5 3)
    0