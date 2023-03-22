using System;

namespace app {
    class Program {
        static void Main(string[] args) {
            // Write a program that:

            // Request data from a customer: Name, email, coupon
            // Determine if a customer has a discount coupon
            // Show a discounted price based on the discount
            // Show the price of a product without discount if there is no coupon
            // Note: you can set a fixed price for a product or a variable one.

            // Set the product price
            double productPrice = 50.00;
            string? customerName = null;
            string? customerEmail = null;
            string? couponCode = null;

            // Request customer information
            Console.Write("Enter your name: ");
            customerName = Console.ReadLine();

            Console.Write("Enter your email: ");
            customerEmail = Console.ReadLine();

            Console.Write("Enter your coupon code (if you have one): ");
            couponCode = Console.ReadLine();

            if (customerName != null && customerEmail != null && couponCode != null) {
                // Check if customer has a valid coupon code
                bool hasDiscountCoupon = false;
                double discountPercentage = 0.0;

                if (couponCode == "DISCOUNT10") {
                    hasDiscountCoupon = true;
                    discountPercentage = 0.10;
                }

                // Calculate the discounted price if customer has a valid coupon
                double discountedPrice = 0.0;

                if (hasDiscountCoupon) {
                    discountedPrice = productPrice - (productPrice * discountPercentage);
                    Console.WriteLine($"Dear {customerName}, your discounted price is: ${discountedPrice:F2}");
                } else {
                    Console.WriteLine($"Dear {customerName}, the price of the product without discount is: ${productPrice:F2}");
                }
            }
        }
    }
}