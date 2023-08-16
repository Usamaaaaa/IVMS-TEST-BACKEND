using Dapper;
using Backend.Model;
using Backend.Model.Data;
using System.Data;

namespace Backend.Repo
{
    public class ProductRepo : ProductInterface
    {
        private readonly DapperDBContext context;
        public ProductRepo(DapperDBContext context) {
            this.context = context;

        }

        public async Task<string> Create(Products product)
        {
            string response = string.Empty;
            string query = "Insert into Product(title,description,price,quantity,category) values (@title,@description,@price,@quantity,@category)";
            var parameters = new DynamicParameters();
            parameters.Add("title",product.title , DbType.String);
            parameters.Add("description", product.description, DbType.String);
            parameters.Add("price", product.price, DbType.Int32);
            parameters.Add("quantity", product.quantity, DbType.Int32);
            parameters.Add("category", product.category, DbType.String);
            using (var connectin = this.context.CreateConnection())
            {

                var productlist = await connectin.ExecuteAsync(query, parameters);
                    response = "pass";

            }
            return response;
        }

        public  async Task<List<Products>> GetAll()
        {
            string query = "Select * From Product";
            using (var connectin=this.context.CreateConnection())
            {

                var productlist = await connectin.QueryAsync<Products>(query)

                    ;
                return productlist.ToList();
            }
            
        }

        public async Task<Products> GetById(int Product_Id)
        {
            string query = "Select * From Product where Product_Id=@Product_Id";
            using (var connectin = this.context.CreateConnection())
            {

                var productlist = await connectin.QueryFirstOrDefaultAsync<Products>(query, new { Product_Id })

                    ;
                return productlist;
            }
        }

        public async Task<string> Remove(int Product_Id)
        {
            string response = string.Empty;
            string query = "Delete From Product where Product_Id=@Product_Id";
            using (var connectin = this.context.CreateConnection())
            {

                var productlist = await connectin.ExecuteAsync(query, new { Product_Id });
                    response = "pass";
                               
            }
            return response;
        }

        public async Task<string> Update(Products product, int Product_Id)
        {
            string response = string.Empty;
            string query = "update Product set title=@title, description=@description, price=@price, quantity=@quantity, category=@category where Product_Id=@Product_Id";
            var parameters = new DynamicParameters();
            parameters.Add("Product_Id", product.Product_Id, DbType.Int32);
            parameters.Add("title", product.title, DbType.String);
            parameters.Add("description", product.description, DbType.String);
            parameters.Add("price", product.price, DbType.Int16);
            parameters.Add("quantity", product.quantity, DbType.Int32);
            parameters.Add("category", product.category, DbType.String);
            using (var connectin = this.context.CreateConnection())
            {

                var productlist = await connectin.ExecuteAsync(query, parameters);
                    response = "pass";

            }
            return response;
        }
    }
}
