<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DiseaseDetails.aspx.cs" Inherits="DiseasePredictionApp.DiseaseDetails" %>
<%@ PreviousPageType VirtualPath="~/Home.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="center">RESULT</h2><hr /><br />

<section>
      <div class="container">
         <div class="row">
            <div class="col-md-2">
               <asp:AdRotator BorderWidth="1" ID="AdRotator1" runat="server" Width="200px" Height="400px" Style="text-align: center"
                DataSourceID="xmlSource1" />
                <asp:XmlDataSource ID="xmlSource1" runat="server" DataFile="~/Ads.xml"></asp:XmlDataSource>
            </div>
            <div class="col-md-8" style="background-image:url(imgs/homes.jpg); background-size:cover; Height:400px">
               <center><br /><h3 style="color: #0000FF">Predicted Disease :</h3><br/>
                   <b><asp:Label ID="Label1" runat="server" Text="DiseaseName" ForeColor="#FF0066"></asp:Label></b>
                   <br />
                   <br />
                   <br />
                   <h4 style="color: #008000">Doctor Details :</h4>
                   <br /><asp:GridView ID="GridView1" 
                       runat="server" AllowPaging="True" AllowSorting="True" 
                       AutoGenerateColumns="False" CellPadding="4" 
                       DataKeyNames="SrId" DataSourceID="SqlDataSource1" PageSize="5" 
                       ForeColor="#333333" GridLines="None">
                   <AlternatingRowStyle BackColor="White" />
                   <Columns>
                       <asp:BoundField DataField="SrId" HeaderText="SrId" Visible="False" 
                           ReadOnly="True" SortExpression="SrId" />
                       <asp:BoundField DataField="DName" HeaderText="DName" SortExpression="DName" />
                       <asp:BoundField DataField="DPhone" HeaderText="DPhone" 
                           SortExpression="DPhone" />
                       <asp:BoundField DataField="DAddress" HeaderText="DAddress" 
                           SortExpression="DAddress" />
                   </Columns>
                   <EditRowStyle BackColor="#7C6F57" />
                   <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                   <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                   <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#666666" />
                   <RowStyle BackColor="#E3EAEB" />
                   <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#F8FAFA" />
                   <SortedAscendingHeaderStyle BackColor="#246B61" />
                   <SortedDescendingCellStyle BackColor="#D4DFE1" />
                   <SortedDescendingHeaderStyle BackColor="#15524A" />
                   </asp:GridView>
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                       ConnectionString="<%$ ConnectionStrings:DiseasePredictorAppConnectionString %>" 
                       SelectCommand="SELECT * FROM [Doctors]"></asp:SqlDataSource>
                   <br />
                   <font size="5px">
                   <br />
                   </font>
                   <br />
                   <br /></center>
            </div>
            <div class="col-md-2">
               <asp:AdRotator BorderWidth="1" ID="AdRotator2" runat="server" Width="200px" Height="400px" Style="text-align: center"
                DataSourceID="xmlSource2" />
                <asp:XmlDataSource ID="xmlSource2" runat="server" DataFile="~/Ads.xml"></asp:XmlDataSource>
            </div>
         </div>
      </div>
   </section>
</asp:Content>
