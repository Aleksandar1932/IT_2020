<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default3.aspx.cs" Inherits="IT_lab1_zadaca2.Default3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
                <asp:TextBox ID="txtPoraka" runat="server" TextMode="MultiLine" Rows="5" ReadOnly="true" AutoPostBack="true"></asp:TextBox>
                
                <asp:Button ID="btnProveri" runat="server" Text="Провери лозинка" OnClick="btnProveri_Click"/>
                <asp:Button ID="btnPrvaStrana" runat="server" Text="Копче за прва страна" Enabled="false" OnClick="btnPrvaStrana_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
