using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safety_Induction_V0.WindowsForms;

namespace Safety_Induction_V0.Models
{
    class Class1
    {
        //public void GrantAccessGV(DataGridView gv)
        //{
        //    try
        //    {

        //        DataGridViewRow gvRow = new DataGridViewRow();
        //        gvRow = gv.CurrentRow;
        //        foreach (DataGridViewRow Row in gv.Rows)
        //        {

        //            if ((Row.Cells["ck_GrantAccessGV"].Value) != null)
        //            {
        //                if ((bool)(Row.Cells["ck_GrantAccessGV"].Value) == true)
        //                {
        //                    Login login = new Login();
        //                    gv.Rows[Row.Index].Selected = true;
        //                    login.User_Name = GenerateName(gvRow.Cells["InstructorName"].Value.ToString());
        //                    login.Password = GeneratePassword();
        //                    login.InstID = short.Parse(gvRow.Cells["InstructorID"].Value.ToString());
        //                    login.RoleID = 1;//short.Parse(gvRow.Cells["txt_GVRoleID"].Value.ToString());
        //                    context.Logins.Add(login);
        //                    context.SaveChanges();
        //                }
        //                else
        //                {
        //                    gv.Rows[Row.Index].Selected = false;
        //                }
        //            }


        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}








    }
}
