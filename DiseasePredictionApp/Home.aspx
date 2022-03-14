<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DiseasePredictionApp.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="center">HOME</h2><hr /><br />

<section>
      <div class="container">
         <div class="row">
            <div class="col-md-2">
               <asp:AdRotator BorderWidth="1" ID="AdRotator1" runat="server" Width="200px" Height="400px" Style="text-align: center"
                DataSourceID="xmlSource1" />
                <asp:XmlDataSource ID="xmlSource1" runat="server" DataFile="~/Ads.xml"></asp:XmlDataSource>
            </div>
            <div class="col-md-8" style="background-image:url(imgs/homes.jpg); background-size:cover; Height:400px">
               <center><br /><h4 style="color: #FF0000">Symptoms</h4>
                   <br />
                   <asp:DropDownList ID="DropDownList7" runat="server" Width="300px" Height="30px">
                       <asp:ListItem Selected="True">Symptom1</asp:ListItem>
                       <asp:ListItem>Breathing Issues</asp:ListItem>
                       <asp:ListItem>Body Pain</asp:ListItem>
                       <asp:ListItem>Chest Tightness</asp:ListItem>
                       <asp:ListItem>Cough</asp:ListItem>
                       <asp:ListItem>Fatigue</asp:ListItem>
                       <asp:ListItem>Fever</asp:ListItem>
                       <asp:ListItem>Headache</asp:ListItem>
                       <asp:ListItem>Runny Nose</asp:ListItem>
                       <asp:ListItem>Sneezing</asp:ListItem>
                       <asp:ListItem>Sore Throat</asp:ListItem>
                       <asp:ListItem>Watering Eyes</asp:ListItem>
                       <asp:ListItem>Weakness</asp:ListItem>
                       <asp:ListItem>Wheezing</asp:ListItem>
                   </asp:DropDownList>
                &nbsp;&nbsp;
                &nbsp;<asp:DropDownList ID="DropDownList6" runat="server" Width="300px" 
                       Height="30px">
                       <asp:ListItem Selected="True">Symptom2</asp:ListItem>
                       <asp:ListItem>Breathing Issues</asp:ListItem>
                       <asp:ListItem>Body Pain</asp:ListItem>
                       <asp:ListItem>Chest Tightness</asp:ListItem>
                       <asp:ListItem>Cough</asp:ListItem>
                       <asp:ListItem>Fatigue</asp:ListItem>
                       <asp:ListItem>Fever</asp:ListItem>
                       <asp:ListItem>Headache</asp:ListItem>
                       <asp:ListItem>Runny Nose</asp:ListItem>
                       <asp:ListItem>Sneezing</asp:ListItem>
                       <asp:ListItem>Sore Throat</asp:ListItem>
                       <asp:ListItem>Watering Eyes</asp:ListItem>
                       <asp:ListItem>Weakness</asp:ListItem>
                       <asp:ListItem>Wheezing</asp:ListItem>
                   </asp:DropDownList>
                &nbsp;<br />
                   <br />
                   <asp:DropDownList ID="DropDownList5" runat="server" Width="300px" Height="30px">
                       <asp:ListItem Selected="True">Symptom3</asp:ListItem>
                       <asp:ListItem>Breathing Issues</asp:ListItem>
                       <asp:ListItem>Body Pain</asp:ListItem>
                       <asp:ListItem>Chest Tightness</asp:ListItem>
                       <asp:ListItem>Cough</asp:ListItem>
                       <asp:ListItem>Fatigue</asp:ListItem>
                       <asp:ListItem>Fever</asp:ListItem>
                       <asp:ListItem>Headache</asp:ListItem>
                       <asp:ListItem>Runny Nose</asp:ListItem>
                       <asp:ListItem>Sneezing</asp:ListItem>
                       <asp:ListItem>Sore Throat</asp:ListItem>
                       <asp:ListItem>Watering Eyes</asp:ListItem>
                       <asp:ListItem>Weakness</asp:ListItem>
                       <asp:ListItem>Wheezing</asp:ListItem>
                   </asp:DropDownList>
                &nbsp;&nbsp;
                &nbsp;<asp:DropDownList ID="DropDownList4" runat="server" Width="300px" 
                       Height="30px">
                       <asp:ListItem Selected="True">Symptom4</asp:ListItem>
                       <asp:ListItem>Breathing Issues</asp:ListItem>
                       <asp:ListItem>Body Pain</asp:ListItem>
                       <asp:ListItem>Chest Tightness</asp:ListItem>
                       <asp:ListItem>Cough</asp:ListItem>
                       <asp:ListItem>Fatigue</asp:ListItem>
                       <asp:ListItem>Fever</asp:ListItem>
                       <asp:ListItem>Headache</asp:ListItem>
                       <asp:ListItem>Runny Nose</asp:ListItem>
                       <asp:ListItem>Sneezing</asp:ListItem>
                       <asp:ListItem>Sore Throat</asp:ListItem>
                       <asp:ListItem>Watering Eyes</asp:ListItem>
                       <asp:ListItem>Weakness</asp:ListItem>
                       <asp:ListItem>Wheezing</asp:ListItem>
                   </asp:DropDownList>
                &nbsp;<br />
                   <br />
                   <asp:DropDownList ID="DropDownList3" runat="server" Width="300px" Height="30px">
                       <asp:ListItem Selected="True">Symptom5</asp:ListItem>
                       <asp:ListItem>Breathing Issues</asp:ListItem>
                       <asp:ListItem>Body Pain</asp:ListItem>
                       <asp:ListItem>Chest Tightness</asp:ListItem>
                       <asp:ListItem>Cough</asp:ListItem>
                       <asp:ListItem>Fatigue</asp:ListItem>
                       <asp:ListItem>Fever</asp:ListItem>
                       <asp:ListItem>Headache</asp:ListItem>
                       <asp:ListItem>Runny Nose</asp:ListItem>
                       <asp:ListItem>Sneezing</asp:ListItem>
                       <asp:ListItem>Sore Throat</asp:ListItem>
                       <asp:ListItem>Watering Eyes</asp:ListItem>
                       <asp:ListItem>Weakness</asp:ListItem>
                       <asp:ListItem>Wheezing</asp:ListItem>
                   </asp:DropDownList>
                &nbsp;&nbsp;
                &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Width="300px" 
                       Height="30px">
                       <asp:ListItem Selected="True">Symptom6</asp:ListItem>
                       <asp:ListItem>Breathing Issues</asp:ListItem>
                       <asp:ListItem>Body Pain</asp:ListItem>
                       <asp:ListItem>Chest Tightness</asp:ListItem>
                       <asp:ListItem>Cough</asp:ListItem>
                       <asp:ListItem>Fatigue</asp:ListItem>
                       <asp:ListItem>Fever</asp:ListItem>
                       <asp:ListItem>Headache</asp:ListItem>
                       <asp:ListItem>Runny Nose</asp:ListItem>
                       <asp:ListItem>Sneezing</asp:ListItem>
                       <asp:ListItem>Sore Throat</asp:ListItem>
                       <asp:ListItem>Watering Eyes</asp:ListItem>
                       <asp:ListItem>Weakness</asp:ListItem>
                       <asp:ListItem>Wheezing</asp:ListItem>
                   </asp:DropDownList>
                &nbsp;<br />
                   <br />
                   <asp:DropDownList ID="DropDownList1" runat="server" Width="300px" Height="30px">
                       <asp:ListItem Selected="True">Symptom7</asp:ListItem>
                       <asp:ListItem>Breathing Issues</asp:ListItem>
                       <asp:ListItem>Body Pain</asp:ListItem>
                       <asp:ListItem>Chest Tightness</asp:ListItem>
                       <asp:ListItem>Cough</asp:ListItem>
                       <asp:ListItem>Fatigue</asp:ListItem>
                       <asp:ListItem>Fever</asp:ListItem>
                       <asp:ListItem>Headache</asp:ListItem>
                       <asp:ListItem>Runny Nose</asp:ListItem>
                       <asp:ListItem>Sneezing</asp:ListItem>
                       <asp:ListItem>Sore Throat</asp:ListItem>
                       <asp:ListItem>Watering Eyes</asp:ListItem>
                       <asp:ListItem>Weakness</asp:ListItem>
                       <asp:ListItem>Wheezing</asp:ListItem>
                   </asp:DropDownList>
                   <font size="5px">
                   <br />
                   <br />
                   </font>
                   <asp:Button class="btn btn-info btn-lg" ID="Button1" runat="server" 
                       Text="!! Check Disease !!" onclick="Button1_Click" />                   
                   <br />
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
