const button = document.querySelector('.weatherlist');
const listofcustomers = document.querySelector('.listofcustomers')

button.addEventListener('click', (e) => {


  fetch('WeatherForecast/Get')
    .then(res => res.json())
    .then(res => {

    })
});