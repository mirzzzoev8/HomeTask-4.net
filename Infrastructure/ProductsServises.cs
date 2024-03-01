using Dapper;
using Domain;

namespace Infrastructure;

public class ProductsServises
{
    private readonly DapperContext _context;

    public ProductsServises()
    {
        _context = new DapperContext();
    }
    public void AddProduct(Products products)
    {
        var sql = "insert into products (name, count,storageId) values (@name, @count,@storageId)";
        _context.Connection().Execute(sql, products);
    }

    public void AddStorage(Storage storage)
    {
        var sql = "insert into storage (name, address) values (@name, @address)";
        _context.Connection().Execute(sql, storage);
    }
    public void GetProductsOnMovements()
    {
        var sql = @"select storage.name as storage , products.name as products ,
                    products.count from products
                    join storage on product.storageId = storage.storageId";
        var result = _context.Connection().Query(sql);
        foreach (var row in result)
            {
                Console.WriteLine($"Storage: {row.Storage}, Product: {row.Products}, Count: {row.Count}");
            }
    }



}
