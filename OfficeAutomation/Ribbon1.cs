using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeAutomation
{
    public partial class Ribbon1
    {
        
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Sjcl_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.sjclTaskPane.Visible = !(Globals.ThisAddIn.sjclTaskPane.Visible);

        }

        private void Sjwt_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.sjwtTaskPane.Visible = !(Globals.ThisAddIn.sjwtTaskPane.Visible);
        }

        private void Sxlnh_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.sxlnhTaskPane.Visible = !(Globals.ThisAddIn.sxlnhTaskPane.Visible);
        }

        private void Jssmmx_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.jssmmxTaskPane.Visible = !(Globals.ThisAddIn.jssmmxTaskPane.Visible);
        }

        private void Jsyzjs_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.jsyzjsTaskPane.Visible = !(Globals.ThisAddIn.jsyzjsTaskPane.Visible);
        }

        private void Sxljs_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.sxljsTaskPane.Visible = !(Globals.ThisAddIn.sxljsTaskPane.Visible);
        }

        private void Sxsjjs_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.sxsjjsTaskPane.Visible = !(Globals.ThisAddIn.sxsjjsTaskPane.Visible);
        }

        private void Cybz_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.cybzTaskPane.Visible = !(Globals.ThisAddIn.cybzTaskPane.Visible);
        }

        private void Gdqjtykkxbz_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.gdqjtykkxbzTaskPane.Visible = !(Globals.ThisAddIn.gdqjtykkxbzTaskPane.Visible);
        }
    }
}
