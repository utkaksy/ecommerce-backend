// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//ProductTest();

CategoryManager CategoryManager = new CategoryManager(new EfCategoryDal());
foreach (var category in CategoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}

static void ProductTest()
{
    Console.WriteLine("Hello, World!");

    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetByUnitPrice(50, 100))
    {
        Console.WriteLine(product.ProductName);
    }
}