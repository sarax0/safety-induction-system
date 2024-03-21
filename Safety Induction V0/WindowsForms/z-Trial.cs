using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safety_Induction_V0
{
    public partial class Trial : Form
    {
        SafetyInductionEntities context = new SafetyInductionEntities();
        public Trial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string user = txt_Username.Text;
            int user = int.Parse(txt_Username.Text);
            Login log = context.Logins.Where(x => x.InstID == user).FirstOrDefault();
            if (log.RoleID == 1)
            {
                MessageBox.Show("Welcom Admin");    
            }
            else if (log.RoleID == 2)
            {
                MessageBox.Show("Welcom User");    
            }

        }
    }
}
