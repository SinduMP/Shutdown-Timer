Public Class Form1
    Sub muncul()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Shutdown.Enabled = True
        Restart.Enabled = True
        ExitBTN.Enabled = True
    End Sub
    Sub hidden()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Shutdown.Enabled = False
        Restart.Enabled = False
        ExitBTN.Enabled = False
    End Sub
    Private Sub Shutdown_Click(sender As Object, e As EventArgs) Handles Shutdown.Click
        System.Diagnostics.Process.Start("shutdown", "-s -t 1")
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        System.Diagnostics.Process.Start("shutdown", "-r -t 1")
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        TextBox1.Text = DateTime.Now.ToString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextBox2.Text = TextBox2.Text + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = 0
        TextBox3.Text = 0
        Timer2.Start()
        Timer3.Start()
        Dim detik As Double
        If ComboBox2.SelectedIndex = 0 Then
            Label5.Text = "Tidak ada Target"
        ElseIf ComboBox2.SelectedIndex = 1 Then
            detik = TextBox4.Text * 60
            Label5.Text = "Shutdown " + TextBox4.Text + " minute"
            hidden()
            If TextBox2.Text = detik Then
                System.Diagnostics.Process.Start("shutdown", "-s -t 1")
            End If
        ElseIf ComboBox2.SelectedIndex = 2 Then
            detik = TextBox4.Text * 60
            Label5.Text = "Restart " + TextBox4.Text + " minute"
            hidden()
            If TextBox2.Text = detik Then
                System.Diagnostics.Process.Start("shutdown", "-r -t 1")
            End If
        Else
            If ComboBox1.SelectedIndex = 0 Then
                Label5.Text = "Tidak ada Target"
            ElseIf ComboBox1.SelectedIndex = 1 Then
                Label5.Text = "Shutdown 1 minute"
                System.Diagnostics.Process.Start("shutdown", "-s -t 60")
                hidden()
            ElseIf ComboBox1.SelectedIndex = 2 Then
                Label5.Text = "Shutdown 5 minute"
                System.Diagnostics.Process.Start("shutdown", "-s -t 300")
                hidden()
            ElseIf ComboBox1.SelectedIndex = 3 Then
                Label5.Text = "Shutdown 10 minute"
                System.Diagnostics.Process.Start("shutdown", "-s -t 600")
                hidden()
            ElseIf ComboBox1.SelectedIndex = 4 Then
                Label5.Text = "Shutdown 30 minute"
                System.Diagnostics.Process.Start("shutdown", "-s -t 1800")
                hidden()
            ElseIf ComboBox1.SelectedIndex = 5 Then
                Label5.Text = "Shutdown 60 minute"
                System.Diagnostics.Process.Start("shutdown", "-s -t 3600")
                hidden()
            ElseIf ComboBox1.SelectedIndex = 6 Then
                Label5.Text = "Shutdown 90 minute"
                System.Diagnostics.Process.Start("shutdown", "-s -t 5400")
                hidden()
            ElseIf ComboBox1.SelectedIndex = 7 Then
                Label5.Text = "Shutdown 120 minute"
                System.Diagnostics.Process.Start("shutdown", "-s -t 7200")
                hidden()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Stop()
        Timer3.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = 0
        TextBox3.Text = 0
    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        TextBox3.Text = TextBox3.Text + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("shutdown", "-a")
        Label5.Text = "Tidak ada Target"
        muncul()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
