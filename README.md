# F# Mutable Variable Reassignment Issue

This example demonstrates a common issue in F# related to the immutability of values and the potential for unexpected behavior when working with mutable variables.  When you reassign a mutable variable, the references to that value might not change, leading to issues if you are expecting the changes to propagate throughout your code.

The bug.fs file shows the original code with the issue, while bugSolution.fs provides a solution.