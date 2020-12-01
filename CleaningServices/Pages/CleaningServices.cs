using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Data;
using CleaningServices.Utilities;




namespace CleaningServices.Pages
{
    public class ServicesModel : PageModel
    {
        private readonly ILogger<ServicesModel> _logger;

        public ServicesModel(ILogger<ServicesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Binddata();
        }

        public void Binddata()
        {
            SqlConnection Conn = new SqlConnection("Data Source = hgws27.win.hostgator.com; Initial Catalog = eoking5_MSSQL; Persist Security Info = True; User ID = eoking5_5; Password = VDaqm123"); Conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * From eoking5_5.UserInformation", Conn);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet(); adp1.Fill(ds1);
            // GridView1.DataSource = ds1;
            //// GridView1.DataBind();
            cmd1.Dispose();
            Conn.Close();
        }
    }
}
