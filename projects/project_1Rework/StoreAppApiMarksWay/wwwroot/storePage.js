window.onload = function () {

    console.log(sessionStorage.user);
	console.log(sessionStorage.store);
	console.log(sessionStorage.cart)

	let user = JSON.parse(sessionStorage.getItem('user'));
	let store = JSON.parse(sessionStorage.getItem('store'));
	let cart = JSON.parse(sessionStorage.getItem('cart'));
	let productArray = [];
	let ordersLength;
	console.log(productArray);
	

	


	const button = document.createElement('button');

	//Get Orders
	fetch('/api/Orders')
		.then(res => res.json())
		.then(data => {
			ordersLength = (data.length) + 1;
		})

	
	fetch('/api/Orders', {
		method: 'POST',
		body: JSON.stringify({storeId: store.storeId, customerId: user.customerId }),
		headers: {
			'Content-Type': 'application/json'
        }
    })

		
	//GETS PRODUCTS BY THE SELECTED STORE
	fetch(`/api/Products/findProductList/${store.storeId}`)
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const lop = document.querySelector('#productList');
			
			for (let x = 0; x < data.length; x++) {
				let AddButton = button.cloneNode(false);
				AddButton.innerText = 'Add';
				AddButton.classList.add("addProduct");
				AddButton.value = data[x].productId;
				console.log(data[x].productId);
				lop.innerHTML += `<p> ${data[x].productName} ${data[x].productPrice} </p>`;
				lop.appendChild(AddButton);
			}
		})
		//Add the event listener for the add button 
		.then(addproduct => {
			var buttonSelectors = document.getElementsByClassName('addProduct');
			for (let i = 0; i < buttonSelectors.length; i++) {
				let buttonhue = buttonSelectors[i];
				buttonhue.addEventListener('click', function () {

					//GET THE STOREID VALUE FROM THE BUTOnn AND make a storedsession of the storeid
					//Calls stores ID api get
						fetch(`/api/Products/${buttonhue.value}`)
						.then(res => res.json())
						.then(res => {
							console.log(res)
							console.log(buttonhue.value) //prints the id of the product
							productArray.push(res);
							console.log(productArray[0].productName);
							console.log("Add item to the cart array");
						});
				});
			}
		});

	let viewCartButton = document.getElementById('ViewCart');
	let submitCartButton = document.getElementById('SubmitCart');

	viewCartButton.addEventListener('click', function () {
		console.log(productArray);
		for (let x = 0; x < productArray.length; x++) {
			console.log(productArray[x].productId);
		}
	})

	submitCartButton.addEventListener('click', function () {
		console.log(ordersLength);
		console.log(productArray[0].productId);
		
		for (let x = 0; x < productArray.length; x++) {
			fetch('/api/OrderProducts', {
				method: 'POST',
				body: JSON.stringify({ orderId: ordersLength, productId: productArray[x].productId }),
				headers: {
					'Content-Type': 'application/json'
				}
			})
			.then()
        }
		

    })

}