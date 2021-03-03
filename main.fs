module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v = v * 25.4;;
     // write your code here

let footToInch x = x * 12;;
     // write your code here

let yardToFoot v = v * 3;;
     // write your code here

let mileToYard mile = mile * 1760;;
    // write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y = y |> yardToFoot |> footToInch |> inchToMillimeter;;
     // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
    fun x->x/ 1000.0 // write your code here

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n = n |> divBy1000;;
     // write your code here

let meterToKilometer m = m * 1000;;
    fun x->x // write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer x=
    fun x->x/ 3000;;  // write your code here

let inchToMeter x =
    fun x->x * 25.4;; // write your code here

let yardToKilometer x=
    fun x->x // write your code here

let mileToMeter =
    fun x->x // write your code here


// Define following weight unit transformations
let ounceToGram v =
    v * 28.35;; // write your code here

let poundToOunce p =
    p * 16;; // write your code here

let shortTonToPound t =
    t * 2000;; // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    g * 1000;; // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun x->x // write your code here

let poundToKilogram =
    fun x->x // write your code here

let shortTonToMetricTon =
    fun x->x // write your code here
