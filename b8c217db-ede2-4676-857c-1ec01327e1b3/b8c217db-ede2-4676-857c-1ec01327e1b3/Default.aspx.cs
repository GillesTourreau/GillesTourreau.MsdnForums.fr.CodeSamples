using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b8c217db_ede2_4676_857c_1ec01327e1b3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
{
    if (this.GridView1.EditIndex != -1 && this.GridView1.EditIndex != e.NewEditIndex)
    {
        this.GridView1.UpdateRow(this.GridView1.EditIndex, false);
    }
}

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
        }
    }
}