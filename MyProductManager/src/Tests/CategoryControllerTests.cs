using Microsoft.Data.Entity;
using MyProductManager.Controllers;
using MyProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class CategoryControllerTests
    {
        [Fact]
        public void IndexSortedByDisplayName()
        {
           
            //using (var context = new ProductContext())
            //{
            //    // Arrange
            //    context.Categories.Add(new Category { CategoryId = "1", DisplayName = "BBB" });
            //    context.Categories.Add(new Category { CategoryId = "2", DisplayName = "CCC" });
            //    context.Categories.Add(new Category { CategoryId = "3", DisplayName = "AAA" });
            //    context.SaveChanges();
            //}

            //using (var context = new ProductContext())
            //{
            //    // Act
            //    var controller = new CategoryController(context);
            //    var result = controller.Index();

            //    // Assert
            //    var model = (Category[])result.ViewData.Model;
            //    Assert.Equal("AAA", model[0].DisplayName);
            //    Assert.Equal("BBB", model[1].DisplayName);
            //    Assert.Equal("CCC", model[2].DisplayName);
            //}
        }
    }
}
