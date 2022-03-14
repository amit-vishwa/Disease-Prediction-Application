<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AdminDetails.aspx.cs" Inherits="DiseasePredictionApp.AdminDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center><asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Disease Name" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Symptom1" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Symptom2" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Symptom3" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server" placeholder="Enter Symptom4" Width="200px"></asp:TextBox><br /><br />
    <asp:TextBox ID="TextBox6" runat="server" placeholder="Enter Symptom5" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server" placeholder="Enter Symptom6" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox8" runat="server" placeholder="Enter Symptom7" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox9" runat="server" placeholder="Enter Doctor Name" Width="200px"></asp:TextBox>
    <asp:TextBox ID="TextBox10" runat="server" placeholder="Enter Doctor Contact" Width="200px"></asp:TextBox><br /><br />
    <asp:Button class="btn btn-warning btn-xs" ID="Button1" runat="server" Text="Insert Disease Details" 
             onclick="Button1_Click" height="35px" Width="255px"/>
    <asp:TextBox ID="TextBox11" runat="server" placeholder="Enter Doctor Address" Width="500px"></asp:TextBox>
          <asp:Button class="btn btn-primary btn-xs" ID="Button2" runat="server" 
             Text="Insert Doctor Details" onclick="Button2_Click" height="35px" Width="255px"/><br />
    <br/>
<h4>Diseases</h4>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" 
            BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="SrId" 
            DataSourceID="EntityDataSource1" ForeColor="Black" GridLines="Vertical" 
            PageSize="5" ShowHeaderWhenEmpty="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True"/>
            <asp:BoundField DataField="SrId" HeaderText="SrId" ReadOnly="True" Visible="false"
                SortExpression="SrId" />
            <asp:BoundField DataField="Disease1" HeaderText="Disease" 
                SortExpression="Disease1" />
            <asp:BoundField DataField="Symptom1" HeaderText="Symptom1" 
                SortExpression="Symptom1" />
            <asp:BoundField DataField="Symptom2" HeaderText="Symptom2" 
                SortExpression="Symptom2" />
            <asp:BoundField DataField="Symptom3" HeaderText="Symptom3" 
                SortExpression="Symptom3" />
            <asp:BoundField DataField="Symptom4" HeaderText="Symptom4" 
                SortExpression="Symptom4" />
            <asp:BoundField DataField="Symptom5" HeaderText="Symptom5" 
                SortExpression="Symptom5" />
            <asp:BoundField DataField="Symptom6" HeaderText="Symptom6" 
                SortExpression="Symptom6" />
            <asp:BoundField DataField="Symptom7" HeaderText="Symptom7" 
                SortExpression="Symptom7" />
        </Columns>
        <EmptyDataTemplate>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </EmptyDataTemplate>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=DiseasePredictorAppEntities" 
            DefaultContainerName="DiseasePredictorAppEntities" EnableDelete="True" 
            EnableFlattening="False" EnableInsert="True" EnableUpdate="True" 
            EntitySetName="Diseases">
        </asp:EntityDataSource>
        <br/>
<h4>Doctors</h4>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="SrId" DataSourceID="EntityDataSource2" BackColor="White" 
            BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            ForeColor="Black" GridLines="Vertical" AllowPaging="True" PageSize="5" 
            AllowSorting="True" ShowHeaderWhenEmpty="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True"/>
                <asp:BoundField DataField="SrId" HeaderText="SrId" Visible="false"
                    SortExpression="SrId" ReadOnly="True" />
                <asp:BoundField DataField="DName" HeaderText="DName" 
                    SortExpression="DName" />
                <asp:BoundField DataField="DPhone" HeaderText="DPhone" 
                    SortExpression="DPhone" />
                <asp:BoundField DataField="DAddress" HeaderText="DAddress" 
                    SortExpression="DAddress" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource2" runat="server" 
            ConnectionString="name=DiseasePredictorAppEntities" 
            DefaultContainerName="DiseasePredictorAppEntities" EnableDelete="True" 
            EnableFlattening="False" EnableInsert="True" EnableUpdate="True" 
            EntitySetName="Doctors">
        </asp:EntityDataSource>
    <br/>    
<h4>Visitors</h4>
     <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
            AutoGenerateDeleteButton="True"
            DataKeyNames="SrId" DataSourceID="EntityDataSource3" BackColor="White" 
            BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            ForeColor="Black" GridLines="Vertical" AllowPaging="True" PageSize="5" 
            AllowSorting="True" ShowHeaderWhenEmpty="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="SrId" HeaderText="SrId" ReadOnly="True" Visible="false"
                    SortExpression="SrId" />
                <asp:BoundField DataField="VName" HeaderText="VName" 
                    SortExpression="VName" />
                <asp:BoundField DataField="VEmail" HeaderText="VEmail" 
                    SortExpression="VEmail" />
                <asp:BoundField DataField="VMessage" HeaderText="VMessage" 
                    SortExpression="VMessage" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource3" runat="server" 
            ConnectionString="name=DiseasePredictorAppEntities" 
            DefaultContainerName="DiseasePredictorAppEntities" EnableDelete="True" 
            EnableFlattening="False" 
            EntitySetName="Visitors">
        </asp:EntityDataSource>
    </center>
</asp:Content>
