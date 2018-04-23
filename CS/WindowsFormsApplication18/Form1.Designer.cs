using MRUComboBox;

namespace WindowsFormsApplication18
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemMRUComboBox1 = new RepositoryItemMRUComboBox();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carsDBDataSet = new WindowsFormsApplication18.CarsDBDataSet();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemMRUComboBox2 = new RepositoryItemMRUComboBox();
			this.carsTableAdapter = new WindowsFormsApplication18.CarsDBDataSetTableAdapters.CarsTableAdapter();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.mruComboBoxEdit1 = new MRUComboBoxEdit();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUComboBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mruComboBoxEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ApplicationButtonText = null;
			// 
			// 
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.ExpandCollapseItem.Name = "";
			this.ribbonControl1.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barEditItem1});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 2;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMRUComboBox1});
			this.ribbonControl1.SelectedPage = this.ribbonPage1;
			this.ribbonControl1.Size = new System.Drawing.Size(534, 141);
			// 
			// barEditItem1
			// 
			this.barEditItem1.Caption = "MRUComboBoxEdit as BarItem";
			this.barEditItem1.Edit = this.repositoryItemMRUComboBox1;
			this.barEditItem1.Id = 1;
			this.barEditItem1.Name = "barEditItem1";
			this.barEditItem1.Width = 100;
			this.barEditItem1.EditValueChanged += new System.EventHandler(this.barEditItem1_EditValueChanged);
			// 
			// repositoryItemMRUComboBox1
			// 
			this.repositoryItemMRUComboBox1.AutoHeight = false;
			this.repositoryItemMRUComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemMRUComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.repositoryItemMRUComboBox1.MRUItemsCount = 5;
			this.repositoryItemMRUComboBox1.Name = "repositoryItemMRUComboBox1";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "ribbonPage1";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem1);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.carsBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 141);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.MenuManager = this.ribbonControl1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMRUComboBox2});
			this.gridControl1.Size = new System.Drawing.Size(534, 261);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// carsBindingSource
			// 
			this.carsBindingSource.DataMember = "Cars";
			this.carsBindingSource.DataSource = this.carsDBDataSet;
			// 
			// carsDBDataSet
			// 
			this.carsDBDataSet.DataSetName = "CarsDBDataSet";
			this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTrademark});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
			// 
			// colID
			// 
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			this.colID.Width = 99;
			// 
			// colTrademark
			// 
			this.colTrademark.Caption = "MRUComboBoxEdit as ColumnEdit";
			this.colTrademark.ColumnEdit = this.repositoryItemMRUComboBox2;
			this.colTrademark.FieldName = "Trademark";
			this.colTrademark.Name = "colTrademark";
			this.colTrademark.Visible = true;
			this.colTrademark.VisibleIndex = 1;
			this.colTrademark.Width = 414;
			// 
			// repositoryItemMRUComboBox2
			// 
			this.repositoryItemMRUComboBox2.AutoHeight = false;
			this.repositoryItemMRUComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemMRUComboBox2.Items.AddRange(new object[] {
            "123",
            "234",
            "345",
            "456",
            "567",
            "678",
            "789",
            "890"});
			this.repositoryItemMRUComboBox2.MRUItemsCount = 5;
			this.repositoryItemMRUComboBox2.Name = "repositoryItemMRUComboBox2";
			// 
			// carsTableAdapter
			// 
			this.carsTableAdapter.ClearBeforeFill = true;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.mruComboBoxEdit1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(0, 402);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(534, 47);
			this.panelControl1.TabIndex = 3;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 18);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(197, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "MRUComboBoxEdit as standalone control";
			// 
			// mruComboBoxEdit1
			// 
			this.mruComboBoxEdit1.Location = new System.Drawing.Point(215, 15);
			this.mruComboBoxEdit1.MenuManager = this.ribbonControl1;
			this.mruComboBoxEdit1.Name = "mruComboBoxEdit1";
			this.mruComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.mruComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.mruComboBoxEdit1.Properties.MRUItemsCount = 5;
			this.mruComboBoxEdit1.Size = new System.Drawing.Size(100, 20);
			this.mruComboBoxEdit1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 449);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.ribbonControl1);
			this.Controls.Add(this.panelControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUComboBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mruComboBoxEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarEditItem barEditItem1;
		private RepositoryItemMRUComboBox repositoryItemMRUComboBox1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private CarsDBDataSet carsDBDataSet;
		private System.Windows.Forms.BindingSource carsBindingSource;
		private WindowsFormsApplication18.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colTrademark;
		private RepositoryItemMRUComboBox repositoryItemMRUComboBox2;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private MRUComboBoxEdit mruComboBoxEdit1;


	}
}

