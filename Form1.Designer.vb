<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.btnPerformance = New System.Windows.Forms.Button()
        Me.btnSalesReports = New System.Windows.Forms.Button()
        Me.btnSystemLogs = New System.Windows.Forms.Button()
        Me.btnActivityLogs = New System.Windows.Forms.Button()
        Me.btnMovieMgmt = New System.Windows.Forms.Button()
        Me.btnTellerMgmt = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.pnlReservations = New System.Windows.Forms.Panel()
        Me.lblResHeader = New System.Windows.Forms.Label()
        Me.lblReservations = New System.Windows.Forms.Label()
        Me.pnlTellers = New System.Windows.Forms.Panel()
        Me.lblTellersHeader = New System.Windows.Forms.Label()
        Me.lblTellers = New System.Windows.Forms.Label()
        Me.pnlMovies = New System.Windows.Forms.Panel()
        Me.lblMoviesHeader = New System.Windows.Forms.Label()
        Me.lblMovies = New System.Windows.Forms.Label()
        Me.pnlRevenue = New System.Windows.Forms.Panel()
        Me.lblRevenueHeader = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.dgvRecent = New System.Windows.Forms.DataGridView()
        Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSidebar
        '
        Me.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(20, 20, 20)
        Me.PanelSidebar.Controls.Add(Me.btnPerformance)
        Me.PanelSidebar.Controls.Add(Me.btnSalesReports)
        Me.PanelSidebar.Controls.Add(Me.btnSystemLogs)
        Me.PanelSidebar.Controls.Add(Me.btnActivityLogs)
        Me.PanelSidebar.Controls.Add(Me.btnMovieMgmt)
        Me.PanelSidebar.Controls.Add(Me.btnTellerMgmt)
        Me.PanelSidebar.Controls.Add(Me.btnDashboard)
        Me.PanelSidebar.Controls.Add(Me.lblTitle)
        Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSidebar.Size = New System.Drawing.Size(200, 600)
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Size = New System.Drawing.Size(200, 60)
        Me.lblTitle.Text = "CinemaAdmin"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Size = New System.Drawing.Size(200, 40)
        Me.btnDashboard.Text = "Dashboard"
        '
        'btnTellerMgmt
        '
        Me.btnTellerMgmt.BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.btnTellerMgmt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTellerMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTellerMgmt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTellerMgmt.ForeColor = System.Drawing.Color.White
        Me.btnTellerMgmt.Size = New System.Drawing.Size(200, 40)
        Me.btnTellerMgmt.Text = "Teller Management"
        '
        'btnMovieMgmt
        '
        Me.btnMovieMgmt.BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.btnMovieMgmt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMovieMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovieMgmt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMovieMgmt.ForeColor = System.Drawing.Color.White
        Me.btnMovieMgmt.Size = New System.Drawing.Size(200, 40)
        Me.btnMovieMgmt.Text = "Movie Management"
        '
        'btnActivityLogs
        '
        Me.btnActivityLogs.BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.btnActivityLogs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActivityLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivityLogs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActivityLogs.ForeColor = System.Drawing.Color.White
        Me.btnActivityLogs.Size = New System.Drawing.Size(200, 40)
        Me.btnActivityLogs.Text = "Activity Logs"
        '
        'btnSystemLogs
        '
        Me.btnSystemLogs.BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.btnSystemLogs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSystemLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSystemLogs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSystemLogs.ForeColor = System.Drawing.Color.White
        Me.btnSystemLogs.Size = New System.Drawing.Size(200, 40)
        Me.btnSystemLogs.Text = "System Logs"
        '
        'btnSalesReports
        '
        Me.btnSalesReports.BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.btnSalesReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalesReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesReports.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalesReports.ForeColor = System.Drawing.Color.White
        Me.btnSalesReports.Size = New System.Drawing.Size(200, 40)
        Me.btnSalesReports.Text = "Sales Reports"
        '
        'btnPerformance
        '
        Me.btnPerformance.BackColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.btnPerformance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerformance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPerformance.ForeColor = System.Drawing.Color.White
        Me.btnPerformance.Size = New System.Drawing.Size(200, 40)
        Me.btnPerformance.Text = "Performance"
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.PanelMain.Controls.Add(Me.dgvRecent)
        Me.PanelMain.Controls.Add(Me.lblRecent)
        Me.PanelMain.Controls.Add(Me.pnlRevenue)
        Me.PanelMain.Controls.Add(Me.pnlMovies)
        Me.PanelMain.Controls.Add(Me.pnlTellers)
        Me.PanelMain.Controls.Add(Me.pnlReservations)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(200, 0)
        Me.PanelMain.Size = New System.Drawing.Size(700, 600)
        '
        'pnlReservations
        '
        Me.pnlReservations.BackColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.pnlReservations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlReservations.Controls.Add(Me.lblReservations)
        Me.pnlReservations.Controls.Add(Me.lblResHeader)
        Me.pnlReservations.Location = New System.Drawing.Point(20, 20)
        Me.pnlReservations.Size = New System.Drawing.Size(300, 80)
        '
        'lblResHeader
        '
        Me.lblResHeader.BackColor = System.Drawing.Color.Red
        Me.lblResHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblResHeader.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblResHeader.ForeColor = System.Drawing.Color.White
        Me.lblResHeader.Height = 20
        Me.lblResHeader.Text = "   Reservations"
        Me.lblResHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReservations
        '
        Me.lblReservations.AutoSize = True
        Me.lblReservations.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblReservations.ForeColor = System.Drawing.Color.White
        Me.lblReservations.Location = New System.Drawing.Point(15, 35)
        Me.lblReservations.Text = "Total Reservations Today: 156"
        '
        'pnlTellers
        '
        Me.pnlTellers.BackColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.pnlTellers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTellers.Controls.Add(Me.lblTellers)
        Me.pnlTellers.Controls.Add(Me.lblTellersHeader)
        Me.pnlTellers.Location = New System.Drawing.Point(340, 20)
        Me.pnlTellers.Size = New System.Drawing.Size(300, 80)
        '
        'lblTellersHeader
        '
        Me.lblTellersHeader.BackColor = System.Drawing.Color.Red
        Me.lblTellersHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTellersHeader.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTellersHeader.ForeColor = System.Drawing.Color.White
        Me.lblTellersHeader.Height = 20
        Me.lblTellersHeader.Text = "   Tellers"
        Me.lblTellersHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTellers
        '
        Me.lblTellers.AutoSize = True
        Me.lblTellers.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTellers.ForeColor = System.Drawing.Color.White
        Me.lblTellers.Location = New System.Drawing.Point(15, 35)
        Me.lblTellers.Text = "Active Tellers: 8"
        '
        'pnlMovies
        '
        Me.pnlMovies.BackColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.pnlMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMovies.Controls.Add(Me.lblMovies)
        Me.pnlMovies.Controls.Add(Me.lblMoviesHeader)
        Me.pnlMovies.Location = New System.Drawing.Point(20, 120)
        Me.pnlMovies.Size = New System.Drawing.Size(300, 80)
        '
        'lblMoviesHeader
        '
        Me.lblMoviesHeader.BackColor = System.Drawing.Color.Red
        Me.lblMoviesHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMoviesHeader.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMoviesHeader.ForeColor = System.Drawing.Color.White
        Me.lblMoviesHeader.Height = 20
        Me.lblMoviesHeader.Text = "   Movies"
        Me.lblMoviesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMovies
        '
        Me.lblMovies.AutoSize = True
        Me.lblMovies.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMovies.ForeColor = System.Drawing.Color.White
        Me.lblMovies.Location = New System.Drawing.Point(15, 35)
        Me.lblMovies.Text = "Movies Playing: 12"
        '
        'pnlRevenue
        '
        Me.pnlRevenue.BackColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.pnlRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRevenue.Controls.Add(Me.lblRevenue)
        Me.pnlRevenue.Controls.Add(Me.lblRevenueHeader)
        Me.pnlRevenue.Location = New System.Drawing.Point(340, 120)
        Me.pnlRevenue.Size = New System.Drawing.Size(300, 80)
        '
        'lblRevenueHeader
        '
        Me.lblRevenueHeader.BackColor = System.Drawing.Color.Red
        Me.lblRevenueHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRevenueHeader.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevenueHeader.ForeColor = System.Drawing.Color.White
        Me.lblRevenueHeader.Height = 20
        Me.lblRevenueHeader.Text = "   Revenue"
        Me.lblRevenueHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevenue.ForeColor = System.Drawing.Color.White
        Me.lblRevenue.Location = New System.Drawing.Point(15, 35)
        Me.lblRevenue.Text = "Today's Revenue: ₱45,680"
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = True
        Me.lblRecent.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecent.ForeColor = System.Drawing.Color.White
        Me.lblRecent.Location = New System.Drawing.Point(20, 220)
        Me.lblRecent.Text = "Recent Activity"
        '
        'dgvRecent
        '
        Me.dgvRecent.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30)
        Me.dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Red
        Me.dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecent.EnableHeadersVisualStyles = False
        Me.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTime, Me.colUser, Me.colAction, Me.colDetails})
        Me.dgvRecent.Location = New System.Drawing.Point(20, 250)
        Me.dgvRecent.RowHeadersVisible = False
        Me.dgvRecent.Size = New System.Drawing.Size(650, 200)
        '
        'colTime
        '
        Me.colTime.HeaderText = "Time"
        Me.colTime.Name = "colTime"
        Me.colTime.Width = 80
        '
        'colUser
        '
        Me.colUser.HeaderText = "User"
        Me.colUser.Name = "colUser"
        Me.colUser.Width = 120
        '
        'colAction
        '
        Me.colAction.HeaderText = "Action"
        Me.colAction.Name = "colAction"
        Me.colAction.Width = 120
        '
        'colDetails
        '
        Me.colDetails.HeaderText = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Width = 300
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelSidebar)
        Me.Name = "Form1"
        Me.Text = "CinemaAdmin Dashboard"
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnTellerMgmt As Button
    Friend WithEvents btnMovieMgmt As Button
    Friend WithEvents btnActivityLogs As Button
    Friend WithEvents btnSystemLogs As Button
    Friend WithEvents btnSalesReports As Button
    Friend WithEvents btnPerformance As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents pnlReservations As Panel
    Friend WithEvents lblResHeader As Label
    Friend WithEvents lblReservations As Label
    Friend WithEvents pnlTellers As Panel
    Friend WithEvents lblTellersHeader As Label
    Friend WithEvents lblTellers As Label
    Friend WithEvents pnlMovies As Panel
    Friend WithEvents lblMoviesHeader As Label
    Friend WithEvents lblMovies As Label
    Friend WithEvents pnlRevenue As Panel
    Friend WithEvents lblRevenueHeader As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblRecent As Label
    Friend WithEvents dgvRecent As DataGridView
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents colUser As DataGridViewTextBoxColumn
    Friend WithEvents colAction As DataGridViewTextBoxColumn
    Friend WithEvents colDetails As DataGridViewTextBoxColumn
End Class