Imports System.Data.OleDb


Module Connection_Load

    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\المشاريع 2018\SuperMarkt\SuperMarkt\SuperMarktDB.accdb")

    Public UsersDT As New DataTable
    Public UsersDA As New OleDbDataAdapter
    Public mynewIDUsers As Integer
    'this code for lode table users in v.b
    Public Sub load_Users()
        UsersDT.Clear()
        UsersDA = New OleDbDataAdapter("select*from Users", con)
        UsersDA.Fill(UsersDT)
    End Sub
    Public Sub code_Users()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("SELECT MAX (UserID) FROM Users", con)
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDUsers = 1
        Else
            mynewIDUsers = dt(0)(0) + 1

        End If
    End Sub
    '********************************************************************************
    '********************************************************************************
    'This counection beetwen v.b databisc 
    Public CustomersDT As New DataTable
    Public CustomersDA As New OleDbDataAdapter
    Public mynewIDCustomers As Integer

    Public Sub Load_Customers()
        CustomersDT.Clear()
        CustomersDA = New OleDbDataAdapter("select * From Customers", con)
        CustomersDA.Fill(CustomersDT)
    End Sub

    Public Sub Code_Customers()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("Select Max(CustomerID) FROM Customers", con)
        'If (ID) Equal Zreo Then be bigin 1 and sum this 1 and bigin new 
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDCustomers = 1
        Else
            mynewIDCustomers = dt(0)(0) + 1


        End If



    End Sub
    '********************************************************************************
    '********************************************************************************

    Public ImportersDT As New DataTable
    Public ImportersDA As New OleDbDataAdapter
    Public mynewIDImporters As Integer
    Public Sub Load_Importers()
        ImportersDT.Clear()
        ImportersDA = New OleDbDataAdapter("select * from Importers ", con)
        ImportersDA.Fill(ImportersDT)

    End Sub

    Public Sub Code_Importers()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select Max(ImporterID)from Importers", con)
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDImporters = 1
        Else
            mynewIDImporters = dt(0)(0) + 1


        End If

    End Sub
    '********************************************************************************
    '********************************************************************************
    Public ItemsDT As New DataTable
    Public ItemsDA As New OleDbDataAdapter
    Public mynewIDItems As Integer
    Public Sub Load_Items()
        ItemsDT.Clear()
        ItemsDA = New OleDbDataAdapter("select * from Items", con)
        ItemsDA.Fill(ItemsDT)

    End Sub

    Public Sub Code_Items()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select Max(ItemID)from Items", con)
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDItems = 1
        Else
            mynewIDItems = dt(0)(0) + 1


        End If

    End Sub

    '********************************************************************************
    '********************************************************************************
    Public GroupDT As New DataTable
    Public GroupDA As New OleDbDataAdapter
    Public mynewIDGroups As Integer

    Public Sub Code_Groups()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select Max(GroupID)from Groups", con)
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDGroups = 1
        Else
            mynewIDGroups = dt(0)(0) + 1

        End If
    End Sub
    Public Sub load_Gruop()

        GroupDT.Clear()
        GroupDA = New OleDbDataAdapter("select*from Groups", con)
        GroupDA.Fill(GroupDT)

    End Sub
    '********************************************************************************
    '********************************************************************************
    Public CompinyDT As New DataTable
    Public CompinyDA As New OleDbDataAdapter
    Public mynewIDCompiny As Integer

    Public Sub Code_Compinyes()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select Max(CompanyID)from Companies", con)
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDCompiny = 1
        Else
            mynewIDCompiny = dt(0)(0) + 1

        End If

    End Sub
    Public Sub load_Compinys()

        CompinyDT.Clear()
        CompinyDA = New OleDbDataAdapter("select*from Companies", con)
        CompinyDA.Fill(CompinyDT)
        Code_Compinyes()
    End Sub
    '********************************************************************************
    '********************************************************************************
    Public placeDt As New DataTable
    Public placeDA As New OleDbDataAdapter
    Public mynewIDplace As Integer

    Public Sub Code_Place()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select MAX(PlacesID)FROM places ", con)
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDplace = 1
        Else
            mynewIDplace = dt(0)(0) + 1
        End If

    End Sub
    Public Sub load_place()
        placeDt.Clear()
        placeDA = New OleDbDataAdapter("select * from places", con)
        placeDA.Fill(placeDt)
        Code_Place()
    End Sub
    '********************************************************************************
    '******************************************************************************** 
    Public hooder_EnsrafdtDT As New DataTable
    Public hooder_EnsrafdtDA As New OleDbDataAdapter
    Public mynewIDhooder_Ensraf As Integer

    Public Sub Code_hooder_Ensraf()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select MAX(HEID)FROM Hoodorenseraf ", con)
        da.Fill(dt)
        If IsDBNull(dt(0)(0)) = True Then
            mynewIDhooder_Ensraf = 1

        Else
            mynewIDhooder_Ensraf = dt(0)(0) + 1
        End If

    End Sub
    Public Sub load_hooder_Ensraf()
        hooder_EnsrafdtDT.Clear()
        hooder_EnsrafdtDA = New OleDbDataAdapter("select*from Hoodorenseraf where HEDate=#" & Now.Date.ToString("yyyy/MM/dd") & "#", con)
        hooder_EnsrafdtDA.Fill(hooder_EnsrafdtDT)
    End Sub
    '#######################################################################################
    Public BuypllDT As New DataTable
    Public BuypllDA As New OleDbDataAdapter
    Public mynewIDBuypll As Integer
    Public Sub Code_Buypll()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select Max(BuyID)From Buypll ", con)
        da.Fill(dt)

        If IsDBNull(BuypllDT(0)(0)) = True Then
            mynewIDBuypll = 1
        Else
            mynewIDBuypll = dt(0)(0) + 1
        End If

    End Sub
    Public Sub load_Buypll()
        BuypllDT.Clear()
        BuypllDA = New OleDbDataAdapter("select*from Buypll ", con)
        BuypllDA.Fill(BuypllDT)

    End Sub



End Module
