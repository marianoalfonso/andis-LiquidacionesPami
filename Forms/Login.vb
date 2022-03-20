Imports System.Globalization

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CO")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        cmbArea.Items.Add("Discapacidad")
        cmbArea.Items.Add("Hemodialisis")
        cmbArea.Items.Add("Geriatria")
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If cmbArea.Text = "" Then
            MsgBox("Debe seleccionar un area", vbInformation)
            Exit Sub
        End If

        'MsgBox("DADO LOS INCONVENIENTES GENERADOS POR EL MAL FUNCIONAMIENTO DE UN EQUIPO SERVIDOR" & Chr(13) & _
        '"DONDE SE ENCUENTRAN HOSTEADAS LAS BASES DE DATOS, SE INFORMA QUE EN LOS DIAS SUBSIGUIENTES PODRIAN EXPERIMENTARSE" & Chr(13) & _
        '"ALGUNOS PROBLEMAS DE LENTITUD DE LOS SISTEMAS." & Chr(13) & _
        '"EN CASO DE GENERARSE PANTALLAS DE ERRORES POR FAVOR INFORMAR DIRECTAMENTE AL AREA DE TECNOLOGÍA Y SISTEMAS" & Chr(13) & _
        '"PARA SU PRONTA RESOLUCIÓN", vbCritical)

        Cargar_Variables_Globales()
        frmDefault.Show()
    End Sub

    Sub Cargar_Variables_Globales()
        'CARGAR ESTAS VARIABLES DESDE EL CONFIG.INI
        gsArea = Trim(cmbArea.Text)
        gsPath = "C:\ArchivosFacturacion\"
        gsSistema = "Liquidaciones Pami"
        'urlReport = "http://riv-sql03/ReportServer/Pages/ReportViewer.aspx?%2fadministracion%2fReporte_unico_Andis_Pami&rs:Command=Render&p_NUMLIQ="
        gsMontoNotaElevacion = 680000

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
