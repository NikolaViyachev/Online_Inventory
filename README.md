# Online_Inventory
 Progress_Interview_task

Explanation of the task:
In this project I have create a list of products.
This table is accessible in the Product Table tab in the navigation bar.
The class Product contains 8 properties - Id, Image (a string, that points to the image address), Name, Category Country of Origin, Price Quantity, Notes. 
After that, in the ProductTable.razor file, I created a table, with every property as a column and a table body for the product information. 
To run through each product, I used a foreach cycle and put the products in a List<Product>. 
In order to color the cells with the quantity, I used a switch-case.
Finally i also found that through IgniteUI, I can also create a data grid in Blazor.
The data for the IgniteUI data grid is fed through an excel file converted to a json file.
