<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="GestorBD.WF.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <style>
* {
    box-sizing: border-box;
}

/* Create two equal columns that floats next to each other */
.column {
    float: left;
    width: 45%;
    padding: 10px;
    height: 100%; /* Should be removed. Only for demonstration */
}

.base {
    float: left;
    width: 20%;
    padding: 10px;
    height: 100%; /* Should be removed. Only for demonstration */
}

/* Clear floats after the columns */
.row:after {
    content: "";
    display: table;
    clear: both;
}

 #mydivConf {
            position: absolute;
            z-index: 9;
            background-color: #f1f1f1;
            border: 1px solid #d3d3d3;
            text-align: center;
           
            left: 10px;
            top: 10%;
        }

        #mydivConfheader {
            padding: 10px;
            cursor: move;
            z-index: 10;
            background-color: #ff0000;
            color: #fff;
        }
        
         #mydivConf2 {
            position: absolute;
            z-index: 9;
            background-color: #f1f1f1;
            border: 1px solid #d3d3d3;
            text-align: center;
           
            left: 25%;
            top: 10%;
        }

        #mydivConf2header {
            padding: 10px;
            cursor: move;
            z-index: 10;
            background-color: blue;
            color: #fff;
        }
</style>

<h2>GESTOR BASE DE DATOS</h2>

<div class="row">
<div id="mydivConf" class="base">
    
    <div id="mydivConfheader">BASES DE DATOS</div>
    </br></br>
            <asp:GridView ID="DGVBases" runat="server" class="table table-bordered table-condensed table-responsive table-hover"></asp:GridView>
</div>
<div id="mydivConf2" class="column">
    
    <div id="mydivConf2header">INSTRUCCIONES SQL</div>            
            </br>
            <asp:TextBox ID="txtInstruccion" runat="server" Height="63px" Width="100%"></asp:TextBox>
            </br></br>
            <asp:Button ID="btnEjecutar" runat="server" Text="Ejecutar" OnClick="btnEjecutar_Click" class="btn btn-primary" />
            </br></br>
            <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
            </br></br>
            <asp:Label ID="lblSalida" runat="server" Text="Salida"></asp:Label>
            </br></br>
            <asp:GridView ID="DGVSalida" runat="server" class="table table-bordered table-condensed table-responsive table-hover" Width="100%"></asp:GridView>
</div>
</div>

    <script type="text/javascript">

        //Make the DIV element draggagle:
        dragElement(document.getElementById("mydivConf"));

        function dragElement(elmnt) {
            var pos1 = 0, pos2 = 0, pos3 = 0, pos4 = 0;
            if (document.getElementById(elmnt.id + "header")) {
                /* if present, the header is where you move the DIV from:*/
                document.getElementById(elmnt.id + "header").onmousedown = dragMouseDown;
            } else {
                /* otherwise, move the DIV from anywhere inside the DIV:*/
                elmnt.onmousedown = dragMouseDown;
            }

            function dragMouseDown(e) {
                e = e || window.event;
                e.preventDefault();
                // get the mouse cursor position at startup:
                pos3 = e.clientX;
                pos4 = e.clientY;
                document.onmouseup = closeDragElement;
                // call a function whenever the cursor moves:
                document.onmousemove = elementDrag;
            }

            function elementDrag(e) {
                e = e || window.event;
                e.preventDefault();
                // calculate the new cursor position:
                pos1 = pos3 - e.clientX;
                pos2 = pos4 - e.clientY;
                pos3 = e.clientX;
                pos4 = e.clientY;
                // set the element's new position:
                elmnt.style.top = (elmnt.offsetTop - pos2) + "px";
                elmnt.style.left = (elmnt.offsetLeft - pos1) + "px";
            }

            function closeDragElement() {
                /* stop moving when mouse button is released:*/
                document.onmouseup = null;
                document.onmousemove = null;
            }
        }

        //Make the DIV element draggagle:
        dragElement(document.getElementById("mydivConf2"));

        function dragElement(elmnt) {
            var pos1 = 0, pos2 = 0, pos3 = 0, pos4 = 0;
            if (document.getElementById(elmnt.id + "header")) {
                /* if present, the header is where you move the DIV from:*/
                document.getElementById(elmnt.id + "header").onmousedown = dragMouseDown;
            } else {
                /* otherwise, move the DIV from anywhere inside the DIV:*/
                elmnt.onmousedown = dragMouseDown;
            }

            function dragMouseDown(e) {
                e = e || window.event;
                e.preventDefault();
                // get the mouse cursor position at startup:
                pos3 = e.clientX;
                pos4 = e.clientY;
                document.onmouseup = closeDragElement;
                // call a function whenever the cursor moves:
                document.onmousemove = elementDrag;
            }

            function elementDrag(e) {
                e = e || window.event;
                e.preventDefault();
                // calculate the new cursor position:
                pos1 = pos3 - e.clientX;
                pos2 = pos4 - e.clientY;
                pos3 = e.clientX;
                pos4 = e.clientY;
                // set the element's new position:
                elmnt.style.top = (elmnt.offsetTop - pos2) + "px";
                elmnt.style.left = (elmnt.offsetLeft - pos1) + "px";
            }

            function closeDragElement() {
                /* stop moving when mouse button is released:*/
                document.onmouseup = null;
                document.onmousemove = null;
            }
        }
    </script>
    <script src="../Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
