using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

     [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Category";
      Category newCategory = new Category(name);

      string result = newCategory.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      string name = "test category";
      Category newCategory = new Category(name);

      int result = newCategory.Id;

      Assert.AreEqual(1, result);
    }

    
      [TestMethod]
      public void GetAll_ReturnsAllCategoryObjects_CategoryList()
      {
        string name1 = "work";
        string name2 = "school";
        Category newCategory1 = new Category(name1);
        Category newCategory2 = new Category(name2);
        List<Category> newList = new List<Category> {newCategory1, newCategory2};

        List<Category> result = Category.GetAll();

        CollectionAssert.AreEqual(result, newList);
      }

      [TestMethod]
      public void Find_ReturnsCorrectCategory_Category()
      {
        string name1 = "work";
        string name2 = "school";
        Category newCategory1 = new Category(name1);
        Category newCategory2 = new Category(name2);

        Category result = Category.Find(2);

        Assert.AreEqual(result, newCategory2);
      }

      [TestMethod]
      public void AddItem_AssociatesItemWithCategory_ItemList()
      {
        string description = "Walk the dog.";
        Item newItem = new Item(description);
        List<Item> newList = new List<Item> {newItem};
        string name = "Work";
        Category newCategory = new Category(name);
        newCategory.AddItem(newItem);

        //act
        List<Item> result = newCategory.Items;

        CollectionAssert.AreEqual(result, newList);
      }
  }
}