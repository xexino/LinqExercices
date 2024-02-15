using System.Linq;

namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region CountQuery
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountQuery()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      value = (from prod in products select prod).Count();

      return value;
    }
    #endregion

    #region CountMethod
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountMethod()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Method Syntax Here
            value = products.Select(s => s).Count();

            return value;
    }
    #endregion

    #region CountFilteredQuery
    /// <summary>
    /// Can either add a where clause or a predicate in the Count() method
    /// </summary>
    public int CountFilteredQuery()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Query Syntax #1 Here
             value = (from prod in products where prod.Color == "Red" select prod).Count();


            // Write Query Syntax #2 Here

           // value = (from prod in products where prod.TotalSales > 5 select prod).Count();
            return value;
    }
    #endregion

    #region CountFilteredMethod
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountFilteredMethod()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Method Syntax #1 Here

            value = products.Where(p=> p.Color == "Red").Count();
            // Write Method Syntax #2 Here

            return value;
    }
    #endregion

    #region MinQuery
    /// <summary>
    /// Get the minimum value of a single property in a collection
    /// </summary>
    public decimal MinQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Query Syntax #1 Here
            value = (from prod in products select prod).Min(prod => prod.ListPrice);

            // Write Query Syntax #2 Here

            value = (from prod in products  select prod.ListPrice).Min();

            return value;
    }
    #endregion

    #region MinMethod
    /// <summary>
    /// Get the minimum value of a single property in a collection
    /// </summary>
    public decimal MinMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
            // Write Query Syntax #1 Here
            value =products.Min(prod => prod.ListPrice);

            // Write Query Syntax #2 Here

            value = products.Select(p => p.StandardCost).Min();


            return value;
    }
    #endregion

    #region MaxQuery
    /// <summary>
    /// Get the maximum value of a single property in a collection
    /// </summary>
    public decimal MaxQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            value = (from prod in products select prod).Max(prod => prod.ListPrice);

            // Write Query Syntax #2 Here

            value = (from prod in products select prod.ListPrice).Max();
            return value;
    }
    #endregion

    #region MaxMethod
    /// <summary>
    /// Get the maximum value of a single property in a collection
    /// </summary>
    public decimal MaxMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Method Syntax #1 Here


            value = products.Max(prod => prod.ListPrice);

            // Write Query Syntax #2 Here

            value = products.Select(p => p.StandardCost).Max();

            // Write Method Syntax #2 Here


            return value;
    }
    #endregion

    #region MinByQuery
    /// <summary>
    /// Get the minimum value of a single property in a collection, but return the object
    /// </summary>
    public Product MinByQuery()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Query Syntax Here
            product = (from prod in products select prod).MinBy(prod => prod.StandardCost);

            return product;
    }
    #endregion

    #region MinByMethod
    /// <summary>
    /// Get the minimum value of a single property in a collection, but return the object
    /// </summary>
    public Product MinByMethod()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Method Syntax Here

            product = products.MinBy(p => p.ListPrice);
            return product;
    }
    #endregion

    #region MaxByQuery
    /// <summary>
    /// Get the maximum value of a single property in a collection, but return the object
    /// </summary>
    public Product MaxByQuery()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
            product = (from prod in products select prod).MaxBy(prod => prod.StandardCost);


            return product;
    }
    #endregion

    #region MaxByMethod
    /// <summary>
    /// Get the maximum value of a single property in a collection, but return the object
    /// </summary>
    public Product MaxByMethod()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
            product = products.MaxBy(p => p.ListPrice);


            return product;
    }
    #endregion

    #region AverageQuery
    /// <summary>
    /// Get the average of all values within a single property in a collection
    /// </summary>
    public decimal AverageQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Query Syntax #1 Here
            value = (from prod in products select prod).Average(prod => prod.StandardCost);

      // Write Query Syntax #2 Here
      

      return value;
    }
    #endregion

    #region AverageMethod
    /// <summary>
    /// Get the average of all values within a single property in a collection
    /// </summary>
    public decimal AverageMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

            // Write Method Syntax #1 Here
            value = products.Average(prod => prod.StandardCost);

            // Write Method Syntax #2 Here


            return value;
    }
    #endregion

    #region SumQuery
    /// <summary>
    /// Gets the sum of the values of a single property in a collection
    /// </summary>
    public decimal SumQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      

      // Write Query Syntax #2 Here
      

      return value;
    }
    #endregion

    #region SumMethod
    /// <summary>
    /// Gets the sum of the values of a single property in a collection
    /// </summary>
    public decimal SumMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      

      // Write Method Syntax #1 Here
      

      return value;
    }
    #endregion

    #region AggregateQuery
    /// <summary>
    /// Aggregate allows you to iterate over a collection and perform an accumulation of values. With this operator you can simulate count, sum, etc.
    /// </summary>
    public decimal AggregateQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region AggregateMethod
    /// <summary>
    /// Aggregate allows you to iterate over a collection and perform an accumulation of values. With this operator you can simulate count, sum, etc.
    /// </summary>
    public decimal AggregateMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region AggregateCustomQuery
    /// <summary>
    /// Use Sales Orders and calculate the total Sales by multiplying OrderQty * UnitPrice for each order
    /// </summary>
    public decimal AggregateCustomQuery()
    {
      decimal value = 0;
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region AggregateCustomMethod
    /// <summary>
    /// Use Sales Orders and calculate the total Sales by multiplying OrderQty * UnitPrice for each order
    /// </summary>
    public decimal AggregateCustomMethod()
    {
      decimal value = 0;
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region AggregateUsingGroupByQuery
    /// <summary>
    /// Group products by Size property and calculate min/max/average prices
    /// </summary>
    public List<ProductStats> AggregateUsingGroupByQuery()
    {
      List<ProductStats> list = null;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region AggregateUsingGroupByMethod
    /// <summary>
    /// Group products by Size property and calculate min/max/average prices
    /// </summary>
    public List<ProductStats> AggregateUsingGroupByMethod()
    {
      List<ProductStats> list = null;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region AggregateMoreEfficientMethod
    /// <summary>
    /// Use Aggregate with some custom methods to gather the data in one pass 
    /// </summary>
    public List<ProductStats> AggregateMoreEfficientMethod()
    {
      List<ProductStats> list = null;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      

      return list;
    }
    #endregion
  }
}
