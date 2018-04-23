Imports Microsoft.VisualBasic
Imports System
Imports MRUComboBox

Namespace WindowsFormsApplication18
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem
            Me.repositoryItemMRUComboBox1 = New MRUComboBox.RepositoryItemMRUComboBox
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemMRUComboBox2 = New MRUComboBox.RepositoryItemMRUComboBox
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.mruComboBoxEdit1 = New MRUComboBox.MRUComboBoxEdit
            Me.CarsDBDataSet = New CarsDBDataSet
            Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CarsTableAdapter = New CarsDBDataSetTableAdapters.CarsTableAdapter
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMRUComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMRUComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.mruComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CarsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ApplicationButtonText = Nothing
            '
            '
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.ExpandCollapseItem.Name = ""
            Me.ribbonControl1.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.barEditItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 2
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMRUComboBox1})
            Me.ribbonControl1.SelectedPage = Me.ribbonPage1
            Me.ribbonControl1.Size = New System.Drawing.Size(534, 141)
            '
            'barEditItem1
            '
            Me.barEditItem1.Caption = "MRUComboBoxEdit as BarItem"
            Me.barEditItem1.Edit = Me.repositoryItemMRUComboBox1
            Me.barEditItem1.Id = 1
            Me.barEditItem1.Name = "barEditItem1"
            Me.barEditItem1.Width = 100
            '
            'repositoryItemMRUComboBox1
            '
            Me.repositoryItemMRUComboBox1.AutoHeight = False
            Me.repositoryItemMRUComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMRUComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
            Me.repositoryItemMRUComboBox1.MRUItemsCount = 5
            Me.repositoryItemMRUComboBox1.Name = "repositoryItemMRUComboBox1"
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            '
            'ribbonPageGroup1
            '
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barEditItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.CarsBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 141)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.MenuManager = Me.ribbonControl1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMRUComboBox2})
            Me.gridControl1.Size = New System.Drawing.Size(534, 261)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colTrademark})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            Me.colID.Width = 99
            '
            'colTrademark
            '
            Me.colTrademark.Caption = "MRUComboBoxEdit as ColumnEdit"
            Me.colTrademark.ColumnEdit = Me.repositoryItemMRUComboBox2
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.Visible = True
            Me.colTrademark.VisibleIndex = 1
            Me.colTrademark.Width = 414
            '
            'repositoryItemMRUComboBox2
            '
            Me.repositoryItemMRUComboBox2.AutoHeight = False
            Me.repositoryItemMRUComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMRUComboBox2.Items.AddRange(New Object() {"123", "234", "345", "456", "567", "678", "789", "890"})
            Me.repositoryItemMRUComboBox2.MRUItemsCount = 5
            Me.repositoryItemMRUComboBox2.Name = "repositoryItemMRUComboBox2"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.mruComboBoxEdit1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 402)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(534, 47)
            Me.panelControl1.TabIndex = 3
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(12, 18)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(197, 13)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "MRUComboBoxEdit as standalone control"
            '
            'mruComboBoxEdit1
            '
            Me.mruComboBoxEdit1.Location = New System.Drawing.Point(215, 15)
            Me.mruComboBoxEdit1.MenuManager = Me.ribbonControl1
            Me.mruComboBoxEdit1.Name = "mruComboBoxEdit1"
            Me.mruComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.mruComboBoxEdit1.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.mruComboBoxEdit1.Properties.MRUItemsCount = 5
            Me.mruComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
            Me.mruComboBoxEdit1.TabIndex = 0
            '
            'CarsDBDataSet
            '
            Me.CarsDBDataSet.DataSetName = "CarsDBDataSet"
            Me.CarsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'CarsBindingSource
            '
            Me.CarsBindingSource.DataMember = "Cars"
            Me.CarsBindingSource.DataSource = Me.CarsDBDataSet
            '
            'CarsTableAdapter
            '
            Me.CarsTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(534, 449)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMRUComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMRUComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.mruComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CarsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemMRUComboBox1 As RepositoryItemMRUComboBox
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMRUComboBox2 As RepositoryItemMRUComboBox
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private mruComboBoxEdit1 As MRUComboBoxEdit
        Friend WithEvents CarsDBDataSet As CarsDBDataSet
        Friend WithEvents CarsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents CarsTableAdapter As CarsDBDataSetTableAdapters.CarsTableAdapter


	End Class
End Namespace

