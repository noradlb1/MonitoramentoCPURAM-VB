Namespace MonitoramentoCPURAM
	Partial Public Class Form1
		''' <summary>
		''' Variável de designer necessária.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Limpar os recursos que estão sendo usados.
		''' </summary>
		''' <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Código gerado pelo Windows Form Designer"

		''' <summary>
		''' Método necessário para suporte ao Designer - não modifique 
		''' o conteúdo deste método com o editor de código.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim chartArea2 As New System.Windows.Forms.DataVisualization.Charting.ChartArea()
			Dim legend2 As New System.Windows.Forms.DataVisualization.Charting.Legend()
			Dim series3 As New System.Windows.Forms.DataVisualization.Charting.Series()
			Dim series4 As New System.Windows.Forms.DataVisualization.Charting.Series()
			Me.pCPU = New System.Diagnostics.PerformanceCounter()
			Me.pRAM = New System.Diagnostics.PerformanceCounter()
			Me.timer = New System.Windows.Forms.Timer(Me.components)
			Me.metroLabel1 = New MetroFramework.Controls.MetroLabel()
			Me.metroProgressBarCPU = New MetroFramework.Controls.MetroProgressBar()
			Me.metroProgressBarRAM = New MetroFramework.Controls.MetroProgressBar()
			Me.metroLabel2 = New MetroFramework.Controls.MetroLabel()
			Me.lblCPU = New MetroFramework.Controls.MetroLabel()
			Me.lblRAM = New MetroFramework.Controls.MetroLabel()
			Me.chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
			DirectCast(Me.pCPU, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pRAM, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.chart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pCPU
			' 
			Me.pCPU.CategoryName = "Processor"
			Me.pCPU.CounterName = "% Processor Time"
			Me.pCPU.InstanceName = "_Total"
			' 
			' pRAM
			' 
			Me.pRAM.CategoryName = "Memory"
			Me.pRAM.CounterName = "% Committed Bytes In Use"
			' 
			' timer
			' 
			Me.timer.Interval = 1000
'			Me.timer.Tick += New System.EventHandler(Me.timer_Tick)
			' 
			' metroLabel1
			' 
			Me.metroLabel1.AutoSize = True
			Me.metroLabel1.Location = New System.Drawing.Point(23, 67)
			Me.metroLabel1.Name = "metroLabel1"
			Me.metroLabel1.Size = New System.Drawing.Size(38, 19)
			Me.metroLabel1.TabIndex = 0
			Me.metroLabel1.Text = "CPU:"
			' 
			' metroProgressBarCPU
			' 
			Me.metroProgressBarCPU.Location = New System.Drawing.Point(67, 63)
			Me.metroProgressBarCPU.Name = "metroProgressBarCPU"
			Me.metroProgressBarCPU.Size = New System.Drawing.Size(291, 23)
			Me.metroProgressBarCPU.TabIndex = 1
			' 
			' metroProgressBarRAM
			' 
			Me.metroProgressBarRAM.Location = New System.Drawing.Point(67, 92)
			Me.metroProgressBarRAM.Name = "metroProgressBarRAM"
			Me.metroProgressBarRAM.Size = New System.Drawing.Size(291, 23)
			Me.metroProgressBarRAM.TabIndex = 3
			' 
			' metroLabel2
			' 
			Me.metroLabel2.AutoSize = True
			Me.metroLabel2.Location = New System.Drawing.Point(23, 96)
			Me.metroLabel2.Name = "metroLabel2"
			Me.metroLabel2.Size = New System.Drawing.Size(41, 19)
			Me.metroLabel2.TabIndex = 2
			Me.metroLabel2.Text = "RAM:"
			' 
			' lblCPU
			' 
			Me.lblCPU.AutoSize = True
			Me.lblCPU.Location = New System.Drawing.Point(364, 67)
			Me.lblCPU.Name = "lblCPU"
			Me.lblCPU.Size = New System.Drawing.Size(31, 19)
			Me.lblCPU.TabIndex = 4
			Me.lblCPU.Text = "0 %"
'			Me.lblCPU.Click += New System.EventHandler(Me.MetroLabel3_Click)
			' 
			' lblRAM
			' 
			Me.lblRAM.AutoSize = True
			Me.lblRAM.Location = New System.Drawing.Point(364, 96)
			Me.lblRAM.Name = "lblRAM"
			Me.lblRAM.Size = New System.Drawing.Size(31, 19)
			Me.lblRAM.TabIndex = 5
			Me.lblRAM.Text = "0 %"
			' 
			' chart1
			' 
			chartArea2.Name = "ChartArea1"
			Me.chart1.ChartAreas.Add(chartArea2)
			legend2.Name = "Legend1"
			Me.chart1.Legends.Add(legend2)
			Me.chart1.Location = New System.Drawing.Point(67, 121)
			Me.chart1.Name = "chart1"
			series3.ChartArea = "ChartArea1"
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
			series3.Legend = "Legend1"
			series3.Name = "CPU"
			series4.ChartArea = "ChartArea1"
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
			series4.Legend = "Legend1"
			series4.Name = "RAM"
			Me.chart1.Series.Add(series3)
			Me.chart1.Series.Add(series4)
			Me.chart1.Size = New System.Drawing.Size(300, 300)
			Me.chart1.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(437, 431)
			Me.Controls.Add(Me.chart1)
			Me.Controls.Add(Me.lblRAM)
			Me.Controls.Add(Me.lblCPU)
			Me.Controls.Add(Me.metroProgressBarRAM)
			Me.Controls.Add(Me.metroLabel2)
			Me.Controls.Add(Me.metroProgressBarCPU)
			Me.Controls.Add(Me.metroLabel1)
			Me.Name = "Form1"
			Me.Text = "RAM && CPU"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.pCPU, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pRAM, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chart1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private pCPU As System.Diagnostics.PerformanceCounter
		Private pRAM As System.Diagnostics.PerformanceCounter
		Private WithEvents timer As System.Windows.Forms.Timer
		Private metroLabel1 As MetroFramework.Controls.MetroLabel
		Private metroProgressBarCPU As MetroFramework.Controls.MetroProgressBar
		Private metroProgressBarRAM As MetroFramework.Controls.MetroProgressBar
		Private metroLabel2 As MetroFramework.Controls.MetroLabel
		Private WithEvents lblCPU As MetroFramework.Controls.MetroLabel
		Private lblRAM As MetroFramework.Controls.MetroLabel
		Private chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
	End Class
End Namespace

