﻿using System.Diagnostics.Contracts;
using System.Xml;
using MNSDotNetTrainingBatch1.ConsoleApp3;
using Newtonsoft.Json;

string query = @"select * from Tbl_Product";
SqlService sqlService = new SqlService();
var lst = sqlService.Query<Product>(query);

foreach (var item in lst)
{
    Console.WriteLine(item.ProductId);
    Console.WriteLine(item.ProductCode);
    Console.WriteLine(item.ProductName);
    Console.WriteLine(item.Price);
    Console.WriteLine(item.Quantity);
    Console.WriteLine(item.CreatedDate);
    Console.WriteLine(item.CreatedBy);
    Console.WriteLine("--------------------");
}

//SqlService sqlService = new SqlService();
//string query1 = @"INSERT INTO [dbo].[Tbl_BlogDetail]
//           ([BlogId]
//           ,[BlogContent])
//     VALUES
//           (@BlogId
//           ,@BlogContent)";


//string read = File.ReadAllText("DreamDictionary.json");
//var lst = JsonConvert.DeserializeObject<DreamDictionaryResponseModel>(read);

//sqlService.Execute(query1, lst.BlogDetail);

//string query1 = @"INSERT INTO [dbo].[Tbl_Product]
//           ([ProductName]
//           ,[Price]
//           ,[Quantity]
//           ,[CreatedDateTime]
//           ,[CreatedBy])
//       VALUES
//           (@ProductName
//           ,@Price
//           ,@Quantity
//           ,@CreatedDate
//           ,@CreatedBy)";

////int result = sqlService.Execute(query1, new Product
////{
////    ProductName = "SunKiss",
////    Price = 3000,
////    Quantity = 50,
////    CreatedDate = DateTime.Now,
////    CreatedBy = 1
////});


//string query2 = @"UPDATE [dbo].[Tbl_Product]
//   SET [ProductName] = @ProductName
//      ,[Price] = @Price
//      ,[Quantity] = @Quantity
//      ,[ModifiedDateTime] = @ModifiedDate
//      ,[ModifiedBy] = @ModifiedBy
// WHERE ProductId = @ProductId";

//int result = sqlService.Execute(query2, new Product
//{
//    ProductName = "Apple",
//    Price = 3000,
//    ProductId = 1,
//    Quantity = 40,
//    ModifiedDate = DateTime.Now,
//    ModifiedBy = 1
//});

//string query3 = "delete from Tbl_Product where @ProductCode = ProductCode";
//int result = sqlService.Execute(query3, new Product
//{
//    ProductCode = "P0017"
//});


Console.ReadLine();

public class Product
{
    public int ProductId { get; set; }
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CreatedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int ModifiedBy { get; set; }

}

//public class DreamDictionaryResponseModel
//{
//    //public Blogheader[] BlogHeader { get; set; }
//    public Blogdetail[] BlogDetail { get; set; }
//}
//public class Blogheader
//{
//    public int BlogId { get; set; }
//    public string BlogTitle { get; set; }
//}
//public class Blogdetail
//{
//    public int BlogDetailId { get; set; }
//    public int BlogId { get; set; }
//    public string BlogContent { get; set; }
//}

