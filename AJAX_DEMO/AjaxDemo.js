console.log("This is auto ran");

//1.Create Request object
//let xhr = new XMLHttpRequest();


//2.assign the object to do something when the response is received
//xhr.onreadystatechange = PrintJokes;

function PrintJoke() {
  console.log(`The onereadystatechage was fire.  ${this.readyState}`)
  if (this.status === 200 && this.readyState === 4) {
    const result = JSON.parse(this.responseText);
    console.log(`${result.value.joke}`)

    const para = document.querySelector('p');
    para.innerText = result.value.joke
  }
}

function PrintJokes() {
  console.log(`The onereadystatechage was fire.  ${this.readyState}`)
  if (this.status === 200 && this.readyState === 4) {
    const result = JSON.parse(this.responseText);
    console.log(`${this.responseText}`)
    const body = document.querySelector('body');
    for (let i = 0; i < result.value.length; i++) {
      console.log(`${result.value[i].joke}`);
      body.innerHTML += `<p>${result.value[i].joke}</p><br>`;
    }
  }
}


//3 .OPEN A CONNECTION TO THE API YOU WANT
//xhr.open('GET', `http://api.icndb.com/jokes/random/5`, true)

//4 SEND THE REQUEST
//xhr.send();

fetch('http://api.icndb.com/jokes/random/5',)
  .then(res => res.json())
  .then(res => {
    console.log(res)
    return res;
  })
  .then(res => {
    const para = document.querySelectorAll('p');
    console.log(para);
    for (let i = 0; i < res.value.length; i++) {
      para[i].innerText = res.value[i].joke;
    }
    console.log(this.responseText);
  });
