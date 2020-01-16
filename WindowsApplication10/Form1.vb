Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Text = "RGB"
        RadioButton2.Text = "CMYK"
        RadioButton1.Checked = True

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        If (RadioButton1.Checked = True) Then
            PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar1.Value, VScrollBar2.Value, VScrollBar3.Value)
            TextBox1.Text = "RED = " & (VScrollBar1.Value)
            TextBox2.Text = "GREEN = " & (VScrollBar2.Value)
            TextBox3.Text = "BLUE = " & (VScrollBar3.Value)
        Else
            PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar2.Value + VScrollBar3.Value, VScrollBar1.Value + VScrollBar3.Value, VScrollBar1.Value + VScrollBar2.Value, 0)
            TextBox1.Text = "CYAN = " & (VScrollBar1.Value)
            TextBox2.Text = "MAGENTA = " & (VScrollBar2.Value)
            TextBox3.Text = "YELLOW = " & (VScrollBar3.Value)
            TextBox4.Text = "BLACK = " & (0)
        End If
    End Sub

    Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar2.Scroll
        If (RadioButton1.Checked = True) Then
            PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar1.Value, VScrollBar2.Value, VScrollBar3.Value)
            TextBox1.Text = "RED = " & (VScrollBar1.Value)
            TextBox2.Text = "GREEN = " & (VScrollBar2.Value)
            TextBox3.Text = "BLUE = " & (VScrollBar3.Value)
        Else
            PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar2.Value + VScrollBar3.Value, VScrollBar1.Value + VScrollBar3.Value, VScrollBar1.Value + VScrollBar2.Value, 0)
            TextBox1.Text = "CYAN = " & (VScrollBar1.Value)
            TextBox2.Text = "MAGENTA = " & (VScrollBar2.Value)
            TextBox3.Text = "YELLOW = " & (VScrollBar3.Value)
            TextBox4.Text = "BLACK = " & (0)
        End If
    End Sub

    Private Sub VScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar3.Scroll
        If (RadioButton1.Checked = True) Then
            PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar1.Value, VScrollBar2.Value, VScrollBar3.Value)
            TextBox1.Text = "RED = " & (VScrollBar1.Value)
            TextBox2.Text = "GREEN = " & (VScrollBar2.Value)
            TextBox3.Text = "BLUE = " & (VScrollBar3.Value)
        Else
            PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar2.Value + VScrollBar3.Value, VScrollBar1.Value + VScrollBar3.Value, VScrollBar1.Value + VScrollBar2.Value, 0)
            TextBox1.Text = "CYAN = " & (VScrollBar1.Value)
            TextBox2.Text = "MAGENTA = " & (VScrollBar2.Value)
            TextBox3.Text = "YELLOW = " & (VScrollBar3.Value)
            TextBox4.Text = "BLACK = " & (0)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "RED"
        Label2.Text = "GREEN"
        Label3.Text = "BLUE"
        Label7.Visible = False
        TextBox4.Visible = False
        Label4.Text = "R"
        Label5.Text = "G"
        Label6.Text = "B"

        PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar1.Value, VScrollBar2.Value, VScrollBar3.Value)
        VScrollBar1.Minimum = 0
        VScrollBar1.Maximum = 255
        VScrollBar1.LargeChange = 1

        VScrollBar2.Minimum = 0
        VScrollBar2.Maximum = 255
        VScrollBar2.LargeChange = 1

        VScrollBar3.Minimum = 0
        VScrollBar3.Maximum = 255
        VScrollBar3.LargeChange = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "CYAN"
        Label2.Text = "MAGENTA"
        Label3.Text = "YELLOW"
        Label7.Visible = True
        TextBox4.Visible = True
        Label4.Text = "C"
        Label5.Text = "M"
        Label6.Text = "Y"
        Label7.Text = "K"

        PictureBox1.BackColor = System.Drawing.Color.FromArgb(VScrollBar1.Value, VScrollBar2.Value, VScrollBar3.Value)
        VScrollBar1.Minimum = 0
        VScrollBar1.Maximum = 100
        VScrollBar1.LargeChange = 1

        VScrollBar2.Minimum = 0
        VScrollBar2.Maximum = 100
        VScrollBar2.LargeChange = 1

        VScrollBar3.Minimum = 0
        VScrollBar3.Maximum = 100
        VScrollBar3.LargeChange = 1
    End Sub
End Class
