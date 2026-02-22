# AJAX MVC CRUD App – Transaction Management

A modern **ASP.NET Core MVC 8** application demonstrating **AJAX-powered CRUD operations** without full page reloads.  
The app provides a smooth user experience using **jQuery AJAX**, **Entity Framework Core**, **SQL Server**, and **Bootstrap 5**.

---

## 🚀 Features

✅ Full CRUD Operations (Create, Read, Update, Delete)  
✅ AJAX-Based UI (No Page Refresh)  
✅ Partial View Rendering  
✅ Modal Form Handling  
✅ Real-Time List Updates  
✅ Server-Side & Client-Side Validation  
✅ Clean & Responsive UI  
✅ Optimized User Experience  

---

## 🛠️ Tech Stack

- **ASP.NET Core MVC 8**
- **Entity Framework Core**
- **SQL Server**
- **jQuery AJAX**
- **Bootstrap 5**
- **Font Awesome**

---

## ⚡ AJAX Functionality

This project eliminates traditional page reloads by using:

✔ **jQuery AJAX Calls** for form submissions  
✔ **Partial Views** for dynamic content updates  
✔ **JSON Responses** from controller actions  
✔ **Bootstrap Modal** for popup forms  

### ✔ Benefits

- Faster interactions
- Better UX
- Reduced server load
- Modern SPA-like behavior

---

## 🗄️ Database Schema

### **Transaction**

| Column | Type | Description |
|--------|------|-------------|
| Id | PK | Primary Key |
| AccountNumber | string | Sender Account |
| BeneficiaryName | string | Receiver Name |
| BankName | string | Bank Details |
| SwiftCode | string | Bank Identifier |
| Amount | decimal | Transaction Amount |
| Date | DateTime | Transaction Date |

---

## 🔁 CRUD Flow (AJAX)

### **Create / Edit**

1. Open form inside Bootstrap modal  
2. Submit form via AJAX  
3. Controller validates ModelState  
4. Partial view re-rendered  
5. Transaction list updated dynamically  

---

### **Delete**

1. User clicks Delete  
2. Confirmation view shown  
3. AJAX POST request sent  
4. Record removed from database  
5. Updated list returned via JSON  
