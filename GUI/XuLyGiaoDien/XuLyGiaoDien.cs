using System.Windows.Forms;

namespace GUI
{
    public static class XuLyGiaoDien
    {
        public static Form currentFormChild;
        public static Form moFormCon(Form formCon)              //có chức năng mở form con và truyền vào pnlMain
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formCon;

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            formCon.BringToFront();
            formCon.Show();
            return formCon;
        }

        public static void resetButtonVeMacDinh(Button buttonDangChon, Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Button button)
                {
                    button.FlatAppearance.BorderSize = 0;
                }
            }
            buttonDangChon.FlatAppearance.BorderSize = 1;
        }
    }
}
