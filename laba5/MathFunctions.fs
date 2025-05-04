module MathFunctions

let add x y = x + y
let subtract x y = x - y
let multiply x y = x * y
let divide x y = x / y

let rec factorial n =
    if n <= 1 then 1
    else n * factorial (n - 1)