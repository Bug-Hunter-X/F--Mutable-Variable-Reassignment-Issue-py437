let x = ref 1
let y = ref 2
let z = !x + !y
printf "%d" z
x := 3
printf "%d" (!x + !y) // z is now 5, correctly reflecting the change.