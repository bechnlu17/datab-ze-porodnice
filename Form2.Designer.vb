<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Dítě__auto_BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Dítě__auto_BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Dítě__auto_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Rodička__majitel_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Porodnice__Servis_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Rodička__porodnice__Majitel__Servis_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rodička__porodnice__Majitel__Servis_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Porodnice_databáze0203DataSet = New WindowsApp2.Porodnice_databáze0203DataSet()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porodnice__Servis_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rodička__majitel_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dítě__auto_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dítě__auto_TableAdapter = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.dítě__auto_TableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.TableAdapterManager()
        Me.Porodnice__Servis_TableAdapter = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.Porodnice__Servis_TableAdapter()
        Me.Rodička__majitel_TableAdapter = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.Rodička__majitel_TableAdapter()
        Me.Rodička__porodnice__Majitel__Servis_TableAdapter = New WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.Rodička__porodnice__Majitel__Servis_TableAdapter()
        CType(Me.Dítě__auto_BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dítě__auto_BindingNavigator.SuspendLayout()
        CType(Me.Dítě__auto_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rodička__majitel_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Porodnice__Servis_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rodička__porodnice__Majitel__Servis_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rodička__porodnice__Majitel__Servis_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Porodnice_databáze0203DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Porodnice__Servis_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rodička__majitel_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dítě__auto_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dítě__auto_BindingNavigator
        '
        Me.Dítě__auto_BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Dítě__auto_BindingNavigator.BindingSource = Me.Dítě__auto_BindingSource
        Me.Dítě__auto_BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Dítě__auto_BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Dítě__auto_BindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Dítě__auto_BindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Dítě__auto_BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Dítě__auto_BindingNavigatorSaveItem})
        Me.Dítě__auto_BindingNavigator.Location = New System.Drawing.Point(14, 30)
        Me.Dítě__auto_BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Dítě__auto_BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Dítě__auto_BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Dítě__auto_BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Dítě__auto_BindingNavigator.Name = "Dítě__auto_BindingNavigator"
        Me.Dítě__auto_BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Dítě__auto_BindingNavigator.Size = New System.Drawing.Size(373, 38)
        Me.Dítě__auto_BindingNavigator.TabIndex = 0
        Me.Dítě__auto_BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveFirstItem.Text = "Přesunout na první"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMovePreviousItem.Text = "Přesunout na předchozí"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Umístění"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuální pozice"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 33)
        Me.BindingNavigatorCountItem.Text = "z {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Celkový počet položek"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveNextItem.Text = "Přesunout na další"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveLastItem.Text = "Přesunout na poslední"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorAddNewItem.Text = "Přidat nový"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorDeleteItem.Text = "Odstranit"
        '
        'Dítě__auto_BindingNavigatorSaveItem
        '
        Me.Dítě__auto_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dítě__auto_BindingNavigatorSaveItem.Image = CType(resources.GetObject("Dítě__auto_BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Dítě__auto_BindingNavigatorSaveItem.Name = "Dítě__auto_BindingNavigatorSaveItem"
        Me.Dítě__auto_BindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 33)
        Me.Dítě__auto_BindingNavigatorSaveItem.Text = "Uložit data"
        '
        'Dítě__auto_DataGridView
        '
        Me.Dítě__auto_DataGridView.AutoGenerateColumns = False
        Me.Dítě__auto_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dítě__auto_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Dítě__auto_DataGridView.DataSource = Me.Dítě__auto_BindingSource
        Me.Dítě__auto_DataGridView.Location = New System.Drawing.Point(44, 87)
        Me.Dítě__auto_DataGridView.Name = "Dítě__auto_DataGridView"
        Me.Dítě__auto_DataGridView.RowHeadersWidth = 62
        Me.Dítě__auto_DataGridView.RowTemplate.Height = 28
        Me.Dítě__auto_DataGridView.Size = New System.Drawing.Size(576, 220)
        Me.Dítě__auto_DataGridView.TabIndex = 1
        '
        'Rodička__majitel_DataGridView
        '
        Me.Rodička__majitel_DataGridView.AutoGenerateColumns = False
        Me.Rodička__majitel_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rodička__majitel_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Rodička__majitel_DataGridView.DataSource = Me.Rodička__majitel_BindingSource
        Me.Rodička__majitel_DataGridView.Location = New System.Drawing.Point(734, 87)
        Me.Rodička__majitel_DataGridView.Name = "Rodička__majitel_DataGridView"
        Me.Rodička__majitel_DataGridView.RowHeadersWidth = 62
        Me.Rodička__majitel_DataGridView.RowTemplate.Height = 28
        Me.Rodička__majitel_DataGridView.Size = New System.Drawing.Size(503, 220)
        Me.Rodička__majitel_DataGridView.TabIndex = 2
        '
        'Porodnice__Servis_DataGridView
        '
        Me.Porodnice__Servis_DataGridView.AutoGenerateColumns = False
        Me.Porodnice__Servis_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Porodnice__Servis_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Porodnice__Servis_DataGridView.DataSource = Me.Porodnice__Servis_BindingSource
        Me.Porodnice__Servis_DataGridView.Location = New System.Drawing.Point(1419, 87)
        Me.Porodnice__Servis_DataGridView.Name = "Porodnice__Servis_DataGridView"
        Me.Porodnice__Servis_DataGridView.RowHeadersWidth = 62
        Me.Porodnice__Servis_DataGridView.RowTemplate.Height = 28
        Me.Porodnice__Servis_DataGridView.Size = New System.Drawing.Size(511, 220)
        Me.Porodnice__Servis_DataGridView.TabIndex = 3
        '
        'Rodička__porodnice__Majitel__Servis_DataGridView
        '
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.AutoGenerateColumns = False
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.DataSource = Me.Rodička__porodnice__Majitel__Servis_BindingSource
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.Location = New System.Drawing.Point(393, 504)
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.Name = "Rodička__porodnice__Majitel__Servis_DataGridView"
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.RowHeadersWidth = 62
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.RowTemplate.Height = 28
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.Size = New System.Drawing.Size(1092, 220)
        Me.Rodička__porodnice__Majitel__Servis_DataGridView.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 57)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "aktualizovat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(891, 441)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 57)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "přiřadit rodičce dítě"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1176, 441)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 57)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "ukaž rodičku v který je porodnici"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Jméno"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Jméno"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Příjmení"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Příjmení"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "věk"
        Me.DataGridViewTextBoxColumn16.HeaderText = "věk"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "zaměstnaná od"
        Me.DataGridViewTextBoxColumn17.HeaderText = "zaměstnaná od"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ID_Rodička"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID_Rodička"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 150
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ID_Porodnice"
        Me.DataGridViewTextBoxColumn19.HeaderText = "ID_Porodnice"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 150
        '
        'Rodička__porodnice__Majitel__Servis_BindingSource
        '
        Me.Rodička__porodnice__Majitel__Servis_BindingSource.DataMember = "Rodička__porodnice (Majitel__Servis)"
        Me.Rodička__porodnice__Majitel__Servis_BindingSource.DataSource = Me.Porodnice_databáze0203DataSet
        '
        'Porodnice_databáze0203DataSet
        '
        Me.Porodnice_databáze0203DataSet.DataSetName = "Porodnice_databáze0203DataSet"
        Me.Porodnice_databáze0203DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "název"
        Me.DataGridViewTextBoxColumn11.HeaderText = "název"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "kraj"
        Me.DataGridViewTextBoxColumn12.HeaderText = "kraj"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "zaplněnost v %"
        Me.DataGridViewTextBoxColumn13.HeaderText = "zaplněnost v %"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'Porodnice__Servis_BindingSource
        '
        Me.Porodnice__Servis_BindingSource.DataMember = "Porodnice (Servis)"
        Me.Porodnice__Servis_BindingSource.DataSource = Me.Porodnice_databáze0203DataSet
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Příjmení"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Příjmení"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Jméno"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Jméno"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'Rodička__majitel_BindingSource
        '
        Me.Rodička__majitel_BindingSource.DataMember = "Rodička (majitel)"
        Me.Rodička__majitel_BindingSource.DataSource = Me.Porodnice_databáze0203DataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "váha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "váha"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "potřeba inkubátoru"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "potřeba inkubátoru"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "výška"
        Me.DataGridViewTextBoxColumn3.HeaderText = "výška"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "datum narození"
        Me.DataGridViewTextBoxColumn4.HeaderText = "datum narození"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "jméno"
        Me.DataGridViewTextBoxColumn5.HeaderText = "jméno"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "příjmení"
        Me.DataGridViewTextBoxColumn6.HeaderText = "příjmení"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'Dítě__auto_BindingSource
        '
        Me.Dítě__auto_BindingSource.DataMember = "dítě (auto)"
        Me.Dítě__auto_BindingSource.DataSource = Me.Porodnice_databáze0203DataSet
        '
        'Dítě__auto_TableAdapter
        '
        Me.Dítě__auto_TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dítě__auto_TableAdapter = Me.Dítě__auto_TableAdapter
        Me.TableAdapterManager.dítě__Rodička__auto__Majitel_TableAdapter = Nothing
        Me.TableAdapterManager.Porodnice__Servis_TableAdapter = Me.Porodnice__Servis_TableAdapter
        Me.TableAdapterManager.Rodička__majitel_TableAdapter = Me.Rodička__majitel_TableAdapter
        Me.TableAdapterManager.Rodička__porodnice__Majitel__Servis_TableAdapter = Me.Rodička__porodnice__Majitel__Servis_TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Porodnice_databáze0203DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Porodnice__Servis_TableAdapter
        '
        Me.Porodnice__Servis_TableAdapter.ClearBeforeFill = True
        '
        'Rodička__majitel_TableAdapter
        '
        Me.Rodička__majitel_TableAdapter.ClearBeforeFill = True
        '
        'Rodička__porodnice__Majitel__Servis_TableAdapter
        '
        Me.Rodička__porodnice__Majitel__Servis_TableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1950, 824)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Rodička__porodnice__Majitel__Servis_DataGridView)
        Me.Controls.Add(Me.Porodnice__Servis_DataGridView)
        Me.Controls.Add(Me.Rodička__majitel_DataGridView)
        Me.Controls.Add(Me.Dítě__auto_DataGridView)
        Me.Controls.Add(Me.Dítě__auto_BindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Dítě__auto_BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dítě__auto_BindingNavigator.ResumeLayout(False)
        Me.Dítě__auto_BindingNavigator.PerformLayout()
        CType(Me.Dítě__auto_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rodička__majitel_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Porodnice__Servis_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rodička__porodnice__Majitel__Servis_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rodička__porodnice__Majitel__Servis_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Porodnice_databáze0203DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Porodnice__Servis_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rodička__majitel_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dítě__auto_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Porodnice_databáze0203DataSet As Porodnice_databáze0203DataSet
    Friend WithEvents Dítě__auto_BindingSource As BindingSource
    Friend WithEvents Dítě__auto_TableAdapter As Porodnice_databáze0203DataSetTableAdapters.dítě__auto_TableAdapter
    Friend WithEvents TableAdapterManager As Porodnice_databáze0203DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Dítě__auto_BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Dítě__auto_BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Rodička__majitel_TableAdapter As Porodnice_databáze0203DataSetTableAdapters.Rodička__majitel_TableAdapter
    Friend WithEvents Dítě__auto_DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Rodička__majitel_BindingSource As BindingSource
    Friend WithEvents Porodnice__Servis_TableAdapter As Porodnice_databáze0203DataSetTableAdapters.Porodnice__Servis_TableAdapter
    Friend WithEvents Rodička__majitel_DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Porodnice__Servis_BindingSource As BindingSource
    Friend WithEvents Rodička__porodnice__Majitel__Servis_TableAdapter As Porodnice_databáze0203DataSetTableAdapters.Rodička__porodnice__Majitel__Servis_TableAdapter
    Friend WithEvents Porodnice__Servis_DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Rodička__porodnice__Majitel__Servis_BindingSource As BindingSource
    Friend WithEvents Rodička__porodnice__Majitel__Servis_DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
