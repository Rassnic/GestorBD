<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="GestorBD.WF.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInstruccion" runat="server" Text="Instruccion SQL"></asp:Label>
            </br>
            <asp:TextBox ID="txtInstruccion" runat="server" Height="63px" Width="1012px"></asp:TextBox>
            </br></br>
            <asp:Button ID="btnEjecutar" runat="server" Text="Ejecutar" OnClick="btnEjecutar_Click"  />
            </br></br>
            <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
            </br></br>
            <asp:Label ID="lblSalida" runat="server" Text="Salida"></asp:Label>
            </br></br>
            <asp:GridView ID="DGVSalida" runat="server"></asp:GridView>
        </div>        
    </form>
</body>
</html>
