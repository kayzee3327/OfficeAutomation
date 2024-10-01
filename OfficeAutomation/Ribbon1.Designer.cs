namespace OfficeAutomation
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.sjcl = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.sjwt = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.sxlnh = this.Factory.CreateRibbonButton();
            this.separator3 = this.Factory.CreateRibbonSeparator();
            this.jssmmx = this.Factory.CreateRibbonButton();
            this.separator4 = this.Factory.CreateRibbonSeparator();
            this.jsyzjs = this.Factory.CreateRibbonButton();
            this.separator5 = this.Factory.CreateRibbonSeparator();
            this.sxljs = this.Factory.CreateRibbonButton();
            this.separator8 = this.Factory.CreateRibbonSeparator();
            this.sxsjjs = this.Factory.CreateRibbonButton();
            this.separator6 = this.Factory.CreateRibbonSeparator();
            this.cybz = this.Factory.CreateRibbonButton();
            this.separator7 = this.Factory.CreateRibbonSeparator();
            this.gdqjtykkxbz = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "MaxOpticsReliabilityAnalysis";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.sjcl);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.sjwt);
            this.group1.Items.Add(this.separator2);
            this.group1.Items.Add(this.sxlnh);
            this.group1.Items.Add(this.separator3);
            this.group1.Items.Add(this.jssmmx);
            this.group1.Items.Add(this.separator4);
            this.group1.Items.Add(this.jsyzjs);
            this.group1.Items.Add(this.separator5);
            this.group1.Items.Add(this.sxljs);
            this.group1.Items.Add(this.separator8);
            this.group1.Items.Add(this.sxsjjs);
            this.group1.Items.Add(this.separator6);
            this.group1.Items.Add(this.cybz);
            this.group1.Items.Add(this.separator7);
            this.group1.Items.Add(this.gdqjtykkxbz);
            this.group1.Label = "工具";
            this.group1.Name = "group1";
            // 
            // sjcl
            // 
            this.sjcl.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sjcl.Label = "数据处理";
            this.sjcl.Name = "sjcl";
            this.sjcl.OfficeImageId = "ChartTrendline";
            this.sjcl.ShowImage = true;
            this.sjcl.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Sjcl_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // sjwt
            // 
            this.sjwt.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sjwt.Label = "数据外推";
            this.sjwt.Name = "sjwt";
            this.sjwt.OfficeImageId = "ChartLines";
            this.sjwt.ShowImage = true;
            this.sjwt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Sjwt_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // sxlnh
            // 
            this.sxlnh.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sxlnh.Label = "失效率拟合";
            this.sxlnh.Name = "sxlnh";
            this.sxlnh.OfficeImageId = "ChartTrendline";
            this.sxlnh.ShowImage = true;
            this.sxlnh.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Sxlnh_Click);
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            // 
            // jssmmx
            // 
            this.jssmmx.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.jssmmx.Label = "加速寿命模型";
            this.jssmmx.Name = "jssmmx";
            this.jssmmx.OfficeImageId = "ChartLines";
            this.jssmmx.ShowImage = true;
            this.jssmmx.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Jssmmx_Click);
            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            // 
            // jsyzjs
            // 
            this.jsyzjs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.jsyzjs.Label = "加速因子计算";
            this.jsyzjs.Name = "jsyzjs";
            this.jsyzjs.OfficeImageId = "ChartTypeXYScatterInsertGallery";
            this.jsyzjs.ShowImage = true;
            this.jsyzjs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Jsyzjs_Click);
            // 
            // separator5
            // 
            this.separator5.Name = "separator5";
            // 
            // sxljs
            // 
            this.sxljs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sxljs.Label = "失效率计算";
            this.sxljs.Name = "sxljs";
            this.sxljs.OfficeImageId = "CalculateSheet";
            this.sxljs.ShowImage = true;
            this.sxljs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Sxljs_Click);
            // 
            // separator8
            // 
            this.separator8.Name = "separator8";
            // 
            // sxsjjs
            // 
            this.sxsjjs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sxsjjs.Label = "失效时间计算";
            this.sxsjjs.Name = "sxsjjs";
            this.sxsjjs.OfficeImageId = "CalculateSheet";
            this.sxsjjs.ShowImage = true;
            this.sxsjjs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Sxsjjs_Click);
            // 
            // separator6
            // 
            this.separator6.Name = "separator6";
            // 
            // cybz
            // 
            this.cybz.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.cybz.Label = "抽样标准";
            this.cybz.Name = "cybz";
            this.cybz.OfficeImageId = "GroupMarginsAndPadding";
            this.cybz.ShowImage = true;
            this.cybz.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Cybz_Click);
            // 
            // separator7
            // 
            this.separator7.Name = "separator7";
            // 
            // gdqjtykkxbz
            // 
            this.gdqjtykkxbz.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.gdqjtykkxbz.Label = "光电器件通用可靠性标准";
            this.gdqjtykkxbz.Name = "gdqjtykkxbz";
            this.gdqjtykkxbz.OfficeImageId = "Help";
            this.gdqjtykkxbz.ShowImage = true;
            this.gdqjtykkxbz.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Gdqjtykkxbz_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sjcl;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sjwt;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sxlnh;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton jssmmx;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton jsyzjs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sxljs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sxsjjs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cybz;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gdqjtykkxbz;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator3;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator4;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator5;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator6;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator7;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator8;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
