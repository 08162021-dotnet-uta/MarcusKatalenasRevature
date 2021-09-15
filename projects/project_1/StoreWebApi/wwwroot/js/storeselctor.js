const uri2 = 'api/Stores';
let Stores = [];

function getStoreItems() {
    fetch(uri2)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}


function _displayItems(data) {
    const tBody = document.getElementById('Stores');
    tBody.innerHTML = '';

   

    const button = document.createElement('button');

    data.forEach(item => {

        let tr = tBody.insertRow();

        let SelectButton = button.cloneNode(false);
        SelectButton.innerText = 'Select';

        let td1 = tr.insertCell(0);
        let storeNameCode = document.createTextNode(item.storeName);
        td1.appendChild(storeNameCode);

        let td2 = tr.insertCell(1);
        let storeLocationCode = document.createTextNode(item.storeLocation);
        td2.appendChild(storeLocationCode);

        let td3 = tr.insertCell(2);
        td3.appendChild(SelectButton);
    });

    todos = data;
}