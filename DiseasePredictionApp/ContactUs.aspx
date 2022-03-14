<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="DiseasePredictionApp.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2 align="center">CONTACT US</h2><hr /><br />

<section>
      <div class="container">
         <div class="row">
            <div class="col-md-2">
               <asp:AdRotator BorderWidth="1" ID="AdRotator1" runat="server" Width="200px" Height="400px" Style="text-align: center"
                DataSourceID="xmlSource1" />
                <asp:XmlDataSource ID="xmlSource1" runat="server" DataFile="~/Ads.xml"></asp:XmlDataSource>
            </div>
            <div class="col-md-8" style="background-image:url(imgs/contactbg.jfif); Height:400px">
               <center><br/>
                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Visitor Name"></asp:TextBox><br />
                 <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Visitor Email"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                       ErrorMessage="Invalid Email Id!" ControlToValidate="TextBox2" ForeColor="Red" 
                       ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                 <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Visitor Message" TextMode="MultiLine"></asp:TextBox><br />
                 <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" 
                       Text="Submit" width="857px" onclick="Button1_Click"/><br /><br />
                 <i class="fa fa-compass" aria-hidden="true"></i> <asp:Label ID="Label1" runat="server" Text="Chembur, Mumbai, Maharashtra - 400089">
                 </asp:Label><br />
                 <i class="fa fa-envelope" aria-hidden="true"></i> <asp:Label ID="Label2" runat="server" Text="diseasepredictor@ves.edu">
                 </asp:Label><br />
                 <i class="fa fa-phone" aria-hidden="true"></i> <asp:Label ID="Label3" runat="server" Text="022-20512020">
                 </asp:Label><br />
                </center>
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