console.log('what up my peeps');


document.getElementById
document.getElementsByClassName
document.querySelector
document.getelementsbykey
//get reference to the form
const addtodoform = document.querySelector('.addtodo');
addtodoform.addEventListener('submit', (e) => {
  e.preventDefault();
  console.log(e);
});