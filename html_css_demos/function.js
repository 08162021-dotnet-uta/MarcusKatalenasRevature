
//Welcome to the base JS page
//alert("This is an alert!")
//var msg = prompt("Are you sure??????????????", "Default bby");
//prompt(msg, msg);

//Cannot change CONST, name convention is to have all uppercase
const UPPERCASENAME = 200;

//Declaring mutiple variables are once
//The better verison of var
let guy = "Marcus", age = 27, address = "123 Street ST.";
console.log(`${guy} is ${age} and is at ${address}`);
alert("Check the logs in console");

//Use let unless you are dealing with internet explorer pre v11 lmao
//Var is globally scoped is immune to scoped blocks
var newVar = 2;

//Datatpyes of prims
let bigIexample = 12345678n; //Bigint
let stringExample = "This is a string Var";//String
console.log(`The first letter in the string is => ${stringExample[0]}`); //Should log the letter T
let boolExample = true;
boolExample = (2 > 1);
null
Number
undefined

console.log(typeof (boolExample));
console.log(typeof bigIexample);

console.log(10 / (3 + 2) * 4 + 5 ** 2 + 6 - 9);


//Scope blocks
{

}