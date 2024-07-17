using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductInventoryManagementModel;
using System.Data.SqlClient;

namespace ProductInventoryManagementModel
{
    public class SQLDbData
    {
        string connectionString
        = "Data Source =MANFOSTE\\SQLEXPRESS01; Initial Catalog = CrochetManagement; Integrated Security = True;";

        SqlConnection sqlConnection;

        public SQLDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<CrochetProducts> GetProducts()
        {
            string selectStatement = "SELECT ID, Name, Product_Type, Availability, Description, Category, Material, Size FROM Tbl_CrochetProduct";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<CrochetProducts> products = new List<CrochetProducts>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string ID = reader["ID"].ToString();
                string name = reader["Name"].ToString();
                string productType = reader["Product_Type"].ToString();
                string availability = reader["Availability"].ToString();
                string description = reader["Description"].ToString();
                string category = reader["Category"].ToString();
                string material = reader["Material"].ToString();
                string size = reader["Size"].ToString();

                CrochetProducts readProducts = new CrochetProducts();
                readProducts.ID = ID;
                readProducts.name = name;
                readProducts.productType = productType;
                readProducts.availability = availability;
                readProducts.description = description;
                readProducts.category = category;
                readProducts.material = size;
                //readProducts.status = Convert.ToInt16(reader["status"]);

                products.Add(readProducts);
            }

            sqlConnection.Close();

            return products;
        }

        public int AddProducts(string ID, string name, string productType, string availability, string description, string category, string material, string size)
        {
            int success;

            string insertStatement = "INSERT INTO Tbl_CrochetProduct VALUES (@ID, @Name, @Product_Type, @Availability, @Description, @Category, @Material, @Size)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@ID", ID);
            insertCommand.Parameters.AddWithValue("@Name", name);
            insertCommand.Parameters.AddWithValue("@Product_Type", productType);
            insertCommand.Parameters.AddWithValue("@Availability", availability);
            insertCommand.Parameters.AddWithValue("@Description", description);
            insertCommand.Parameters.AddWithValue("@Category", category);
            insertCommand.Parameters.AddWithValue("@Material", material);
            insertCommand.Parameters.AddWithValue("@Size", size);


            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int UpdateProducts(string ID, string name, string ProductType, string availability, string description, string category, string material, string size)
        {
            int success;

            //string updateStatement = $"UPDATE Tbl_CrochetProduct SET ID = @ID, name = @Name, productType = @Product_Type, availability = @Availability, description = @Description, category = @Category, material = @Material, size = @Size WHERE name = @Name";
            //string updateStatement =$"update Tbl_CrochetProduct set availability = @Availability where ID = @ID";
            string updateStatement = $"update Tbl_CrochetProduct set ID = @ID, name = @Name, availability = @Availability where ID = @ID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            //updateCommand.Parameters.AddWithValue("@Name", name);
            //updateCommand.Parameters.AddWithValue("@Availability", availability);

            updateCommand.Parameters.AddWithValue("@ID", ID);
            updateCommand.Parameters.AddWithValue("@Name", name);
            //updateCommand.Parameters.AddWithValue("@Product_Type", ProductType);
            updateCommand.Parameters.AddWithValue("@Availability", availability);
            //updateCommand.Parameters.AddWithValue("@Description", description);
            //updateCommand.Parameters.AddWithValue("@Category", category);
            //updateCommand.Parameters.AddWithValue("@Material", material);
            //updateCommand.Parameters.AddWithValue("@Size", size);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteProducts(string name)
        {
            int success;

            string deleteStatement = $"DELETE FROM Tbl_CrochetProduct WHERE name = @Name";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@Name", name);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

    }
}
