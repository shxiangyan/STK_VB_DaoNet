Imports System.ComponentModel
Imports AGI.STKObjects
Imports AGI.STKVgt
Public Class Form1
    Dim stkRootObject As AGI.STKObjects.AgStkObjectRoot

    Private ReadOnly Property stkRoot() As AGI.STKObjects.AgStkObjectRoot
        Get
            If stkRootObject Is Nothing Then
                stkRootObject = New AGI.STKObjects.AgStkObjectRoot
            End If
            stkRoot = stkRootObject
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MapView
        On Error GoTo ErrHandler

        OpenFileDialog1 = New OpenFileDialog
        Dim path As String
        path = Application.StartupPath + "\..\..\..\..\..\..\SharedResources\Scenarios\Events\"
        OpenFileDialog1.InitialDirectory = System.IO.Path.GetFullPath(path)
        OpenFileDialog1.Filter = "Scenario (.sc)|*.sc"
        OpenFileDialog1.Title = "打开sc文件"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result <> System.Windows.Forms.DialogResult.Cancel Then
            If OpenFileDialog1.CheckFileExists Then
                On Error Resume Next
                If Not (IsNothing(stkRootObject)) Then
                    stkRootObject.CloseScenario()
                End If
                On Error GoTo 0
                stkRoot.LoadScenario(OpenFileDialog1.FileName)
                Button2.Visible = False
                Button4.Visible = True
                Button5.Visible = True
                Button6.Visible = True
                Button7.Visible = True
                Button3.Visible = True
            End If
        End If


        Exit Sub
ErrHandler:

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not (IsNothing(stkRootObject)) Then
            stkRootObject.CloseScenario()
        End If
        Button2.Visible = True
        Button1.Visible = True
        Button8.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button3.Visible = False
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '新建场景
        Dim oScenario As IAgScenario
        stkRoot.NewScenario("AzElMaskToolTest")
        stkRoot.UnitPreferences.SetCurrentUnit("DistanceUnit", "km")
        stkRoot.UnitPreferences.SetCurrentUnit("DateFormat", "UTCG")
        oScenario = stkRoot.CurrentScenario
        oScenario.SetTimePeriod("1 Jul 2007 12:00:00.000", "2 Jul 2007 12:00:00.000")
        oScenario.Epoch = "1 Jul 2007 12:00:00.000"
        oScenario.Animation.StartTime = "1 Jul 2007 12:00:00.000"
        stkRoot.Rewind()
        '新建卫星
        Dim oSat As IAgSatellite
        Dim oTwobody As IAgVePropagatorTwoBody
        Dim oOrb As AGI.STKUtil.IAgOrbitState

        oSat = stkRoot.CurrentScenario.Children.New(AgESTKObjectType.eSatellite, "Satellite1")
        oSat.SetPropagatorType(AgEVePropagatorType.ePropagatorTwoBody)
        oSat.VO.Model.ScaleValue = 0.0
        oTwobody = CType(oSat.Propagator, IAgVePropagatorTwoBody)
        Dim interval As IAgCrdnEventIntervalSmartInterval = oTwobody.EphemerisInterval
        interval.SetExplicitInterval("1 Jul 2007 12:00:00.000", "2 Jul 2007 12:00:00.000")
        oTwobody.Step = 60
        oOrb = oTwobody.InitialState.Representation
        oOrb.Epoch = "1 Jul 2007 12:00:00.000"
        oTwobody.InitialState.Representation.AssignClassical(AGI.STKUtil.AgECoordinateSystem.eCoordinateSystemJ2000, 6878.14, 0.0, 45.0, 0.0, 0.0, 0.0)
        oTwobody.Propagate()
        '新建传感器
        Dim oStkObj As IAgStkObject
        Dim oSens As IAgSensor
        oStkObj = stkRoot.CurrentScenario.Children("Satellite1")
        oSens = oStkObj.Children.New(AgESTKObjectType.eSensor, "Sensor1")
        oSens.VO.VertexOffset.InheritFromParentObj = False
        oSens.VO.VertexOffset.EnableTranslational = True
        oSens.VO.VertexOffset.SetAxisOffsetValue(AgEAxisOffset.eSensorRadius, 0)
        oSens.VO.VertexOffset.X = 0
        oSens.VO.VertexOffset.Y = 0
        oSens.VO.VertexOffset.Z = -0.03
        stkRoot.Rewind()
        '新建星座
        stkRoot.ExecuteCommand("Walker */Satellite/Satellite1 Type Delta NumPlanes 2 NumSatsPerPlane 4 InterPlanePhaseIncrement 1 ColorByPlane Yes")

        Button1.Visible = False
        Button8.Visible = True

        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim saveAsDialog As SaveFileDialog = New SaveFileDialog
        If (saveAsDialog.ShowDialog() = DialogResult.OK) Then
            stkRoot.SaveScenarioAs(saveAsDialog.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DirectCast(stkRoot, IAgAnimation).PlayForward()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DirectCast(stkRoot, IAgAnimation).Pause()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DirectCast(stkRoot, IAgAnimation).Rewind()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not (IsNothing(stkRootObject)) Then
            stkRootObject.CloseScenario()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button3.Visible = False
    End Sub
End Class
