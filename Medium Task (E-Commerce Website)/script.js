const btnCart = document.querySelector('#cart-icon');
const cart = document.querySelector('.cart');
const btnClose = document.querySelector('#cart-close');

btnCart.addEventListener('click', () => {
    cart.classList.add('cart-active');
});

btnClose.addEventListener('click', () => {
    cart.classList.remove('cart-active');
});

document.addEventListener('DOMContentLoaded', loadProducts);

function loadProducts() {
    loadContent();
}

function loadContent() {
    let btnRemove = document.querySelectorAll('.cart-remove');
    btnRemove.forEach((btn) => {
        btn.addEventListener('click', removeItem);
    });

    let qtyElements = document.querySelectorAll('.cart-quantity');
    qtyElements.forEach((input) => {
        input.addEventListener('change', changeQty);
    });

    let cartBtns = document.querySelectorAll('.add-cart');
    cartBtns.forEach((btn) => {
        btn.addEventListener('click', addCart);
    });

    updateTotal();
}

function removeItem() {
    if (confirm('Are You Sure To Remove?')) 
    {
        let title=this.parentElement.querySelector('.cart-products-title').innerHTML;
        itemList=itemList.filter(el=>el.title!=title);
        this.parentElement.remove();
        loadContent();
    }
}

function changeQty() {
    if (this.value < 1) 
    {
        this.value = 1;
    }
    loadContent();
}

let itemList=[];

function addCart() {
    let products = this.parentElement;
    let title = products.querySelector('.products-title').innerHTML;
    let price = products.querySelector('.products-price').innerHTML;
    let imgSrc = products.querySelector('.products-img').src;
    
    let newProduct={title,price,imgSrc};
    if(itemList.find((el)=>el.title==newProduct.title))
    {
        alert("Product Already Added In Cart");
        return;
    }
    else
    {
        itemList.push(newProduct);
    }
    
    let newProductElement=createCartProduct(title,price,imgSrc);
    let element=document.createElement('div');
    element.innerHTML=newProductElement;
    let cartBasket=document.querySelector('.cart-content');
    cartBasket.append(element);
    loadContent();
}

function createCartProduct(title, price, imgSrc) {
    return `<div class="cart-box">
                <img src="${imgSrc}" class="cart-img">
                <div class="detail-box">
                    <div class="cart-products-title">${title}</div>
                    <div class="price-box">
            <div class="cart-price">${price}</div>
            <div class="cart-amount">${price}</div>
        </div>
        <input type="number" value="1" class="cart-quantity">
    </div>
    <ion-icon name="trash" class="cart-remove"></ion-icon>
</div>`;
}

function updateTotal()
{
    const cartItems=document.querySelectorAll('.cart-box');
    const totalValue=document.querySelector('.total-price');

    let total=0;

    cartItems.forEach(product=>{
        let priceElement=product.querySelector('.cart-price');
        let price=parseFloat(priceElement.innerHTML.replace("Rs.",""));
        let qty=product.querySelector('.cart-quantity').value;
        total+=(price*qty);
        product.querySelector('.cart-amount').innerText="Rs."+(price*qty);
    });
    totalValue.innerHTML="Rs."+total;

    const cartCount=document.querySelector('.cart-count');
    let count=itemList.length;
    cartCount.innerHTML=count;
}

function checkout()
{
    if(itemList.length>0)
    {
        alert("Thank You For Purchasing");
    }
    else
    {
        alert("Please Add Some Products To The Cart");
    }
    
}