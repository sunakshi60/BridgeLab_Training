# E-Commerce Promotion & Order Settlement Engine

## 1. Project Overview

This is a basic C# console application for processing e-commerce orders and applying promotion codes.

The project focuses on practicing:

* CSV file handling
* JSON handling
* Basic validation
* Custom exceptions
* Discount calculation
* C# Streams
* Binary data handling
* NUnit testing

The implementation is kept simple and focuses on the main requirements of the problem.

---

## 2. Input Files

### orders.csv

The order file contains:

```csv
OrderId,Customer,Amount,PromoCode
O1,Sneha,2500,SAVE10
O2,Amit,500,SAVE10
O3,Priya,3000,WELCOME20
O4,Rahul,1200,EXPIRED5
O5,Kiran,4500,SAVE10
O6,Sanjay,800,BOGUS
```

### discounts.json

Promotion details are stored in JSON:

```json
{
  "promoCodes": [
    {
      "code": "SAVE10",
      "percent": 10,
      "minOrder": 1000,
      "expired": false
    },
    {
      "code": "WELCOME20",
      "percent": 20,
      "minOrder": 2000,
      "expired": false
    },
    {
      "code": "EXPIRED5",
      "percent": 5,
      "minOrder": 500,
      "expired": true
    }
  ]
}
```

---

## 3. Main Features

The application currently handles the main order-processing flow:

1. Read orders from CSV.
2. Load promotions from JSON.
3. Check order amount.
4. Check duplicate OrderId.
5. Check whether promo code exists.
6. Check whether promo code is expired.
7. Check minimum order amount.
8. Calculate discount.
9. Calculate final amount.
10. Store successful orders.
11. Generate output files.
12. Handle rejected orders without stopping the complete process.

---

## 4. Streams Used

The project demonstrates different C# stream classes.

### FileStream

Used for opening input and output files.

### StreamReader

Used to read CSV and JSON text.

### StreamWriter

Used to write JSON and log files.

### MemoryStream

Used for temporary in-memory processing of order data.

### BinaryWriter

Used to write order data in binary form.

### BinaryReader

Used to read the binary data again and verify it.

### BufferedStream

Used while writing the rejection log.

---

## 5. Validation

The following basic validations are implemented:

### Amount Validation

Order amount should be greater than zero.

### Duplicate Order Validation

The same OrderId should not be processed twice.

### Promo Code Validation

The promo code should exist in the promotion list.

### Expiry Validation

Expired promotion codes are rejected.

### Minimum Order Validation

The order amount should be greater than or equal to the promotion's minimum order amount.

---

## 6. Custom Exceptions

The project contains:

```text
OrderException
    |
    |-- InvalidPromoCodeException
    |
    |-- MinimumOrderNotMetException
    |
    |-- DuplicateOrderException
```

These exceptions are used to handle different order validation failures.

---

## 7. Discount Calculation

The discount is calculated using:

```text
Discount = Amount × Discount Percentage / 100
```

The final amount is:

```text
Final Amount = Amount - Discount
```

For example:

```text
Amount = 2500
Discount = 10%

Discount = 250
Final Amount = 2250
```

---

## 8. Output Files

The application generates three output files.

### priced_orders.json

Contains successfully processed orders and their calculated discount and final amount.

### order_summary.json

Contains basic processing information such as:

* Total orders
* Successful orders
* Rejected orders
* Total amount
* Total discount
* Total final amount

### rejections.log

Contains rejected orders along with the reason for rejection.

---

## 9. Expected Processing

For the provided input:

```text
O1 → Successful
O2 → Rejected - Minimum Order
O3 → Successful
O4 → Rejected - Expired Promo
O5 → Successful
O6 → Rejected - Unknown Promo
```

Expected successful orders:

```text
O1
O3
O5
```

---

## 10. Project Structure

```text
ECommercePromotionEngine
│
├── Models.cs
├── Order.Exceptions.cs
├── OrderRead.cs
├── PromotionLoad.cs
├── PromotionService.cs
├── BinaryHandler.cs
├── OrderProcessor.cs
├── OutputFiles.cs
├── Program.cs
│
├── orders.csv
├── discounts.json
│
└── Tests
    ├── PromotionTests.cs
    └── BinaryTests.cs
```

---

## 11. Testing

Basic NUnit testing has been added for the important functionality.

The tests cover:

* Valid discount calculation
* Expired promotion
* Unknown promotion
* Minimum order failure
* Duplicate order
* Binary read/write verification

The testing section is intentionally kept small and focuses on the main functionality rather than covering every possible edge case.

---

## 12. Error Handling

Invalid orders are handled using exceptions.

An invalid order does not stop the complete processing.

For example:

```text
O1 → Valid → Processed
O2 → Invalid → Rejected
O3 → Valid → Processed
```

Processing continues after the rejected order.

---

## 13. Current Scope

This implementation focuses on the **main functionality of the assignment** using simple C# concepts.

Some advanced improvements and additional edge-case handling are outside the current scope.

The main purpose of the project is to demonstrate practical understanding of:

* File I/O
* JSON
* Streams
* Exceptions
* Basic collections
* NUnit testing

---

## 14. How to Run

Run the application using:

```bash
dotnet run
```

After execution, check:

```text
priced_orders.json
order_summary.json
rejections.log
```

---

## 15. Run Tests

To run the NUnit tests:

```bash
dotnet test
```

The tests verify the main discount, validation, processing, and binary handling functionality.
