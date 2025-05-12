// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//DTO Data Transformation Object
//IoC Inversion of Control

ProductTest();

//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetails();
    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
        Console.WriteLine(result.Message);
    }
    else
    {
        Console.WriteLine(result.Message);
    }
    
}

static void CategoryTest()
{
    CategoryManager CategoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in CategoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}