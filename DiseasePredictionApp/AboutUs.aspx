<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="DiseasePredictionApp.AboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2 align="center">ABOUT US</h2><hr /><br />

<section>
      <div class="container">
         <div class="row">
            <div class="col-md-2">
               <asp:AdRotator BorderWidth="1" ID="AdRotator1" runat="server" Width="200px" Height="400px" Style="text-align: center"
                DataSourceID="xmlSource1" />
                <asp:XmlDataSource ID="xmlSource1" runat="server" DataFile="~/Ads.xml"></asp:XmlDataSource>
            </div>
            <div class="col-md-8" style="background-image:url(imgs/aboutbg.jfif); Height:400px"><br/><br/>
               <font size="4px"><li>We are the ones who provide online information related to diseases</li><br/>
               <li>Visitors can visit our page to get the prediction related to diseases.</li><br/>
               <li>One can enter the symptoms for check-up.</li><br/>
               <li>After entering the symptoms visitors can see the predicted diseases.</li><br/>
               <li>There are also doctors contact and information mentioned after check-up<br/><br/>
               &nbsp;&nbsp;&nbsp;&nbsp; in order to take prescriptions if needed.</li></font><br/><br/>
              
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