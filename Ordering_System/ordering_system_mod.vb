Imports System.IO
Imports MySql.Data.MySqlClient
Module ordering_system_mod
    Public con As New MySqlConnection("server=localhost;userid=root;pwd=124peao1;database=ordersystem;")
    Public com As New MySqlCommand
    Public dr As MySqlDataReader

    Sub opencon()
        con.Close()
        con.Open()
        com.Connection = con
    End Sub


    Sub drclose()
        dr = com.ExecuteReader
        dr.Close()
    End Sub

    Sub finduser()
        com.CommandText = "select * from ordersystem.users where username ='" & Form1.TextBox1.Text & "';"
        dr = com.ExecuteReader
        While dr.Read
            Form1.Label4.Text = dr.Item(1).ToString
            Form1.Label5.Text = dr.Item(2).ToString
        End While
        dr.Close()
    End Sub

    Sub reload_user()
        f_users.ListView1.BackColor = Color.DodgerBlue
        f_users.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.users order by user_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 2 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_users.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_users.Label2.Text = "ALL USERS: " & f_users.ListView1.Items.Count
        f_dashboard.Label11.Text = "USERS" & vbNewLine & f_users.ListView1.Items.Count

    End Sub

    Sub reload_sales()
        f_sales.ListView1.BackColor = Color.DodgerBlue
        f_sales.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.product_sales order by product_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 3 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_sales.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_sales.Label2.Text = "ALL SALES: " & f_sales.ListView1.Items.Count
        f_dashboard.Label10.Text = "SALES" & vbNewLine & f_sales.ListView1.Items.Count

    End Sub

    Sub reload_products()
        f_products.ListView1.BackColor = Color.DodgerBlue
        f_products.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.products order by product_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 2 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_products.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_products.Label2.Text = "ALL PRODUCTS: " & f_products.ListView1.Items.Count
        f_dashboard.Label9.Text = "PRODUCTS" & vbNewLine & f_products.ListView1.Items.Count

    End Sub

    Sub reload_report()
        f_report.ListView1.BackColor = Color.DodgerBlue
        f_report.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.order_items_report order by order_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 4 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_report.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_report.Label2.Text = "ALL ITEMS REPORT: " & f_report.ListView1.Items.Count
        f_dashboard.Label8.Text = "ITEMS REPORT" & vbNewLine & f_report.ListView1.Items.Count

    End Sub

    Sub reload_items()
        f_items.ListView1.BackColor = Color.DodgerBlue
        f_items.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.order_items order by order_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 3 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_items.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_items.Label2.Text = "ALL ITEMS: " & f_items.ListView1.Items.Count
        f_dashboard.Label7.Text = "ITEMS" & vbNewLine & f_items.ListView1.Items.Count

    End Sub

    Sub reload_orders()
        f_orders.ListView1.BackColor = Color.DodgerBlue
        f_orders.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.orders order by order_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 3 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_orders.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_orders.Label2.Text = "ALL ORDERS: " & f_orders.ListView1.Items.Count
        f_dashboard.Label5.Text = "ORDERS" & vbNewLine & f_orders.ListView1.Items.Count

    End Sub

    Sub reload_customer_orders()
        f_customerorders.ListView1.BackColor = Color.DodgerBlue
        f_customerorders.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.customer_orders order by customer_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 4 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_customerorders.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_customerorders.Label2.Text = "ALL CUSTOMER ORDERS: " & f_customerorders.ListView1.Items.Count
        f_dashboard.Label4.Text = "CUSTOMER ORDERS" & vbNewLine & f_customerorders.ListView1.Items.Count

    End Sub

    Sub reload_customers()
        f_customers.ListView1.BackColor = Color.DodgerBlue
        f_customers.ListView1.Items.Clear()
        com.CommandText = "select * from ordersystem.customers order by customer_id desc;"
        dr = com.ExecuteReader
        While dr.Read
            Dim os_c As Integer
            Dim os As New ListViewItem(dr.Item(0).ToString)
            For os_c = 1 To 4 Step 1
                os.SubItems.Add(dr.Item(os_c).ToString).BackColor = Color.White
            Next
            f_customers.ListView1.Items.AddRange(New ListViewItem() {os})
            os.UseItemStyleForSubItems = False
        End While
        dr.Close()
        f_customers.Label2.Text = "ALL ORDERS: " & f_customers.ListView1.Items.Count
        f_dashboard.Label3.Text = "ORDERS" & vbNewLine & f_customers.ListView1.Items.Count

    End Sub


End Module
