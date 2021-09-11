let class1 = new Object();
let class2 = {};

class2.name = 'Mark';
console.log(class2.name);

class2.myObject = {
  fname: 'joe',
  lname: 'Dimaggio'
}

function baseballPlayer(batAvg, fName, lname, team) {
  return {
    batAvg: batAvg,
    fname: fname,
    lname: lname,
    team: team
  }
}

let joeyD = baseballPlayer(.200, 'Joe', 'Dimag', 'Yankees');
let NolanR = baseballPlayer(.050, 'Nolan', 'Ryan', 'Rangers');

let class3 = {
  name:,
  age:
};