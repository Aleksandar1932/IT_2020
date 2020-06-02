<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IT_lab1_zadaca2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>IT Lab1</h1>
        <p>Aleksandar Ivanovski 186063</p>
    </div>

    <div class="row">
       <div class="col-xs-12">
            <asp:Label ID="lblVreme1" runat="server" Text="Контрола за приказ на време" Font-Size="Medium" Font-Names="Arial" ForeColor="Navy"></asp:Label>
       </div>
        <div class="col-xs-12">
            <asp:Label ID="lblVreme2" runat="server" Text="Контрола за приказ на време" Font-Size="Medium" Font-Names="Arial" ForeColor="Navy"></asp:Label><br />
            <asp:Button ID="btnVreme" runat="server" Text="Прикажи време" OnClick="btnVreme_Click" />
        </div>
        <div class="col-xs-12">
            <asp:HyperLink ID="hlSledno" runat="server" NavigateUrl="~/Default2.aspx">Следна страница</asp:HyperLink>
        </div>
    </div>

</asp:Content>
