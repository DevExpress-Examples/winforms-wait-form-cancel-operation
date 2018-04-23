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
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.splashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.WaitFormCanceling.WaitForm1), True, True)
            Me.label1 = New System.Windows.Forms.Label()
            Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl
            ' 
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView1
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(1100, 524)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.gridView1.GridControl = Me.gridControl
            Me.gridView1.Name = "gridView1"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(253, 552)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(174, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Load Data"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(499, 561)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(35, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "label1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1100, 602)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.gridControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private gridControl As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private label1 As System.Windows.Forms.Label
        Private backgroundWorker1 As System.ComponentModel.BackgroundWorker
        Private splashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager

    End Class
End Namespace
