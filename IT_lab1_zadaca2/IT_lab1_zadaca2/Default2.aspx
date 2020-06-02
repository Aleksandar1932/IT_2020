<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="IT_lab1_zadaca2.Default2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container pt-10">
    <div class="row">
        <div class="col-xs-12">
            <asp:Table ID="Table1" runat="server">
              <asp:TableRow>
                    <asp:TableCell>
                     <asp:Panel runat="server" ID="pnlPanela1">
                         <asp:TextBox ID="txtOperand1" runat="server"></asp:TextBox>
                         <asp:TextBox ID="txtOperand2" runat="server"></asp:TextBox>

                         <asp:Label ID="lblRezultat" runat="server" Text="(Резултат)"></asp:Label>
                         <asp:Button ID="btnSoberi" runat="server" Text="Собери" OnClick="btnSoberi_Click" />
                     </asp:Panel>
                    </asp:TableCell>
                </asp:TableRow>

                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:CheckBox ID="chbVidlivo" runat="server" Text="Видливо" OnCheckedChanged="chbVidlivo_CheckedChanged" AutoPostBack="True" />
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
        </div>
    </div>
       </div>
</asp:Content>
