<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="IT_lab2_zad3.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 text-right">
                Корисник:
            </div>

            <div class="col-md-6">
                <asp:TextBox ID="txtKorisnik" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6 text-right">
                Лозинка:
            </div>

            <div class="col-md-6">
                <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6 text-right">
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Поднеси" />
            </div>
            <div class="col-md-6 text-left">
               Обиди: <asp:Label ID="lblObidi" runat="server" Text="0"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
