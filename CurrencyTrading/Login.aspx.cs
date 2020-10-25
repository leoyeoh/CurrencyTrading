using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyTrading
{
    public partial class Login : System.Web.UI.Page
    {
        Dictionary<string, object> dic;
        Util.SqlBuilder sqlbuilder = new Util.SqlBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region // button Login Click
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(isValidUser(txtUserName.Text, txtPassword.Text))
            {
                Response.Redirect("Trading.aspx");
            }
        }
        #endregion

        #region // Check is User Exists ? return True if User Exists
        private bool isValidUser(string UserName, string Password)
        {
            bool isValid = false;
            DataTable dtTable = new DataTable();
            string sql = "select * from tblUser where UserName =@UserName and Password=@Password";
            dic = new Dictionary<string, object>();
            dic.Add("@UserName", UserName);
            dic.Add("@Password", Password);

            dtTable = sqlbuilder.ExecuteDataTable(sql, sqlbuilder.ConnectionString, dic);

            if(dtTable.Rows.Count > 0)
            {
                isValid = true;
                lblErrorMsg.Text = "";
                Session["UserID"] = dtTable.Rows[0]["Id"].ToString();
            }
            else
            {
                lblErrorMsg.Text = "Invalid User Name / Password";
            }

            return isValid;
        }
        #endregion
    }
}