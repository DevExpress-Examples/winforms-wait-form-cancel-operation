' Developer Express Code Central Example:
' How to cancel time-consuming operation from the WaitForm
' 
' This example illustrates how to cancel a time-consuming operation on a WaitForm.
' To accomplish this task, place a BackgroundWorker and SplashScreenManager onto a
' Form, and add the Cancel button in the WaitForm's designer. The main idea is to
' perform data loading in a background thread, pass the ILocked object both to the
' WaitForm and to this thread, and check its condition while data is loading.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4524
Namespace WaitFormCanceling

    Partial Class WaitForm1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.progressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' progressPanel1
            ' 
            Me.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.progressPanel1.Appearance.Options.UseBackColor = True
            Me.progressPanel1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F)
            Me.progressPanel1.AppearanceCaption.Options.UseFont = True
            Me.progressPanel1.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.progressPanel1.AppearanceDescription.Options.UseFont = True
            Me.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.progressPanel1.ImageHorzOffset = 20
            Me.progressPanel1.Location = New System.Drawing.Point(0, 17)
            Me.progressPanel1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
            Me.progressPanel1.Name = "progressPanel1"
            Me.progressPanel1.Size = New System.Drawing.Size(246, 40)
            Me.progressPanel1.TabIndex = 0
            Me.progressPanel1.Text = "progressPanel1"
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.AutoSize = True
            Me.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.tableLayoutPanel1.Controls.Add(Me.progressPanel1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.simpleButton1, 0, 1)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 14, 0, 14)
            Me.tableLayoutPanel1.RowCount = 2
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.2635F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.7365F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(246, 110)
            Me.tableLayoutPanel1.TabIndex = 1
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.simpleButton1.Location = New System.Drawing.Point(3, 63)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(240, 30)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Cancel"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' WaitForm1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ClientSize = New System.Drawing.Size(246, 110)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.DoubleBuffered = True
            Me.Name = "WaitForm1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Form1"
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private progressPanel1 As DevExpress.XtraWaitForm.ProgressPanel

        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
