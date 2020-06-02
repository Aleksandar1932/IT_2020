<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Converter.aspx.cs" Inherits="IT_AV2.Converter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm">
                <h5>Додади валута и вредност во денари</h5>
                <br />

                <div class="row">
                    <div class="col-sm">
                        Име на валута:
                    </div>
                    <div class="col-sm">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm">
                        Вредност на валута:
                    </div>
                    <div class="col-sm">
                        <asp:TextBox ID="CurrencyValue" runat="server"></asp:TextBox>
                    </div>
                </div>

                <asp:Button ID="AddCurrency" runat="server" Text="AddCurrency" />

                <hr />

                <asp:RadioButtonList ID="AllCurrencies" runat="server"></asp:RadioButtonList>

                Вкупно:
                <asp:Label ID="NumberCurrencies" runat="server" Text="(none)"></asp:Label>

            </div>
            <div class="col-sm">
                Right
            </div>
        </div>
    </div>
</asp:Content>
