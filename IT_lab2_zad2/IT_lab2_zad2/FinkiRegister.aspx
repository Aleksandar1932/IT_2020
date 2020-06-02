<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinkiRegister.aspx.cs" Inherits="IT_lab2_zad2.FinkiRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Label ID="lblLoggedIn" runat="server" Text="Label"></asp:Label>
        <div class="row p-2">
            <div class="col-xs-6 text-right">
                Име:
            </div>
            <div class="col-xs-6">
                <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator1"
                    ControlToValidate="txtIme"
                    ValidationGroup="podatoci1"
                    runat="server"
                    ErrorMessage="Внеси Име!">
                </asp:RequiredFieldValidator>

            </div>
        </div>
        <div class="row p-2">
            <div class="col-xs-6 text-right">
                Презиме:
            </div>
            <div class="col-xs-6">
                <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2"
                    ControlToValidate="txtPrezime"
                    ValidationGroup="podatoci1"
                    runat="server"
                    ErrorMessage="Внеси Презиме!">
                </asp:RequiredFieldValidator>

            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Финки ID:
            </div>
            <div class="col-xs-6 ">
                <asp:TextBox ID="txtFinkiID" runat="server"></asp:TextBox>@finki.ukim.mk    
                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator3"
                    ControlToValidate="txtFinkiID"
                    ValidationGroup="podatoci1"
                    runat="server"
                    ErrorMessage="Внеси Финки ID!">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1"
                    ControlToValidate="txtFinkiID"
                    ValidationGroup="podatoci1"
                    runat="server"
                    ErrorMessage="Неправилен формат на ID"
                    ValidationExpression="(([A-Z]|[0-9])+)(([A-Z]|[0-9])+|[_]\d{2})">
                </asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Лозинка:
            </div>
            <div class="col-xs-6">
                <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator4"
                    ControlToValidate="txtLozinka"
                    ValidationGroup="podatoci1"
                    runat="server"
                    ErrorMessage="Внеси лозинка!">

                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Потврда:
            </div>
            <div class="col-xs-6 ">
                <asp:TextBox ID="txtPotvrdiLozinka" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator5"
                    ControlToValidate="txtPotvrdiLozinka"
                    ValidationGroup="podatoci1"
                    runat="server"
                    ErrorMessage="Внеси потврда на лозинка!">

                </asp:RequiredFieldValidator>
                <asp:CompareValidator
                    ID="CompareValidator1"
                    runat="server"
                    ControlToCompare="txtLozinka"
                    ValidationGroup="podatoci1"
                    ControlToValidate="txtPotvrdiLozinka"
                    ErrorMessage="Различни лозинки">

                </asp:CompareValidator>
            </div>
        </div>

        <div class="row">
            <div class="col-xs-12">
                <asp:ValidationSummary ID="ValidationSummary2" runat="server"
                    ShowSummary="true"
                    ShowMessageBox="true"
                    ShowModelStateErrors="True"
                    DisplayMode="List" />
            </div>
        </div>

        <div class="row">
            <div class="col-xs-6 text-right">
                Адреса:
            </div>
            <div class="col-xs-6">
                <asp:TextBox ID="txtAdresa" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6"
                    ControlToValidate="txtAdresa"
                    runat="server"
                    ErrorMessage="Внесете адреса адреса!">

                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Телефон:
            </div>
            <div class="col-xs-6 ">
                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7"
                    ControlToValidate="txtTelefon"
                    runat="server"
                    ErrorMessage="Внесете телефон!">

                </asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator2"
                    ControlToValidate="txtTelefon"
                    runat="server"
                    ErrorMessage="Неправилен формат на телефон"
                    ValidationExpression="[+][3][8][9]\s(([7][0-9]\s\d{3}\s\d{3})|([1-9][0-9]\s\d{3}\s\d{3})|([2-3]\s\d{4}\s\d{3}))">
                </asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Пол:
            </div>
            <div class="col-xs-6">
                <asp:RadioButtonList ID="rblPol" runat="server">
                    <asp:ListItem>Машки</asp:ListItem>
                    <asp:ListItem>Женски</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8"
                    ControlToValidate="rblPol"
                    runat="server"
                    ErrorMessage="Изберете пол!">

                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Датум на раѓање:
            </div>
            <div class="col-xs-6 ">
                <asp:Calendar ID="caBirthDate" runat="server"></asp:Calendar>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Занимање:

            </div>
            <div class="col-xs-6 ">
                <asp:DropDownList ID="ddlZanimanje" runat="server">
                    <asp:ListItem>Невработен</asp:ListItem>
                    <asp:ListItem>Доктор</asp:ListItem>
                    <asp:ListItem>Инженер</asp:ListItem>
                    <asp:ListItem>Адвокат</asp:ListItem>
                    <asp:ListItem>Консултант</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9"
                    ControlToValidate="ddlZanimanje"
                    runat="server"
                    ErrorMessage="Изберете занимање!">

                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6 text-right">
                Години на вршење на избраната дејност:
            </div>
            <div class="col-xs-6 ">
                <asp:TextBox ID="txtGodiniZanimanje" runat="server"></asp:TextBox>
                <asp:CompareValidator
                    ID="CompareValidator2"
                    runat="server"
                    ControlToValidate="txtGodiniZanimanje"
                    ErrorMessage="CompareValidator" ValueToCompare="0"
                    Operator="GreaterThanEqual">

                </asp:CompareValidator>
            </div>
        </div>
        <div class="row text-center">
            <asp:Button ID="Поднеси" CssClass="btn btn-success" OnClick="Поднеси_Click" runat="server" Text="Button" />
        </div>
    </div>
</asp:Content>
