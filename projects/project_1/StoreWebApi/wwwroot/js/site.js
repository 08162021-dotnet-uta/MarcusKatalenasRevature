const uri = 'api/Customers';
let Customers = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function validateLogin() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _findLogin(data))
        .catch(error => console.error('Unable to get items.', error));
}
validateLogin();

function addItem() {
    const addFNameTextbox = document.getElementById('add-CustomerFname');
    const addLNameTextbox = document.getElementById('add-CustomerLname');

    const item = {
        active: false,
        fname: addFNameTextbox.value.trim(),
        lname: addLNameTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addFNameTextbox.value = '';
            addLNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = todos.find(item => item.id === id);

    document.getElementById('edit-id').value = item.customerId;
    document.getElementById('edit-fname').value = item.fname;
    document.getElementById('edit-lname').value = item.lname;
    document.getElementById('edit-Active').checked = item.active;
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        active: document.getElementById('edit-Active').checked,
        fname: document.getElementById('edit-fname').value.trim(),
        lname: document.getElementById('edit-lname').value.trim()
    };

    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'Customer' : 'Customers';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('Customers');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        let isActiveCheckbox = document.createElement('input');
        isActiveCheckbox.type = 'checkbox';
        isActiveCheckbox.disabled = true;
        isActiveCheckbox.checked = item.active;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.customerId})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.customerId})`);

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
}