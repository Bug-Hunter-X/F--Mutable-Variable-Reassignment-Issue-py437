let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d" z
x <- 3
printf "%d" z // z is still 3, not 6