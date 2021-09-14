const uri = 'api/Stores';
let Customers = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function _displayItems(data) {
    const tBody = document.getElementById('Customers');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
 
        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(isActiveCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(item.fname);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        let textNode2 = document.createTextNode(item.lname);
        td3.appendChild(textNode2);

        let td4 = tr.insertCell(3);
        let textNode3 = document.createTextNode(item.customerId);
        td4.appendChild(textNode3);

        let td5 = tr.insertCell(4);
        td5.appendChild(editButton);

        let td6 = tr.insertCell(5);
        td6.appendChild(deleteButton);
    });

    todos = data;