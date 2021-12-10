Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Protected Sub Insert(ByVal sender As Object, ByVal e As EventArgs)
        Dim username As String = TextBox2.Text
        Dim userno As String = TextBox1.Text
        Dim query As String = "INSERT INTO tbUser VALUES(@name, @no)"
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString

    End Sub
End Class