<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcardnum = New System.Windows.Forms.TextBox()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.grpflowers = New System.Windows.Forms.GroupBox()
        Me.chkgerberas = New System.Windows.Forms.CheckBox()
        Me.chkfreesia = New System.Windows.Forms.CheckBox()
        Me.chklillies = New System.Windows.Forms.CheckBox()
        Me.chkchrys = New System.Windows.Forms.CheckBox()
        Me.chkcarnations = New System.Windows.Forms.CheckBox()
        Me.chkrose = New System.Windows.Forms.CheckBox()
        Me.grppayment = New System.Windows.Forms.GroupBox()
        Me.radmaster = New System.Windows.Forms.RadioButton()
        Me.radvisa = New System.Windows.Forms.RadioButton()
        Me.radswitch = New System.Windows.Forms.RadioButton()
        Me.radcheque = New System.Windows.Forms.RadioButton()
        Me.grpflowers.SuspendLayout()
        Me.grppayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select 4 types of flowers for your bouquet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select the payment method"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Click on process Order"
        '
        'btnorder
        '
        Me.btnorder.Location = New System.Drawing.Point(281, 237)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(146, 44)
        Me.btnorder.TabIndex = 3
        Me.btnorder.Text = "Process order"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Enter Credit card Number"
        '
        'txtcardnum
        '
        Me.txtcardnum.Location = New System.Drawing.Point(15, 292)
        Me.txtcardnum.Name = "txtcardnum"
        Me.txtcardnum.Size = New System.Drawing.Size(250, 20)
        Me.txtcardnum.TabIndex = 5
        '
        'btnpayment
        '
        Me.btnpayment.Location = New System.Drawing.Point(281, 291)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(146, 21)
        Me.btnpayment.TabIndex = 6
        Me.btnpayment.Text = "Make Payment"
        Me.btnpayment.UseVisualStyleBackColor = True
        '
        'grpflowers
        '
        Me.grpflowers.Controls.Add(Me.chkgerberas)
        Me.grpflowers.Controls.Add(Me.chkfreesia)
        Me.grpflowers.Controls.Add(Me.chklillies)
        Me.grpflowers.Controls.Add(Me.chkchrys)
        Me.grpflowers.Controls.Add(Me.chkcarnations)
        Me.grpflowers.Controls.Add(Me.chkrose)
        Me.grpflowers.Location = New System.Drawing.Point(15, 85)
        Me.grpflowers.Name = "grpflowers"
        Me.grpflowers.Size = New System.Drawing.Size(200, 171)
        Me.grpflowers.TabIndex = 8
        Me.grpflowers.TabStop = False
        Me.grpflowers.Text = "Flowers"
        '
        'chkgerberas
        '
        Me.chkgerberas.AutoSize = True
        Me.chkgerberas.Location = New System.Drawing.Point(7, 140)
        Me.chkgerberas.Name = "chkgerberas"
        Me.chkgerberas.Size = New System.Drawing.Size(69, 17)
        Me.chkgerberas.TabIndex = 5
        Me.chkgerberas.Text = "Gerberas"
        Me.chkgerberas.UseVisualStyleBackColor = True
        '
        'chkfreesia
        '
        Me.chkfreesia.AutoSize = True
        Me.chkfreesia.Location = New System.Drawing.Point(7, 116)
        Me.chkfreesia.Name = "chkfreesia"
        Me.chkfreesia.Size = New System.Drawing.Size(60, 17)
        Me.chkfreesia.TabIndex = 4
        Me.chkfreesia.Text = "Freesia"
        Me.chkfreesia.UseVisualStyleBackColor = True
        '
        'chklillies
        '
        Me.chklillies.AutoSize = True
        Me.chklillies.Location = New System.Drawing.Point(7, 92)
        Me.chklillies.Name = "chklillies"
        Me.chklillies.Size = New System.Drawing.Size(94, 17)
        Me.chklillies.TabIndex = 3
        Me.chklillies.Text = "Scented Lillies"
        Me.chklillies.UseVisualStyleBackColor = True
        '
        'chkchrys
        '
        Me.chkchrys.AutoSize = True
        Me.chkchrys.Location = New System.Drawing.Point(7, 68)
        Me.chkchrys.Name = "chkchrys"
        Me.chkchrys.Size = New System.Drawing.Size(106, 17)
        Me.chkchrys.TabIndex = 2
        Me.chkchrys.Text = "Chrysanthamums"
        Me.chkchrys.UseVisualStyleBackColor = True
        '
        'chkcarnations
        '
        Me.chkcarnations.AutoSize = True
        Me.chkcarnations.Location = New System.Drawing.Point(7, 44)
        Me.chkcarnations.Name = "chkcarnations"
        Me.chkcarnations.Size = New System.Drawing.Size(76, 17)
        Me.chkcarnations.TabIndex = 1
        Me.chkcarnations.Text = "Carnations"
        Me.chkcarnations.UseVisualStyleBackColor = True
        '
        'chkrose
        '
        Me.chkrose.AutoSize = True
        Me.chkrose.Location = New System.Drawing.Point(7, 20)
        Me.chkrose.Name = "chkrose"
        Me.chkrose.Size = New System.Drawing.Size(79, 17)
        Me.chkrose.TabIndex = 0
        Me.chkrose.Text = "Red Roses"
        Me.chkrose.UseVisualStyleBackColor = True
        '
        'grppayment
        '
        Me.grppayment.Controls.Add(Me.radmaster)
        Me.grppayment.Controls.Add(Me.radvisa)
        Me.grppayment.Controls.Add(Me.radswitch)
        Me.grppayment.Controls.Add(Me.radcheque)
        Me.grppayment.Location = New System.Drawing.Point(243, 85)
        Me.grppayment.Name = "grppayment"
        Me.grppayment.Size = New System.Drawing.Size(200, 119)
        Me.grppayment.TabIndex = 9
        Me.grppayment.TabStop = False
        Me.grppayment.Text = "Payment Method"
        '
        'radmaster
        '
        Me.radmaster.AutoSize = True
        Me.radmaster.Location = New System.Drawing.Point(16, 92)
        Me.radmaster.Name = "radmaster"
        Me.radmaster.Size = New System.Drawing.Size(78, 17)
        Me.radmaster.TabIndex = 3
        Me.radmaster.TabStop = True
        Me.radmaster.Text = "Mastercard"
        Me.radmaster.UseVisualStyleBackColor = True
        '
        'radvisa
        '
        Me.radvisa.AutoSize = True
        Me.radvisa.Location = New System.Drawing.Point(16, 68)
        Me.radvisa.Name = "radvisa"
        Me.radvisa.Size = New System.Drawing.Size(45, 17)
        Me.radvisa.TabIndex = 2
        Me.radvisa.TabStop = True
        Me.radvisa.Text = "Visa"
        Me.radvisa.UseVisualStyleBackColor = True
        '
        'radswitch
        '
        Me.radswitch.AutoSize = True
        Me.radswitch.Location = New System.Drawing.Point(16, 44)
        Me.radswitch.Name = "radswitch"
        Me.radswitch.Size = New System.Drawing.Size(57, 17)
        Me.radswitch.TabIndex = 1
        Me.radswitch.TabStop = True
        Me.radswitch.Text = "Switch"
        Me.radswitch.UseVisualStyleBackColor = True
        '
        'radcheque
        '
        Me.radcheque.AutoSize = True
        Me.radcheque.Location = New System.Drawing.Point(16, 20)
        Me.radcheque.Name = "radcheque"
        Me.radcheque.Size = New System.Drawing.Size(62, 17)
        Me.radcheque.TabIndex = 0
        Me.radcheque.TabStop = True
        Me.radcheque.Text = "Cheque"
        Me.radcheque.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 325)
        Me.Controls.Add(Me.grppayment)
        Me.Controls.Add(Me.grpflowers)
        Me.Controls.Add(Me.btnpayment)
        Me.Controls.Add(Me.txtcardnum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "The Flower Box"
        Me.grpflowers.ResumeLayout(False)
        Me.grpflowers.PerformLayout()
        Me.grppayment.ResumeLayout(False)
        Me.grppayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcardnum As System.Windows.Forms.TextBox
    Friend WithEvents btnpayment As System.Windows.Forms.Button
    Friend WithEvents grpflowers As System.Windows.Forms.GroupBox
    Friend WithEvents chkgerberas As System.Windows.Forms.CheckBox
    Friend WithEvents chkfreesia As System.Windows.Forms.CheckBox
    Friend WithEvents chklillies As System.Windows.Forms.CheckBox
    Friend WithEvents chkchrys As System.Windows.Forms.CheckBox
    Friend WithEvents chkcarnations As System.Windows.Forms.CheckBox
    Friend WithEvents chkrose As System.Windows.Forms.CheckBox
    Friend WithEvents grppayment As System.Windows.Forms.GroupBox
    Friend WithEvents radmaster As System.Windows.Forms.RadioButton
    Friend WithEvents radvisa As System.Windows.Forms.RadioButton
    Friend WithEvents radswitch As System.Windows.Forms.RadioButton
    Friend WithEvents radcheque As System.Windows.Forms.RadioButton

End Class
