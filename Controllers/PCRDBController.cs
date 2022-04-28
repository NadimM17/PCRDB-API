using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace PrincessConnectUnitDBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PCRDBController : ControllerBase
    {
        public const string connectionString = @"Data Source=NADIM\INSTANCE_2K19_TR;Initial Catalog=PrincessConnect;User ID=sa;Password=U4yO%2eHhEs%";

        [HttpGet]
        [Route("GetUnits")]
        public string GetAllUnits()
        {
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatment = "SELECT * FROM dbo.Characters ORDER BY dbo.Characters.Name";
                using (SqlCommand _cmd = new SqlCommand(queryStatment, _con))
                {
                    DataTable characterTable = new DataTable("Characters");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_cmd);
                    _con.Open();
                    sqlDataAdapter.Fill(characterTable);
                    _con.Close();
                    return JsonConvert.SerializeObject(characterTable, Formatting.Indented);
                }
            }
        }
        [HttpGet]
        [Route("Events/GetSummerUnits")]
        public string GetAllSummerUnits()
        {
            using(SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatment = "SELECT * FROM dbo.Characters WHERE dbo.Characters.Name LIKE '%(Summer)%' ORDER BY dbo.Characters.Name";
                using (SqlCommand _cmd = new SqlCommand(queryStatment, _con))
                {
                    DataTable SummerCharacters = new DataTable("Characters");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_cmd);
                    _con.Open();
                    sqlDataAdapter.Fill(SummerCharacters);
                    _con.Close();
                    return JsonConvert.SerializeObject(SummerCharacters, Formatting.Indented);
                }
            }
        }

        [HttpGet]
        [Route("Events/GetHalloweenUnits")]
        public string GetAllHalloweenUnits()
        {
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatment = "SELECT * FROM dbo.Characters WHERE dbo.Characters.Name LIKE '%(Halloween)%' ORDER BY dbo.Characters.Name";
                using (SqlCommand _cmd = new SqlCommand(queryStatment, _con))
                {
                    DataTable HalloweenCharacters = new DataTable("Characters");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_cmd);
                    _con.Open();
                    sqlDataAdapter.Fill(HalloweenCharacters);
                    _con.Close();
                    return JsonConvert.SerializeObject(HalloweenCharacters, Formatting.Indented);
                }
            }
        }

        [HttpGet]
        [Route("Events/GetHolidayUnits")]
        public string GetAllHolidayUnits()
        {
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatment = "SELECT * FROM dbo.Characters WHERE dbo.Characters.Name LIKE '%(Holiday)%' ORDER BY dbo.Characters.Name";
                using (SqlCommand _cmd = new SqlCommand(queryStatment, _con))
                {
                    DataTable HolidayCharacters = new DataTable("Characters");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_cmd);
                    _con.Open();
                    sqlDataAdapter.Fill(HolidayCharacters);
                    _con.Close();
                    return JsonConvert.SerializeObject(HolidayCharacters, Formatting.Indented);
                }
            }
        }

        [HttpGet]
        [Route("Events/GetNewYearUnits")]
        public string GetAllNewYearUnits()
        {
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatment = "SELECT * FROM dbo.Characters WHERE dbo.Characters.Name LIKE '%(New Year)%' ORDER BY dbo.Characters.Name";
                using (SqlCommand _cmd = new SqlCommand(queryStatment, _con))
                {
                    DataTable NewYearCharacters = new DataTable("Characters");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_cmd);
                    _con.Open();
                    sqlDataAdapter.Fill(NewYearCharacters);
                    _con.Close();
                    return JsonConvert.SerializeObject(NewYearCharacters, Formatting.Indented);
                }
            }
        }

        [HttpGet]
        [Route("Events/GetValentineUnits")]
        public string GetAllValentineUnits()
        {
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatment = "SELECT * FROM dbo.Characters WHERE dbo.Characters.Name LIKE '%(Valentine)%' ORDER BY dbo.Characters.Name";
                using (SqlCommand _cmd = new SqlCommand(queryStatment, _con))
                {
                    DataTable ValentineCharacters = new DataTable("Characters");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_cmd);
                    _con.Open();
                    sqlDataAdapter.Fill(ValentineCharacters);
                    _con.Close();
                    return JsonConvert.SerializeObject(ValentineCharacters, Formatting.Indented);
                }
            }
        }

        [HttpGet]
        [Route("Events/GetOedoUnits")]
        public string GetAllOedoUnits()
        {
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatment = "SELECT * FROM dbo.Characters WHERE dbo.Characters.Name LIKE '%(Oedo)%' ORDER BY dbo.Characters.Name";
                using (SqlCommand _cmd = new SqlCommand(queryStatment, _con))
                {
                    DataTable OedoCharacters = new DataTable("Characters");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_cmd);
                    _con.Open();
                    sqlDataAdapter.Fill(OedoCharacters);
                    _con.Close();
                    return JsonConvert.SerializeObject(OedoCharacters, Formatting.Indented);
                }
            }
        }

        [HttpPost]
        [Route("AddUnit")]
        public void AddUnit()
        {
            using (SqlConnection _con = new SqlConnection(@"Data Source=NADIM\INSTANCE_2K19_TR;Initial Catalog=Test;User ID=sa;Password=U4yO%2eHhEs%"))
            {
                _con.Open();
                string queryAdd = "INSERT INTO TestTable(id, name) VALUES (0, 'TestName')";
                using (SqlCommand _cmd = new SqlCommand(queryAdd, _con))
                {
                    _cmd.ExecuteNonQuery();
                }
                _con.Close();
            }
        }
    }
}
