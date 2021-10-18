using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using WebApplication1.Model;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AdmissionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"select *from dbo.Department";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("LoginAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }
        [HttpPost]
        public JsonResult Post(Department detail)
        {
            string query = @"insert into dbo.Department(DepartmentName,AvailableCount,TotalCount)
                           values('" + detail.DepartmentName + @"','" + detail.AvailableCount + @"','" + detail.TotalCount + @"')";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("LoginAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("success");
        }
        [HttpPut]
        public JsonResult Put(Department detail)
        {
            string query = @"update dbo.Department set DepartmentName= '" + detail.DepartmentName + @"',AvailableCount='" + detail.AvailableCount + @"',TotalCount='"
                   + detail.TotalCount + @"'
                            where DepartmentId=" + detail.DepartmentId + @" ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("LoginAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Updated");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"delete from dbo.Department where DepartmentId=" + id + @" ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("LoginAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); ;
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Deleted");
        }
    }
}

