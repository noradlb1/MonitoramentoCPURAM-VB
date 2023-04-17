Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
'MY Telegram:@MONSTERMC
Namespace MonitoramentoCPURAM
	Partial Public Class Form1
		Inherits MetroFramework.Forms.MetroForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
			Dim fcpu As Single = pCPU.NextValue()
			Dim fram As Single = pRAM.NextValue()
			metroProgressBarCPU.Value = CInt(Math.Truncate(fcpu)) ' barra
			metroProgressBarRAM.Value = CInt(Math.Truncate(fram))
			lblCPU.Text = String.Format("{0:0.00}%", fcpu) ' atulaizar a porcentagem
			lblRAM.Text = String.Format("{0:0.00}%", fram)
			chart1.Series("CPU").Points.AddY(fcpu) ' grafico
			chart1.Series("RAM").Points.AddY(fram)
		End Sub

		Private Sub MetroLabel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblCPU.Click

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			timer.Start()
		End Sub
	End Class
End Namespace
