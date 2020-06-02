<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaneTicket.aspx.cs" Inherits="IT_lab2_zad1.PlaneTicket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container border border-primary">
        <div class="row">
            <div class="col-xs-6 border border-danger">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Име:
                        </div>
                        <div class="col-xs-4">
                            <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Презиме:
                        </div>
                        <div class="col-xs-4">
                            <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Oд:
                        </div>
                        <div class="col-xs-4">
                            <asp:DropDownList ID="ddlOd" runat="server">
                                <asp:ListItem>Скопје</asp:ListItem>
                                <asp:ListItem>Белград</asp:ListItem>
                                <asp:ListItem>Париз</asp:ListItem>
                                <asp:ListItem>Лондон</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            До:
                        </div>
                        <div class="col-xs-4">
                            <asp:DropDownList ID="ddlDo" runat="server">
                                <asp:ListItem>Белград</asp:ListItem>
                                <asp:ListItem>Париз</asp:ListItem>
                                <asp:ListItem>Лондон</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Датум на тргнување:
                        </div>
                        <div class="col-xs-4">
                            <asp:DropDownList ID="ddlDen" runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="ddlMesec" runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="ddlGodina" runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Време на тргање:
                        </div>
                        <div class="col-xs-4">
                            <asp:DropDownList ID="ddlVreme" runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Превозно средство:
                        </div>
                        <div class="col-xs-4">
                            <asp:ListBox ID="lstSredstvo" runat="server"></asp:ListBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Зона:
                        </div>
                        <div class="col-xs-4">
                            <asp:RadioButtonList ID="rblZona" runat="server"></asp:RadioButtonList>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Класа:
                        </div>
                        <div class="col-xs-4">
                            <asp:RadioButtonList ID="rblKlasa" runat="server"></asp:RadioButtonList>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Послуга:
                        </div>
                        <div class="col-xs-4">
                            <asp:CheckBoxList ID="cblPosluga" runat="server"></asp:CheckBoxList>
                        </div>
                    </div>
                    <asp:Button ID="btnPodnesi" runat="server" Text="Поднеси" OnClick="btnPodnesi_Click"/>
                </div>
            </div>
            <div class="col-xs-6 border border-danger">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Почитуван патнику:
                        </div>
                        <div class="col-xs-4">
                            <asp:Label ID="lblPatnik" runat="server" Text="[lblPatnik]"></asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Издадена ви е карта за:
                        </div>
                        <div class="col-xs-4">
                            <asp:Label ID="lblSredstvo" runat="server" Text="[lblSredstvo]"></asp:Label>
                        </div>
                    </div>

                     <div class="row">
                        <div class="col-xs-2 text-right">
                            со почетна дестинација:
                        </div>
                        <div class="col-xs-4">
                            <asp:Label ID="lblOd" runat="server" Text="[lblOd]"></asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            со крајна дестинација:
                        </div>
                        <div class="col-xs-4">
                            <asp:Label ID="lblDo" runat="server" Text="[lblDo]"></asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-2 text-right">
                            Времето на поаѓање е:
                        </div>
                        <div class="col-xs-4">
                            <asp:Label ID="lblVreme" runat="server" Text="[lblVreme]"></asp:Label>
                        </div>
                    </div>

                     <div class="row">
                         <div class="col-xs-2 text-right">
                            Детали:
                        </div>
                        <div class="col-xs-4">
                            Вашето место за седење ќе биде во зоната за <asp:Label ID="lblZona" runat="server" Text="[lblSredstvo]"></asp:Label>
                            во <asp:Label ID="lblKlasa" runat="server" Text="[lblZona]"></asp:Label>
                            и во текот на патувањето ќе бидете послужени со: <asp:Label ID="lblPosluga" runat="server" Text="[lblPosluga]"></asp:Label>.
                        </div>
                    </div>

                    <div class="row">
                         <div class="col-xs-2 text-right">
                            Слика:
                        </div>
                        <div class="col-xs-4">
                            <asp:Image ID="imgSredstvo" runat="server"/>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>

</asp:Content>
