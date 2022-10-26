using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] sa_Cgy = new string[] { "蔬菜", "水果" };
        string[,] sa_Food = new string[,] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(IsPostBack);
            if (!IsPostBack) // 判定是否第一次載入介面
            {
                for (int a_i = 0; a_i < sa_Cgy.Length; a_i++)
                {
                    ListItem L_I = new ListItem();
                    L_I.Text = L_I.Value = sa_Cgy[a_i];
                    ddl_Category.Items.Add(L_I);
                }
                set_Food();
            }
        }

        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_Food();
        }

        void set_Food()
        {
            ddl_Food.Items.Clear(); // 清空原前面新增項目
            int i_idx = ddl_Category.SelectedIndex;
            //Response.Write(i_idx);
            for (int a_i = 0; a_i < sa_Food.GetLength(1); a_i++)
            {
                ListItem L_I = new ListItem();
                L_I.Text = L_I.Value = sa_Food[i_idx, a_i];

                ddl_Food.Items.Add(L_I);
            }
        }
    }
}