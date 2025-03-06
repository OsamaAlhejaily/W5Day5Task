import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  private cart: any[] = []; // Stores cart items

  addToCart(product: any) {
    const existingItem = this.cart.find(item => item.id === product.id);
    if (existingItem) {
      existingItem.quantity++; // Increment quantity if item exists
    } else {
      this.cart.push({ ...product, quantity: 1 }); // Add new item to cart
    }
    console.log("Cart updated:", this.cart); // Log cart updates
  }

  getCartItems(): any[] {
    return this.cart; // Return all cart items
  }
  
  getTotalItems(): number {
    return this.cart.reduce((total, item) => total + item.quantity, 0); // Calculate total items
  }
  
  getTotalPrice(): number {
    return this.cart.reduce((total, item) => total + (item.price * item.quantity), 0); // Calculate total price
  }
}