
//Welcome to the base JS page
//alert("This is an alert!")
//var msg = prompt("Are you sure??????????????", "Default bby");
//prompt(msg, msg);

//Cannot change CONST, name convention is to have all uppercase
const UPPERCASENAME = 200;

//Declaring mutiple variables are once
//The better verison of var
// let guy = "Marcus", age = 27, address = "123 Street ST.";
// console.log(`${guy} is ${age} and is at ${address}`);
// alert("Check the logs in console");

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
console.log(5 - 5 + 5 + 10)

//=  assingment 
//== Equality with content will translate between types(type Coersion)
//=== 100% same type and content

/*TRUTHY vs FALSY
By default, all boolean contexts are truthy unless defined as falsy

*/

let var1 = null;
let var2 = false;
let var3 = 12;
let var4 = "3e3";
let var5 = '';

//TYPE CONVERSION
console.log(Number(var2));
console.log(Boolean(var3))



if (25) {
  console.log("This is true because of default stuff");
}
else {
  console.log("FALSE BBY");
}

//JSON JavaScrpitObjectNottaion
//JSON.Stringify() = obj => JSON
//JSON.Parse() = JSON => obj


//Maps Map vs Weak Map
//Sets Set vs Weak Set

//Scope blocks
{

}