﻿namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region OrderByQuery
    /// <summary>
    /// Order products by Name
    /// </summary>
    public List<Product> OrderByQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products orderby prod.Name select prod).ToList();

      return list;
    }
    #endregion

    #region OrderByMethod
    /// <summary>
    /// Order products by Name
    /// </summary>
    public List<Product> OrderByMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = products.OrderBy(p => p.Name).ToList();
     

      return list;
    }
    #endregion

    #region OrderByDescendingQuery Method
    /// <summary>
    /// Order products by name in descending order
    /// </summary>
    public List<Product> OrderByDescendingQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = (from prod in products orderby prod.Name descending select prod).ToList();



      return list;
    }
    #endregion

    #region OrderByDescendingMethod Method
    /// <summary>
    /// Order products by name in descending order
    /// </summary>
    public List<Product> OrderByDescendingMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

            // Write Method Syntax Here
      list = products.OrderByDescending(p => p.Name).ToList();

      return list;
    }
    #endregion

    #region OrderByTwoFieldsQuery Method
    /// <summary>
    /// Order products by Color descending, then Name
    /// </summary>
    public List<Product> OrderByTwoFieldsQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = (from prod in products orderby prod.Name , prod.Color select prod).ToList();
     

      return list;
    }
    #endregion

    #region OrderByTwoFieldsMethod Method
    /// <summary>
    /// Order products by Color descending, then Name
    /// </summary>
    public List<Product> OrderByTwoFieldsMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = products.OrderBy(prod => prod.Name).
                ThenBy(prod => prod.Color).ToList();
     

      return list;
    }
    #endregion

    #region OrderByTwoFieldsDescMethod Method
    /// <summary>
    /// Order products by Color descending, then Name Descending
    /// </summary>
    public List<Product> OrderByTwoFieldsDescMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

            // Write Method Syntax Here

            list = products.OrderByDescending(prod => prod.Name).ThenByDescending(prod => prod.StandardCost).ToList();

            return list;
    }
    #endregion

  }
}
