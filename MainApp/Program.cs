
using Domain;
using Infrastructure;

var servise = new ProductsServises();
var product = new Products();
System.Console.Write("Your name please = ");
product.Name = Console.ReadLine();
System.Console.Write("Your count please = ");
product.Count = int.Parse(Console.ReadLine());
System.Console.Write("Your storageid please = ");
product.StorageId = int.Parse(Console.ReadLine());
servise.AddProduct(product);
System.Console.WriteLine("-----Product added succesfully------");

var storage = new Storage();
System.Console.Write("Your name please = ");
storage.Name = Console.ReadLine();
System.Console.Write("Your address please = ");
storage.Address = Console.ReadLine();
servise.AddStorage(storage);
System.Console.WriteLine("-----Storage added succesfully------");

servise.GetProductsOnMovements();

