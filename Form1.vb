Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Media.Animation

Public Class Form1

    Private slideBarExpand As Boolean = True
    Private Sub slidebarTransition_Tick(sender As Object, e As EventArgs) Handles slidebarTransition.Tick
        If (slideBarExpand) Then
            pnSlideBar.Width -= 5
            If (pnSlideBar.Width <= 90) Then
                slideBarExpand = False
                slidebarTransition.Stop()
            End If
        Else
            pnSlideBar.Width += 10
            If (pnSlideBar.Width >= 260) Then
                slideBarExpand = True
                slidebarTransition.Stop()
            End If
        End If

    End Sub

    Private Sub icLogoHome_Click(sender As Object, e As EventArgs) Handles icLogoHome.Click
        slidebarTransition.Start()
    End Sub

    Private currentchildForm As Form

    Private Sub openChildForm(childForm As Form)
        If (currentchildForm IsNot Nothing) Then
            currentchildForm.Close()
        End If
        currentchildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnContainer.Controls.Add(childForm)
        pnContainer.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lbcurrentHome.Text = childForm.Text
    End Sub

    Private Sub btSV_Click(sender As Object, e As EventArgs) Handles btSV.Click
        openChildForm(New Sv)
    End Sub

    Private Sub btKhoa_Click(sender As Object, e As EventArgs) Handles btKhoa.Click
        openChildForm(New Khoa)
    End Sub
End Class
