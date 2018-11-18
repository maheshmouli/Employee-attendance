Public Class Form1

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EmpNo As Integer
        PictureBox1.Image = My.Resources.office
        ComboBox1.Items.Add("/")
        ComboBox1.Items.Add("0")
        ComboBox1.Items.Add("S")
        ComboBox1.Items.Add("L")
        ComboBox1.Items.Add("A")

        EmpNo = 21243

        Label7.Text = " Mahesh"
        Label11.Text = "Harsha"
        Label15.Text = "Nani"
        Label19.Text = "Chaitanya"
        Label23.Text = "Pooja"
        Label27.Text = "Anuhya"
        Label31.Text = "Naveen"
        Label35.Text = "MOULI "
        Label39.Text = "Harshu"
        Label43.Text = "Vikas"
        Label47.Text = "Vinisha"
        Label51.Text = "Dolly"
        Label55.Text = "Viswa"
        Label59.Text = "Rohit"
        Label63.Text = "Mounika"
        Label67.Text = "Subbu"
        Label71.Text = "Priyanka"
        Label75.Text = "Prasanthi"
        Label79.Text = "Venkat"

        Label6.Text = EmpNo + 20
        Label10.Text = Label6.Text + 20
        Label14.Text = Label10.Text + 20
        Label18.Text = Label14.Text + 20
        Label22.Text = Label18.Text + 20
        Label26.Text = Label22.Text + 20
        Label30.Text = Label26.Text + 20
        Label34.Text = Label30.Text + 20
        Label38.Text = Label34.Text + 20
        Label42.Text = Label38.Text + 20
        Label46.Text = Label42.Text + 20
        Label50.Text = Label46.Text + 20
        Label54.Text = Label50.Text + 20
        Label58.Text = Label54.Text + 20
        Label62.Text = Label58.Text + 20
        Label66.Text = Label62.Text + 20
        Label70.Text = Label66.Text + 20
        Label74.Text = Label70.Text + 20
        Label78.Text = Label74.Text + 20


        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox18.Visible = False
        TextBox19.Visible = False
        TextBox20.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False

        ComboBox2.Items.Add("/-Present")
        ComboBox2.Items.Add("0-Absent")
        ComboBox2.Items.Add("S-Sick")
        ComboBox2.Items.Add("L-Late")
        ComboBox2.Items.Add("A-Authorised")

        ComboBox3.Items.Add("/-Present")
        ComboBox3.Items.Add("0-Absent")
        ComboBox3.Items.Add("S-Sick")
        ComboBox3.Items.Add("L-Late")
        ComboBox3.Items.Add("A-Authorised")

        ComboBox4.Items.Add("/-Present")
        ComboBox4.Items.Add("0-Absent")
        ComboBox4.Items.Add("S-Sick")
        ComboBox4.Items.Add("L-Late")
        ComboBox4.Items.Add("A-Authorised")

        ComboBox5.Items.Add("/-Present")
        ComboBox5.Items.Add("0-Absent")
        ComboBox5.Items.Add("S-Sick")
        ComboBox5.Items.Add("L-Late")
        ComboBox5.Items.Add("A-Authorised")

        ComboBox6.Items.Add("/-Present")
        ComboBox6.Items.Add("0-Absent")
        ComboBox6.Items.Add("S-Sick")
        ComboBox6.Items.Add("L-Late")
        ComboBox6.Items.Add("A-Authorised")

        ComboBox7.Items.Add("/-Present")
        ComboBox7.Items.Add("0-Absent")
        ComboBox7.Items.Add("S-Sick")
        ComboBox7.Items.Add("L-Late")
        ComboBox7.Items.Add("A-Authorised")

        ComboBox8.Items.Add("/-Present")
        ComboBox8.Items.Add("0-Absent")
        ComboBox8.Items.Add("S-Sick")
        ComboBox8.Items.Add("L-Late")
        ComboBox8.Items.Add("A-Authorised")

        ComboBox9.Items.Add("/-Present")
        ComboBox9.Items.Add("0-Absent")
        ComboBox9.Items.Add("S-Sick")
        ComboBox9.Items.Add("L-Late")
        ComboBox9.Items.Add("A-Authorised")

        ComboBox10.Items.Add("/-Present")
        ComboBox10.Items.Add("0-Absent")
        ComboBox10.Items.Add("S-Sick")
        ComboBox10.Items.Add("L-Late")
        ComboBox10.Items.Add("A-Authorised")

        ComboBox11.Items.Add("/-Present")
        ComboBox11.Items.Add("0-Absent")
        ComboBox11.Items.Add("S-Sick")
        ComboBox11.Items.Add("L-Late")
        ComboBox11.Items.Add("A-Authorised")

        ComboBox12.Items.Add("/-Present")
        ComboBox12.Items.Add("0-Absent")
        ComboBox12.Items.Add("S-Sick")
        ComboBox12.Items.Add("L-Late")
        ComboBox12.Items.Add("A-Authorised")

        ComboBox13.Items.Add("/-Present")
        ComboBox13.Items.Add("0-Absent")
        ComboBox13.Items.Add("S-Sick")
        ComboBox13.Items.Add("L-Late")
        ComboBox13.Items.Add("A-Authorised")

        ComboBox14.Items.Add("/-Present")
        ComboBox14.Items.Add("0-Absent")
        ComboBox14.Items.Add("S-Sick")
        ComboBox14.Items.Add("L-Late")
        ComboBox14.Items.Add("A-Authorised")

        ComboBox15.Items.Add("/-Present")
        ComboBox15.Items.Add("0-Absent")
        ComboBox15.Items.Add("S-Sick")
        ComboBox15.Items.Add("L-Late")
        ComboBox15.Items.Add("A-Authorised")

        ComboBox16.Items.Add("/-Present")
        ComboBox16.Items.Add("0-Absent")
        ComboBox16.Items.Add("S-Sick")
        ComboBox16.Items.Add("L-Late")
        ComboBox16.Items.Add("A-Authorised")

        ComboBox17.Items.Add("/-Present")
        ComboBox17.Items.Add("0-Absent")
        ComboBox17.Items.Add("S-Sick")
        ComboBox17.Items.Add("L-Late")
        ComboBox17.Items.Add("A-Authorised")

        ComboBox18.Items.Add("/-Present")
        ComboBox18.Items.Add("0-Absent")
        ComboBox18.Items.Add("S-Sick")
        ComboBox18.Items.Add("L-Late")
        ComboBox18.Items.Add("A-Authorised")

        ComboBox19.Items.Add("/-Present")
        ComboBox19.Items.Add("0-Absent")
        ComboBox19.Items.Add("S-Sick")
        ComboBox19.Items.Add("L-Late")
        ComboBox19.Items.Add("A-Authorised")

        ComboBox20.Items.Add("/-Present")
        ComboBox20.Items.Add("0-Absent")
        ComboBox20.Items.Add("S-Sick")
        ComboBox20.Items.Add("L-Late")
        ComboBox20.Items.Add("A-Authorised")


    End Sub

    Private Sub btnFull_Click(sender As Object, e As EventArgs) Handles btnFull.Click
        If ComboBox1.Text = "/" Then
            ComboBox2.Text = ("/-Present")
            ComboBox3.Text = ("/-Present")
            ComboBox4.Text = ("/-Present")
            ComboBox5.Text = ("/-Present")
            ComboBox6.Text = ("/-Present")
            ComboBox7.Text = ("/-Present")
            ComboBox8.Text = ("/-Present")
            ComboBox9.Text = ("/-Present")
            ComboBox10.Text = ("/-Present")
            ComboBox11.Text = ("/-Present")
            ComboBox12.Text = ("/-Present")
            ComboBox13.Text = ("/-Present")
            ComboBox14.Text = ("/-Present")
            ComboBox15.Text = ("/-Present")
            ComboBox16.Text = ("/-Present")
            ComboBox17.Text = ("/-Present")
            ComboBox18.Text = ("/-Present")
            ComboBox19.Text = ("/-Present")
            ComboBox20.Text = ("/-Present")

        ElseIf ComboBox1.Text = "0" Then
            ComboBox2.Text = ("0-Absent")
            ComboBox3.Text = ("0-Absent")
            ComboBox4.Text = ("0-Absent")
            ComboBox5.Text = ("0-Absent")
            ComboBox6.Text = ("0-Absent")
            ComboBox7.Text = ("0-Absent")
            ComboBox8.Text = ("0-Absent")
            ComboBox9.Text = ("0-Absent")
            ComboBox10.Text = ("0-Absent")
            ComboBox11.Text = ("0-Absent")
            ComboBox12.Text = ("0-Absent")
            ComboBox13.Text = ("0-Absent")
            ComboBox14.Text = ("0-Absent")
            ComboBox15.Text = ("0-Absent")
            ComboBox16.Text = ("0-Absent")
            ComboBox17.Text = ("0-Absent")
            ComboBox18.Text = ("0-Absent")
            ComboBox19.Text = ("0-Absent")
            ComboBox20.Text = ("0-Absent")

        ElseIf ComboBox1.Text = "S" Then
            ComboBox2.Text = ("S-Sick")
            ComboBox3.Text = ("S-Sick")
            ComboBox4.Text = ("S-Sick")
            ComboBox5.Text = ("S-Sick")
            ComboBox6.Text = ("S-Sick")
            ComboBox7.Text = ("S-Sick")
            ComboBox8.Text = ("S-Sick")
            ComboBox9.Text = ("S-Sick")
            ComboBox10.Text = ("S-Sick")
            ComboBox11.Text = ("S-Sick")
            ComboBox12.Text = ("S-Sick")
            ComboBox13.Text = ("S-Sick")
            ComboBox14.Text = ("S-Sick")
            ComboBox15.Text = ("S-Sick")
            ComboBox16.Text = ("S-Sick")
            ComboBox17.Text = ("S-Sick")
            ComboBox18.Text = ("S-Sick")
            ComboBox19.Text = ("S-Sick")
            ComboBox20.Text = ("S-Sick")

        ElseIf ComboBox1.Text = "L" Then
            ComboBox2.Text = ("L-Late")
            ComboBox3.Text = ("L-Late")
            ComboBox4.Text = ("L-Late")
            ComboBox5.Text = ("L-Late")
            ComboBox6.Text = ("L-Late")
            ComboBox7.Text = ("L-Late")
            ComboBox8.Text = ("L-Late")
            ComboBox9.Text = ("L-Late")
            ComboBox10.Text = ("L-Late")
            ComboBox11.Text = ("L-Late")
            ComboBox12.Text = ("L-Late")
            ComboBox13.Text = ("L-Late")
            ComboBox14.Text = ("L-Late")
            ComboBox15.Text = ("L-Late")
            ComboBox16.Text = ("L-Late")
            ComboBox17.Text = ("L-Late")
            ComboBox18.Text = ("L-Late")
            ComboBox19.Text = ("L-Late")
            ComboBox20.Text = ("L-Late")

        ElseIf ComboBox1.Text = "A" Then
            ComboBox2.Text = ("A-Authorised")
            ComboBox3.Text = ("A-Authorised")
            ComboBox4.Text = ("A-Authorised")
            ComboBox5.Text = ("A-Authorised")
            ComboBox6.Text = ("A-Authorised")
            ComboBox7.Text = ("A-Authorised")
            ComboBox8.Text = ("A-Authorised")
            ComboBox9.Text = ("A-Authorised")
            ComboBox10.Text = ("A-Authorised")
            ComboBox11.Text = ("A-Authorised")
            ComboBox12.Text = ("A-Authorised")
            ComboBox13.Text = ("A-Authorised")
            ComboBox14.Text = ("A-Authorised")
            ComboBox15.Text = ("A-Authorised")
            ComboBox16.Text = ("A-Authorised")
            ComboBox17.Text = ("A-Authorised")
            ComboBox18.Text = ("A-Authorised")
            ComboBox19.Text = ("A-Authorised")
            ComboBox20.Text = ("A-Authorised")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count As Integer
        ComboBox1.Text = ""
        lblTotalPresent.Text = ""
        PictureBox1.Image = My.Resources.office
        lblName.Text = ""
        lblID.Text = ""

        lblName.Text = "Employee Register(2018)"
        lblID.Text = "Number 2018/500"

        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox1.Visible = False
        ComboBox1.Visible = True

        TextBox4.Text = ""
        ComboBox2.Text = ""
        TextBox4.Visible = False
        ComboBox2.Visible = True

        TextBox5.Text = ""
        ComboBox3.Text = ""
        TextBox5.Visible = False
        ComboBox3.Visible = True

        TextBox6.Text = ""
        ComboBox4.Text = ""
        TextBox6.Visible = False
        ComboBox4.Visible = True

        TextBox7.Text = ""
        ComboBox5.Text = ""
        TextBox7.Visible = False
        ComboBox5.Visible = True

        TextBox8.Text = ""
        ComboBox6.Text = ""
        TextBox8.Visible = False
        ComboBox6.Visible = True

        TextBox9.Text = ""
        ComboBox7.Text = ""
        TextBox9.Visible = False
        ComboBox7.Visible = True

        TextBox10.Text = ""
        ComboBox8.Text = ""
        TextBox10.Visible = False
        ComboBox8.Visible = True

        TextBox11.Text = ""
        ComboBox9.Text = ""
        TextBox11.Visible = False
        ComboBox9.Visible = True

        TextBox12.Text = ""
        ComboBox10.Text = ""
        TextBox12.Visible = False
        ComboBox10.Visible = True

        TextBox13.Text = ""
        ComboBox11.Text = ""
        TextBox13.Visible = False
        ComboBox11.Visible = True

        TextBox14.Text = ""
        ComboBox12.Text = ""
        TextBox14.Visible = False
        ComboBox12.Visible = True

        TextBox15.Text = ""
        ComboBox13.Text = ""
        TextBox15.Visible = False
        ComboBox13.Visible = True

        TextBox16.Text = ""
        ComboBox14.Text = ""
        TextBox16.Visible = False
        ComboBox14.Visible = True

        TextBox17.Text = ""
        ComboBox15.Text = ""
        TextBox17.Visible = False
        ComboBox15.Visible = True

        TextBox18.Text = ""
        ComboBox16.Text = ""
        TextBox18.Visible = False
        ComboBox16.Visible = True

        TextBox19.Text = ""
        ComboBox17.Text = ""
        TextBox19.Visible = False
        ComboBox17.Visible = True

        TextBox20.Text = ""
        ComboBox18.Text = ""
        TextBox20.Visible = False
        ComboBox18.Visible = True

        TextBox21.Text = ""
        ComboBox19.Text = ""
        TextBox21.Visible = False
        ComboBox19.Visible = True

        TextBox22.Text = ""
        ComboBox20.Text = ""
        TextBox22.Visible = False
        ComboBox20.Visible = True

        ComboBox1.Text = ""

        If TextBox4.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox5.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox6.Text = ("/- Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox7.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox8.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox9.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox10.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox11.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox12.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox13.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox14.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox15.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox16.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox17.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox18.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox19.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox20.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox21.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If
        If TextBox22.Text = ("/-Present") Then
            count = count + 1
            lblTotalPresent.Text = count
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        PictureBox1.Image = My.Resources.Mahesh
        lblID.Text = Label6.Text
        lblName.Text = Label7.Text

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        PictureBox1.Image = My.Resources.Sis
        lblID.Text = Label10.Text
        lblName.Text = Label11.Text

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        PictureBox1.Image = My.Resources.Nani
        lblID.Text = Label14.Text
        lblName.Text = Label15.Text
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        PictureBox1.Image = My.Resources.Chaitanya
        lblID.Text = Label18.Text
        lblName.Text = Label19.Text
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label22.Text
        lblName.Text = Label23.Text
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        PictureBox1.Image = My.Resources.Shradha
        lblID.Text = Label26.Text
        lblName.Text = Label27.Text
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label30.Text
        lblName.Text = Label31.Text
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label34.Text
        lblName.Text = Label35.Text
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label38.Text
        lblName.Text = Label39.Text
    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click
        PictureBox1.Image = My.Resources.Shradha
        lblID.Text = Label42.Text
        lblName.Text = Label43.Text
    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label46.Text
        lblName.Text = Label47.Text
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label50.Text
        lblName.Text = Label51.Text
    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label54.Text
        lblName.Text = Label55.Text
    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label58.Text
        lblName.Text = Label59.Text
    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label62.Text
        lblName.Text = Label63.Text
    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label66.Text
        lblName.Text = Label67.Text
    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label71.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label70.Text
        lblName.Text = Label71.Text
    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label74.Text
        lblName.Text = Label75.Text
    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles Label79.Click
        PictureBox1.Image = My.Resources.office
        lblID.Text = Label78.Text
        lblName.Text = Label79.Text
    End Sub
End Class
