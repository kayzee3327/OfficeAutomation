using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace OfficeAutomation
{
    public partial class ThisAddIn
    {
        private 数据处理 sjcl;
        private Microsoft.Office.Tools.CustomTaskPane sjclPane;
        private 数据外推 sjwt;
        private Microsoft.Office.Tools.CustomTaskPane sjwtPane;
        private 失效率拟合 sxlnh;
        private Microsoft.Office.Tools.CustomTaskPane sxlnhPane;
        private 加速寿命模型 jssmmx;
        private Microsoft.Office.Tools.CustomTaskPane jssmmxPane;
        private 加速因子计算 jsyzjs;
        private Microsoft.Office.Tools.CustomTaskPane jsyzjsPane;
        private 失效率计算 sxljs;
        private Microsoft.Office.Tools.CustomTaskPane sxljsPane;
        private 失效时间计算 sxsjjs;
        private Microsoft.Office.Tools.CustomTaskPane sxsjjsPane;
        private 抽样标准 cybz;
        private Microsoft.Office.Tools.CustomTaskPane cybzPane;
        private 光电器件通用可靠性标准 gdqjtykkxbz;
        private Microsoft.Office.Tools.CustomTaskPane gdqjtykkxbzPane;


        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            sjcl = new 数据处理();
            sjclPane = this.CustomTaskPanes.Add(sjcl, "数据处理");
            sjwt = new 数据外推();
            sjwtPane = this.CustomTaskPanes.Add(sjwt, "数据外推");
            sxlnh = new 失效率拟合();
            sxlnhPane = this.CustomTaskPanes.Add(sxlnh, "失效率拟合");
            jssmmx = new 加速寿命模型();
            jssmmxPane = this.CustomTaskPanes.Add(jssmmx, "加速寿命模型");
            jsyzjs = new 加速因子计算();
            jsyzjsPane = this.CustomTaskPanes.Add(jsyzjs, "加速因子计算");
            sxljs = new 失效率计算();
            sxljsPane = this.CustomTaskPanes.Add(sxljs, "失效率计算");
            sxsjjs = new 失效时间计算();
            sxsjjsPane = this.CustomTaskPanes.Add(sxsjjs, "失效时间计算");
            cybz = new 抽样标准();
            cybzPane = this.CustomTaskPanes.Add(cybz, "抽样标准");
            gdqjtykkxbz = new 光电器件通用可靠性标准();
            gdqjtykkxbzPane = this.CustomTaskPanes.Add(gdqjtykkxbz, "光电器件通用可靠性标准");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public Microsoft.Office.Tools.CustomTaskPane sjclTaskPane
        {
            get
            {
                return sjclPane;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane sjwtTaskPane
        {
            get
            {
                return sjwtPane;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane sxlnhTaskPane
        {
            get
            {
                return sxlnhPane;
            }
        }
        public Microsoft.Office.Tools.CustomTaskPane jssmmxTaskPane
        {
            get
            {
                return jssmmxPane;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane jsyzjsTaskPane
        {
            get
            {
                return jsyzjsPane;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane sxljsTaskPane
        {
            get
            {
                return sxljsPane;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane sxsjjsTaskPane
        {
            get
            {
                return sxsjjsPane;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane cybzTaskPane
        {
            get
            {
                return cybzPane;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane gdqjtykkxbzTaskPane
        {
            get
            {
                return gdqjtykkxbzPane;
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
