Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MonitoramentoCPURAM
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' Ponto de entrada principal para o aplicativo.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
