# E-Commerce Promotion & Order Settlement Engine

## 1. Objective

This project is a simple C# console application for processing e-commerce orders.

The application:

* Reads orders from a CSV file.
* Reads promotion rules from a JSON file.
* Validates orders and promotion codes.
* Calculates discount and final amount.
* Uses `MemoryStream` to temporarily stage successful order data.
* Uses `BinaryWriter` to write financial data.
* Uses `BinaryReader` to read and verify the data.
* Uses `BufferedStream` for rejection logging.
* Generates JSON output files.
* Handles invalid orders using custom exceptions.
* Uses NUnit for testing.

---

## 2. Input Files

### orders.csv

Contains order information:

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

Contains promotion rules:

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

## 3. Validation

The application performs the following validations:

### Order Validation

* Order ID must be unique.
* Amount must be greater than 0.

### Promotion Validation

* Promo code must exist.
* Promo code must not be expired.
* Order amount must satisfy the minimum order amount.

If validation fails, the order is rejected and processing continues for the remaining orders.

---

## 4. Custom Exceptions

The project uses the following exception hierarchy:

```text
OrderException
|
|-- InvalidPromoCodeException
|-- MinimumOrderNotMetException
|-- DuplicateOrderException
```

### InvalidPromoCodeException

Used when:

* Promo code does not exist.
* Promo code is expired.

### MinimumOrderNotMetException

Used when the order amount is less than the promotion's minimum order amount.

### DuplicateOrderException

Used when the same `OrderId` appears more than once.

---

## 5. Stream Concepts Used

### FileStream

Used to open and read/write files.

Example:

```csharp
FileStream fileStream =
    new FileStream(filePath, FileMode.Open);
```

### StreamReader

Used to read text data from files such as CSV and JSON.

### StreamWriter

Used to write text data to output files.

### MemoryStream

Used to temporarily store successful order data in memory before it is committed.

### BinaryWriter

Used to write order financial data in binary format.

The following data is written:

* OrderId
* Customer
* Amount
* PromoCode
* Discount
* FinalAmount

### BinaryReader

Used to read the binary data and verify that the written data can be correctly decoded.

### BufferedStream

Used while writing `rejections.log` to provide buffered file writing.

---

## 6. Processing Flow

The complete processing flow is:

```text
orders.csv
     |
     v
Read orders using FileStream + StreamReader
     |
     v
Validate Order
     |
     v
Find Promotion
     |
     v
Validate Promotion
     |
     v
Calculate Discount
     |
     v
Stage successful order
     |
     v
MemoryStream
     |
     v
BinaryWriter
     |
     v
BinaryReader
     |
     v
Verify Data
     |
     +------------------+
     |                  |
     v                  v
 Successful          Rejected
     |                  |
     v                  v
priced_orders.json  rejections.log
     |
     v
order_summary.json
```

---

## 7. Discount Calculation

The discount is calculated using:

```text
Discount = Amount × Percent / 100
```

Final amount:

```text
Final Amount = Amount - Discount
```

### Example

For:

```text
Amount = 2500
Promo = SAVE10
Discount = 10%
```

Calculation:

```text
Discount = 2500 × 10 / 100
         = 250

Final Amount = 2500 - 250
             = 2250
```

---

## 8. Expected Result

For the given input:

| Order | Result                   | Discount | Final Amount |
| ----- | ------------------------ | -------: | -----------: |
| O1    | Successful               |      250 |         2250 |
| O2    | Rejected - Minimum Order |        0 |            - |
| O3    | Successful               |      600 |         2400 |
| O4    | Rejected - Expired Promo |        0 |            - |
| O5    | Successful               |      450 |         4050 |
| O6    | Rejected - Unknown Promo |        0 |            - |

### Summary

```text
Total Orders       = 6
Successful Orders  = 3
Rejected Orders    = 3

Total Amount       = 10000
Total Discount     = 1300
Total Final Amount = 8700
```

---

## 9. Output Files

### priced_orders.json

Contains successfully processed orders with:

* OrderId
* Customer
* Amount
* PromoCode
* Discount
* FinalAmount

### order_summary.json

Contains:

* TotalOrders
* SuccessfulOrders
* RejectedOrders
* TotalAmount
* TotalDiscount
* TotalFinalAmount

### rejections.log

Contains the reason for every rejected order.

Example:

```text
O2: Minimum order amount is 1000
O4: Promo code is expired: EXPIRED5
O6: Promo code does not exist: BOGUS
```

---

## 10. Project Structure

```text
ECommercePromotionEngine
|
|-- Models.cs
|-- OrderException.cs
|-- OrderRead.cs
|-- PromotionLoad.cs
|-- PromotionService.cs
|-- BinaryHandler.cs
|-- OrderProcessor.cs
|-- OutputFiles.cs
|-- Program.cs
|
|-- orders.csv
|-- discounts.json
|-- priced_orders.json
|-- order_summary.json
|-- rejections.log
|
|-- Tests
    |
    |-- UnitTests1
```

---

## 11. Testing

NUnit tests are included for:

1. Valid discount calculation.
2. Expired promotion.
3. Unknown promotion.
4. Minimum order failure.
5. Positive amount validation.

---

## 12. Error Handling

A single invalid order should not stop the complete application.

For example:

```text
O1 → Valid → Processed
O2 → Invalid → Rejected
O3 → Valid → Processed
```

The application continues processing `O3` even though `O2` failed.

---

## 13. Important Assumptions

* CSV fields are separated using commas.
* The CSV file contains a header row.
* Amount is expected to be a valid decimal number.
* Promo codes are matched exactly.
* Rejected orders are not included in the successful priced orders.
* Only successfully validated orders are staged and committed.
* Output files are created/overwritten during each run.

---

## 14. How to Run

### Step 1

Open the project in Visual Studio or VS Code.

### Step 2

Make sure these files are present:

```text
orders.csv
discounts.json
```

### Step 3

Run the application:

```bash
dotnet run
```

### Step 4

Check the generated files:

```text
priced_orders.json
order_summary.json
rejections.log
```

---

## 15. How to Run Tests

Run:

```bash
dotnet test
```

NUnit will execute all test cases and display the result in the terminal.

---

## 16. Main Concepts Demonstrated

This project demonstrates practical use of:

* C# Classes and Objects
* Exception Handling
* Custom Exceptions
* CSV File Processing
* JSON Deserialization
* `FileStream`
* `StreamReader`
* `StreamWriter`
* `MemoryStream`
* `BinaryWriter`
* `BinaryReader`
* `BufferedStream`
* `using` for resource management
* NUnit Testing
* Basic collections such as `List<T>` and `HashSet<T>`
