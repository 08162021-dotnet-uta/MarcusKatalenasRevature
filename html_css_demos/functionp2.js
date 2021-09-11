console.log("What up from 9/7/2021")

//function declaration
function myfunc1(x, y = 'this is a default value') {
  return `I have ${x} values called ${y}.`
}

console.log(myfunc1(3, 4));

//function expression

let myfunc2 = function (x, y) {
  return x + y;
}


console.log(myfunc2(1, 2));

//Pass by reference
let myfunc3 = myfunc2;

console.log(myfunc2(1, 3));
console.log(myfunc3(1, 3));

//Arrowed/Lambda expressions
let myFunc4 = (x, y) => x + y;
let myFunc5 = function (x, y) {
  return x + y;
}
console.log(myFunc4(9, 10));
console.log(myFunc5(9, 10));
let myFunc6 = () => {
  console.log(`This is a multiline arrow function`);
  console.log(`here is the second line`);
}

myFunc6();

function callback1(param1) {
  return `This value is ${param1} from callback1`;
}

function callback2(param1) {
  return `This value is ${param1} from callback2`;
}

//Callback Function
let myFunc7 = (x, y, z) => {
  if (x % 2 === 0) {
    console.log(y(x));
  }
  else {
    console.log(z(x));
  }
}

myFunc7(1, callback1, callback2);

function makeadder(x) {
  return (y) => {
    return x + y;
  }
}

let makeadderholder = makeadder(10);

console.log(makeadderholder(5));

